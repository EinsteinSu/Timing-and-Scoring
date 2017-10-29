using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ApplicationClient
{
    public partial class Settings : ApplicationControlCommon.DialogForm
    {
        public Settings()
        {
            InitializeComponent();
            tbIPAddress.DataBindings.Add("EditValue", ClientCommon.RemoteConnect.ONREMOTE, "IPADDRESS", true, DataSourceUpdateMode.OnPropertyChanged);
            tbServicePort.DataBindings.Add("Text", ClientCommon.RemoteConnect.ONREMOTE, "SERVICEPORT", true, DataSourceUpdateMode.OnPropertyChanged);
            tbBroadCastPort.DataBindings.Add("Text", ClientCommon.RemoteConnect.ONREMOTE, "BROADCASTPORT", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            using (DevExpress.Utils.WaitDialogForm wfm = new DevExpress.Utils.WaitDialogForm("请稍后", "正在连接到服务器 ..."))
            {
                DataTable dt = new DataTable();
                ClientCommon.RemoteConnect.ONREMOTE = ClientCommon.RemoteConnect.ONREMOTE;
                ClientCommon.RemoteConnect.ONREMOTE.Load();
                try
                {
                    dt = new ClientCommon.SystemUsersPst(null).GetDataTable();
                }
                catch
                {
                    MessageBox.Show("连接失败！");
                    return;
                }
                if (dt == null || dt.Rows.Count == 0)
                    MessageBox.Show("连接失败！");
                else
                    MessageBox.Show("连接成功！");
            }
        }

        private void Settings_OkClick()
        {
            ClientCommon.RemoteConnect.ONREMOTE = ClientCommon.RemoteConnect.ONREMOTE;
            ClientCommon.RemoteConnect.ONREMOTE.Load();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void Settings_CancelClick()
        {

        }
    }
}
