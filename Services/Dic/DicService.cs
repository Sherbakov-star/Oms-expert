using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraVerticalGrid;
using DevExpress.XtraVerticalGrid.Rows;
using Lib.Helpers;
//using LibRgs.Enums;
using Mee.Properties;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using Aspose.Cells;
using Mee.Dic;


namespace Mee
{
    public class DicService
    {
        public event EventHandler<string> Log;
       
        public void Add(string adress, string schemaName, string dicName, string jsonFileName)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                var newDicVersion = GetDicVersion(client, adress, schemaName, dicName);

                var currentDicVersion = "";
                var createUserPath =
                    Directory.CreateDirectory($"{System.Environment.GetEnvironmentVariable("USERPROFILE")}\\OmsFiles");
                var userPath =createUserPath.FullName;
                var userPathJson = Path.Combine(userPath, jsonFileName);
                var currentPath = Path.Combine(userPath, $"Dic{dicName}Version.txt");

                if (File.Exists(currentPath))
                {
                    currentDicVersion = File.ReadAllText(currentPath);
                }
                else
                {
                    File.WriteAllText(currentPath, "");
                }


                if (newDicVersion != currentDicVersion)
                {
                    OnLog("Обновление справочника " + dicName);

                    File.Delete(userPathJson);
                    int i = 1;
                    var result = "";
                  
                    File.AppendAllText(userPathJson, "[");
                    Regex regex = new Regex(@"");
                    
                    while (result != "[]")
                    {
                        string uri = $"{adress}/{schemaName}/{dicName}/data?sheet={i}&count=100";
                        result = client.GetStringAsync(uri).Result;
                        if (result != "[]")
                        {
                            result = result.Substring(1);
                            result = result.Remove(result.Length - 1);
                            File.AppendAllText(userPathJson, result + ",");
                            OnLog($"Обновление {dicName} записи: {i * 100}");
                            i++;
                        }
                        
                    }
                    File.AppendAllText(userPathJson, "]");
                    File.WriteAllText(currentPath, newDicVersion);

                    //Дата обновления справочников

                   
                    var pathOfLastUpdate = Path.Combine(userPath, "DicLastUpdate.txt");
                    string[] currentLastUpdate;
                    if (File.Exists(pathOfLastUpdate))
                    { 
                        currentLastUpdate = File.ReadAllLines(pathOfLastUpdate);
                    }
                    else
                    {
                        currentLastUpdate = new[] { "" };
                    }
                   
                    var dateOfLastUpdate = "";
                    var getJsonForDate = new DicService().GetDicDate(client, adress, schemaName, dicName);
                    List<DicNsi> lastUpdates = JsonConvert.DeserializeObject<List<DicNsi>>(getJsonForDate);
                    foreach (var lastUpdate in lastUpdates)
                    {
                        if (lastUpdate.Code == dicName)
                        {
                            if (currentLastUpdate.Length == 2)
                            {
                                File.Delete(pathOfLastUpdate);
                            }
                            DateTime myDate = DateTime.Parse(lastUpdate.UpdateDate);
                            dateOfLastUpdate += $" {dicName} от {myDate:dd.MM.yyyy}\n";
                            File.AppendAllText(pathOfLastUpdate, dateOfLastUpdate);
                        }
                    }
                  
                    //Сохраняем json в excel формате для отчета

                    Workbook book = new Workbook();
                 
                    Worksheet sheet = book.Worksheets[0];

                    var json = File.ReadAllText(Path.Combine(userPath, "F014.json"));
                    List<F014> userList = JsonConvert.DeserializeObject<List<F014>>(json);
                   
                    sheet.Cells.ImportCustomObjects((System.Collections.ICollection)userList,
                        new string[] { "Osn", "Caption" }, // propertyNames
                        true, // isPropertyNameShown
                        0, // firstRow
                        0, // firstColumn
                        userList.Count, // Number of objects to be exported
                        true, // insertRows
                        null, // dateFormatString
                        false); // convertStringToNumber

                    // Save the Excel file
                    book.Save(Path.Combine(userPath,"F014.xlsx"));

                }

            }

        }


        string GetDicVersion(HttpClient client,string adress,string schemaName,string dicName)
        {
            return client.GetStringAsync($"{adress}/NsiVersion/version?code={schemaName}.{dicName}").Result;
        }

        public string GetDicDate(HttpClient client, string adress, string schemaName, string dicName)
        {
            return client.GetStringAsync($"{adress}/NsiVersion/data?UpdateDate={schemaName}.{dicName}").Result;
        }

        protected virtual void OnLog(string e)
        {
            Log?.Invoke(this, e);
        }

        public void SetMandatoryField(BaseEdit controlEdit)
        {
            if (controlEdit.EditValue is null)
            {
                controlEdit.Properties.Appearance.BackColor = Color.Tomato;
            }
        }

        public bool IsNotEmpty(BaseEdit controlEdit)
        {
            if (controlEdit?.EditValue?.ToString() != null && controlEdit?.EditValue?.ToString() != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<SluchFields> UpdateData(string fileName)
        {
            var list = ExcelHelper.GetData<SluchFields>(File.ReadAllBytes(fileName), 0, out var errors);
            new DicService().SetRowHandle(list);
            return list;
        }

        public void SetRowHandle(List<SluchFields> _list)
        {
            for (int i = 1; i <= _list.Count; i++)
            {
                _list[i - 1].RowHandle = i;
            }
        }

        public Bitmap SetImageForStatus(SluchFields row)
        {
            return row.Status == Enums.Status.Случай_не_снят ? new Bitmap(Resources.galka) : new Bitmap(Resources.krestik);
        }

        public void UpdateDictionary()
        {
            var service = new DicService();
            service.Add(Properties.Settings.Default.DicUrl, "Dic", "F014", "F014.json");
            service.Add(Properties.Settings.Default.DicUrl, "Tyumen", "T003", "T003.json");
        }

        public void SetFormat(PropertyGridControl propertyGridControl1,RepositoryItemMemoEdit repositoryItemMemoEdit1)
        {
            propertyGridControl1.RowsIterator.DoOperation(new SetEditor(repositoryItemMemoEdit1, "CODE_USL_NAME"));
            propertyGridControl1.RowsIterator.DoOperation(new SetEditor(repositoryItemMemoEdit1, "DS1_NAME"));
            propertyGridControl1.RowsIterator.DoOperation(new SetEditor(repositoryItemMemoEdit1, "RSLT_D_NAME"));
            propertyGridControl1.RowsIterator.DoOperation(new SetEditor(repositoryItemMemoEdit1, "DiagnozPatolOsn"));
            propertyGridControl1.RowsIterator.DoOperation(new SetEditor(repositoryItemMemoEdit1, "OslogneniePatol"));
            propertyGridControl1.RowsIterator.DoOperation(new SetEditor(repositoryItemMemoEdit1, "SoputsPatol"));
            propertyGridControl1.RowsIterator.DoOperation(new SetEditor(repositoryItemMemoEdit1, "DiagnozKlinZaklOsn"));
            propertyGridControl1.RowsIterator.DoOperation(new SetEditor(repositoryItemMemoEdit1, "OslognenieKlZak"));
            propertyGridControl1.RowsIterator.DoOperation(new SetEditor(repositoryItemMemoEdit1, "SoputsKlZak"));
            propertyGridControl1.RowsIterator.DoOperation(new SetEditor(repositoryItemMemoEdit1, "Operation"));
            propertyGridControl1.RowsIterator.DoOperation(new SetEditor(repositoryItemMemoEdit1, "SborInformacii"));
            propertyGridControl1.RowsIterator.DoOperation(new SetEditor(repositoryItemMemoEdit1, "Diagnoz"));
            propertyGridControl1.RowsIterator.DoOperation(new SetEditor(repositoryItemMemoEdit1, "Lechenie"));
            propertyGridControl1.RowsIterator.DoOperation(new SetEditor(repositoryItemMemoEdit1, "Preemstvennost"));
            propertyGridControl1.RowsIterator.DoOperation(new SetEditor(repositoryItemMemoEdit1, "Vivod"));
            propertyGridControl1.RowsIterator.DoOperation(new SetEditor(repositoryItemMemoEdit1, "Recommend"));
        }

        public class SetEditor : RowOperation
        {
            private readonly RepositoryItem _item;
            private readonly string _field;

            public SetEditor(RepositoryItem item, string field)
            {
                _item = item;
                _field = field;
            }

            public override void Execute(BaseRow row)
            {
                if (row.Name.ToUpper().EndsWith(_field.ToUpper()))
                {
                    row.Properties.RowEdit = _item;
                }
            }
        }

    }
}
