using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Excel;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.Utils.Diagnostics;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraReports;
using DevExpress.XtraReports.Design;
using DevExpress.XtraReports.Serialization;
using DevExpress.XtraReports.UI;
using DevExpress.XtraTab;
using DevExpress.XtraVerticalGrid.Rows;
using Lib.Helpers;
using LibRgs.Enums;
using Mee.Classes;
using Mee.Dic;
using Mee.Forms;
using Mee.Properties;
using Newtonsoft.Json;


namespace Mee
{
    public partial class Main : Form
    {
        private string _filePath = "";
        private List<SluchFields> _list = new List<SluchFields>();
      

        public Main()
        {
            InitializeComponent();
            //Скачивает и обновляет справочники если нет на компьютере
            if (Program.CheckForInternetConnection())
            {
                ShowUpdateDic(false);
            }
            
            var infoTable = new ToolStripLabel();
            var dateUpdateLabel = new ToolStripLabel();
            var dateUpdateLabel2 = new ToolStripLabel();
            var group1 = new ToolStripSeparator();
            var group2 = new ToolStripSeparator();
            statusStrip1.Items.Add(infoTable);
            statusStrip1.Items.Add(group1);
            statusStrip1.Items.Add(dateUpdateLabel);
            statusStrip1.Items.Add(group2);
            statusStrip1.Items.Add(dateUpdateLabel2);

            infoTable.Text = "Дата последнего обновления справочника ";
            var listLabel = new List<ToolStripLabel>();
            listLabel.Add(dateUpdateLabel);
            listLabel.Add(dateUpdateLabel2);

            if (File.Exists($"{System.Environment.GetEnvironmentVariable("USERPROFILE")}\\OmsFiles\\DicLastUpdate.txt"))
            {
                var statusText = File.ReadAllLines($"{System.Environment.GetEnvironmentVariable("USERPROFILE")}\\OmsFiles\\DicLastUpdate.txt");
                foreach (var status in statusText)
                {
                    foreach (var label in listLabel)
                    {
                        if (label.Text.Contains("F014"))
                        {
                            continue;
                        }
                        label.Text = status;
                        break;
                    }

                }
            }
            else
            {
                infoTable.ForeColor = Color.Red;
                infoTable.Text = "НЕВОЗМОЖНО ОПРЕДЕЛИТЬ ВЕРСИЮ СПРАВОЧНИКА,ВКЛЮЧИТЕ ИНТЕРНЕТ И ПЕРЕЗАПУСТИТЕ ПРОГРАММУ";
            }
            
        }

        private void OpenDoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "*.xls;*.xlsx";
            ofd.Filter = "Microsoft Excel (*.xls*)|*.xls*";
            ofd.Title = "Выберите документ для загрузки данных";
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Вы не выбрали файл для открытия", "Загрузка данных...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _list = ExcelHelper.GetData<SluchFields>(File.ReadAllBytes(ofd.FileName), 0, out var errors);
                if (_list.Count == 0)
                {
                    MessageBox.Show("1й лист файла пустой.\n" +
                                    "Пожайлуста убедитесть что данные находятся на первом листе", "Загрузка данных...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Regex regex = new Regex(@"\w*.\w*$");
                var fileName = regex.Match(ofd.FileName);
                if (ActiveForm != null) ActiveForm.Text = $@"ОМС-Экспертиза [{fileName}]";
                gridControl1.DataSource = _list;
                _filePath = ofd.FileName;
                new DicService().SetRowHandle(_list);
                propertyGridControl1.UpdateData();
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

       


        //Команда ctr + M + M чтобы развернуть регионы и метды
        #region ==События==

        //Событие которое позволяет скролить табличку при выделении ячеек
        private void gridView1_MouseWheel(object sender, MouseEventArgs e)
        {
            gridView1.CloseEditor();
        }

      
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView view = sender as GridView;

          
            var row = gridView1.GetRow(view.FocusedRowHandle) as SluchFields;
            propertyGridControl1.SelectedObject = row;

            new DicService().SetFormat(propertyGridControl1, repositoryItemMemoEdit1);
           
        }
        void SetPropertyGridReadOnly(BaseRow row)
        {
            if (row != null)
            {
                row.Properties.ReadOnly = true;
            }
        }

        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.Bisque;
            }
        }

