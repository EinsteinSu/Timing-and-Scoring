using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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

        private void btSetting_Click(object sender, EventArgs e)
        {
            try
            {
                ClientCommon.RemoteConnect.ONREMOTE = ClientCommon.RemoteConnect.ONREMOTE;
                ClientCommon.RemoteConnect.ONREMOTE.Load();
                Settings.ONSETTINGS.REFEREEIPADDRESS = tbRefereeIP.Text;
                Settings.ONSETTINGS.REFEREEPORT = int.Parse(tbRefereePort.Text);
                Settings.ONSETTINGS = Settings.ONSETTINGS;
                Settings.ONSETTINGS.Load();
                MessageBox.Show(@"设置成功!");
            }
            catch
            {
                MessageBox.Show(@"设置失败!");
            }
        }
    }
}
