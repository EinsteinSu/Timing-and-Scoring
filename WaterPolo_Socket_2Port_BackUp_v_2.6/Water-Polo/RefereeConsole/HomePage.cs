using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ApplicationControlCommon;
using ClientCommon;
using Common;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using log4net;
using RefereeConfig;
using SocketPublic;

namespace RefereeConsole
{
    public partial class HomePage : BaseForm
    {
        private static readonly ILog Log = LogManager.GetLogger("HomePage");
        private readonly SocketListening _socket;
        private MatchControlExtend _onMatch;

        public HomePage()
        {
            InitializeComponent();
            Log.Info($"Start listening from prot {Settings.ONSETTINGS.LISTENINGPORT}");
            _socket = new SocketListening(Settings.ONSETTINGS.LISTENINGPORT);
            _socket.ProcessMessage += ProcessMessage;
            LoadSchedule("106e9e3f-29dd-4a8a-a8af-af90d46c8e0d");
        }

        private void ProcessMessage(string msg)
        {
            Log.Debug($"Got message {msg}");
            var lstMsg = new List<string>();
            foreach (var str in msg.Split(','))
                lstMsg.Add(str);
            var key = lstMsg[0];
            switch (key)
            {
                case "ScheduleLoad":
                    LoadSchedule(lstMsg[1]);
                    break;
            }
        }

        public void LoadSchedule(string scheduleGuid)
        {
            using (var wfm = new WaitDialogForm("Loading data ...", "Please wait"))
            {
                if (_onMatch == null)
                {
                    _onMatch = new MatchControlExtend();
                    wfm.Caption = "Create Window ...";
                    SetControlDock(_onMatch, DockStyle.Fill);
                    AddControl(plParent, _onMatch);
                }
                _onMatch.ScheduleGuid = scheduleGuid;
                var schedule = new ScheduleOperate(scheduleGuid);

                //config it
                SetControlText(lbTitle,
                    $"2011 SHENZHEN Universiade Water-Polo Referee Console——{schedule.OnSchedule.NAME}");
                SetControlEnabled(btFinish, true);

                //回写比赛状态
                var sSql = $"UPDATE Schedule SET STATE = \'进行中\' WHERE GUID = \'{scheduleGuid}\'";
                SqlHelper.RunSql(sSql);
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    CloseApplication();
                    break;
                case Keys.L:
                    LoadScheduleFromUI();
                    break;
            }
        }

        private void LoadScheduleFromUI()
        {
            var from = new ScheduleLoad();
            if (from.ShowDialog() == DialogResult.OK)
            {
                LoadSchedule(from.ScheduleRow["Guid"].ToString());
            }
        }

        public void CloseApplication()
        {
            if (MessageBox.Show("Whether to exit the program?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (_onMatch != null)
                    _onMatch.EndListening();
                _socket.StopListening();
                Application.Exit();
            }
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            CloseApplication();
        }

        private void btLock_Click(object sender, EventArgs e)
        {
            var frm = new LockWindow();
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void btFinish_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you ture finish this match?", "Finish", MessageBoxButtons.OKCancel) ==
                DialogResult.OK)
            {
                _onMatch.ClearAthletes();
                //回写比赛数据
                var sSql =
                    $"UPDATE Schedule SET TEAMASCORE = \'{_onMatch.ScoreA}\',TEAMBSCORE = \'{_onMatch.ScoreB}\',STATE = \'已结束\' WHERE GUID = \'{_onMatch.ScheduleGuid}\'";
                SqlHelper.RunSql(sSql);

                //发送信息到显示控制台和主控台
                SocketSend.SendMessage(Settings.ONSETTINGS.MAJORIPADDRESS, Settings.ONSETTINGS.MAJORPORT,
                    "Finish");
                SocketSend.SendMessage(Settings.ONSETTINGS.DISPLAYIPADDRESS, Settings.ONSETTINGS.DISPLAYPORT,
                    "Finish");
                SetControlEnabled(btFinish, false);
            }
        }

        #region Delegates

        public delegate void DisposeControlCallback(Control ctrl);

        public void DisposeControl(Control ctrl)
        {
            if (ctrl.InvokeRequired)
            {
                DisposeControlCallback d = DisposeControl;
                ctrl.Invoke(d, ctrl);
            }
            else
            {
                ctrl.Dispose();
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