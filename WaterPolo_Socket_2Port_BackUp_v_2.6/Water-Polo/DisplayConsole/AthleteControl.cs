using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DisplayConsole
{
    public partial class AthleteControl : UserControl
    {
        public AthleteControl(DataRow dr)
        {
            InitializeComponent();

            lbNumber.Text = dr["BIBNum"].ToString();
            lbName.Text = dr["NameEn"].ToString();
            this.Tag = dr["BIBNum"].ToString();
        }

        public void SetAthleteStyle()
        {
            lbNumber.Font = StyleSettings.StringToFont(StyleSettings.ONSETTINGS.BIBNUMBERFont);
            lbNumber.ForeColor = StyleSettings.StringToColor(StyleSettings.ONSETTINGS.BIBNUMBERCOLOR);

            lbName.Font = StyleSettings.StringToFont(StyleSettings.ONSETTINGS.NAMEFont);
            lbName.ForeColor = StyleSettings.StringToColor(StyleSettings.ONSETTINGS.NAMECOLOR);

            lbFoul1.Font = lbFoul2.Font = StyleSettings.StringToFont(StyleSettings.ONSETTINGS.FOULSFont);
            lbFoul1.ForeColor = lbFoul2.ForeColor = StyleSettings.StringToColor(StyleSettings.ONSETTINGS.FOULSCOLOR);

            lbSerious.Font = StyleSettings.StringToFont(StyleSettings.ONSETTINGS.SERIOUSFont);
            lbSerious.ForeColor = StyleSettings.StringToColor(StyleSettings.ONSETTINGS.SERIOUSCOLOR);

            lbTTime.Font = StyleSettings.StringToFont(StyleSettings.ONSETTINGS.SECONDSFont);
            lbTTime.ForeColor = StyleSettings.StringToColor(StyleSettings.ONSETTINGS.SERIOUSCOLOR);
        }

        public void SetFouls(int fouls)
        {
            foreach (Label lb in tlpFouls.Controls)
            {
                SetControlText(lb, "");
            }

            for (int i = 0; i < fouls; i++)
            {
                foreach (Label lb in tlpFouls.Controls)
                {
                    if (lb.Name == "lbFoul" + (i + 1).ToString())
                    {
                        string a = lbNumber.Text;
                        string b = lbName.Text;
                        SetControlText(lb, "●");
                    }
                }
            }
        }

        public void SetSerious(string serious)
        {
            if (serious == "1")
                SetControlText(lbSerious, "●");
            else
                SetControlText(lbSerious, "");
        }

        public void SetTwentyTime(string time)
        {
            SetControlText(lbTTime, time);
        }

        #region Delegates
        public delegate void SetFontsCallback(Control ctrl, Font f);
        public void SetFonts(Control ctrl, Font f)
        {
            if (ctrl.InvokeRequired)
            {
                SetFontsCallback d = new SetFontsCallback(SetFonts);
                ctrl.Invoke(d, ctrl, f);
            }
            else
                ctrl.Font = f;
        }

        public delegate void SetForeColorCallback(Control ctrl, Color c);
        public void SetForeColor(Control ctrl, Color c)
        {
            if (ctrl.InvokeRequired)
            {
                SetForeColorCallback d = new SetForeColorCallback(SetForeColor);
                ctrl.Invoke(d, ctrl, c);
            }
            else
                ctrl.ForeColor = c;
        }

        public delegate List<Label> GetLabelsCallback(Control ctrl);
        public List<Label> GetLabels(Control ctrl)
        {
            if (ctrl.InvokeRequired)
            {
                GetLabelsCallback d = new GetLabelsCallback(GetLabels);
                return (List<Label>)ctrl.Invoke(d, ctrl);
            }
            else
            {
                List<Label> lst = new List<Label>();
                foreach (Label lb in lst)
                {
                    lst.Add(lb);
                }
                return lst;
            }
        }

        public delegate void SetControlShowHideCallback(Control ctrl, bool isShow);
        public void SetControlShowHide(Control ctrl, bool isShow)
        {
            if (ctrl.InvokeRequired)
            {
                SetControlShowHideCallback d = new SetControlShowHideCallback(SetControlShowHide);
                ctrl.Invoke(d, ctrl, isShow);
            }
            else
            {
                if (isShow)
                    ctrl.Show();
                else
                    ctrl.Hide();
            }
        }

        public delegate void SetControlTextCallback(Control ctrl, string text);
        public void SetControlText(Control ctrl, string text)
        {
            if (ctrl.InvokeRequired)
            {
                SetControlTextCallback d = new SetControlTextCallback(SetControlText);
                ctrl.Invoke(d, ctrl, text);
            }
            else
            {
                ctrl.Text = text;
            }
        }

        public delegate void SetControlDockCallback(Control ctrl, DockStyle dc);
        public void SetControlDock(Control ctrl, DockStyle dc)
        {
            if (ctrl.InvokeRequired)
            {
                SetControlDockCallback d = new SetControlDockCallback(SetControlDock);
                ctrl.Invoke(d, ctrl, dc);
            }
            else
                ctrl.Dock = dc;
        }

        public delegate void AddControlCallback(Control ctrl, Control sContrl);
        public void AddControl(Control ctrl, Control sControl)
        {
            if (ctrl.InvokeRequired)
            {
                AddControlCallback d = new AddControlCallback(AddControl);
                ctrl.Invoke(d, ctrl, sControl);
            }
            else
                ctrl.Controls.Add(sControl);
        }

        public delegate void SetControlEnabledCallback(Control ctrl, bool isEnable);
        public void SetControlEnabled(Control ctrl, bool isEnable)
        {
            if (ctrl.InvokeRequired)
            {
                SetControlEnabledCallback d = new SetControlEnabledCallback(SetControlEnabled);
                ctrl.Invoke(d, ctrl, isEnable);
            }
            else
                ctrl.Enabled = isEnable;
        }

        public delegate void SetControlForeColorCallback(Control ctrl, Color c);
        public void SetControlForeColor(Control ctrl, Color c)
        {
            if (ctrl.InvokeRequired)
            {
                SetControlForeColorCallback d = new SetControlForeColorCallback(SetControlForeColor);
                ctrl.Invoke(d, c);
            }
            else
                ctrl.ForeColor = c;
        }

        public delegate void ClearControlCallback(Control ctrl);
        public void ClearControl(Control ctrl)
        {
            if (ctrl.InvokeRequired)
            {
                ClearControlCallback d = new ClearControlCallback(ClearControl);
                ctrl.Invoke(d, ctrl);
            }
            else
                ctrl.Controls.Clear();
        }
        #endregion

    }
}
