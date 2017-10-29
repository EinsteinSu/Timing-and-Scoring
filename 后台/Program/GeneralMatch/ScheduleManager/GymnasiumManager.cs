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
    public partial class GymnasiumManager : UserControl, ClientCommon.IDataRefresh
    {
        public GymnasiumManager()
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
            dt = new Persistent.GymnasiumPst(null).GetDataTable();
            gcGymnasium.DataSource = dt;
        }

        public void SaveData()
        {
            ClientCommon.TableSave ts = new ClientCommon.TableSave(new ClientCommon.TableInfo(typeof(SubStance.Gymnasium),
                typeof(Persistent.GymnasiumPst)), dt);
            ts.SaveByImage("Photo");
        }
        #endregion

        private void btRefresh_Click(object sender, EventArgs e)
        {
            ClientCommon.DataRefreshOperate dro = new ClientCommon.DataRefreshOperate(this);
            dro.SaveDataOnRefresh();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            dr["Guid"] = Guid.NewGuid();
            dr["Name"] = "New Gymnasium";
            dt.Rows.Add(dr);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (lvGymnasium.GetFocusedDataRow() != null)
            {
                if (MessageBox.Show("是否删除该记录？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lvGymnasium.GetFocusedDataRow().Delete();
                }
            }
        }
    }
}
