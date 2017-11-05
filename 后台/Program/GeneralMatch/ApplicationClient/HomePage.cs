using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ApplicationCommon;
using ApplicationControlCommon;
using ClientCommon;
using ClientControlCommon;
using DevExpress.Utils;
using GeneralMatchClient.Properties;

namespace ApplicationClient
{
    public partial class HomePage : BaseForm
    {
        private Functions _onFunction;

        private bool isClose;

        public HomePage()
        {
            InitializeComponent();
            functionMenum.BuildMenum();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            try
            {
                Text = lbName.Text = SystemParam.ONPARAM.TITLENAME;
                lbNameEn.Text = SystemParam.ONPARAM.TITLENAMEEN;
                try
                {
                    tlpHome.BackgroundImage = Image.FromFile(DirectoryHelper.ImageDirectory + "HomePage.jpg");
                    tlpHome.BackgroundImageLayout = ImageLayout.Center;
                }
                catch
                {
                    MessageBox.Show("找不到系统图片！");
                }

                broadcastPanel1.LoadBroadCast();
            }
            catch (Exception ex)
            {throw new Exception(ex.Message);
                broadcastPanel1.Visible = false;
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (broadcastPanel1.Visible)
            {
                broadcastPanel1.EndShow();
                broadcastPanel1.CancelBroadCast();
            }
            foreach (var str in Directory.GetFiles(DirectoryHelper.TempDirectory))
                try
                {
                    File.Delete(str);
                }
                catch
                {
                }
            isClose = true;
        }

        private void btFastMenum_Click(object sender, EventArgs e)
        {
            var frm = new FastMenumForm();
            frm.FunctionClick += frm_FunctionClick;
            frm.Show();
        }

        private void frm_FunctionClick(Functions f)
        {
            ShowControl(ReflectionHelper.GetObjectTypeByName(f.DLL, f.MODLE), f);
        }

        private void functionMenum_MenumClick(Functions f)
        {
            switch (f.TYPE)
            {
                case "UserControl":
                    _onFunction = f;
                    ShowControl(ReflectionHelper.GetObjectTypeByName(f.DLL, f.MODLE), f);
                    break;
                case "Method":
                    ReflectionHelper.ReflectionMethodByRun(false, f.DLL, f.MODLE, f.METHOD, null);
                    break;
            }
        }

        private void functionTask_OnFunctionsClick(Functions f)
        {
            ShowControl(ReflectionHelper.GetObjectTypeByName(f.DLL, f.MODLE), f);
        }

        private void functionTask_OnClose(Functions f)
        {
            CloseControl(f);
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            functionTask.CloseClick(_onFunction);
        }

        private void btDeskTop_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in plParent.Controls)
                if (ctrl.Tag != null)
                    ctrl.Hide();
            lbTitle.Text = "主页";
            lbClose.Visible = false;
            pbFunctionImage.Image = Resources.Desktop;
        }

        #region Control method

        public void ShowControl(Type t, Functions f)
        {
            _onFunction = f;
            var bHave = false;
            Control showedCtrl = null;
            foreach (Control ctrl in plParent.Controls)
            {
                var fu = ctrl.Tag as Functions;
                if (fu != null)
                    ctrl.Hide();
            }
            foreach (Control ctrl in plParent.Controls)
                if (ctrl.GetType() == t)
                {
                    showedCtrl = ctrl;
                    ctrl.Show();
                    ctrl.BringToFront();
                    bHave = true;
                    break;
                }
            if (!bHave)
                using (var wfm = new WaitDialogForm("请稍后", "正在加载功能菜单 ..."))
                {
                    var uc = (UserControl) Activator.CreateInstance(t);
                    showedCtrl = uc;
                    uc.Tag = f;
                    plParent.Controls.Add(uc);
                    functionTask.AddFunctions(f);
                    uc.Dock = DockStyle.Fill;
                    uc.BringToFront();
                }
            SetTitle(f.ToString(), f.IMAGEINDEX);
        }

        public void CloseControl(Functions fu)
        {
            foreach (Control ctrl in plParent.Controls)
            {
                var f = ctrl.Tag as Functions;
                if (f != null && f == fu)
                {
                    ctrl.Dispose();
                    if (plParent.Controls.Count > 0 && plParent.Controls[0].Tag != null)
                    {
                        ShowControl(plParent.Controls[0].GetType(), plParent.Controls[0].Tag as Functions);
                        _onFunction = plParent.Controls[0].Tag as Functions;
                    }
                    else
                    {
                        lbTitle.Text = "主页";
                        lbClose.Visible = false;
                        pbFunctionImage.Image = Resources.Desktop;
                    }
                }
            }
        }

        public void SetTitle(string title, int imageIndex)
        {
            lbTitle.Text = title;
            Image img;
            try
            {
                img = SystemImages.OnImageList.Images[imageIndex];
            }
            catch
            {
                img = null;
            }
            pbFunctionImage.Image = img;
            lbClose.Visible = true;
        }

        #endregion
    }
}