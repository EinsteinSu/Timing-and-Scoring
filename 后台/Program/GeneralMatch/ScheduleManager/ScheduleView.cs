using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScheduleManager
{
    public partial class ScheduleView : UserControl,ClientCommon.IDataRefresh
    {
        public ScheduleView()
        {
            InitializeComponent();

            RefreshData();
        }

        DataTable dt;
        public DataTable[] OperateTables
        {
            get
            {
                DataTable[] dts = new DataTable[3];
                dts[0] = dt;
                return dts;
            }
        }

        public void RefreshData()
        {
            DataTable dtTeams = new Persistent.TeamsPst(null).GetDataTable();
            lueTeamA.DataSource = dtTeams;
            lueTeamB.DataSource = dtTeams;

            DataTable dtGymnasium = new Persistent.GymnasiumPst(null).GetDataTable();
            lueGymnasium.DataSource = dtGymnasium;

            DataTable dtArea = new Persistent.AreaPst(null).GetDataTable();
            lueArea.DataSource = dtArea;

            dt = new Persistent.SchedulePst(null).GetDataTable();
            tvSchedule.DataSource = dt;
            tvSchedule.ExpandAll();
        }

        public void SaveData()
        {
            throw new NotImplementedException();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btExpand_Click(object sender, EventArgs e)
        {
            tvSchedule.ExpandAll();
        }

        private void btCollapse_Click(object sender, EventArgs e)
        {
            tvSchedule.CollapseAll();
        }
    }
}
