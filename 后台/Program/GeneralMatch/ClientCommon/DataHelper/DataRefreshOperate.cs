using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace ClientCommon
{
    public class DataRefreshOperate
    {
        public IDataRefresh DataRefresh { get; set; }

        public DataRefreshOperate(IDataRefresh r)
        {
            DataRefresh = r;
        }

        public DataRefreshOperate()
        {

        }

        public bool IsChanged()
        {
            foreach (DataTable dt in DataRefresh.OperateTables)
            {
                if (dt != null)
                {
                    dt.DefaultView.RowStateFilter = DataViewRowState.Added | DataViewRowState.Deleted | DataViewRowState.ModifiedOriginal;
                    if (dt.DefaultView.Count > 0)
                        return true;
                }
            }
            return false;
        }

        public void SaveDataOnRefresh()
        {
            if (IsChanged())
            {
                if (MessageBox.Show("数据已发生更改，是否保存数据？", "询问", System.Windows.Forms.MessageBoxButtons.OKCancel)
                    == System.Windows.Forms.DialogResult.OK)
                {
                    DataRefresh.SaveData();
                }
            }
            using (DevExpress.Utils.WaitDialogForm wfm = new DevExpress.Utils.WaitDialogForm("请稍后", "正在刷新数据 ..."))
            {
                DataRefresh.RefreshData();
            }
        }

        public void SaveDataOnClosing()
        {
            if (IsChanged())
            {
                if (MessageBox.Show("数据已发生更改，是否保存数据？", "询问", System.Windows.Forms.MessageBoxButtons.OKCancel)
                            == System.Windows.Forms.DialogResult.OK)
                {
                    DataRefresh.SaveData();
                }
            }
        }
    }
}
