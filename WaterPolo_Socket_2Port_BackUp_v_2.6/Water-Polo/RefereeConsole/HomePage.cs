using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RefereeConsole
{
    public partial class HomePage : ApplicationControlCommon.BaseForm
    {
        SocketPublic.SocketListening ul;
        public HomePage()
        {
            InitializeComponent();
            ul = new SocketPublic.SocketListening(RefereeConfig.Settings.ONSETTINGS.LISTENINGPORT);
            ul.ProcessMessage += new SocketPublic.SocketListening.ProcessMessageCallback(sl_ProcessMessage);
            //LoadSchedule("1");
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
                case "ScheduleLoad":
                    LoadSchedule(lstMsg[1]);
                    break;
            }
        }

        MatchControlExtend OnMatch;
        ComPublic.ComListening ComTotal;
        ComPublic.ComListening ComSenconds;
        public void LoadSchedule(string scheduleGuid)
        {
            using (DevExpress.Utils.WaitDialogForm wfm = new DevExpress.Utils.WaitDialogForm("Loading data ...", "Please wait"))
            {
                if (OnMatch == null)
                {
                    OnMatch = new MatchControlExtend();
                    wfm.Caption = "Create Window ...";
                    SetControlDock(OnMatch, DockStyle.Fill);
                    AddControl(plParent, OnMatch);
                }
                OnMatch.ScheduleGuid = scheduleGuid;
                Common.ScheduleOperate s = new Common.ScheduleOperate(scheduleGuid);
                SetControlText(lbTitle, string.Format("2011 SHENZHEN Universiade Water-Polo Referee Console——{0}", s.OnSchedule.NAME));
                SetControlEnabled(btFinish, true);

                //回写比赛状态
                string sSql = String.Format("UPDATE Schedule SET STATE = '{0}' WHERE GUID = '{1}'", "进行中", scheduleGuid);
                ClientCommon.SqlHelper.RunSql(sSql);
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
            }
        }

        public void CloseApplication()
        {
            if (MessageBox.Show("Whether to exit the program?", "Exit", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (OnMatch != null)
                    OnMatch.EndListening();
                ul.StopListening();
                Application.Exit();
            }
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            CloseApplication();
        }

        private void btLock_Click(object sender, EventArgs e)
        {
            Common.LockWindow frm = new Common.LockWindow();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
            }
        }

        #region Delegates
        public delegate void DisposeControlCallback(Control ctrl);
        public void DisposeControl(Control ctrl)
        {
            if (ctrl.InvokeRequired)
            {
                DisposeControlCallback d = new DisposeControlCallback(DisposeControl);
                ctrl.Invoke(d, ctrl);
            }
            else
                ctrl.Dispose();
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

        private void btFinish_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you ture finish this match?", "Finish", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                OnMatch.ClearAthletes();
                OnMatch.WriteLog();
                //回写比赛数据
                string sSql = String.Format("UPDATE Schedule SET TEAMASCORE = '{0}',TEAMBSCORE = '{1}',STATE = '{2}' WHERE GUID = '{3}'",
                    OnMatch.ScoreA, OnMatch.ScoreB, "已结束", OnMatch.ScheduleGuid);
                ClientCommon.SqlHelper.RunSql(sSql);

                //发送信息到显示控制台和主控台
                SocketPublic.SocketSend.SendMessage(RefereeConfig.Settings.ONSETTINGS.MAJORIPADDRESS, RefereeConfig.Settings.ONSETTINGS.MAJORPORT,
                    "Finish");
                SocketPublic.SocketSend.SendMessage(RefereeConfig.Settings.ONSETTINGS.DISPLAYIPADDRESS, RefereeConfig.Settings.ONSETTINGS.DISPLAYPORT,
                    "Finish");
                SetControlEnabled(btFinish, false);
            }
        }
    }
}
