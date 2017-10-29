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
    public partial class SingleSchedule : UserControl, ClientCommon.IDataRefresh
    {
        public SingleSchedule()
        {
            InitializeComponent();

            RefreshData();
        }

        #region IDataRefresh成员
        DataTable dt;
        DataTable dtTeamA;
        DataTable dtTeamB;
        public DataTable[] OperateTables
        {
            get
            {
                DataTable[] dts = new DataTable[3];
                dts[0] = dt;
                dts[1] = dtTeamA;
                dts[2] = dtTeamB;
                return dts;
            }
        }

        public void RefreshData()
        {
            dtTeamA = new Persistent.ScheduleAthletesPst(null).GetDataTable(" WHERE TEAMMARK = 'A'");
            dtTeamB = new Persistent.ScheduleAthletesPst(null).GetDataTable(" WHERE TEAMMARK = 'B'");
            gcTeamA.DataSource = dtTeamA;
            gcTeamB.DataSource = dtTeamB;

            DataTable dtTeams = new Persistent.TeamsPst(null).GetDataTable();
            lueTeamA.DataSource = dtTeams;
            lueTeamB.DataSource = dtTeams;

            DataTable dtGymnasium = new Persistent.GymnasiumPst(null).GetDataTable();
            lueGymnasium.DataSource = dtGymnasium;

            DataTable dtArea = new Persistent.AreaPst(null).GetDataTable();
            lueArea.DataSource = dtArea;

            dt = new Persistent.SchedulePst(null).GetDataTable();
            gcSchedule.DataSource = dt;
        }

        public void SaveData()
        {
            ClientCommon.TableSave ts = new ClientCommon.TableSave(new ClientCommon.TableInfo(typeof(SubStance.Schedule),
                typeof(Persistent.SchedulePst)), dt);
            ts.Save();

            ClientCommon.TableSave tsa = new ClientCommon.TableSave(new ClientCommon.TableInfo(typeof(SubStance.ScheduleAthletes),
                typeof(Persistent.ScheduleAthletesPst)), dtTeamA);
            tsa.Save();

            ClientCommon.TableSave tsb = new ClientCommon.TableSave(new ClientCommon.TableInfo(typeof(SubStance.ScheduleAthletes),
                typeof(Persistent.ScheduleAthletesPst)), dtTeamB);
            tsb.Save();
        }
        #endregion

        private void btSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            dr["Guid"] = Guid.NewGuid();
            dr["PGuid"] = -1;
            dr["Name"] = "New Match";
            dr["State"] = "未开始";
            dt.Rows.Add(dr);
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            ClientCommon.DataRefreshOperate dro = new ClientCommon.DataRefreshOperate(this);
            dro.SaveDataOnRefresh();
        }

        private void btDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvSchedule.GetFocusedDataRow() != null)
            {
                if (MessageBox.Show("是否删除该记录？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gvSchedule.GetFocusedDataRow().Delete();
                }
            }
        }

        private void gvSchedule_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvSchedule.GetFocusedDataRow() != null)
            {
                DataRow dr = gvSchedule.GetFocusedDataRow();
                dtTeamA.DefaultView.RowFilter = dtTeamB.DefaultView.RowFilter = string.Format("ScheduleGuid = '{0}'", dr["Guid"]);
            }
        }

        private void btDeleteTeamAAthletes_Click(object sender, EventArgs e)
        {
            if (gvTeamA.GetFocusedDataRow() != null)
            {
                gvTeamA.GetFocusedDataRow().Delete();
            }
        }

        private void btAddTeamAAthletes_Click(object sender, EventArgs e)
        {
            DataRow drp = gvSchedule.GetFocusedDataRow();
            if (drp != null && drp["TeamAGuid"].ToString().Length > 0)
            {
                AddAthletics frm = new AddAthletics(drp["TeamAGuid"].ToString());
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    frm.AthletesTable.DefaultView.RowFilter = "Choose = 1";
                    for (int i = 0; i < frm.AthletesTable.DefaultView.Count; i++)
                    {
                        DataRow dr = frm.AthletesTable.DefaultView[i].Row;
                        DataRow drn = dtTeamA.NewRow();
                        drn["Guid"] = Guid.NewGuid();
                        drn["ScheduleGuid"] = drp["Guid"];
                        drn["TeamMark"] = "A";
                        drn["ATHLETESGUID"] = dr["Guid"];
                        drn["ATHLETESNAME"] = dr["Name"];
                        drn["BIBNum"] = dr["BIBNum"];
                        drn["Sex"] = dr["Sex"];
                        dtTeamA.Rows.Add(drn);
                    }
                }
            }
        }

        private void btDeleteTeamBAthletes_Click(object sender, EventArgs e)
        {
            if (gvTeamB.GetFocusedDataRow() != null)
            {
                gvTeamB.GetFocusedDataRow().Delete();
            }
        }

        private void btAddTeamBAthletes_Click(object sender, EventArgs e)
        {
            DataRow drp = gvSchedule.GetFocusedDataRow();
            if (drp != null && drp["TeamBGuid"].ToString().Length > 0)
            {
                AddAthletics frm = new AddAthletics(drp["TeamBGuid"].ToString());
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    frm.AthletesTable.DefaultView.RowFilter = "Choose = 1";
                    for (int i = 0; i < frm.AthletesTable.DefaultView.Count; i++)
                    {
                        DataRow dr = frm.AthletesTable.DefaultView[i].Row;
                        DataRow drn = dtTeamB.NewRow();
                        drn["Guid"] = Guid.NewGuid();
                        drn["ScheduleGuid"] = drp["Guid"];
                        drn["TeamMark"] = "B";
                        drn["ATHLETESGUID"] = dr["Guid"];
                        drn["ATHLETESNAME"] = dr["Name"];
                        drn["BIBNum"] = dr["BIBNum"];
                        drn["Sex"] = dr["Sex"];
                        dtTeamB.Rows.Add(drn);
                    }
                }
            }
        }
    }
}
