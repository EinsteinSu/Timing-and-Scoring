using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Common
{
    public partial class PDPShowingTime : Form
    {
        public PDPShowingTime(string t)
        {
            InitializeComponent();
            lbTimingType.Text = t;
        }

        public void SetTime(string time)
        {
            SetControlText(lbTime, time);
        }

        public delegate void SetControlTextCallback(Control ctrl, string text);
        public void SetControlText(Control ctrl, string text)
        {
            if (ctrl.InvokeRequired)
            {
                SetControlTextCallback d = new SetControlTextCallback(SetControlText);
                try
                {
                    ctrl.Invoke(d, ctrl, text);
                }
                catch
                {
                    this.Dispose();
                }
            }
            else
            {
                ctrl.Text = text;
            }
        }
    }
}
