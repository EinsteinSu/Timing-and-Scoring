using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SystemManager
{
    public partial class Options : ApplicationControlCommon.SettingsForm
    {
        public Options()
        {
            InitializeComponent();
            tbIPAddress.DataBindings.Add("Text", ClientCommon.RemoteConnect.ONREMOTE, "IPADDRESS", true, DataSourceUpdateMode.OnPropertyChanged);
            tbServicePort.DataBindings.Add("Text", ClientCommon.RemoteConnect.ONREMOTE, "SERVICEPORT", true, DataSourceUpdateMode.OnPropertyChanged);
            tbBroadCastPort.DataBindings.Add("Text", ClientCommon.RemoteConnect.ONREMOTE, "BROADCASTPORT", true, DataSourceUpdateMode.OnPropertyChanged);
            cbRememberPwd.DataBindings.Add("EditValue", ClientCommon.SystemOptions.ONOPTIONS, "REMEMBERPASSWORD", true, DataSourceUpdateMode.OnPropertyChanged);
            cbAutoLogin.DataBindings.Add("EditValue", ClientCommon.SystemOptions.ONOPTIONS, "AUTOLOGIN", true, DataSourceUpdateMode.OnPropertyChanged);
            tbName.DataBindings.Add("Text", ClientCommon.SystemParam.ONPARAM, "TITLENAME", true, DataSourceUpdateMode.OnPropertyChanged);
            tbNameEn.DataBindings.Add("Text", ClientCommon.SystemParam.ONPARAM, "TITLENAMEEN", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void Options_SettingClick()
        {
            ClientCommon.RemoteConnect.ONREMOTE = ClientCommon.RemoteConnect.ONREMOTE;
            ClientCommon.SystemOptions.ONOPTIONS = ClientCommon.SystemOptions.ONOPTIONS;
            ClientCommon.SystemParam.ONPARAM = ClientCommon.SystemParam.ONPARAM;
            ClientCommon.RemoteConnect.ONREMOTE.Load();
        }
    }
}
