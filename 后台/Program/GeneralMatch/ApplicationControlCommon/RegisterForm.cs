using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Management;

namespace ApplicationControlCommon
{
    public partial class RegisterForm : DialogBaseForm
    {
        public RegisterForm()
        {
            InitializeComponent();
            tbDiskID.DataBindings.Add("Text", EncryptionForApplication.ONENCRYPTION, "CPUID", true, DataSourceUpdateMode.OnPropertyChanged);
            tbKey.DataBindings.Add("Text", EncryptionForApplication.ONENCRYPTION, "KEY", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (tbDiskID.Text.Length == 0
                || ApplicationControlCommon.EncryptionForApplication.ONENCRYPTION.CPUID != GetCpuString())
            {
                tbDiskID.Text = GetCpuString();
            }
        }

        public string GetCpuString()
        {
            string cpuInfo = "";//cpu序列号
            ManagementClass cimobject = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = cimobject.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                cpuInfo = mo.Properties["ProcessorId"].Value.ToString();
                return cpuInfo;
            }
            return cpuInfo;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            ApplicationCommon.PasswordHelper ph = new ApplicationCommon.PasswordHelper();
            string key = ph.EncryptString(EncryptionForApplication.ONENCRYPTION.CPUID);
            if (key == tbKey.Text)
            {
                EncryptionForApplication.ONENCRYPTION = EncryptionForApplication.ONENCRYPTION;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("注册码错误！");
            }
        }


    }
}
