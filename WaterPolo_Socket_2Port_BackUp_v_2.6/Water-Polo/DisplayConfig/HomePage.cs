using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DisplayConfig
{
    public partial class HomePage : ApplicationControlCommon.DialogBaseForm
    {
        public HomePage()
        {
            InitializeComponent();

            tbServiceIP.DataBindings.Add("Text", ClientCommon.RemoteConnect.ONREMOTE, "IPADDRESS", true, DataSourceUpdateMode.OnPropertyChanged);
            tbServicePort.DataBindings.Add("Text", ClientCommon.RemoteConnect.ONREMOTE, "SERVICEPORT", true, DataSourceUpdateMode.OnPropertyChanged);
            //tbRefereeIP.DataBindings.Add("Text", Settings.ONSETTINGS, "REFEREEIPADDRESS", true, DataSourceUpdateMode.OnPropertyChanged);
            //tbRefereePort.DataBindings.Add("Text", Settings.ONSETTINGS, "REFEREEPORT", true, DataSourceUpdateMode.OnPropertyChanged);
            tbWidth.DataBindings.Add("Text", Settings.ONSETTINGS, "WIDTH", true, DataSourceUpdateMode.OnPropertyChanged);
            tbHeight.DataBindings.Add("Text", Settings.ONSETTINGS, "HEIGHT", true, DataSourceUpdateMode.OnPropertyChanged);
            tbX.DataBindings.Add("Text", Settings.ONSETTINGS, "X", true, DataSourceUpdateMode.OnPropertyChanged);
            tbY.DataBindings.Add("Text", Settings.ONSETTINGS, "Y", true, DataSourceUpdateMode.OnPropertyChanged);
            tbListeningPort.DataBindings.Add("Text", Settings.ONSETTINGS, "LISTENINGPORT", true, DataSourceUpdateMode.OnPropertyChanged);
            tbWelcome.DataBindings.Add("Text", Settings.ONSETTINGS, "WelcomeUrl", true,
                DataSourceUpdateMode.OnPropertyChanged);
            tbPrice.DataBindings.Add("Text", Settings.ONSETTINGS, "PriceUrl", true,
                DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
