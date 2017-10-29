using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;

namespace ClientControlCommon
{
    public partial class LoginViewForm : ApplicationControlCommon.DialogBaseForm
    {
        public LoginViewForm()
        {
            InitializeComponent();
            this.Deactivate += new EventHandler(LogViewForm_Deactivate);
            this.Location = new Point(Screen.GetWorkingArea(this).Width - this.Width, Screen.GetWorkingArea(this).Height - this.Height - 42);
            lbUserName.Text = ClientCommon.SystemUsers.ONUSERS.USERNAME;
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection nics = mc.GetInstances();
            string ips = string.Empty;
            foreach (ManagementObject nic in nics)
            {
                if (Convert.ToBoolean(nic["ipEnabled"]) == true)
                {
                    try
                    {
                        ips += (nic["IPAddress"] as String[])[0] + ",";
                    }
                    catch { }
                }
            }
            lbIPAddress.Text = ips.TrimEnd(',');
            lbLoginTime.Text = ClientCommon.SystemUsers.ONUSERS.LOGINTIME.ToString("yyyy/MM/dd HH:mm:ss");
        }

        void LogViewForm_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