        private void propertyGridControl1_FocusedRowChanged(object sender, DevExpress.XtraVerticalGrid.Events.FocusedRowChangedEventArgs e)
        {
            SetPropertyGridReadOnly(e.Row);
        }

        private void Service_Log(object sender, string e)
        {
            splashScreenManager1.SetWaitFormDescription(e);
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
            {
                GridView view = sender as GridView;
                var row = gridView1.GetRow(view.FocusedRowHandle) as SluchFields;
                propertyGridControl1.SelectedObject = row;

                new DicService().SetFormat(propertyGridControl1, repositoryItemMemoEdit1);
            }

            if (e.KeyData == Keys.Enter)
            {
                OpenEditDefectForm();
            }
            
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

            if (e.Column.Name == "Status" & e.RowHandle >= 0)
            {
                e.DisplayText = "";
                var row = (SluchFields)gridView1.GetRow(e.RowHandle);

                if (_list.Count != 0)
                {
                    var image = new DicService().SetImageForStatus(row);
                    var startY = e.Bounds.Height <= image.Height
                        ? e.Bounds.Y
                        : e.Bounds.Y + e.Bounds.Height / 2 - image.Height / 2;

                    var finishY = e.Bounds.Height <= image.Height
                        ? e.Bounds.Height
                        : image.Height;

                    var rect = new Rectangle(e.Bounds.X + 1, startY, e.Bounds.Width - 1, finishY);
                    e.Graphics.DrawImage(image, rect);
                }
            }

        }

