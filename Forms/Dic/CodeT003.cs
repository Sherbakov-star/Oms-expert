using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace Mee
{
    public partial class CodeT003 : Form
    {
       public T003 CodeUslugi { get; private set; }

        public CodeT003(string jsonFileName)
        {
            InitializeComponent();
            
            var list = new CodeDefectService().GetDicFromJson<T003>(jsonFileName);
            
            var orderByList = list.OrderBy(ob => ob.Caption).ToList();
            var distinctList = orderByList.GroupBy(gr => new{gr.Caption,gr.Code}).Select(group => group.First()).ToList();
            gridControl1.DataSource = distinctList;
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Clicks != 2)
            {
                return;
            }

            CodeUslugi = gridView1.GetRow(e.RowHandle) as T003;
            DialogResult = DialogResult.OK;
        }

    }
}
