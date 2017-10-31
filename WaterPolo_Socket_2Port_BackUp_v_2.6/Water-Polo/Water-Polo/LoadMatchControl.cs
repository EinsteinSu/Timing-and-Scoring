using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Common;
using DevExpress.XtraGrid;
using log4net;
using SocketPublic;
using SubStance;

namespace Water_Polo
{
    public partial class LoadMatchControl : UserControl
    {
        private static readonly ILog Log = LogManager.GetLogger("LoadMatchControl");
        private readonly SocketListening _socket;
        private Schedule _onSchedule;

        public LoadMatchControl()
        {
            InitializeComponent();
            Log.Info($"Start Listening {Settings.ONSETTINGS.LISTENINGPORT}");
            _socket = new SocketListening(Settings.ONSETTINGS.LISTENINGPORT);
            _socket.ProcessMessage += ProcessMessage;
        }

        private void ProcessMessage(string msg)
        {
            Log.Debug($"Got message: {msg}");
            var lstMsg = new List<string>();
            foreach (var str in msg.Split(','))
                lstMsg.Add(str);
            var key = lstMsg[0];
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
                    SetControlText(lbScheduleName, $"{_onSchedule.NAME}——{lstMsg[1]}");
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

        private void btLoadSchedule_Click(object sender, EventArgs e)
        {
            tlpTeamA.Controls.Clear();
            tlpTeamB.Controls.Clear();
            var frm = new ScheduleLoad();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                SocketSend.SendMessage(Settings.ONSETTINGS.REFEREEIPADDRESS, Settings.ONSETTINGS.REFEREEPORT,
                    $"ScheduleLoad,{frm.ScheduleRow["Guid"]}");
                var s = new ScheduleOperate(frm.ScheduleRow);
                _onSchedule = s.OnSchedule;
                lbScheduleName.Text = s.ScheduleName;
                lbTeamA.Text = $"{s.GetTeam(ScheduleOperate.TeamType.Host).SHORTNAME}";
                lbTeamB.Text = $"{s.GetTeam(ScheduleOperate.TeamType.Guest).SHORTNAME}";
                lbScoreA.Text = lbScoreB.Text = "0";
                var row = 0;
                foreach (DataRow dr in s.GetTeamTable(ScheduleOperate.TeamType.Host).Rows)
                {
                    var mc = new MatchControl(dr);
                    tlpTeamA.Controls.Add(mc, 0, row);
                    mc.Anchor = AnchorStyles.None;
                    row++;
                }
                row = 0;
                foreach (DataRow dr in s.GetTeamTable(ScheduleOperate.TeamType.Guest).Rows)
                {
                    var mc = new MatchControl(dr);
                    tlpTeamB.Controls.Add(mc, 0, row);
                    mc.Anchor = AnchorStyles.None;
                    row++;
                }
            }
        }

        #region common

        public MatchControl GetAthletics(string mark, string number)
        {
            if (mark == "A")
                foreach (MatchControl mc in tlpTeamA.Controls)
                {
                    if (mc.Tag.ToString() == number)
                        return mc;
                }
            else
                foreach (MatchControl mc in tlpTeamB.Controls)
                {
                    if (mc.Tag.ToString() == number)
                        return mc;
                }
            return null;
        }

        #endregion

        #region  犯规操作

        public void SetFouls(string mark, string number, string foul)
        {
            var mc = GetAthletics(mark, number);
            if (mc != null)
                mc.SetFouls(int.Parse(foul));
        }

        public void SetSerious(string mark, string number, string serious)
        {
            var mc = GetAthletics(mark, number);
            if (mc != null)
                mc.SetSerious(serious);
        }

        #endregion

        #region Delegates

        public delegate List<Label> GetLabelsCallback(Control ctrl);

        public List<Label> GetLabels(Control ctrl)
        {
            if (ctrl.InvokeRequired)
            {
                GetLabelsCallback d = GetLabels;
                return (List<Label>) ctrl.Invoke(d, ctrl);
            }
            var lst = new List<Label>();
            foreach (var lb in lst)
                lst.Add(lb);
            return lst;
        }

        public delegate void SetControlShowHideCallback(Control ctrl, bool isShow);

        public void SetControlShowHide(Control ctrl, bool isShow)
        {
            if (ctrl.InvokeRequired)
            {
                SetControlShowHideCallback d = SetControlShowHide;
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

        public delegate void SetDataSourceCallback(GridControl gc, DataTable dt);

        public void SetDataSource(GridControl gc, DataTable dt)
        {
            if (gc.InvokeRequired)
            {
                SetDataSourceCallback d = SetDataSource;
                gc.Invoke(d, gc, dt);
            }
            else
            {
                gc.DataSource = dt;
            }
        }

        public delegate void SetControlTextCallback(Control ctrl, string text);

        public void SetControlText(Control ctrl, string text)
        {
            if (ctrl.InvokeRequired)
            {
                SetControlTextCallback d = SetControlText;
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
                SetControlDockCallback d = SetControlDock;
                ctrl.Invoke(d, ctrl, dc);
            }
            else
            {
                ctrl.Dock = dc;
            }
        }

        public delegate void AddControlCallback(Control ctrl, Control sContrl);

        public void AddControl(Control ctrl, Control sControl)
        {
            if (ctrl.InvokeRequired)
            {
                AddControlCallback d = AddControl;
                ctrl.Invoke(d, ctrl, sControl);
            }
            else
            {
                ctrl.Controls.Add(sControl);
            }
        }

        public delegate void SetControlEnabledCallback(Control ctrl, bool isEnable);

        public void SetControlEnabled(Control ctrl, bool isEnable)
        {
            if (ctrl.InvokeRequired)
            {
                SetControlEnabledCallback d = SetControlEnabled;
                ctrl.Invoke(d, ctrl, isEnable);
            }
            else
            {
                ctrl.Enabled = isEnable;
            }
        }

        public delegate void SetControlForeColorCallback(Control ctrl, Color c);

        public void SetControlForeColor(Control ctrl, Color c)
        {
            if (ctrl.InvokeRequired)
            {
                SetControlForeColorCallback d = SetControlForeColor;
                ctrl.Invoke(d, c);
            }
            else
            {
                ctrl.ForeColor = c;
            }
        }

        public delegate void ClearControlCallback(Control ctrl);

        public void ClearControl(Control ctrl)
        {
            if (ctrl.InvokeRequired)
            {
                ClearControlCallback d = ClearControl;
                ctrl.Invoke(d, ctrl);
            }
            else
            {
                ctrl.Controls.Clear();
            }
        }

        #endregion
    }
}