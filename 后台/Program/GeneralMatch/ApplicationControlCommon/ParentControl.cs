using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ApplicationControlCommon
{
    public partial class ParentControl : UserControl
    {
        public ParentControl()
        {
            InitializeComponent();
        }

        public delegate void ShowControledCallback(Control ctrl);
        public event ShowControledCallback ShowControled;
        public void ShowControl(Type t, DockStyle d)
        {
            bool bHave = false;
            Control showedCtrl = null;
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Hide();
            }
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == t)
                {
                    showedCtrl = ctrl;
                    ctrl.Show();
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
                    this.Controls.Add(uc);
                    uc.Dock = d;
                }
            }
            if (ShowControled != null)
                ShowControled(showedCtrl);
        }
    }
}
