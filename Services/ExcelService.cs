using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Lib.Helpers;
using Mee.Classes;
using NPOI.HSSF.UserModel;
using Npoi.Mapper.Attributes;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace Mee
{
    public class ExcelService
    {
        public void WriteToExcel(string filePath, List<ChangedValues> changedValues)
        {
            IWorkbook workbook;
            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    // XSSFWorkbook подходит для формата XLSX, HSSFWorkbook подходит для формата XLS
                    string fileExt = Path.GetExtension(filePath).ToLower();
                    if (fileExt == ".xls")
                    {
                        workbook = new HSSFWorkbook(fileStream);
                    }
                    else if (fileExt == ".xlsx")
                    {
                        workbook = new XSSFWorkbook(fileStream);
                    }
                    else
                    {
                        workbook = null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            var sheet = workbook.GetSheetAt(0);

            foreach (var changedValue in changedValues)
            {
                foreach (var i in sheet.GetRow(0))
                {
                    if (changedValue.ColumnName == i.StringCellValue)
                    {
                        SetCellValue(sheet, changedValue.RowNumber, i.Address.Column, changedValue.NewValue);
                    }
                }
            }

            
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                workbook.Write(fs);
                fs.Close();
            }

        }

        private void SetCellValue(ISheet worksheet, int rowPosition, int columnPosition, String value)
        {
            IRow dataRow = worksheet.GetRow(rowPosition) ?? worksheet.CreateRow(rowPosition);
            ICell cell = dataRow.GetCell(columnPosition) ?? dataRow.CreateCell(columnPosition);
            cell.SetCellValue(value);
        }

        public void EditExcel(List<SluchFields> _sluchFieldsList,string _filePath,ChangedColumns[] columns,Enums.EditType editType)
        {
            List<ChangedValues> changedValues = new List<ChangedValues>();
            
            foreach (var i in _sluchFieldsList)
            {
                foreach (var column in columns)
                {
                    
                    if (column.Value == "" && (editType == Enums.EditType.Есть_дефект_МЭЭ | editType == Enums.EditType.Есть_дефект_ЭКМП))
                    {
                        continue;
                    }

                    var attribute = ReflectionHelper.GetAttribute<ColumnAttribute>(i, column.Column);

                    if (attribute == null)
                    {
                        throw new Exception($"Не найдена колонка {column}");
                    }

                    var newValue = new ChangedValues()
                    {
                        ColumnName = attribute.Name,
                        RowNumber = i.RowHandle,
                        NewValue = column.Value
                    };
                    changedValues.Add(newValue);
                }
            }

            new ExcelService().WriteToExcel(_filePath, changedValues);
        }

    }
}
