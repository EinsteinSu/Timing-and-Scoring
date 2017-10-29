using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AthleticsParamManager
{
    public partial class TeamsManager : UserControl, ClientCommon.IDataRefresh
    {
        public TeamsManager()
        {
            InitializeComponent();

            RefreshData();
        }

        #region IDataRefresh成员
        DataTable dt;
        DataTable dtAthletes;
        DataTable dtTeamFlowers;
        public DataTable[] OperateTables
        {
            get
            {
                DataTable[] dts = new DataTable[3];
                dts[0] = dt;
                dts[1] = dtAthletes;
                dts[2] = dtTeamFlowers;
                return dts;
            }
        }

        CurrencyManager cmTeams;
        public void RefreshData()
        {

            DataTable dtTemp = Persistent.ParamsPst.GetParams("运动员等级");
            cbLevel.Items.Clear();
            foreach (DataRow dr in dtTemp.Rows)
                cbLevel.Items.Add(dr["Name"].ToString());

            cbClass.Items.Clear();
            dtTemp = Persistent.ParamsPst.GetParams("证件类型");
            foreach (DataRow dr in dtTemp.Rows)
                cbClass.Items.Add(dr["Name"].ToString());

            cbPosition.Items.Clear();
            dtTemp = Persistent.ParamsPst.GetParams("随队人员职务");
            foreach (DataRow dr in dtTemp.Rows)
                cbPosition.Items.Add(dr["Name"].ToString());

            DataSet ds = new DataSet();
            ds.DataSetName = "Sports Entry Form";
            dt = new Persistent.TeamsPst(null).GetDataTable();
            dt.TableName = "Teams";
            ds.Tables.Add(dt);
            dt.RowChanged += new DataRowChangeEventHandler(dt_RowChanged);

            dtAthletes = new Persistent.AthletesPst(null).GetDataTable();
            dtAthletes.TableName = "Athletes";
            ds.Tables.Add(dtAthletes);

            dtTeamFlowers = new Persistent.TeamFlowersPst(null).GetDataTable();
            dtTeamFlowers.TableName = "TeamFlowers";
            ds.Tables.Add(dtTeamFlowers);

            ds.Relations.Add("运动员", dt.Columns["Guid"], dtAthletes.Columns["TeamGuid"], false);
            ds.Relations.Add("教练及随队人员", dt.Columns["Guid"], dtTeamFlowers.Columns["TeamGuid"], false);

            cmTeams = (CurrencyManager)this.BindingContext[ds.Tables["Teams"]];
            dcTeam.DataSource = dngTeam.DataSource = ds.Tables["Teams"];
            dngTeam.PositionChanged += new EventHandler(dngTeam_PositionChanged);

            #region Team bindings
            tbTeamCode.DataBindings.Clear();
            tbTeamCode.DataBindings.Add("EditValue", dt, "Code", true, DataSourceUpdateMode.OnPropertyChanged);
            tbTeamName.DataBindings.Clear();
            tbTeamName.DataBindings.Add("EditValue", dt, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            tbTeamShortName.DataBindings.Clear();
            tbTeamShortName.DataBindings.Add("EditValue", dt, "ShortName", true, DataSourceUpdateMode.OnPropertyChanged);
            tbTeamRemark.DataBindings.Clear();
            tbTeamRemark.DataBindings.Add("EditValue", dt, "Memo", true, DataSourceUpdateMode.OnPropertyChanged);
            pbFlag.DataBindings.Clear();
            pbFlag.DataBindings.Add("EditValue", dt, "Flag", true, DataSourceUpdateMode.OnPropertyChanged);
            #endregion

            gcUsers.DataSource = dtTeamFlowers;

            pbPhoto.DataBindings.Clear();
            pbPhoto.DataBindings.Add("EditValue", dtAthletes, "Photo", true, DataSourceUpdateMode.OnPropertyChanged);

            pbTeamMemberPhoto.DataBindings.Clear();
            pbTeamMemberPhoto.DataBindings.Add("EditValue", dtTeamFlowers, "Photo", true, DataSourceUpdateMode.OnPropertyChanged);

            gcAthletes.DataSource = ds.Tables["Athletes"];
            gvAthletes.BestFitColumns();

            gridControl1.DataSource = ds.Tables["Teams"];
            dt_RowChanged(null, null);
            dngTeam_PositionChanged(null, null);
        }

        void dngTeam_PositionChanged(object sender, EventArgs e)
        {
            if (cmTeams.Position > -1)
            {
                DataRow dr = (cmTeams.Current as DataRowView).Row;
                if (dr != null)
                {
                    dtAthletes.DefaultView.RowFilter = string.Format("TeamGuid = '{0}'", dr["Guid"]);
                    dtTeamFlowers.DefaultView.RowFilter = string.Format("TeamGuid = '{0}'", dr["Guid"]);
                }
                else
                {
                    dtAthletes.DefaultView.RowFilter = string.Format("TeamGuid = '{0}'", -1);
                    dtTeamFlowers.DefaultView.RowFilter = string.Format("TeamGuid = '{0}'", -1);
                }
            }
            else
            {
                dtAthletes.DefaultView.RowFilter = string.Format("TeamGuid = '{0}'", -1);
                dtTeamFlowers.DefaultView.RowFilter = string.Format("TeamGuid = '{0}'", -1);
            }
            gvAthletes.CollapseAllDetails();
        }

        #region RowChanging

        void dt_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            if (dt.Rows.Count == 0)
                dcTeam.Enabled = false;
            else
                dcTeam.Enabled = true;
        }
        #endregion

        public void SaveData()
        {
            gcAthletes.EndUpdate();
            gcUsers.EndUpdate();
            ClientCommon.TableSave ts = new ClientCommon.TableSave(new ClientCommon.TableInfo(typeof(SubStance.Teams),
                            typeof(Persistent.TeamsPst)), dt);
            ts.SaveByImage("flag");

            ClientCommon.TableSave tss = new ClientCommon.TableSave(new ClientCommon.TableInfo(typeof(SubStance.Athletes),
                typeof(Persistent.AthletesPst)), dtAthletes);
            tss.SaveByImage("Photo");

            ClientCommon.TableSave tsf = new ClientCommon.TableSave(new ClientCommon.TableInfo(typeof(SubStance.TeamFlowers),
              typeof(Persistent.TeamFlowersPst)), dtTeamFlowers);
            tsf.SaveByImage("Photo");
        }
        #endregion

        private void btAddTeam_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            dr["Guid"] = Guid.NewGuid();
            dr["Code"] = (dt.Rows.Count + 1).ToString().PadLeft(3, '0');
            dr["Name"] = "New team";
            dt.Rows.Add(dr);
            dngTeam.Position = dt.Rows.IndexOf(dr);
        }

        private void btDeleteTeam_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该记录？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dngTeam.Buttons.DoClick(dngTeam.Buttons.Remove);
                if (cmTeams.Position > -1)
                {
                    DataRow dr = (cmTeams.Current as DataRowView).Row;
                    if (dr != null)
                    {
                        dtAthletes.DefaultView.RowFilter = string.Format("TeamGuid = '{0}'", dr["Guid"]);
                        dtTeamFlowers.DefaultView.RowFilter = string.Format("TeamGuid = '{0}'", dr["Guid"]);
                    }
                    else
                    {
                        dtAthletes.DefaultView.RowFilter = string.Format("TeamGuid = '{0}'", -1);
                        dtTeamFlowers.DefaultView.RowFilter = string.Format("TeamGuid = '{0}'", -1);
                    }
                }
                else
                {
                    dtAthletes.DefaultView.RowFilter = string.Format("TeamGuid = '{0}'", -1);
                    dtTeamFlowers.DefaultView.RowFilter = string.Format("TeamGuid = '{0}'", -1);
                }
                gvAthletes.CollapseAllDetails();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            ClientCommon.DataRefreshOperate dro = new ClientCommon.DataRefreshOperate(this);
            dro.SaveDataOnRefresh();
        }

        private void btAddAthlete_Click(object sender, EventArgs e)
        {
            DataRow dr = (cmTeams.Current as DataRowView).Row;
            if (dr != null)
            {
                int startNum = 0;
                int endNum = 0;
                try
                {
                    startNum = int.Parse(dr["StartNum"].ToString());
                    endNum = int.Parse(dr["EndNum"].ToString());
                }
                catch { }
                if (dr != null)
                {
                    DataRow drn = dtAthletes.NewRow();
                    drn["Guid"] = Guid.NewGuid();
                    if (endNum > 0 && startNum > 0 && endNum < startNum + dtAthletes.DefaultView.Count)
                        MessageBox.Show("BIB编号已越界！");
                    //drn["BIBNum"] = (startNum + dtAthletes.DefaultView.Count).ToString().PadLeft(AthleticsCommon.AthleticsParam.ONPARAM.BIBPADNUM, '0');
                    drn["TeamGuid"] = dr["Guid"];
                    drn["Name"] = "New athlete";
                    dtAthletes.Rows.Add(drn);
                }
            }
            else
            {
                MessageBox.Show("请增加一个参赛队伍！");
            }
        }

        private void btDeleteAthlete_Click(object sender, EventArgs e)
        {
            if (gvAthletes.GetFocusedDataRow() != null)
            {
                if (MessageBox.Show("是否删除该记录？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gvAthletes.GetFocusedDataRow().Delete();
                }
            }
        }

        private void btDeleteEntry_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (entryGrid.GetFocusedDataRow() != null)
            {
                if (MessageBox.Show("是否删除该记录？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    entryGrid.GetFocusedDataRow().Delete();
                }
            }
        }

        DevExpress.XtraGrid.Views.Grid.GridView entryGrid;
        private void gvEntryForm_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            entryGrid = sender as DevExpress.XtraGrid.Views.Grid.GridView;
        }

        private void btAddFlower_Click(object sender, EventArgs e)
        {
            DataRow drt = (cmTeams.Current as DataRowView).Row;
            if (drt != null)
            {
                DataRow dr = dtTeamFlowers.NewRow();
                dr["Guid"] = Guid.NewGuid();
                dr["TeamGuid"] = drt["Guid"];
                dr["Name"] = "New Folower";
                dr["Sex"] = "男";
                dtTeamFlowers.Rows.Add(dr);
            }
        }

        private void btDeleteFlower_Click(object sender, EventArgs e)
        {
            if (gvTeamFlowers.GetFocusedDataRow() != null)
            {
                if (MessageBox.Show("是否删除该记录？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gvTeamFlowers.GetFocusedDataRow().Delete();
                }
            }
        }

        public enum PhotoType
        {
            Athletes, TeamFollowers
        }

        CameraToPhoto cp;
        PhotoType pt;
        private void btAthletesPhoto_Click(object sender, EventArgs e)
        {
            pt = PhotoType.Athletes;
            if (cp == null)
            {
                cp = new CameraToPhoto();
                cp.SelectPhoto += new CameraToPhoto.SelectPhotoCallback(cp_SelectPhoto);
            }
            cp.Show();
        }

        void cp_SelectPhoto(Image img)
        {
            switch (pt)
            {
                case PhotoType.Athletes:
                    if (gvAthletes.GetFocusedDataRow() != null)
                        gvAthletes.GetFocusedDataRow()["Photo"] = ApplicationCommon.BinaryHelper.ImageToByte(img, System.Drawing.Imaging.ImageFormat.Jpeg);
                    break;
                case PhotoType.TeamFollowers:
                    if (gvTeamFlowers.GetFocusedDataRow() != null)
                        gvTeamFlowers.GetFocusedDataRow()["Photo"] = ApplicationCommon.BinaryHelper.ImageToByte(img, System.Drawing.Imaging.ImageFormat.Jpeg);
                    break;
            }
        }

        private void btMembersPhoto_Click(object sender, EventArgs e)
        {
            pt = PhotoType.TeamFollowers;
            if (cp == null)
            {
                cp = new CameraToPhoto();
                cp.SelectPhoto += new CameraToPhoto.SelectPhotoCallback(cp_SelectPhoto);
            }
            cp.Show();
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            DataRow drt = (cmTeams.Current as DataRowView).Row;
            if (drt != null)
            {
                DataTable temp = ClientCommon.SqlHelper.GetDataTable(string.Format(@"SELECT * FROM V_TEAMLIST WHERE TEAMGUID = '{0}'",
                    drt["Guid"]));
                ClientCommon.ReportHelper.ShowPrint("Athletes.repx", temp);
            }
        }

        private void btPrintAll_Click(object sender, EventArgs e)
        {
            DataTable temp = ClientCommon.SqlHelper.GetDataTable(@"SELECT * FROM V_TEAMLIST");
            ClientCommon.ReportHelper.ShowPrint("Athletes.repx", temp);
        }

        private void btClipBord_Click(object sender, EventArgs e)
        {
            ClientControlCommon.TempClipbord tc = new ClientControlCommon.TempClipbord();
            tc.Show();
        }
    }
}
