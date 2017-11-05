using System;
using System.Data;
using System.Windows.Forms;
using ClientCommon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using Persistent;
using SubStance;

namespace ScheduleManager
{
    public partial class TeamSchedule : UserControl, IDataRefresh
    {
        public TeamSchedule()
        {
            InitializeComponent();
            RefreshData();
        }

        private void tvSchedule_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            var drp = (DataRowView)tvSchedule.GetDataRecordByNode(tvSchedule.FocusedNode);
            if (drp != null)
            {
                _dtTeamA.DefaultView.RowFilter = _dtTeamB.DefaultView.RowFilter =
                    $"ScheduleGuid = '{drp["Guid"]}'";
                if (drp["PGuid"].ToString() == "-1")
                {
                    cNum.OptionsColumn.AllowEdit = false;
                    cTeamA.OptionsColumn.AllowEdit = true;
                    cTeamB.OptionsColumn.AllowEdit = true;
                }
                else
                {
                    cNum.OptionsColumn.AllowEdit = true;
                    cTeamA.OptionsColumn.AllowEdit = false;
                    cTeamB.OptionsColumn.AllowEdit = false;
                }
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            var dr = _dt.NewRow();
            dr["Guid"] = Guid.NewGuid();
            dr["PGuid"] = -1;
            dr["Name"] = "New Match";
            dr["State"] = "未开始";
            _dt.Rows.Add(dr);
        }

        private void btAddChild_Click(object sender, EventArgs e)
        {
            if (tvSchedule.FocusedNode != null)
            {
                var drp = (DataRowView)tvSchedule.GetDataRecordByNode(tvSchedule.FocusedNode);
                if (drp != null)
                {
                    if (drp["PGuid"].ToString() != "-1")
                    {
                        MessageBox.Show(@"子项中不能再有子项！");
                        return;
                    }
                    var dr = _dt.NewRow();
                    dr["Guid"] = Guid.NewGuid();
                    dr["PGuid"] = drp["Guid"];
                    dr["Name"] = drp["Name"];
                    dr["GameDate"] = drp["GameDate"];
                    dr["GameTime"] = drp["GameTime"];
                    dr["TeamAGuid"] = drp["TeamAGuid"];
                    dr["TeamBGuid"] = drp["TeamBGuid"];
                    dr["GymnasiumGuid"] = drp["GymnasiumGuid"];
                    dr["AreaGuid"] = drp["AreaGuid"];
                    dr["Num"] = tvSchedule.FocusedNode.Nodes.Count + 1;
                    dr["State"] = "未开始";
                    _dt.Rows.Add(dr);
                    tvSchedule.FocusedNode.ExpandAll();
                }
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            var dro = new DataRefreshOperate(this);
            dro.SaveDataOnRefresh();
        }

        private void btDelete_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (tvSchedule.FocusedNode != null)
            {
                if (MessageBox.Show(@"是否删除该记录？", @"询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    tvSchedule.DeleteNode(tvSchedule.FocusedNode);
            }
            else
            {
                MessageBox.Show(@"请选择一条需要删除的记录！");
            }
        }

        private void lueTeamA_EditValueChanged(object sender, EventArgs e)
        {
            var lue = sender as LookUpEdit;
            if (tvSchedule.FocusedNode != null)
            {
                var drp = (DataRowView)tvSchedule.GetDataRecordByNode(tvSchedule.FocusedNode);
                if (drp["PGuid"].ToString() == "-1")
                    foreach (TreeListNode tn in tvSchedule.FocusedNode.Nodes)
                    {
                        var drc = ((DataRowView)tvSchedule.GetDataRecordByNode(tn)).Row;
                        if (lue != null)
                        {
                            drc["TeamAGuid"] = lue.EditValue;
                        }
                    }
            }
        }

        private void lueTeamB_EditValueChanged(object sender, EventArgs e)
        {
            var lue = sender as LookUpEdit;
            if (tvSchedule.FocusedNode != null)
            {
                var drp = (DataRowView)tvSchedule.GetDataRecordByNode(tvSchedule.FocusedNode);
                if (drp["PGuid"].ToString() == "-1")
                    foreach (TreeListNode tn in tvSchedule.FocusedNode.Nodes)
                    {
                        var drc = ((DataRowView)tvSchedule.GetDataRecordByNode(tn)).Row;
                        if (lue != null)
                        {
                            drc["TeamBGuid"] = lue.EditValue;
                        }
                    }
            }
        }

        private void btExpand_Click(object sender, EventArgs e)
        {
            tvSchedule.ExpandAll();
        }

        private void btCollapse_Click(object sender, EventArgs e)
        {
            tvSchedule.CollapseAll();
        }

        private void btAddTeamAAthletes_Click(object sender, EventArgs e)
        {
            var drp = (DataRowView)tvSchedule.GetDataRecordByNode(tvSchedule.FocusedNode);
            if (drp != null && drp["TeamAGuid"].ToString().Length > 0)
            {
                var frm = new AddAthletics(drp["TeamAGuid"].ToString());
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    frm.AthletesTable.DefaultView.RowFilter = "Choose = 1";
                    for (var i = 0; i < frm.AthletesTable.DefaultView.Count; i++)
                    {
                        var dr = frm.AthletesTable.DefaultView[i].Row;
                        var drn = _dtTeamA.NewRow();
                        drn["Guid"] = Guid.NewGuid();
                        drn["ScheduleGuid"] = drp["Guid"];
                        drn["TeamMark"] = "A";
                        drn["ATHLETESGUID"] = dr["Guid"];
                        drn["ATHLETESNAME"] = dr["Name"];
                        drn["BIBNum"] = dr["BIBNum"];
                        drn["Sex"] = dr["Sex"];
                        _dtTeamA.Rows.Add(drn);
                    }
                }
            }
        }

        private void btDeleteTeamAAthletes_Click(object sender, EventArgs e)
        {
            if (gvTeamA.GetFocusedDataRow() != null)
            {var row = gvTeamA.GetFocusedDataRow();
                new ScheduleAthletesPst(null).Delete(row["guid"].ToString());
                _dtTeamA.Rows.Remove(row);
            }
        }private void btAddTeamBAthletes_Click(object sender, EventArgs e)
        {
            var drp = (DataRowView)tvSchedule.GetDataRecordByNode(tvSchedule.FocusedNode);
            if (drp != null && drp["TeamBGuid"].ToString().Length > 0)
            {
                var frm = new AddAthletics(drp["TeamBGuid"].ToString());
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    frm.AthletesTable.DefaultView.RowFilter = "Choose = 1";
                    for (var i = 0; i < frm.AthletesTable.DefaultView.Count; i++)
                    {
                        var dr = frm.AthletesTable.DefaultView[i].Row;
                        var drn = _dtTeamB.NewRow();
                        drn["Guid"] = Guid.NewGuid();
                        drn["ScheduleGuid"] = drp["Guid"];
                        drn["TeamMark"] = "B";
                        drn["ATHLETESGUID"] = dr["Guid"];
                        drn["ATHLETESNAME"] = dr["Name"];
                        drn["BIBNum"] = dr["BIBNum"];
                        drn["Sex"] = dr["Sex"];
                        _dtTeamB.Rows.Add(drn);
                    }
                }
            }
        }

