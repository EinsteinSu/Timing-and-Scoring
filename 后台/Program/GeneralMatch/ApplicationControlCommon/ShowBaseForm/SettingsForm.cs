using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ApplicationControlCommon
{
    public partial class SettingsForm : DialogBaseForm
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        public delegate void CancelClickCallback();
        public event CancelClickCallback CancelClick;
        private void btCancel_Click(object sender, EventArgs e)
        {
            if (CancelClick != null)
                CancelClick();
            else
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        public delegate void SettingClickCallback();
        public event SettingClickCallback SettingClick;
        private void btSetting_Click(object sender, EventArgs e)
        {
            try
            {
                if (SettingClick != null)
                {
                    SettingClick();
                    MessageBox.Show("设置成功！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("设置失败：" + ex.Message);
            }
        }
    }
}
