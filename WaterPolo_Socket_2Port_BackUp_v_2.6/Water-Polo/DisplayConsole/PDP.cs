using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common;

namespace DisplayConsole
{
    public partial class PDP : ApplicationControlCommon.BaseForm
    {
        SocketPublic.SocketListening ul;
        public PDP()
        {
            InitializeComponent();
            ul = new SocketPublic.SocketListening(DisplayConfig.Settings.ONSETTINGS.LISTENINGPORT);
            ul.ProcessMessage += new SocketPublic.SocketListening.ProcessMessageCallback(sl_ProcessMessage);
        }

        #region 渐变色
        private Color _StartColor;
        /// <summary>
        /// StartColor
        /// </summary>
        public Color STARTCOLOR
        {
            get { return _StartColor; }
            set { _StartColor = value; }
        }

        private Color _EndColor;
        /// <summary>
        /// EndColor
        /// </summary>
        public Color ENDCOLOR
        {
            get { return _EndColor; }
            set { _EndColor = value; }
        }

        private float _ColorAngle;
        /// <summary>
        /// ColorAngle
        /// </summary>
        public float COLORANGLE
        {
            get { return _ColorAngle; }
            set { _ColorAngle = value; this.Invalidate(); }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rBackground = new Rectangle(0, 0, this.Width, this.Height);
            System.Drawing.Drawing2D.LinearGradientBrush bBackground = new System.Drawing.Drawing2D.LinearGradientBrush(rBackground, _StartColor, _EndColor, _ColorAngle);
            g.FillRectangle(bBackground, rBackground);
            bBackground.Dispose();
        }
        #endregion

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

        SubStance.Schedule OnSchedule;
        public void LoadSchedule(string scheduleGuid)
        {
            Common.ScheduleOperate s = new Common.ScheduleOperate(scheduleGuid);
            OnSchedule = s.OnSchedule;

            ClearControl(tlpTeamA);
            ClearControl(tlpTeamB);

            SetControlText(lbTeamA, s.GetTeamA().SHORTNAME);
            SetControlText(lbTeamB, s.GetTeamB().SHORTNAME);
            //SetControlText(lbColorA, string.Format("({0})", OnSchedule.TEAMACOLOR));
            //SetControlText(lbColorB, string.Format("({0})", OnSchedule.TEAMBCOLOR));
            SetImage(pbTeamA, s.GetTeamFlag(ScheduleOperate.TeamType.Host));
            SetImage(pbTeamB, s.GetTeamFlag(ScheduleOperate.TeamType.Guest));

            SetControlText(lbPauseA, "");
            SetControlText(lbPauseB, "");

            int row = 0;
            foreach (DataRow dr in s.GetTeamATable().Rows)
            {
                AthleteControl ac = new AthleteControl(dr);
                TableLayoutPanelAddControl(tlpTeamA, ac, 0, row);
                SetControlDock(ac, DockStyle.Fill);
                ac.SetAthleteStyle();
                row++;
            }
            row = 0;
            foreach (DataRow dr in s.GetTeamBTable().Rows)
            {
                AthleteControl ac = new AthleteControl(dr);
                TableLayoutPanelAddControl(tlpTeamB, ac, 0, row);
                ac.SetAthleteStyle();
                SetControlDock(ac, DockStyle.Fill);
                row++;
            }

            ShowEvent();
        }

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
            {
                SetFont(lbTotalTime, new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            }
            else
            {
                SetFont(lbTotalTime, new System.Drawing.Font("Comic Sans MS", 63.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            }
            SetControlText(lbTotalTime, time);
        }

        #region 犯规操作
        public void SetFouls(string mark, string number, string foul)
        {
            AthleteControl ac = GetAthletics(mark, number);
            if (ac != null)
            {
                ac.SetFouls(int.Parse(foul));
            }
        }

        public void SetSerious(string mark, string number, string serious)
        {
            AthleteControl ac = GetAthletics(mark, number);
            if (ac != null)
            {
                ac.SetSerious(serious);
            }
        }

        public void SetTwentyTime(string mark, string number, string time)
        {
            AthleteControl ac = GetAthletics(mark, number);
            if (ac != null)
            {
                ac.SetTwentyTime(time);
            }
        }
        #endregion

        public AthleteControl GetAthletics(string mark, string number)
        {
            if (mark == "A")
                foreach (AthleteControl ac in tlpTeamA.Controls)
                {
                    if (ac.Tag.ToString() == number)
                    {
                        return ac;
                    }
                }
            else
                foreach (AthleteControl ac in tlpTeamB.Controls)
                {
                    if (ac.Tag.ToString() == number)
                    {
                        return ac;
                    }
                }
            return null;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.Location = new Point(DisplayConfig.Settings.ONSETTINGS.X, DisplayConfig.Settings.ONSETTINGS.Y);
            this.Width = DisplayConfig.Settings.ONSETTINGS.WIDTH;
            this.Height = DisplayConfig.Settings.ONSETTINGS.HEIGHT;

            ShowWelcome();

            //LoadSchedule("58");
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    ul.StopListening();
                    Application.Exit();
                    break;
                case Keys.F4:
                    Fonts frm = new Fonts();
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        foreach (Control ctrl in tlpTeamA.Controls)
                        {
                            AthleteControl ac = ctrl as AthleteControl;
                            if (ac != null)
                                ac.SetAthleteStyle();
                        }
                        foreach (Control ctrl in tlpTeamB.Controls)
                        {
                            AthleteControl ac = ctrl as AthleteControl;
                            if (ac != null)
                                ac.SetAthleteStyle();
                        }
                    }
                    break;
            }
        }

        #region Delegates
        public delegate void SetFontCallback(Label lb, Font f);
        public void SetFont(Label lb, Font f)
        {
            if (lb.InvokeRequired)
            {
                SetFontCallback d = new SetFontCallback(SetFont);
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
                SetControlBackColorCallback d = new SetControlBackColorCallback(SetControlBackColor);
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
                SetImageCallback d = new SetImageCallback(SetImage);
                pb.Invoke(d, pb, img);
            }
            else
            {
                pb.Image = img;
            }
        }

        public delegate void SetProgressBarCallback(DevExpress.XtraEditors.ProgressBarControl pb, string position);
        public void SetProgressBar(DevExpress.XtraEditors.ProgressBarControl pb, string position)
        {
            if (pb.InvokeRequired)
            {
                SetProgressBarCallback d = new SetProgressBarCallback(SetProgressBar);
                pb.Invoke(d, pb, position);
            }
            else
            {
                pb.Position = int.Parse(position);
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbTotalTime_Click(object sender, EventArgs e)
        {

        }
    }
}
