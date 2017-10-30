using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ApplicationControlCommon;
using Common;
using DevExpress.XtraEditors;
using DisplayConfig;
using SocketPublic;

namespace DisplayConsole
{
    public partial class PDP : BaseForm
    {
        private readonly SocketListening _socket;

        public PDP()
        {
            InitializeComponent();
            _socket = new SocketListening(Settings.ONSETTINGS.LISTENINGPORT);
            _socket.ProcessMessage += sl_ProcessMessage;
        }

        private void sl_ProcessMessage(string msg)
        {
            var lstMsg = new List<string>();
            foreach (var str in msg.Split(','))
                lstMsg.Add(str);
            var key = lstMsg[0];
            switch (key)
            {
                case "ScheduleLoad":
                    LoadSchedule(lstMsg[1]);
                    break;
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
                    SetControlText(lbCournt, lstMsg[1]);
                    break;
                case "TimeOut":
                    SetTimeOut(lstMsg[1], lstMsg[2]);
                    break;
                case "TimeOutCount":
                    SetTimeOutCount(lstMsg[1], lstMsg[2]);
                    break;
                case "TimeOutHide":
                    TimeOutHide(lstMsg[1]);
                    break;
                case "TwentyTime":
                    SetTwentyTime(lstMsg[1], lstMsg[2], lstMsg[3]);
                    break;
                case "TotalTime":
                    SetTotalTime(lstMsg[1]);
                    break;
                case "Finish":
                    ShowWelcome();
                    break;
            }
        }

        public void ShowWelcome()
        {
            SetControlShowHide(plParent, true);
            SetControlShowHide(tlpParent, false);
        }

        public void ShowEvent()
        {
            SetControlShowHide(plParent, false);
            SetControlShowHide(tlpParent, true);
        }

        public void LoadSchedule(string scheduleGuid)
        {
            var s = new ScheduleOperate(scheduleGuid);

            ClearControl(tlpTeamA);
            ClearControl(tlpTeamB);

            SetControlText(lbTeamA, s.GetTeam(ScheduleOperate.TeamType.Host).SHORTNAME);
            SetControlText(lbTeamB, s.GetTeam(ScheduleOperate.TeamType.Guest).SHORTNAME);
            //SetControlText(lbColorA, string.Format("({0})", OnSchedule.TEAMACOLOR));
            //SetControlText(lbColorB, string.Format("({0})", OnSchedule.TEAMBCOLOR));
            SetImage(pbTeamA, s.GetTeamFlag(ScheduleOperate.TeamType.Host));
            SetImage(pbTeamB, s.GetTeamFlag(ScheduleOperate.TeamType.Guest));

            SetControlText(lbPauseA, "");
            SetControlText(lbPauseB, "");

            var row = 0;
            foreach (DataRow dr in s.GetTeamTable(ScheduleOperate.TeamType.Host).Rows)
            {
                var ac = new AthleteControl(dr);
                TableLayoutPanelAddControl(tlpTeamA, ac, 0, row);
                SetControlDock(ac, DockStyle.Fill);
                ac.SetAthleteStyle();
                row++;
            }
            row = 0;
            foreach (DataRow dr in s.GetTeamTable(ScheduleOperate.TeamType.Guest).Rows)
            {
                var ac = new AthleteControl(dr);
                TableLayoutPanelAddControl(tlpTeamB, ac, 0, row);
                ac.SetAthleteStyle();
                SetControlDock(ac, DockStyle.Fill);
                row++;
            }

            ShowEvent();
        }

        public void SetScore(string mark, string score)
        {
            if (mark == "A")
                SetControlText(lbScoreA, score);
            else
                SetControlText(lbScoreB, score);
        }

