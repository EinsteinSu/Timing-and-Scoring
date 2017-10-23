using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimingControl
{
    public partial class FrmSetting : Form
    {
        public FrmSetting(DateTime dt,string displayFormat)
        {
            InitializeComponent();
            tbTime.Text = dt.ToString("HH:mm:ss");
        }

        public string SettingTime
        {
            get
            {
                return tbTime.Text;
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
