using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DisplayPerformanceConsole
{
    public partial class PDP : Form
    {
        SocketPublic.UdpListening sl;
        public PDP()
        {
            InitializeComponent();

            sl = new SocketPublic.UdpListening(DisplayConfig.Settings.ONSETTINGS.LISTENINGPORTEXTEND);
            sl.ProcessMessage += new SocketPublic.UdpListening.ProcessMessageCallback(sl_ProcessMessage);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    sl.StopListening();
                    Application.Exit();
                    break;
            }
        }

        void sl_ProcessMessage(string msg)
        {
            List<string> lstMsg = new List<string>();
            foreach (string str in msg.Split(','))
            {
                lstMsg.Add(str);
            }
            string key = lstMsg[0];
            switch (key)
            {
                case "TotalTime":
                    SetControlText(lbTotalTime, lstMsg[1]);
                    break;
                case "ThiryTime":
                    SetControlText(lbThirtyTime, lstMsg[1]);
                    break;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.Location = new Point(DisplayConfig.Settings.ONSETTINGS.X, 0);
            this.Width = DisplayConfig.Settings.ONSETTINGS.WIDTH;
            this.Height = DisplayConfig.Settings.ONSETTINGS.HEIGHT;
        }

        #region Delegates
        public delegate void SetControlBackColorCallback(Control ctrl, Color c);
        public void SetControlBackColor(Control ctrl, Color c)
        {
            if (ctrl.InvokeRequired)
            {
                SetControlBackColorCallback d = new SetControlBackColorCallback(SetControlBackColor);
                ctrl.Invoke(d, ctrl, c);
            }
            else
            {
                ctrl.BackColor = c;
            }
        }

        public delegate void TableLayoutPanelAddControlCallback(TableLayoutPanel tlp, Control ctrl, int column, int row);
        public void TableLayoutPanelAddControl(TableLayoutPanel tlp, Control ctrl, int column, int row)
        {
            if (tlp.InvokeRequired)
            {
                TableLayoutPanelAddControlCallback d = new TableLayoutPanelAddControlCallback(TableLayoutPanelAddControl);
                tlp.Invoke(d, tlp, ctrl, column, row);
            }
            else
            {
                tlp.Controls.Add(ctrl, column, row);
            }
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

        //public delegate void SetDataSourceCallback(DevExpress.XtraGrid.GridControl gc, DataTable dt);
        //public void SetDataSource(DevExpress.XtraGrid.GridControl gc, DataTable dt)
        //{
        //    if (gc.InvokeRequired)
        //    {
        //        SetDataSourceCallback d = new SetDataSourceCallback(SetDataSource);
        //        gc.Invoke(d, gc, dt);
        //    }
        //    else
        //        gc.DataSource = dt;
        //}

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
