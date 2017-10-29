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
    public partial class ParamsManager : UserControl, ClientCommon.IDataRefresh
    {
        public ParamsManager()
        {
            InitializeComponent();

            RefreshData();
        }

        #region IDataRefresh成员
        DataTable dt;
        public DataTable[] OperateTables
        {
            get
            {
                DataTable[] dts = new DataTable[1];
                dts[0] = dt;
                return dts;
            }
        }

        public void RefreshData()
        {
            dt = new Persistent.ParamsPst(null).GetDataTable();
            gcParams.DataSource = dt;
        }

        public void SaveData()
        {
            ClientCommon.TableSave ts = new ClientCommon.TableSave(new ClientCommon.TableInfo(typeof(SubStance.Params),
                            typeof(Persistent.ParamsPst)), dt);
            ts.Save();
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
            dr["Class"] = "New param class";
            dr["OrderID"] = 0;
            dt.Rows.Add(dr);
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            ClientCommon.DataRefreshOperate dro = new ClientCommon.DataRefreshOperate(this);
            dro.SaveDataOnRefresh();
        }

        private void btDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow dr = gvParamers.GetFocusedDataRow();
            if (dr != null)
            {
                if (MessageBox.Show("是否删除该记录？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dr.Delete();
                }
            }
            else
            {
                MessageBox.Show("请选择一条需要删除的记录！");
            }
        }
    }
}
