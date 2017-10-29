using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ApplicationCommon;
using ClientCommon;

namespace ApplicationClient
{
    public partial class Login : ApplicationControlCommon.DialogBaseForm
    {
        public Login()
        {
            InitializeComponent();
            cbRememberPwd.DataBindings.Add("EditValue", SystemOptions.ONOPTIONS, "REMEMBERPASSWORD", true, DataSourceUpdateMode.OnPropertyChanged);
            cbAutoLogin.DataBindings.Add("EditValue", SystemOptions.ONOPTIONS, "AUTOLOGIN", true, DataSourceUpdateMode.OnPropertyChanged);
            lbName.Text = ClientCommon.SystemParam.ONPARAM.TITLENAME;
            lbNameEn.Text = ClientCommon.SystemParam.ONPARAM.TITLENAMEEN;
            //lbRelease.Text = string.Format("版本号：V{0}", SystemOptions.ONOPTIONS.SYSTEMRELEASE);
        }

        #region 初始化登录信息

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (LoadInfos())
            {
                try
                {
                   
                    RemoteCommon.SystemRelease newSr = new RemoteCommon.SystemRelease();
                    RemoteCommon.SystemRelease sr = RemoteCommon.SystemRelease.MaxRelease;
                    if (SystemUpdateHelper.BUpdate(sr, out newSr)
                        && MessageBox.Show("已发现新版本，是否启动升级程序？","系统升级",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        using (DevExpress.Utils.WaitDialogForm wfm = new DevExpress.Utils.WaitDialogForm("请稍后", "正在下载升级包 ..."))
                        {
                            SystemUpdateHelper.GetUpdateFile(newSr);
                            RemoteCommon.SystemRelease.ONRELEASE.Add(newSr);
                            RemoteCommon.SystemRelease.ONRELEASE = RemoteCommon.SystemRelease.ONRELEASE;
                            wfm.Caption = "正在退出程序 ...";
                            Application.Exit();
                            System.Diagnostics.Process p = new System.Diagnostics.Process();
                            p.StartInfo.FileName = newSr.FILENAME;
                            p.Start();
                        }
                    }
                    lbRelease.Text = string.Format("版本号：v{0}", RemoteCommon.SystemRelease.MaxRelease.RELEASE);
                }
                catch
                {
                    MessageBox.Show("系统版本错误！");
                }
                if (SystemOptions.ONOPTIONS.REMEMBERPASSWORD)
                {
                    PasswordHelper ph = new PasswordHelper();
                    tbPassWord.Text = ph.DecryptString(SystemOptions.ONOPTIONS.PASSWORD);
                }
                if (SystemOptions.ONOPTIONS.AUTOLOGIN)
                {
                    if (OnUser == null)
                    {
                        MessageBox.Show("找不到该用户！");
                        return;
                    }
                    btLogin_Click(null, null);
                }

            }
        }

        public bool LoadInfos()
        {
            using (DevExpress.Utils.WaitDialogForm wfm = new DevExpress.Utils.WaitDialogForm("请稍后", "正在连接到服务器 ..."))
            {
                try
                {
                    cbUserGuid.Properties.Items.Clear();
                    DataTable dt = new SystemUsersPst(null).GetDataTable();
                    foreach (DataRow dr in dt.Rows)
                    {
                        SystemUsers user = (SystemUsers)ReflectionHelper.ReflectionFromDataRow(dr, typeof(SystemUsers));
                        cbUserGuid.Properties.Items.Add(user);
                    }
                    for (int i = 0; i < cbUserGuid.Properties.Items.Count; i++)
                    {
                        SystemUsers user = (SystemUsers)cbUserGuid.Properties.Items[i];
                        if (user.GUID == SystemOptions.ONOPTIONS.LOGINUSERGUID)
                        {
                            cbUserGuid.SelectedIndex = i;
                            OnUser = user;
                            break;
                        }
                    }
                    return true;
                }
                catch
                {
                    cbUserGuid.Properties.Items.Clear();
                    cbUserGuid.Text = "";
                    tbPassWord.Text = "";
                    MessageBox.Show("用户信息读取失败，请“设置”连接信息！", "错误");
                    return false;
                }
            }
        }

        #endregion

        private void btSetting_Click(object sender, EventArgs e)
        {
            Settings frm = new Settings();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LoadInfos();
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            #region 验证用户名
            SystemUsers user = cbUserGuid.SelectedItem as SystemUsers;
            if (user != null)
                OnUser = user;
            else
            {
                MessageBox.Show("用户名错误！");
                return;
            }
            #endregion

            #region 验证密码
            PasswordHelper ph = new PasswordHelper();
            if (ph.EncryptString(tbPassWord.Text) != OnUser.PASSWORD)
            {
                MessageBox.Show("密码错误！");
                return;
            }
            #endregion

            SystemUsers.ONUSERS = OnUser;
            SystemOptions.ONOPTIONS.LOGINUSERGUID = OnUser.GUID;
            SystemOptions.ONOPTIONS.PASSWORD = OnUser.PASSWORD;
            SystemOptions.ONOPTIONS = SystemOptions.ONOPTIONS;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        SystemUsers OnUser;
        private void cbUserGuid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUserGuid.SelectedItem != null)
            {
                SystemUsers user = cbUserGuid.SelectedItem as SystemUsers;
                if (user != null)
                {
                    OnUser = user;
                    SystemOptions.ONOPTIONS.LOGINUSERGUID = user.GUID;
                }
            }
        }

        private void cbRememberPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbRememberPwd.Checked)
                cbAutoLogin.Checked = false;
        }

        private void cbAutoLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAutoLogin.Checked)
                cbRememberPwd.Checked = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
