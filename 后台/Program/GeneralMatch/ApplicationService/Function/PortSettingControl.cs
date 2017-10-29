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
    public partial class PortSettingControl : UserControl
    {
        public PortSettingControl()
        {
            InitializeComponent();
            try
            {
                tbSystemPort.DataBindings.Add("Text", ServicePort.ONSERVICEPORT, "SYSTEMPORT", true, DataSourceUpdateMode.OnPropertyChanged);
                tbBroadCastPort.DataBindings.Add("Text", ServicePort.ONSERVICEPORT, "BROADCASTPORT", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch { }
        }

        private void btSetting_Click(object sender, EventArgs e)
        {
            try
            {
                ServicePort.ONSERVICEPORT = ServicePort.ONSERVICEPORT;
                MessageBox.Show("设置成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("设置失败：" + ex.Message);
            }
        }
    }
}
