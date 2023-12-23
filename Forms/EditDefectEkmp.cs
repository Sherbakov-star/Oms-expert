using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mee.Classes;

namespace Mee.Forms
{
    public partial class EditDefectEkmp : EditDefect
    {
        List<string> listF014 = new List<string>();
        private List<SluchFields> _sluchFieldsList = new List<SluchFields>();
        private string _filePath = "";
        public EditDefectEkmp()
        {
            InitializeComponent();
        }

        public EditDefectEkmp(string filePath, List<SluchFields> sluchFieldsList) : base(filePath, sluchFieldsList)
        {
            
            InitializeComponent();
            _filePath = filePath;
            _sluchFieldsList = sluchFieldsList;
            var list = GetList("F014.json", listF014, "Osn");
            var orderByList = list.OrderBy(ob => ob).ToList();

            var actuallList = new List<string>();

            //Делаем новый список и оставляем там значения которые начинаются на 3
            foreach (var i in orderByList)
            {
                if (i.StartsWith("3"))
                {
                    actuallList.Add(i);
                }
            }

            CodeDefect.Properties.DataSource = actuallList;
            SetDataFromExcel();
        }

        protected override void SaveAndClose_Click(object sender, EventArgs e)
        {
            var editType = Enums.EditType.Есть_дефект_ЭКМП;

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
                },

                new ChangedColumns()
                {
                    Column = "DiagnozPatolOsn",
                    Value = diagnozPatolOsn?.EditValue?.ToString() ?? ""
                },

                new ChangedColumns()
                {
                    Column = "OslogneniePatol",
                    Value = oslogneniePatol?.EditValue?.ToString() ?? ""
                },

                new ChangedColumns()
                {
                    Column = "SoputsPatol",
                    Value = soputsPatol?.EditValue?.ToString() ?? ""
                },

                new ChangedColumns()
                {
                    Column = "DiagnozKlinZaklOsn",
                    Value = diagnozKliZaklOsn?.EditValue?.ToString() ?? ""
                },

                new ChangedColumns()
                {
                    Column = "OslognenieKlZak",
                    Value = oslognenie?.EditValue?.ToString() ?? ""
                },

                new ChangedColumns()
                {
                    Column = "SoputsKlZak",
                    Value = soputs?.EditValue?.ToString() ?? ""
                },

                new ChangedColumns()
                {
                    Column = "Operation",
                    Value = operation?.EditValue?.ToString() ?? ""
                },
                
                new ChangedColumns()
                {
                    Column = "DateOperac",
                    Value = dateOperation?.EditValue?.ToString() ?? ""
                },

                new ChangedColumns()
                {
                    Column = "SborInformacii",
                    Value = sborInfo?.EditValue?.ToString() ?? ""
                },

                new ChangedColumns()
                {
                    Column = "Diagnoz",
                    Value = diagnoz?.EditValue?.ToString() ?? ""
                },

                new ChangedColumns()
                {
                    Column = "Lechenie",
                    Value = lechenie?.EditValue?.ToString() ?? ""
                },

                new ChangedColumns()
                {
                    Column = "Preemstvennost",
                    Value = preemstvenost?.EditValue?.ToString() ?? ""
                }
                
            };

            new ExcelService().EditExcel(_sluchFieldsList, _filePath, columns,editType);
            Close();
        }

        protected sealed override void SetDataFromExcel()
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
                    diagnozPatolOsn.EditValue = i.DiagnozPatolOsn;
                    oslogneniePatol.EditValue = i.OslogneniePatol;
                    soputsPatol.EditValue = i.SoputsPatol;
                    diagnozKliZaklOsn.EditValue = i.DiagnozKlinZaklOsn;
                    oslognenie.EditValue = i.OslognenieKlZak;
                    soputs.EditValue = i.SoputsKlZak;
                    operation.EditValue = i.Operation;
                    dateOperation.EditValue = i.DateOperac;
                    sborInfo.EditValue = i.SborInformacii;
                    diagnoz.EditValue = i.Diagnoz;
                    lechenie.EditValue = i.Lechenie;
                    preemstvenost.EditValue = i.Preemstvennost;
                }
            }
        }

    }
}
