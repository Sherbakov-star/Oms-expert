using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Lib.Helpers;
using Mee.Classes;
using Newtonsoft.Json.Linq;
using Color = System.Drawing.Color;

namespace Mee
{
    public partial class EditDefect : Form
    {
        List<string> listF014 = new List<string>();
        private List<SluchFields> _sluchFieldsList = new List<SluchFields>();
        private string _filePath = ""; 
        public EditDefect(string filePath,List<SluchFields> sluchFieldsList)
        {
            _sluchFieldsList = sluchFieldsList;
            _filePath = filePath;
            InitializeComponent();
           
            var list = GetList("F014.json", listF014, "Osn");
            var orderByList = list.OrderBy(ob => ob).ToList();

            var actuallList = new List<string>();

            //Делаем новый список и оставляем там значения которые начинаются на 2
            foreach (var i in orderByList)
            {
                if (i.StartsWith("2"))
                {
                    actuallList.Add(i);
                }
            }

            CodeDefect.Properties.DataSource = actuallList;
            SetDataFromExcel();
        }

        public EditDefect(string filePath)
        {
            _filePath = filePath;
        }

        public EditDefect()
        {
            InitializeComponent();
        }

        protected List<string> GetList(string jsonFileName, List<string> fieldListName,string parametr)
        {

            
            string json = File.ReadAllText(Path.Combine($"{System.Environment.GetEnvironmentVariable("USERPROFILE")}\\OmsFiles", jsonFileName));
            

            JArray array = JArray.Parse(json);
            var groupArray = array.GroupBy(ao => ao[parametr]);
            
            foreach (var e in groupArray)
            {
                if (e.Key != null) fieldListName.Add(e.Key.ToString());
            }

            return fieldListName;
        }

        private void CodeUsl_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            using (CodeT003 codeT003 = new CodeT003("T003.json"))
            {
                if (codeT003.ShowDialog() == DialogResult.OK)
                {
                    CodeUsl.EditValue = codeT003.CodeUslugi.Code;
                }
            }
        }

        protected bool IsEditDefectValid()
        {
            var ErrorText = "";

            var service = new DicService();


            if (!service.IsNotEmpty(CodeDefect))
            {
                ErrorText += "\nКод дефекта";
            }
            else
            {
                if (CodeDefect?.EditValue.ToString() == "2.16.1.")
                {
                    if ((koef1?.Value == null || koef1?.Value?.ToString() == ""))
                    {
                        ErrorText += "\nПравильный коэффициент";
                    }
                }
            }

            if (!service.IsNotEmpty(vivod))
            {
                ErrorText += "\nВывод";
            }

           

            if (ErrorText != "")
            {
                service.SetMandatoryField(CodeDefect);
                service.SetMandatoryField(vivod);
                MessageBox.Show($@"Введите данные для полей: {ErrorText}", "Сохранение...Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CodeDefect.Properties.Appearance.BackColor = Color.White;
                vivod.Properties.Appearance.BackColor = Color.White;
                return false;
            }

            return true;
        }

        protected virtual void SaveAndClose_Click(object sender, System.EventArgs e)
        {
            var editType = Enums.EditType.Есть_дефект_МЭЭ;
            if (!IsEditDefectValid())
            {
                return;
            }

            var columns = new[]
            {
                new ChangedColumns()
                {
                    Column = "PravilTarif",
                    Value = CodeUsl?.EditValue?.ToString() ?? ""
                },

                new ChangedColumns()
                {
                    Column = "CodeDef",
                    Value = CodeDefect?.EditValue?.ToString() ?? ""
                },

                new ChangedColumns()
                {
                    Column = "PravilKoef",
                    Value =  koef1?.Value?.ToString() ?? ""
                },

                new ChangedColumns()
                {
                    Column = "Recommend",
                    Value =  recommend?.EditValue?.ToString() ?? ""
                },

                new ChangedColumns()
                {
                    Column = "Vivod",
                    Value =  vivod?.EditValue?.ToString() ?? ""
                }

            };

            new ExcelService().EditExcel(_sluchFieldsList, _filePath,columns,editType);

            Close();
        }

        protected virtual void SetDataFromExcel()
        {
            if (_sluchFieldsList.Count == 1)
            {
                foreach (var i in _sluchFieldsList)
                {
                    CodeDefect.EditValue = i.CodeDef;
                    CodeUsl.EditValue = i.CodeUsl;
                    var culture = new CultureInfo("de-DE", false);
                    Thread.CurrentThread.CurrentCulture = culture;
                    decimal value;
                    decimal.TryParse(i.PravilKoef, out value);
                    koef1.Value = value;
                    vivod.EditValue = i.Vivod;
                    recommend.EditValue = i.Recommend;
                }
            }
        }

    }

}
