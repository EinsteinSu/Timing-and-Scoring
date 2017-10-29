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
    public partial class AreaManager : UserControl, ClientCommon.IDataRefresh
    {
        public AreaManager()
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
            dt = new Persistent.AreaPst(null).GetDataTable();
            gcArea.DataSource = dt;
        }

        public void SaveData()
        {
            ClientCommon.TableSave ts = new ClientCommon.TableSave(new ClientCommon.TableInfo(typeof(SubStance.Area),
                typeof(Persistent.AreaPst)), dt);
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
            dr["Name"] = "New Area";
            dt.Rows.Add(dr);
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            ClientCommon.DataRefreshOperate dro = new ClientCommon.DataRefreshOperate(this);
            dro.SaveDataOnRefresh();
        }

        private void btDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvArea.GetFocusedDataRow() != null)
            {
                if (MessageBox.Show("是否删除该记录？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gvArea.GetFocusedDataRow().Delete();
                }
            }
        }

    }
}
