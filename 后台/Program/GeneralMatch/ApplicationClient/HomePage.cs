using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClientCommon;
using ApplicationCommon;

namespace ApplicationClient
{
    public partial class HomePage : ApplicationControlCommon.BaseForm
    {
        public HomePage()
        {
            InitializeComponent();
            functionMenum.BuildMenum();

        }

        bool isClose = false;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            try
            {
                this.Text = lbName.Text = ClientCommon.SystemParam.ONPARAM.TITLENAME;
                lbNameEn.Text = ClientCommon.SystemParam.ONPARAM.TITLENAMEEN;
                try
                {
                    tlpHome.BackgroundImage = Image.FromFile(ApplicationCommon.DirectoryHelper.ImageDirectory + "HomePage.jpg");
                    tlpHome.BackgroundImageLayout = ImageLayout.Center;
                }
                catch
                {
                    MessageBox.Show("找不到系统图片！");
                }
               
                broadcastPanel1.LoadBroadCast();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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
            foreach (string str in System.IO.Directory.GetFiles(ApplicationCommon.DirectoryHelper.TempDirectory))
            {
                try
                {
                    System.IO.File.Delete(str);
                }
                catch { }
            }
            isClose = true;
        }

        private void btFastMenum_Click(object sender, EventArgs e)
        {
            ClientControlCommon.FastMenumForm frm = new ClientControlCommon.FastMenumForm();
            frm.FunctionClick += new ClientControlCommon.FastMenumForm.FunctionClickCallback(frm_FunctionClick);
            frm.Show();
        }

        void frm_FunctionClick(Functions f)
        {
            ShowControl(ReflectionHelper.GetObjectTypeByName(f.DLL, f.MODLE), f);
        }

        Functions _onFunction;
        private void functionMenum_MenumClick(ClientCommon.Functions f)
        {
            switch (f.TYPE)
            {
                case "UserControl":
                    _onFunction = f;
                    ShowControl(ReflectionHelper.GetObjectTypeByName(f.DLL, f.MODLE), f);
                    break;
                case "Method":
                    ApplicationCommon.ReflectionHelper.ReflectionMethodByRun(false, f.DLL, f.MODLE, f.METHOD, null);
                    break;
            }
        }

        #region Control method
        public void ShowControl(Type t, Functions f)
        {
            _onFunction = f;
            bool bHave = false;
            Control showedCtrl = null;
            foreach (Control ctrl in this.plParent.Controls)
            {
                Functions fu = ctrl.Tag as Functions;
                if (fu != null)
                    ctrl.Hide();
            }
            foreach (Control ctrl in this.plParent.Controls)
            {
                if (ctrl.GetType() == t)
                {
                    showedCtrl = ctrl;
                    ctrl.Show();
                    ctrl.BringToFront();
                    bHave = true;
                    break;
                }
            }
            if (!bHave)
            {
                using (DevExpress.Utils.WaitDialogForm wfm = new DevExpress.Utils.WaitDialogForm("请稍后", "正在加载功能菜单 ..."))
                {
                    UserControl uc = (UserControl)Activator.CreateInstance(t);
                    showedCtrl = uc;
                    uc.Tag = f;
                    this.plParent.Controls.Add(uc);
                    functionTask.AddFunctions(f);
                    uc.Dock = DockStyle.Fill;
                    uc.BringToFront();
                }
            }
            SetTitle(f.ToString(), f.IMAGEINDEX);
        }

        public void CloseControl(Functions fu)
        {
            foreach (Control ctrl in plParent.Controls)
            {
                Functions f = ctrl.Tag as Functions;
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
                        pbFunctionImage.Image = GeneralMatchClient.Properties.Resources.Desktop;
                    }
                }
            }
        }

        public void SetTitle(string title, int imageIndex)
        {
            lbTitle.Text = title;
            System.Drawing.Image img;
            try
            {
                img = ClientCommon.SystemImages.OnImageList.Images[imageIndex];
            }
            catch { img = null; }
            pbFunctionImage.Image = img;
            lbClose.Visible = true;
        }
        #endregion

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
            {
                if (ctrl.Tag != null)
                    ctrl.Hide();
            }
            lbTitle.Text = "主页";
            lbClose.Visible = false;
            pbFunctionImage.Image = GeneralMatchClient.Properties.Resources.Desktop;
        }
    }
}
