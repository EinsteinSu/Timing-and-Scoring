using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Water_Polo
{
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();

            tbServiceIP.DataBindings.Add("Text", ClientCommon.RemoteConnect.ONREMOTE, "IPADDRESS", true, DataSourceUpdateMode.OnPropertyChanged);
            tbServicePort.DataBindings.Add("Text", ClientCommon.RemoteConnect.ONREMOTE, "SERVICEPORT", true, DataSourceUpdateMode.OnPropertyChanged);
            tbRefereeIP.DataBindings.Add("Text", Settings.ONSETTINGS, "REFEREEIPADDRESS", true, DataSourceUpdateMode.OnPropertyChanged);
            tbRefereePort.DataBindings.Add("Text", Settings.ONSETTINGS, "REFEREEPORT", true, DataSourceUpdateMode.OnPropertyChanged);
            tbListeningPort.DataBindings.Add("Text", Settings.ONSETTINGS, "LISTENINGPORT", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btTestService_Click(object sender, EventArgs e)
        {
            using (DevExpress.Utils.WaitDialogForm wfm = new DevExpress.Utils.WaitDialogForm("Please wait", "Connecting to service ..."))
            {
                DataTable dt = new DataTable();
                ClientCommon.RemoteConnect.ONREMOTE = ClientCommon.RemoteConnect.ONREMOTE;
                ClientCommon.RemoteConnect.ONREMOTE.Load();
                try
                {
                    dt = ClientCommon.SqlHelper.GetDataTable("select * from SystemUsers");
                }
                catch
                {
                    MessageBox.Show("Connection fail!");
                    return;
                }
                if (dt == null || dt.Rows.Count == 0)
                    MessageBox.Show("Connection fail!");
                else
                    MessageBox.Show("Connection successful!");
            }
        }

        private void btSetting_Click(object sender, EventArgs e)
        {
            try
            {
                ClientCommon.RemoteConnect.ONREMOTE = ClientCommon.RemoteConnect.ONREMOTE;
                ClientCommon.RemoteConnect.ONREMOTE.Load();
                Settings.ONSETTINGS = Settings.ONSETTINGS;
                Settings.ONSETTINGS.Load();
                MessageBox.Show("Setting successful!");
            }
            catch
            {
                MessageBox.Show("Setting fail!");
            }
        }
    }
}
