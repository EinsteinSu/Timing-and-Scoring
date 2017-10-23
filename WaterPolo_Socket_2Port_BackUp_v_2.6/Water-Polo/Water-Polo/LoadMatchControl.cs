using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Water_Polo
{
    public partial class LoadMatchControl : UserControl
    {
        SocketPublic.SocketListening ul;
        public LoadMatchControl()
        {
            InitializeComponent();
            ul = new SocketPublic.SocketListening(Settings.ONSETTINGS.LISTENINGPORT);
            ul.ProcessMessage += new SocketPublic.SocketListening.ProcessMessageCallback(sl_ProcessMessage);
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
                case "Foul":
                    SetFouls(lstMsg[1], lstMsg[2], lstMsg[3]);
                    break;
                case "Score":
                    SetScore(lstMsg[1], lstMsg[2]);
                    break;
                case "Serious":
                    SetSerious(lstMsg[1], lstMsg[2], lstMsg[3]);
                    break;
                case "Court":
                    SetControlText(lbScheduleName, string.Format("{0}——{1}", OnSchedule.NAME, lstMsg[1]));
                    break;
                case "Finish":
                    Finish();
                    break;
            }
        }

        public void Finish()
        {
            ClearControl(tlpTeamA);
            ClearControl(tlpTeamB);
            SetControlText(lbScoreA, "");
            SetControlText(lbScoreB, "");
            SetControlText(lbScheduleName, "");
            SetControlText(lbTeamA, "");
            SetControlText(lbTeamB, "");
        }

        public void SetScore(string mark, string score)
        {
            if (mark == "A")
                SetControlText(lbScoreA, score);
            else
                SetControlText(lbScoreB, score);
        }

        SubStance.Schedule OnSchedule;
        private void btLoadSchedule_Click(object sender, EventArgs e)
        {
            tlpTeamA.Controls.Clear();
            tlpTeamB.Controls.Clear();
            Common.ScheduleLoad frm = new Common.ScheduleLoad();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                
                SocketPublic.SocketSend.SendMessage(Settings.ONSETTINGS.REFEREEIPADDRESS, Settings.ONSETTINGS.REFEREEPORT,
                    string.Format("ScheduleLoad,{0}", frm.ScheduleRow["Guid"]));
                Common.ScheduleOperate s = new Common.ScheduleOperate(frm.ScheduleRow);
                OnSchedule = s.OnSchedule;
                lbScheduleName.Text = s.ScheduleName;
                lbTeamA.Text = string.Format("{0}", s.GetTeamA().SHORTNAME);
                lbTeamB.Text = string.Format("{0}", s.GetTeamB().SHORTNAME);
                lbScoreA.Text = lbScoreB.Text = "0";
                int row = 0;
                foreach (DataRow dr in s.GetTeamATable().Rows)
                {
                    MatchControl mc = new MatchControl(dr);
                    tlpTeamA.Controls.Add(mc, 0, row);
                    mc.Anchor = System.Windows.Forms.AnchorStyles.None;
                    row++;
                }
                row = 0;
                foreach (DataRow dr in s.GetTeamBTable().Rows)
                {
                    MatchControl mc = new MatchControl(dr);
                    tlpTeamB.Controls.Add(mc, 0, row);
                    mc.Anchor = System.Windows.Forms.AnchorStyles.None;
                    row++;
                }
            }
        }

        #region  犯规操作
        public void SetFouls(string mark, string number, string foul)
        {
            MatchControl mc = GetAthletics(mark, number);
            if (mc != null)
            {
                mc.SetFouls(int.Parse(foul));
            }
        }

        public void SetSerious(string mark, string number, string serious)
        {
            MatchControl mc = GetAthletics(mark, number);
            if (mc != null)
            {
                mc.SetSerious(serious);
            }
        }
        #endregion

        #region common
        public MatchControl GetAthletics(string mark, string number)
        {
            if (mark == "A")
                foreach (MatchControl mc in tlpTeamA.Controls)
                {
                    if (mc.Tag.ToString() == number)
                    {
                        return mc;
                    }
                }
            else
                foreach (MatchControl mc in tlpTeamB.Controls)
                {
                    if (mc.Tag.ToString() == number)
                    {
                        return mc;
                    }
                }
            return null;
        }
        #endregion

        #region Delegates
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

        public delegate void SetDataSourceCallback(DevExpress.XtraGrid.GridControl gc, DataTable dt);
        public void SetDataSource(DevExpress.XtraGrid.GridControl gc, DataTable dt)
        {
            if (gc.InvokeRequired)
            {
                SetDataSourceCallback d = new SetDataSourceCallback(SetDataSource);
                gc.Invoke(d, gc, dt);
            }
            else
                gc.DataSource = dt;
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
