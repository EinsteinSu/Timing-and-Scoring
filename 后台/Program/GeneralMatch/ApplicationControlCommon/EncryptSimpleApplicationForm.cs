using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;

namespace ApplicationControlCommon
{
    public partial class EncryptSimpleApplicationForm : SimpleApplicationForm
    {
        public EncryptSimpleApplicationForm()
        {
            InitializeComponent();

            ApplicationCommon.PasswordHelper ph = new ApplicationCommon.PasswordHelper();
            //CPUID为空 CPUID不是当前电脑的CPUID 密码错误
            if (ApplicationControlCommon.EncryptionForApplication.ONENCRYPTION.CPUID == null
                ||ApplicationControlCommon.EncryptionForApplication.ONENCRYPTION.CPUID.Length == 0
                || ApplicationControlCommon.EncryptionForApplication.ONENCRYPTION.CPUID != GetCpuString()
                || ApplicationControlCommon.EncryptionForApplication.ONENCRYPTION.KEY != ph.EncryptString(ApplicationControlCommon.EncryptionForApplication.ONENCRYPTION.CPUID))
            {
                RegisterForm frm = new RegisterForm();
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //闪屏
                    using (DevExpress.Utils.WaitDialogForm wfm = new DevExpress.Utils.WaitDialogForm())
                    {
                        wfm.Caption = "注册成功，欢迎使用本软件！";
                        System.Threading.Thread.Sleep(1000);
                    }
                }
            }
            else
            {
                using (DevExpress.Utils.WaitDialogForm wfm = new DevExpress.Utils.WaitDialogForm())
                {
                    wfm.Caption = "欢迎使用本软件！";
                    System.Threading.Thread.Sleep(1000);
                }
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
    }
}
