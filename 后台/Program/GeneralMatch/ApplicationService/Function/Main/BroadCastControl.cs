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
    public partial class BroadCastControl : UserControl
    {
        public BroadCastControl()
        {
            InitializeComponent();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            if (rtbBroadCast.Text.Length > 0)
            {
                try
                {
                    HomePage.bcObj.BroadCastingInfo(rtbBroadCast.Text);
                    MessageBox.Show("广播发送成功！");
                    rtbBroadCast.Text = "";
                }
                catch(Exception ex)
                {
                    MessageBox.Show("广播发送失败：" + ex.Message);
                }
            }
            else
                MessageBox.Show("请输入需要发送的内容！");
        }

        public override string ToString()
        {
            return "广播";
        }
    }
}
