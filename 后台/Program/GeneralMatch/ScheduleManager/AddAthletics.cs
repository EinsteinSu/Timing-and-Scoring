using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScheduleManager
{
    public partial class AddAthletics : ApplicationControlCommon.DialogForm
    {
        public DataTable AthletesTable { get; set; }
        public AddAthletics(string teamGuid)
        {
            InitializeComponent();
            DataTable temp = ClientCommon.SqlHelper.GetDataTable(
                string.Format("SELECT * FROM Teams WHERE GUID = '{0}'", teamGuid));
            if (temp.Rows.Count > 0)
            {
                this.Text = string.Format("{0} 队员名单", temp.Rows[0]["Name"]);
            }
            AthletesTable = ClientCommon.SqlHelper.GetDataTable(
                string.Format("SELECT * FROM Athletes WHERE TEAMGUID = '{0}'", teamGuid));
            AthletesTable.Columns.Add("CHOOSE", typeof(int));
            foreach (DataRow dr in AthletesTable.Rows)
            {
                dr["Choose"] = 0;
            }
            gcAthletics.DataSource = AthletesTable;
        }

        private void rbSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sex = (int)rbSex.EditValue;
            switch (sex)
            {
                case -1:
                    AthletesTable.DefaultView.RowFilter = "";
                    break;
                case 0:
                    AthletesTable.DefaultView.RowFilter = "Sex = '男'";
                    break;
                case 1:
                    AthletesTable.DefaultView.RowFilter = "Sex = '女'";
                    break;
            }
        }

        private void btUnChoose_Click(object sender, EventArgs e)
        {
            for(int i=0;i<AthletesTable.DefaultView.Count;i++)
            {
                DataRow dr = AthletesTable.DefaultView[i].Row;
                dr["Choose"] = 0;
            }
        }

        private void btInChoose_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < AthletesTable.DefaultView.Count; i++)
            {
                DataRow dr = AthletesTable.DefaultView[i].Row;
                if (dr["Choose"].ToString() == "0")
                    dr["Choose"] = 1;
                else
                    dr["Choose"] = 0;
            }
        }

        private void btChooseAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < AthletesTable.DefaultView.Count; i++)
            {
                DataRow dr = AthletesTable.DefaultView[i].Row;
                dr["Choose"] = 1;
            }
        }

        private void AddAthletics_OkClick()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
