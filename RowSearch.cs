using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using Lib.Helpers;
using LibRgs.Helpers;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI = LibRgs.Helpers.NPOI;


namespace Mee
{
    public class RowSearch
    {
        
        public List<SluchFields> GetRowForEdit(int[] rowsHandle, GridView gridView)
        {
            List<SluchFields> stroki = new List<SluchFields>();
            
            foreach (var i in rowsHandle)
            {
                if (i < 0)
                {
                   continue;
                }
                stroki.Add(gridView.GetRow(i) as SluchFields);
            }

            return stroki;
        }

    }
}
