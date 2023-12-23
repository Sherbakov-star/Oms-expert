using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraVerticalGrid.Rows;

namespace Mee
{
    public partial class CodeDefect : Form
    {
       
        public CodeDefect(string jsonFileName)
        {
            InitializeComponent();
            var list = new CodeDefectService().GetDicFromJson<F014>(jsonFileName);

            var orderByList = list.OrderBy(ob => ob.Caption).ToList();
            var distinctList = orderByList.GroupBy(gr => new { gr.Caption, gr.Code }).Select(group => group.First()).ToList();
            gridControl1.DataSource = distinctList;
        }

    }
}