        private void btDeleteTeamBAthletes_Click(object sender, EventArgs e)
        {
            if (gvTeamB.GetFocusedDataRow() != null)
            {
                var row = gvTeamB.GetFocusedDataRow();
                new ScheduleAthletesPst(null).Delete(row["guid"].ToString());
                _dtTeamB.Rows.Remove(row);
            }
        }

        #region IDataRefresh成员

        private DataTable _dt;
        private DataTable _dtTeamA;
        private DataTable _dtTeamB;

        public DataTable[] OperateTables
        {
            get
            {
                var dts = new DataTable[3];
                dts[0] = _dt;
                dts[1] = _dtTeamA;
                dts[2] = _dtTeamB;
                return dts;
            }
        }

        public void RefreshData()
        {
            _dtTeamA = new ScheduleAthletesPst(null).GetDataTable(" WHERE TEAMMARK = 'A'");
            _dtTeamB = new ScheduleAthletesPst(null).GetDataTable(" WHERE TEAMMARK = 'B'");
            gcTeamA.DataSource = _dtTeamA;
            gcTeamB.DataSource = _dtTeamB;

            var dtTeams = new TeamsPst(null).GetDataTable();
            lueTeamA.DataSource = dtTeams;
            lueTeamB.DataSource = dtTeams;

            var dtGymnasium = new GymnasiumPst(null).GetDataTable();
            lueGymnasium.DataSource = dtGymnasium;

            var dtArea = new AreaPst(null).GetDataTable();
            lueArea.DataSource = dtArea;

            _dt = new SchedulePst(null).GetDataTable();
            tvSchedule.DataSource = _dt;
        }

        public void SaveData()
        {
            var ts = new TableSave(new TableInfo(typeof(Schedule),
                typeof(SchedulePst)), _dt);
            ts.Save();

            var tsa = new TableSave(new TableInfo(typeof(ScheduleAthletes),
                typeof(ScheduleAthletesPst)), _dtTeamA);
            tsa.Save();

            var tsb = new TableSave(new TableInfo(typeof(ScheduleAthletes),
                typeof(ScheduleAthletesPst)), _dtTeamB);
            tsb.Save();
        }

        #endregion
    }
}