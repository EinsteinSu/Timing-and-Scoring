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
    public partial class InfomationControl : UserControl
    {
        public InfomationControl()
        {
            InitializeComponent();

            if (Service.RegistChannel())
            {
                rtbService.DisplayText(false, string.Format("Ttp端口为{0}企业服务已开启。\r\n--------------------------------------------------------------", ServicePort.ONSERVICEPORT.SYSTEMPORT));
                foreach (Service info in Service.ONSERVICES)
                {
                    if (info.RegistService())
                        rtbService.DisplayText(false, info.ToString() + " 状态：开启。\r\n--------------------------------------------------------------");
                    else
                        rtbService.DisplayText(false, info.ToString() + " 状态：未开启。\r\n--------------------------------------------------------------");
                }
            }
            else
            {
                MessageBox.Show("服务端口未能注册，服务不能正常运行。");
            }
        }

        public void SetText(string text)
        {
            rtbService.DisplayText(false, text);
        }

        
        public override string ToString()
        {
            return "服务";
        }
    }
}
