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
    public partial class PasswordChange : ApplicationControlCommon.SettingsForm
    {
        public PasswordChange()
        {
            InitializeComponent();
            lbUserName.Text = ClientCommon.SystemUsers.ONUSERS.USERNAME;
        }

        private void PasswordChange_SettingClick()
        {
            if (tbPassword.Text.Length == 0 || tbPasswordAgain.Text.Length == 0)
            {
                MessageBox.Show("密码不能为空！");
            }
            if (tbPassword.Text != tbPasswordAgain.Text)
            {
                MessageBox.Show("两次输入的密码不一致！");
                return;
            }
            ClientCommon.SystemUsers.ONUSERS.PASSWORD = tbPasswordAgain.Text;
            ClientCommon.SystemUsersPst pst = new ClientCommon.SystemUsersPst(ClientCommon.SystemUsers.ONUSERS);
            pst.Update();
        }

        private void PasswordChange_CancelClick()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
