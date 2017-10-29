using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClientControlCommon
{
    public class LoginViewPanel : Panel
    {
        public LoginViewPanel()
        {

        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            tt.Hide(this);
            bShow = false;
        }

        bool bShow;
        ToolTip tt;
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (tt == null)
                tt = new ToolTip();
            if (!bShow)
            {
                tt.SetToolTip(this, "登录信息");
                bShow = true;
            }
        }

        protected override void OnClick(EventArgs e)
        {
            LoginViewForm frm = new LoginViewForm();
            frm.Show();
        }
    }
}