        public void SetTotalTime(string time)
        {
            if (time == "Time Out")
                SetFont(lbTotalTime, new Font("Comic Sans MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 0));
            else
                SetFont(lbTotalTime, new Font("Comic Sans MS", 63.75F, FontStyle.Bold, GraphicsUnit.Point, 0));
            SetControlText(lbTotalTime, time);
        }

        public AthleteControl GetAthletics(string mark, string number)
        {
            if (mark == "A")
                foreach (AthleteControl ac in tlpTeamA.Controls)
                {
                    if (ac.Tag.ToString() == number)
                        return ac;
                }
            else
                foreach (AthleteControl ac in tlpTeamB.Controls)
                {
                    if (ac.Tag.ToString() == number)
                        return ac;
                }
            return null;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Location = new Point(Settings.ONSETTINGS.X, Settings.ONSETTINGS.Y);
            Width = Settings.ONSETTINGS.WIDTH;
            Height = Settings.ONSETTINGS.HEIGHT;

            ShowWelcome();

            //LoadSchedule("58");
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    _socket.StopListening();
                    Application.Exit();
                    break;
                case Keys.F4:
                    var frm = new Fonts();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        foreach (Control ctrl in tlpTeamA.Controls)
                        {
                            if (ctrl is AthleteControl ac)
                                ac.SetAthleteStyle();
                        }
                        foreach (Control ctrl in tlpTeamB.Controls)
                        {
                            if (ctrl is AthleteControl ac)
                                ac.SetAthleteStyle();
                        }
                    }
                    break;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void lbTotalTime_Click(object sender, EventArgs e)
        {
        }

        #region 渐变色

        /// <summary>
        ///     StartColor
        /// </summary>
        public Color STARTCOLOR { get; set; }

        /// <summary>
        ///     EndColor
        /// </summary>
        public Color ENDCOLOR { get; set; }

        private float _ColorAngle;

        /// <summary>
        ///     ColorAngle
        /// </summary>
        public float COLORANGLE
        {
            get => _ColorAngle;
            set
            {
                _ColorAngle = value;
                Invalidate();
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            var g = e.Graphics;
            var rBackground = new Rectangle(0, 0, Width, Height);
            var bBackground = new LinearGradientBrush(rBackground, STARTCOLOR, ENDCOLOR, _ColorAngle);
            g.FillRectangle(bBackground, rBackground);
            bBackground.Dispose();
        }

        #endregion

        #region 技术暂停操作

        public void SetTimeOut(string mark, string time)
        {
            if (mark == "A")
            {
                SetControlText(lbPauseA, time);
                if (time == "00:00")
                    SetControlText(lbPauseA, "");
            }
            else
            {
                SetControlText(lbPauseB, time);
                if (time == "00:00")
                    SetControlText(lbPauseB, "");
            }
        }

        public void SetTimeOutCount(string timeOutCountA, string timeOutCountB)
        {
            SetControlText(lbTimeOutA, timeOutCountA);
            SetControlText(lbTimeOutB, timeOutCountB);
        }

        public void TimeOutHide(string mark)
        {
            if (mark == "A")
                SetControlText(lbPauseA, "");
            else
                SetControlText(lbPauseB, "");
        }

        #endregion

        #region 犯规操作

        public void SetFouls(string mark, string number, string foul)
        {
            var ac = GetAthletics(mark, number);
            ac?.SetFouls(int.Parse(foul));
        }

        public void SetSerious(string mark, string number, string serious)
        {
            var ac = GetAthletics(mark, number);
            ac?.SetSerious(serious);
        }

        public void SetTwentyTime(string mark, string number, string time)
        {
            var ac = GetAthletics(mark, number);
            ac?.SetTwentyTime(time);
        }

        #endregion

        #region Delegates

        public delegate void SetFontCallback(Label lb, Font f);

        public void SetFont(Label lb, Font f)
        {
            if (lb.InvokeRequired)
            {
                SetFontCallback d = SetFont;
                lb.Invoke(d, lb, f);
            }
            else
            {
                lb.Font = f;
            }
        }

        public delegate void SetControlBackColorCallback(Control ctrl, Color c);

        public void SetControlBackColor(Control ctrl, Color c)
        {
            if (ctrl.InvokeRequired)
            {
                SetControlBackColorCallback d = SetControlBackColor;
                ctrl.Invoke(d, ctrl, c);
            }
            else
            {
                ctrl.BackColor = c;
            }
        }

        public delegate void SetImageCallback(PictureBox pb, Image img);

        public void SetImage(PictureBox pb, Image img)
        {
            if (pb.InvokeRequired)
            {
                SetImageCallback d = SetImage;
                pb.Invoke(d, pb, img);
            }
            else
            {
                pb.Image = img;
            }
        }

        public delegate void SetProgressBarCallback(ProgressBarControl pb, string position);

        public void SetProgressBar(ProgressBarControl pb, string position)
        {
            if (pb.InvokeRequired)
            {
                SetProgressBarCallback d = SetProgressBar;
                pb.Invoke(d, pb, position);
            }
            else
            {
                pb.Position = int.Parse(position);
            }
        }

        public delegate void
            TableLayoutPanelAddControlCallback(TableLayoutPanel tlp, Control ctrl, int column, int row);

        public void TableLayoutPanelAddControl(TableLayoutPanel tlp, Control ctrl, int column, int row)
        {
            if (tlp.InvokeRequired)
            {
                TableLayoutPanelAddControlCallback d = TableLayoutPanelAddControl;
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