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
    public partial class NotifyForm : BaseForm
    {
        public NotifyForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (ntfForm.Icon != null)
                base.Icon = ntfForm.Icon;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (base.WindowState == FormWindowState.Minimized)
            {
                ntfForm.Visible = true;
                base.ShowInTaskbar = false;
            }
        }

        private void ntfForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (base.WindowState == FormWindowState.Minimized)
            {
                base.WindowState = FormWindowState.Normal;
                base.ShowInTaskbar = true;
                base.Activate();
                ntfForm.Visible = false;
            }
        }

        private void tsmDisplay_Click(object sender, EventArgs e)
        {
            ntfForm_MouseDoubleClick(null, null);
        }

        private void tsmQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
