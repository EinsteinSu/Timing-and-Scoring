using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RefereeConfig
{
    public partial class HomePage : ApplicationControlCommon.DialogBaseForm
    {
        public HomePage()
        {
            InitializeComponent();

            tbServiceIP.DataBindings.Add("Text", ClientCommon.RemoteConnect.ONREMOTE, "IPADDRESS", true, DataSourceUpdateMode.OnPropertyChanged);
            tbServicePort.DataBindings.Add("Text", ClientCommon.RemoteConnect.ONREMOTE, "SERVICEPORT", true, DataSourceUpdateMode.OnPropertyChanged);
            tbMajorIP.DataBindings.Add("Text", Settings.ONSETTINGS, "MAJORIPADDRESS", true, DataSourceUpdateMode.OnPropertyChanged);
            tbMajorPort.DataBindings.Add("Text", Settings.ONSETTINGS, "MAJORPORT", true, DataSourceUpdateMode.OnPropertyChanged);
            tbDisplayIP.DataBindings.Add("Text", Settings.ONSETTINGS, "DISPLAYIPADDRESS", true, DataSourceUpdateMode.OnPropertyChanged);
            tbDisplayPort.DataBindings.Add("Text", Settings.ONSETTINGS, "DISPLAYPORT", true, DataSourceUpdateMode.OnPropertyChanged);

            tbTotalPort.DataBindings.Add("Text", Settings.ONSETTINGS, "TOTALTIMEPORT", true, DataSourceUpdateMode.OnPropertyChanged);
            tbTotalBit.DataBindings.Add("Text", Settings.ONSETTINGS, "TOTALBIT", true, DataSourceUpdateMode.OnPropertyChanged);
            tbTotalHeader.DataBindings.Add("Text", Settings.ONSETTINGS, "TOTALHEADER", true, DataSourceUpdateMode.OnPropertyChanged);
            tbTotalTail.DataBindings.Add("Text", Settings.ONSETTINGS, "TOTALTAIL", true, DataSourceUpdateMode.OnPropertyChanged);

            tbSencondsPort.DataBindings.Add("Text", Settings.ONSETTINGS, "SECONDSTIMEPORT", true, DataSourceUpdateMode.OnPropertyChanged);
            tbSecondsBit.DataBindings.Add("Text", Settings.ONSETTINGS, "SECONDSBIT", true, DataSourceUpdateMode.OnPropertyChanged);
            tbSencondsHeader.DataBindings.Add("Text", Settings.ONSETTINGS, "SECONDSHEADER", true, DataSourceUpdateMode.OnPropertyChanged);
            tbSecondsTail.DataBindings.Add("Text", Settings.ONSETTINGS, "SECONDSTAIL", true, DataSourceUpdateMode.OnPropertyChanged);

            tbListeningPort.DataBindings.Add("Text", Settings.ONSETTINGS, "LISTENINGPORT", true, DataSourceUpdateMode.OnPropertyChanged);

            cbBTotalTime.DataBindings.Add("Checked", Settings.ONSETTINGS, "BTOTALTIME", true, DataSourceUpdateMode.OnPropertyChanged);
            cbBThirtyTime.DataBindings.Add("Checked", Settings.ONSETTINGS, "BTIRTYSECONDS", true, DataSourceUpdateMode.OnPropertyChanged);
            cbBTwentyTime.DataBindings.Add("Checked", Settings.ONSETTINGS, "BTWENTYSECONDS", true, DataSourceUpdateMode.OnPropertyChanged);

            tbVrs_TotalTimeIPAddress.DataBindings.Add("Text", Settings.ONSETTINGS, "TOTALTIMEIPADDRESS", true, DataSourceUpdateMode.OnPropertyChanged);
            tbVrs_TotalTimePort.DataBindings.Add("Text", Settings.ONSETTINGS, "VRS_TOTALTIMEPORT", true, DataSourceUpdateMode.OnPropertyChanged);

            tbThiryTimeIpaddress.DataBindings.Add("Text", Settings.ONSETTINGS, "TIRTYSECONDSIPADDRESS", true, DataSourceUpdateMode.OnPropertyChanged);
            tbThirtyTimePort.DataBindings.Add("Text", Settings.ONSETTINGS, "THIRTYSECONDSPORT", true, DataSourceUpdateMode.OnPropertyChanged);

            tbTwentyTimeIPaddress.DataBindings.Add("Text", Settings.ONSETTINGS, "TWENTYSECONDSIPADDRESS", true, DataSourceUpdateMode.OnPropertyChanged);
            tbTwentyTimePort.DataBindings.Add("Text", Settings.ONSETTINGS, "TWENTYSECONDSPORT", true, DataSourceUpdateMode.OnPropertyChanged);
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