        private void HaveDefect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenEditDefectForm();
        }

        #endregion

        #region ==Справочник==
        private void CodeDefectF014_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (CodeDefect codeDefect = new CodeDefect("F014.json"))
            {
                codeDefect.ShowDialog();
            }

        }

        private void updateDic_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowUpdateDic(true);
        }

        public void ShowUpdateDic(bool setMessageBox)
        {
            if (!Program.CheckForInternetConnection())
            {
                MessageBox.Show("Интернет не подключен, обновление справочников невозможно", "Обновление справочников", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            splashScreenManager1.ShowWaitForm();
            splashScreenManager1.SetWaitFormCaption("Пожалуйста подождите");
            splashScreenManager1.SetWaitFormDescription("Обновление");
            var service = new DicService();
            service.Log += Service_Log;

            service.UpdateDictionary();

            splashScreenManager1.CloseWaitForm();
            if (setMessageBox)
            {
                MessageBox.Show("Справочники обновлены.", "Обновление справочника", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        #endregion


        private void OpenEditDefectForm()//Кнопка есть дефект МЭЭ
        {
            if (gridView1.SelectedRowsCount == 0)
            {
                MessageBox.Show("Не выбранно ни одной строки", "Загрузка данных...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var handleLastRow = 0;
            var rows = GetSelectedRow(out handleLastRow);

            using (EditDefect editDefect = new EditDefect(_filePath, rows))
            {
                editDefect.ShowDialog();
            }

            gridControl1.DataSource = new DicService().UpdateData(_filePath);
            
            _list = new DicService().UpdateData(_filePath);
            gridView1.FocusedRowHandle = handleLastRow;

        }

        private void NoDefect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var editType = Enums.EditType.Нет_дефектов;
            if (gridView1.SelectedRowsCount == 0)
            {
                MessageBox.Show("Не выбранно ни одной строки", "Загрузка данных...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            #region columns

            var columns = new[]
           {
                new ChangedColumns()
                {
                    Column = "PravilTarif",
                    Value = ""
                },

                new ChangedColumns()
                {
                    Column = "CodeDef",
                    Value = ""
                },

                new ChangedColumns()
                {
                    Column = "PravilKoef",
                    Value = ""
                },

                new ChangedColumns()
                {
                    Column = "Recommend",
                    Value = "Не требуются"
                },

                new ChangedColumns()
                {
                    Column = "Vivod",
                    Value = "Замечаний нет"
                },

                new ChangedColumns()
                {
                    Column = "DiagnozPatolOsn",
                    Value = ""
                },

                new ChangedColumns()
                {
                    Column = "OslogneniePatol",
                    Value = ""
                },

                new ChangedColumns()
                {
                    Column = "SoputsPatol",
                    Value = ""
                },

                new ChangedColumns()
                {
                    Column = "DiagnozKlinZaklOsn",
                    Value = ""
                },

                new ChangedColumns()
                {
                    Column = "OslognenieKlZak",
                    Value = ""
                },

                new ChangedColumns()
                {
                    Column = "SoputsKlZak",
                    Value = ""
                },

                new ChangedColumns()
                {
                    Column = "Operation",
                    Value = ""
                },

                new ChangedColumns()
                {
                    Column = "DateOperac",
                    Value = ""
                },

                new ChangedColumns()
                {
                    Column = "SborInformacii",
                    Value = "В полном объеме"
                },

                new ChangedColumns()
                {
                    Column = "Diagnoz",
                    Value = "Сформулирован верно"
                },

                new ChangedColumns()
                {
                    Column = "Lechenie",
                    Value = "В полном объеме"
                },

                new ChangedColumns()
                {
                    Column = "Preemstvennost",
                    Value = "Не нарушена"
                },

                new ChangedColumns()
                {
                    Column = "CodeUsl",
                    Value = ""
                }

            };

            #endregion

            var handleLastRow = 0;
            var rows = GetSelectedRow(out handleLastRow);

            new ExcelService().EditExcel( rows, _filePath,columns,editType);
            gridControl1.DataSource = new DicService().UpdateData(_filePath);
            _list = new DicService().UpdateData(_filePath);
            gridView1.FocusedRowHandle = handleLastRow;

        }

        private List<SluchFields> GetSelectedRow()
        {
            var rowsHandle = gridView1.GetSelectedRows();
            return new RowSearch().GetRowForEdit(rowsHandle, gridView1);
        }
        private List<SluchFields> GetSelectedRow(out int oldRowHandle)
        {
            var rowsHandle = gridView1.GetSelectedRows();
            oldRowHandle = rowsHandle.LastOrDefault();
            return new RowSearch().GetRowForEdit(rowsHandle, gridView1);
        }

        private void DeleteDefect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var editType = Enums.EditType.Удалить_заключение;
            if (gridView1.SelectedRowsCount == 0)
            {
                MessageBox.Show("Не выбранно ни одной строки", "Загрузка данных...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            #region colums

            var columns = new[]
            {
                new ChangedColumns()
                {
                    Column = "PravilTarif",
                    Value = ""
                },

                new ChangedColumns()
                {
                    Column = "CodeDef",
                    Value = ""
                },

                new ChangedColumns()
                {
                    Column = "PravilKoef",
                    Value = ""
                },

                new ChangedColumns()
                {
                    Column = "Recommend",
                    Value = ""
                },

                new ChangedColumns()
                {
                    Column = "Vivod",
                    Value = ""
                },

                new ChangedColumns()
                {
                    Column = "DiagnozPatolOsn",
                    Value = ""
                },

                new ChangedColumns()
                {
                    Column = "OslogneniePatol",
                    Value = ""
                },

                new ChangedColumns()
                {
                    Column = "SoputsPatol",
                    Value = ""
                },

                new ChangedColumns()
                {
                    Column = "DiagnozKlinZaklOsn",
                    Value = ""
                },

                new ChangedColumns()
                {
                    Column = "OslognenieKlZak",
                    Value = ""
                },

                new ChangedColumns()
                {
                    Column = "SoputsKlZak",
                    Value = ""
                },

                new ChangedColumns()
                {
                    Column = "Operation",
                    Value = ""
                },

                new ChangedColumns()
                {
                    Column = "DateOperac",
                    Value = ""
                },

                new ChangedColumns()
                {
                    Column = "SborInformacii",
                    Value = ""
                },

                new ChangedColumns()
                {
                    Column = "Diagnoz",
                    Value = ""
                },

                new ChangedColumns()
                {
                    Column = "Lechenie",
                    Value = ""
                },

                new ChangedColumns()
                {
                    Column = "Preemstvennost",
                    Value = ""
                },

                new ChangedColumns()
                {
                    Column = "CodeUsl",
                    Value = ""
                }

            };

            #endregion

            var handleLastRow = 0;
            var rows = GetSelectedRow(out handleLastRow);

            new ExcelService().EditExcel(rows, _filePath,columns,editType);
            gridControl1.DataSource = new DicService().UpdateData(_filePath);
            _list = new DicService().UpdateData(_filePath);
            gridView1.FocusedRowHandle = handleLastRow;
        }

        private void HaveDefectEkmp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
            {
                MessageBox.Show("Не выбранно ни одной строки", "Загрузка данных...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var handleLastRow = 0;
            var rows = GetSelectedRow(out handleLastRow);
            using (EditDefectEkmp editDefect = new EditDefectEkmp(_filePath, rows))
            {
               editDefect.ShowDialog();
            }

            gridControl1.DataSource = new DicService().UpdateData(_filePath);
           _list = new DicService().UpdateData(_filePath);
           gridView1.FocusedRowHandle = handleLastRow;
        }

        private void UploadReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GetAndShowReport(_filePath);
        }

        public void GetAndShowReport(string filePath)
        {
            if (filePath == "")
            {
                MessageBox.Show("Для начала выгрузки откройте файл", "Выгрузка отчета...", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var report = new XtraReport();

          
          
            Stream stream = new MemoryStream(Resources.Протокол_к_акту);
            stream.Position = 0;
            report.LoadLayout(stream);

            foreach (var component in report.ComponentStorage.Where(e => e is ExcelDataSource))
            {

                var ds = (ExcelDataSource)component;

                var excel = new ExcelDataSource();

                excel.FileName = filePath;

                if (ds.Name == "F014")
                {
                    excel.FileName = Path.Combine($"{System.Environment.GetEnvironmentVariable("USERPROFILE")}\\OmsFiles",
                        "F014.xlsx");
                }

                var workSheet = new ExcelWorksheetSettings();
                workSheet.WorksheetIndex = 0;

                var options = ds.SourceOptions as ExcelSourceOptions;
                options.ImportSettings = workSheet;
                options.SkipHiddenColumns = false;
                options.SkipHiddenRows = false;
                ds.FileName = filePath;
                ds.SourceOptions = options;
            }



            report.ShowRibbonPreviewDialog();
        }

        private void toolTipController1_GetActiveObjectInfo(object sender,
            DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            GridHitInfo hi = gridView1.CalcHitInfo(e.ControlMousePosition);

            if (hi.InRowCell && hi.Column.Name == "Status")
            {

                var rowValue = gridView1.GetRow(hi.RowHandle);

                var row = rowValue as SluchFields;
                
                var status = row?.Status == Enums.Status.Случай_не_снят ? "Случай не снят" : "Случай снят"; 
                var text = string.IsNullOrEmpty(status)
                    ? gridView1.GetRowCellDisplayText(hi.RowHandle, hi.Column)
                    : status;

                if (text == null)
                {
                    return;
                }

                object o = string.Format("{0}{1}", hi.Column.Name, hi.RowHandle);

                e.Info = new DevExpress.Utils.ToolTipControlInfo(o, text)
                {
                    Title = hi.Column.ToString(),
                };

                return;
            }

            if (hi.InColumn)
            {
                object o = string.Format("{0}{1}", hi.Column.Name, hi.RowHandle);

                e.Info = new DevExpress.Utils.ToolTipControlInfo(o, hi.Column.ToString())
                {
                    Text = hi.Column.ToString()
                };
            }
        }
       

    }
}
