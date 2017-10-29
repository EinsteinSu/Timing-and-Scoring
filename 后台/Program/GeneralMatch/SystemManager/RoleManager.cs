using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SystemManager
{
    public partial class RoleManager : UserControl, ClientCommon.IDataRefresh
    {
        public RoleManager()
        {
            InitializeComponent();

            RefreshData();
        }

        #region IDataRefresh成员
        DataTable dt;
        DataTable dtRole;
        DataTable dtFunction;
        public DataTable[] OperateTables
        {
            get
            {
                DataTable[] dts = new DataTable[2];
                dts[0] = dt;
                dts[1] = dtRole;
                return dts;
            }
        }

        public void RefreshData()
        {
            try
            {
                ClientCommon.SqlHelper.RunSql(@"INSERT INTO ROLEFUNCTION(GUID,ROLEGUID,FUNCTIONGUID,ISHAVE)
                            SELECT NEWID() AS GUID,R.GUID AS ROLEGUID,F.GUID AS FUNCTIONGUID ,0 AS ISHAVE FROM ROLE AS R 
                            LEFT JOIN FUNCTIONS AS F ON 1=1
                            WHERE R.GUID NOT IN(SELECT ROLEGUID FROM ROLEFUNCTION) OR F.GUID NOT IN(SELECT FUNCTIONGUID FROM ROLEFUNCTION)");
                dt = new ClientCommon.RoleFunctionPst(null).GetDataTable();
                dtRole = new ClientCommon.RolePst(null).GetDataTable();
                dtFunction = new ClientCommon.FunctionsPst(null).GetDataTable();
                gcRole.DataSource = dtRole;
                treeFunction.DataSource = dt;
                if (dtRole.Rows.Count == 0)
                    dt.DefaultView.RowFilter = "RoleGuid = '-1'";
                else
                    treeFunction.ExpandAll();
            }
            catch { }
        }

        public void SaveData()
        {
            gcRole.EndUpdate();
            treeFunction.EndUpdate();

            ClientCommon.TableSave ts = new ClientCommon.TableSave(new ClientCommon.TableInfo(typeof(ClientCommon.RoleFunction),
                            typeof(ClientCommon.RoleFunctionPst)), dt);
            ts.Save();

            ClientCommon.TableSave tsr = new ClientCommon.TableSave(
                new ClientCommon.TableInfo(typeof(ClientCommon.Role), typeof(ClientCommon.RolePst)), dtRole);
            tsr.Save();

        }
        #endregion

        private void btAdd_Click(object sender, EventArgs e)
        {
            DataRow drn = dtRole.NewRow();
            drn["Guid"] = Guid.NewGuid();
            drn["Name"] = "New role";
            foreach (DataRow dr in dtFunction.Rows)
            {
                DataRow drr = dt.NewRow();
                drr["Guid"] = Guid.NewGuid();
                drr["RoleGuid"] = drn["Guid"];
                drr["Name"] = dr["Name"];
                drr["FunctionGuid"] = dr["Guid"];
                drr["FGUID"] = dr["Guid"];
                drr["FPGUID"] = dr["PGuid"];
                drr["IsHave"] = 0;
                dt.Rows.Add(drr);
            }
            dtRole.Rows.Add(drn);
            treeFunction.ExpandAll();
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

        private void gvRole_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            RefreshRole();
        }

        public void RefreshRole()
        {
            if (gvRole.GetFocusedDataRow() != null)
            {
                dt.DefaultView.RowFilter = string.Format("RoleGuid = '{0}'", gvRole.GetFocusedDataRow()["Guid"]);
                dt.DefaultView.Sort = "ORDERID";
                treeFunction.ExpandAll();
            }
            else
                dt.DefaultView.RowFilter = "RoleGuid = '-1'";
        }

        private void btAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dt.DefaultView.Count; i++)
            {
                DataRow dr = dt.DefaultView[i].Row;
                dr["ISHAVE"] = 1;
            }
        }

        private void btAdverse_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dt.DefaultView.Count; i++)
            {
                DataRow dr = dt.DefaultView[i].Row;
                if (dr["ISHAVE"].ToString() == "1")
                    dr["ISHAVE"] = 0;
                else
                    dr["ISHAVE"] = 1;
            }
        }

        private void btNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dt.DefaultView.Count; i++)
            {
                DataRow dr = dt.DefaultView[i].Row;
                dr["ISHAVE"] = 0;
            }
        }

        private void btDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow dr = gvRole.GetFocusedDataRow();
            if (dr != null)
            {
                if (MessageBox.Show("是否删除该记录？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dr.Delete();
                    RefreshRole();
                }
            }
            else
            {
                MessageBox.Show("请选择一条需要删除的记录！");
            }
        }
    }
}
