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
    public partial class FunctionManager : UserControl,ClientCommon.IDataRefresh
    {
        public FunctionManager()
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
            cbImages.Items.Clear();
            ClientCommon.SystemImages.RefreshImageList();
            cbImages.SmallImages = ClientCommon.SystemImages.OnImageList;
            int i = 0;
            foreach (Image img in ClientCommon.SystemImages.OnImageList.Images)
            {
                cbImages.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(i, i));
                i++;
            }
            dt = new ClientCommon.FunctionsPst(null).GetDataTable();
            treeFunction.DataSource = dt;
            treeFunction.ExpandAll();
        }

        public void SaveData()
        {
            ClientCommon.TableSave ts = new ClientCommon.TableSave(new ClientCommon.TableInfo(typeof(ClientCommon.Functions),
                            typeof(ClientCommon.FunctionsPst)), dt);
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
            dr["PGuid"] = 0;
            dr["Name"] = "New function";
            dr["Type"] = "Null";
            dr["OrderID"] = 0;
            dt.Rows.Add(dr);
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            ClientCommon.DataRefreshOperate dro = new ClientCommon.DataRefreshOperate(this);
            dro.SaveDataOnRefresh();
        }

        private void btAddChild_Click(object sender, EventArgs e)
        {
            if (treeFunction.FocusedNode != null)
            {
                DataRowView drp = (DataRowView)treeFunction.GetDataRecordByNode(treeFunction.FocusedNode);
                if (drp != null)
                {
                    DataRow dr = dt.NewRow();
                    dr["Guid"] = Guid.NewGuid();
                    dr["PGuid"] = drp["Guid"];
                    dr["Name"] = "New child function";
                    dr["Type"] = "Null";
                    dr["OrderID"] = 0;
                    dt.Rows.Add(dr);
                    treeFunction.FocusedNode.ExpandAll();
                }
            }
        }

        private void btDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (treeFunction.FocusedNode != null)
            {
                if (MessageBox.Show("是否删除该记录？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    treeFunction.DeleteNode(treeFunction.FocusedNode);
                }
            }
            else
            {
                MessageBox.Show("请选择一条需要删除的记录！");
            }
        }
    }
}
