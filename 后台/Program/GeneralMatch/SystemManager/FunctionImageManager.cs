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
    public partial class FunctionImageManager : UserControl, ClientCommon.IDataRefresh
    {
        public FunctionImageManager()
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
            dt = new ClientCommon.FunctionImagesPst(null).GetDataTable();
            gcImages.DataSource = dt;
        }

        public void SaveData()
        {
            gcImages.EndUpdate();
            ClientCommon.TableSave ts = new ClientCommon.TableSave(new ClientCommon.TableInfo(typeof(ClientCommon.FunctionImages),
                            typeof(ClientCommon.FunctionImagesPst)), dt);
            ts.SaveByImage("Image");

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
            dr["ImageIndex"] = dt.Rows.Count;
            dt.Rows.Add(dr);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void btDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow dr = gvImages.GetFocusedDataRow();
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
