using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ApplicationService
{
    public partial class ServiceSettingControl : UserControl
    {
        public ServiceSettingControl()
        {
            InitializeComponent();
            try
            {
                gcService.DataSource = Service.ONSERVICES;
            }
            catch { }
        }

        private void btSub_Click(object sender, EventArgs e)
        {
            Service s = lvService.GetFocusedRow() as Service;
            if (s != null && MessageBox.Show("是否删除该服务？","询问", MessageBoxButtons.YesNo)  == DialogResult.Yes)
            {
                Service.ONSERVICES.Remove(s);
                lvService.RefreshData();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Service s = new Service();
            s.DLL = "RemoteCommon.dll";
            s.MODLE = "RemoteCommon.";
            s.BSERVICE = true;
            s.BSTART = true;
            Service.ONSERVICES.Add(s);
            lvService.RefreshData();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Service.ONSERVICES = Service.ONSERVICES;
        }
    }
}
