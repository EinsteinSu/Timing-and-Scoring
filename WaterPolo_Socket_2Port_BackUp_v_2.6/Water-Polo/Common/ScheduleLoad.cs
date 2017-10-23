using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Common
{
    public partial class ScheduleLoad : ApplicationControlCommon.DialogForm
    {
        public DataRow ScheduleRow { get; set; }
        DataTable dt;
        public ScheduleLoad()
        {
            InitializeComponent();

            btRefresh_Click(null, null);
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            dt = ClientCommon.SqlHelper.GetDataTable("SELECT * FROM V_Schedule WHERE PGUID = '-1' ORDER BY GAMEDATE,GAMETIME");
            gridControl1.DataSource = dt;
            advBandedGridView1.ExpandAllGroups();
        }

        private void btExpand_Click(object sender, EventArgs e)
        {
            advBandedGridView1.ExpandAllGroups();
        }

        private void btCollapse_Click(object sender, EventArgs e)
        {
            advBandedGridView1.CollapseAllGroups();
        }

        private void ScheduleLoad_OkClick()
        {
            if (advBandedGridView1.GetFocusedDataRow() != null)
            {
                ScheduleRow = advBandedGridView1.GetFocusedDataRow();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
                MessageBox.Show("请选择一个赛事！");
        }
    }
}
