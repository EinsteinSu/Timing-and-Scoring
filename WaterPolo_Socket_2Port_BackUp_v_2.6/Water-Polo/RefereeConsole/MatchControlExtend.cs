using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RefereeConsole
{
    public partial class MatchControlExtend : UserControl
    {
        Common.ScheduleOperate s;
        const int TWENTYTIMETOTAL = 20;
        private string _scheduleGuid;
        public string ScheduleGuid
        {
            get
            {
                return _scheduleGuid;
            }
            set
            {
                _scheduleGuid = value;

                ClearAthletes();
                //发送信息到显示控制台
                SocketPublic.SocketSend.SendMessage(RefereeConfig.Settings.ONSETTINGS.DISPLAYIPADDRESS, RefereeConfig.Settings.ONSETTINGS.DISPLAYPORT,
                    string.Format("ScheduleLoad,{0}", value));

                s = new Common.ScheduleOperate(value);
                SetControlText(lbTeamA, string.Format("{0}   ({1})", s.GetTeamA().SHORTNAME, s.OnSchedule.TEAMACOLOR));
                SetControlText(lbTeamB, string.Format("{0}   ({1})", s.GetTeamB().SHORTNAME, s.OnSchedule.TEAMBCOLOR));
                CreateAthletes(CreateTable(s.GetTeamATable()), "A");
                CreateAthletes(CreateTable(s.GetTeamBTable()), "B");

                Court = 1;
                ScoreA = 0;
                ScoreB = 0;
                TeamATimeOutCount = 0;
                TeamBTimeOutCount = 0;
            }
        }
        ComPublic.ComListening TotalCom;
        ComPublic.ComListening SecondsCom;
        public MatchControlExtend()
        {
            InitializeComponent();

            #region 总计时
            try
            {
                TotalCom = new ComPublic.ComListening(RefereeConfig.Settings.ONSETTINGS.TOTALTIMEPORT, RefereeConfig.Settings.ONSETTINGS.TOTALBIT);
                TotalCom.Header = RefereeConfig.Settings.ONSETTINGS.TOTALHEADER;
                TotalCom.Tail = RefereeConfig.Settings.ONSETTINGS.TOTALTAIL;
                if (TotalCom.Open())
                {
                    TotalCom.StartListening();
                    TotalCom.DataChanging += new ComPublic.ComListening.DataChangingCallback(TotalCom_DataChanging);
                }
            }
            catch { }
            #endregion

            #region 30秒
            try
            {
                SecondsCom = new ComPublic.ComListening(RefereeConfig.Settings.ONSETTINGS.SECONDSTIMEPORT, RefereeConfig.Settings.ONSETTINGS.SECONDSBIT);
                SecondsCom.Header = RefereeConfig.Settings.ONSETTINGS.SECONDSHEADER;
                SecondsCom.Tail = RefereeConfig.Settings.ONSETTINGS.SECONDSTAIL;
                if (SecondsCom.Open())
                {
                    SecondsCom.StartListening();
                    SecondsCom.DataChanging += new ComPublic.ComListening.DataChangingCallback(SecondsCom_DataChanging);
                }
            }
            catch { }
            #endregion

            tcTotalTime_TextTimingChanged(DateTime.Parse(tcTotalTime.SettingTime).ToString(tcTotalTime.DisplayFormat));
            tcThirtyTime_TextTimingChanged("30");
        }

        #region 总计时和30秒
        /// <summary>
        /// 30秒
        /// </summary>
        /// <param name="msg"></param>
        void SecondsCom_DataChanging(List<string> msg)
        {
            if (IsNumeric(msg[0]))
            {
                int seconds = int.Parse(msg[0]);
                tcThirtyTime.LTime = seconds * 100;
            }

        }

        bool isPauseTime = false;
        bool isAdd = false;
        /// <summary>
        /// 总计时
        /// </summary>
        /// <param name="msg"></param>
        void TotalCom_DataChanging(List<string> msg)
        {
            if (msg.Count > 5)
            {
                if (msg[5].IndexOf("E") >= 0 && cbCourt.Checked)
                {
                    if (IsNumeric(msg[5].Replace("E", "")))
                        Court = int.Parse(msg[5].Replace("E", ""));
                }
                if (msg[5].IndexOf("C") >= 0 && IsNumeric(msg[5].Replace("C", "")))
                {
                    isPauseTime = true;
                    if (!isAdd)
                    {
                        TeamATimeOutCount++;
                        isAdd = true;
                    }
                    if (IsNumeric(msg[0]) && IsNumeric(msg[1]))
                    {
                        string time = string.Format("00:{0}:{1}", msg[0], msg[1]);
                        tcTimeOutA.LTime = tcTimeOutA.GetSecond(DateTime.Parse(time)) * 100;
                    }
                }
                if (msg[5].IndexOf("D") >= 0 && IsNumeric(msg[5].Replace("D", "")))
                {
                    isPauseTime = true;
                    if (!isAdd)
                    {
                        TeamBTimeOutCount++;
                        isAdd = true;
                    }
                    if (IsNumeric(msg[0]) && IsNumeric(msg[1]))
                    {
                        string time = string.Format("00:{0}:{1}", msg[0], msg[1]);
                        tcTimeOutB.LTime = tcTimeOutB.GetSecond(DateTime.Parse(time)) * 100;
                    }
                }
                else
                {
                    if (IsNumeric(msg[5]) && cbCourt.Checked)
                        Court = int.Parse(msg[5]);
                }
                if (IsNumeric(msg[0]) && IsNumeric(msg[1]) && msg[5].IndexOf("C") < 0 && msg[5].IndexOf("D") < 0)
                {
                    //if (isPauseTime)
                    //{
                    //    btHideTimeOutA_Click(null, null);
                    //    btHideTimeOutB_Click(null, null);
                    //}
                    isPauseTime = false;
                    isAdd = false;
                    string time = string.Format("00:{0}:{1}", msg[0], msg[1]);
                    tcTotalTime.LTime = tcTotalTime.GetSecond(DateTime.Parse(time)) * 100;
                }
                if (IsNumeric(msg[3]) && cbScore.Checked)
                    ScoreA = int.Parse(msg[3]);
                if (IsNumeric(msg[4]) && cbScore.Checked)
                    ScoreB = int.Parse(msg[4]);
            }
        }

        public static bool IsNumeric(string str)
        {
            if (str.Length == 0)
                return false;
            char[] ch = new char[str.Length];
            ch = str.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] < 48 || ch[i] > 57)
                    return false;
            }
            return true;
        }
        #endregion

        #region 创建临时表
        public void ClearAthletes()
        {
            foreach (Control ctrl in tlpTeamA.Controls)
            {
                AthletesControl a = ctrl as AthletesControl;
                if (a != null)
                {
                    a.StartTwentyTime -= ac_StartTwentyTime;
                    a.TimeOver -= ac_TimeOver;
                }
            }

            foreach (Control ctrl in tlpTeamB.Controls)
            {
                AthletesControl a = ctrl as AthletesControl;
                if (a != null)
                {
                    a.StartTwentyTime -= ac_StartTwentyTime;
                    a.TimeOver -= ac_TimeOver;
                }
            }
            ClearControl(tlpTeamA);
            ClearControl(tlpTeamB);
        }

        public void CreateAthletes(DataTable dt, string mark)
        {
            TableLayoutPanel tlp;
            if (mark == "A")
                tlp = tlpTeamA;
            else
                tlp = tlpTeamB;
            int row = 0;

            foreach (DataRow dr in dt.Rows)
            {
                AthletesControl ac = new AthletesControl(dr, mark);
                TableLayoutPanelAddControl(tlp, ac, 0, row);
                SetControlDock(ac, DockStyle.Fill);
                ac.StartTwentyTime += new AthletesControl.StartTwentyTimeCallback(ac_StartTwentyTime);
                ac.TimeOver += new AthletesControl.TimeOverCallback(ac_TimeOver);
                row++;
            }
        }

        void ac_TimeOver(AthletesControl ac)
        {
            TableLayoutPanel tlp;
            if (ac.MARK == "A")
                tlp = tlpTeamA;
            else
                tlp = tlpTeamB;

            #region 获取排序
            int num = 1;
            List<AthletesControl> lst = new List<AthletesControl>();
            List<AthletesControl> lstUn = new List<AthletesControl>();
            foreach (Control ctrl in tlp.Controls)
            {
                AthletesControl a = ctrl as AthletesControl;
                if (a != null)
                {
                    if (a.IsStart)
                    {
                        lst.Add(a);
                    }
                    else
                    {
                        lstUn.Add(a);
                    }
                }
            }

            var c = from data in lst
                    orderby data.ORDERID
                    select data;
            foreach (AthletesControl actrl in c)
            {
                actrl.ORDERID = num;
                num++;
            }
            #endregion

            #region
            List<byte[]> lstbs = new List<byte[]>();
            foreach (AthletesControl a in lst)
            {
                byte bMark = new byte();
                if (a.MARK == "A")
                {
                    bMark = 0x00;
                }
                else
                {
                    bMark = 0x01;
                }
                byte[] bs = new byte[6];
                bs[0] = 0xFF;
                bs[1] = bMark;
                bs[2] = byte.Parse(a.NUMBER.ToString());
                bs[3] = byte.Parse(a.ORDERID.ToString());
                bs[4] = byte.Parse(a.TOTALTIME.ToString());
                bs[5] = 0xAF;
                lstbs.Add(bs);
            }

            foreach (AthletesControl a in lstUn)
            {
                byte bMark = new byte();
                if (a.MARK == "A")
                {
                    bMark = 0x00;
                }
                else
                {
                    bMark = 0x01;
                }
                byte[] bs = new byte[6];
                bs[0] = 0xFF;
                bs[1] = bMark;
                bs[2] = byte.Parse(a.NUMBER.ToString());
                bs[3] = byte.Parse(num.ToString());
                bs[4] = 0x00;
                bs[5] = 0xAF;
                lstbs.Add(bs);
                num++;
            }

            byte[] bts = new byte[13 * 7];
            int k = 0;
            foreach (byte[] b in lstbs)
            {
                foreach (byte bcs in b)
                {
                    bts[k] = bcs;
                    k++;
                }
            }
            if (RefereeConfig.Settings.ONSETTINGS.BTWENTYSECONDS)
                SocketPublic.UdpSend.SendMessage(RefereeConfig.Settings.ONSETTINGS.TWENTYSECONDSIPADDRESS,
                        RefereeConfig.Settings.ONSETTINGS.TWENTYSECONDSPORT, bts);
            #endregion
        }

        void ac_StartTwentyTime(AthletesControl ac)
        {
            TableLayoutPanel tlp;
            if (ac.MARK == "A")
                tlp = tlpTeamA;
            else
                tlp = tlpTeamB;
            int num = 0;
            foreach (Control ctrl in tlp.Controls)
            {
                AthletesControl a = ctrl as AthletesControl;
                if (a != null && a.IsStart)
                {
                    num++;
                }
            }
            ac.ORDERID = num;

            #region 获取排序
            num = 1;
            List<AthletesControl> lst = new List<AthletesControl>();
            List<AthletesControl> lstUn = new List<AthletesControl>();
            foreach (Control ctrl in tlp.Controls)
            {
                AthletesControl a = ctrl as AthletesControl;
                if (a != null)
                {
                    if (a.IsStart)
                    {
                        lst.Add(a);
                    }
                    else
                    {
                        lstUn.Add(a);
                    }
                }
            }

            var c = from data in lst
                    orderby data.ORDERID
                    select data;
            foreach (AthletesControl actrl in c)
            {
                actrl.ORDERID = num;
                num++;
            }
            #endregion

            #region
            List<byte[]> lstbs = new List<byte[]>();
            foreach (AthletesControl a in lst)
            {
                byte bMark = new byte();
                if (a.MARK == "A")
                {
                    bMark = 0x00;
                }
                else
                {
                    bMark = 0x01;
                }
                byte[] bs = new byte[6];
                bs[0] = 0xFF;
                bs[1] = bMark;
                bs[2] = byte.Parse(a.NUMBER.ToString());
                bs[3] = byte.Parse(a.ORDERID.ToString());
                bs[4] = byte.Parse(a.TOTALTIME.ToString());
                bs[5] = 0xAF;
                lstbs.Add(bs);
            }

            foreach (AthletesControl a in lstUn)
            {
                byte bMark = new byte();
                if (a.MARK == "A")
                {
                    bMark = 0x00;
                }
                else
                {
                    bMark = 0x01;
                }
                byte[] bs = new byte[6];
                bs[0] = 0xFF;
                bs[1] = bMark;
                bs[2] = byte.Parse(a.NUMBER.ToString());
                bs[3] = byte.Parse(num.ToString());
                bs[4] = 0x00;
                bs[5] = 0xAF;
                lstbs.Add(bs);
                num++;
            }

            byte[] bts = new byte[13 * 7];
            int k = 0;
            foreach (byte[] b in lstbs)
            {
                foreach (byte bcs in b)
                {
                    bts[k] = bcs;
                    k++;
                }
            }
            if (RefereeConfig.Settings.ONSETTINGS.BTWENTYSECONDS)
                SocketPublic.UdpSend.SendMessage(RefereeConfig.Settings.ONSETTINGS.TWENTYSECONDSIPADDRESS,
                        RefereeConfig.Settings.ONSETTINGS.TWENTYSECONDSPORT, bts);
            #endregion
        }

        public DataTable CreateTable(DataTable dt)
        {
            DataTable dtTeam = new DataTable();
            dtTeam.Columns.Add("NUM", typeof(int));
            dtTeam.Columns.Add("NAME", typeof(string));
            dtTeam.Columns.Add("FOULS", typeof(int));
            dtTeam.Columns.Add("SERIOUS", typeof(int));
            dtTeam.Columns.Add("TTIME", typeof(string));
            foreach (DataRow dr in dt.Rows)
            {
                DataRow drn = dtTeam.NewRow();
                drn["Num"] = dr["BIBNUM"];
                drn["Name"] = dr["NameEn"];
                drn["Fouls"] = 0;
                drn["Serious"] = 0;
                dtTeam.Rows.Add(drn);
            }
            return dtTeam;
        }
        #endregion

        #region 比分操作
        private int _scoreA;
        public int ScoreA
        {
            get
            {
                return _scoreA;
            }
            set
            {
                if (value >= 0)
                {
                    _scoreA = value;
                    SetControlText(lbScoreA, value.ToString());
                    //发送信息到显示控制台和主控台
                    SocketPublic.SocketSend.SendMessage(RefereeConfig.Settings.ONSETTINGS.MAJORIPADDRESS, RefereeConfig.Settings.ONSETTINGS.MAJORPORT,
                        string.Format("Score,{0},{1}", "A", value));
                    SocketPublic.SocketSend.SendMessage(RefereeConfig.Settings.ONSETTINGS.DISPLAYIPADDRESS, RefereeConfig.Settings.ONSETTINGS.DISPLAYPORT,
                       string.Format("Score,{0},{1}", "A", value));

                    SendToVrs();
                }
            }
        }

        private int _scoreB;
        public int ScoreB
        {
            get
            {
                return _scoreB;
            }
            set
            {
                if (value >= 0)
                {
                    _scoreB = value;
                    SetControlText(lbScoreB, value.ToString());
                    //发送信息到显示控制台和主控台
                    SocketPublic.SocketSend.SendMessage(RefereeConfig.Settings.ONSETTINGS.MAJORIPADDRESS, RefereeConfig.Settings.ONSETTINGS.MAJORPORT,
                        string.Format("Score,{0},{1}", "B", value));
                    SocketPublic.SocketSend.SendMessage(RefereeConfig.Settings.ONSETTINGS.DISPLAYIPADDRESS, RefereeConfig.Settings.ONSETTINGS.DISPLAYPORT,
                        string.Format("Score,{0},{1}", "B", value));

                    SendToVrs();
                }
            }
        }

        private void btAddScoreA_Click(object sender, EventArgs e)
        {
            ScoreA++;
        }

        private void btSubScoreA_Click(object sender, EventArgs e)
        {
            ScoreA--;
        }

        private void btAddScoreB_Click(object sender, EventArgs e)
        {
            ScoreB++;
        }

        private void btSubScoreB_Click(object sender, EventArgs e)
        {
            ScoreB--;
        }
        #endregion

        #region 比赛节数操作
        private int _court;
        public int Court
        {
            get
            {
                return _court;
            }
            set
            {
                if (value > 0)
                {
                    _court = value;
                    string court = string.Empty;
                    switch (value)
                    {
                        case 1:
                            court = "1st";
                            break;
                        case 2:
                            court = "2nd";
                            break;
                        case 3:
                            court = "3rd";
                            break;
                        case 4:
                            court = "4th";
                            break;
                        default:
                            court = string.Format("Extra Time({0})", value - 4);
                            break;
                    }
                    SetControlText(lbAcournt, court);
                    //发送信息到显示控制台和主控台
                    SocketPublic.SocketSend.SendMessage(RefereeConfig.Settings.ONSETTINGS.MAJORIPADDRESS, RefereeConfig.Settings.ONSETTINGS.MAJORPORT,
                        string.Format("Court,{0}", court));
                    SocketPublic.SocketSend.SendMessage(RefereeConfig.Settings.ONSETTINGS.DISPLAYIPADDRESS, RefereeConfig.Settings.ONSETTINGS.DISPLAYPORT,
                        string.Format("Court,{0}", court));

                    SendToVrs();
                }
            }
        }

        private void btAddAcournt_Click(object sender, EventArgs e)
        {
            Court++;
        }

        private void btSubAcournt_Click(object sender, EventArgs e)
        {
            Court--;
        }
        #endregion

        #region 技术暂停操作
        private int _teamATimeOutCount;
        public int TeamATimeOutCount
        {
            get
            {
                return _teamATimeOutCount;
            }
            set
            {
                _teamATimeOutCount = value;
                SetControlText(lbTimeOutA, value.ToString());
                //send to display console
                SocketPublic.SocketSend.SendMessage(RefereeConfig.Settings.ONSETTINGS.DISPLAYIPADDRESS, RefereeConfig.Settings.ONSETTINGS.DISPLAYPORT,
                      string.Format("TimeOutCount,{0},{1}", value, TeamBTimeOutCount));
            }
        }

        private int _teamBTimeOutCount;
        public int TeamBTimeOutCount
        {
            get
            {
                return _teamBTimeOutCount;
            }
            set
            {
                _teamBTimeOutCount = value;
                SetControlText(lbTimeOutB, value.ToString());
                //send to display console
                SocketPublic.SocketSend.SendMessage(RefereeConfig.Settings.ONSETTINGS.DISPLAYIPADDRESS, RefereeConfig.Settings.ONSETTINGS.DISPLAYPORT,
                      string.Format("TimeOutCount,{0},{1}", TeamATimeOutCount, value));
            }
        }

        private void btHideTimeOutA_Click(object sender, EventArgs e)
        {
            tcTimeOutA.Stop();
            tcTimeOutA.Reset();
            SocketPublic.SocketSend.SendMessage(RefereeConfig.Settings.ONSETTINGS.DISPLAYIPADDRESS, RefereeConfig.Settings.ONSETTINGS.DISPLAYPORT,
                     string.Format("TimeOutHide,{0}", "A"));
            isPauseTime = false;
        }

        private void btHideTimeOutB_Click(object sender, EventArgs e)
        {
            tcTimeOutB.Stop();
            tcTimeOutB.Reset();
            SocketPublic.SocketSend.SendMessage(RefereeConfig.Settings.ONSETTINGS.DISPLAYIPADDRESS, RefereeConfig.Settings.ONSETTINGS.DISPLAYPORT,
                     string.Format("TimeOutHide,{0}", "B"));
            isPauseTime = false;
        }

        private void tcTimeOutA_Started()
        {
            //TeamATimeOutCount++;
            tcTotalTime.Stop();
            btStartTotalTime.Enabled = true;
            btPauseTotalTime.Enabled = false;
        }

        private void tcTimeOutB_Started()
        {
            //TeamBTimeOutCount++;
            tcTotalTime.Stop();
            btStartTotalTime.Enabled = true;
            btPauseTotalTime.Enabled = false;
        }

        private void tcTimeOutA_TextTimingChanged(string timing)
        {
            int ltime = tcTimeOutA.GetSecond(DateTime.Parse("00:" + timing));
            if (ltime == 15)
            {
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
                sp.SoundLocation = string.Format(@"{0}\{1}", ApplicationCommon.DirectoryHelper.SoundDirectory, "TimeOut15.wav");
                sp.Play();
            }
            if (ltime == 0)
            {
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
                sp.SoundLocation = string.Format(@"{0}\{1}", ApplicationCommon.DirectoryHelper.SoundDirectory, "TimeOut0.wav");
                sp.Play();

                SocketPublic.SocketSend.SendMessage(RefereeConfig.Settings.ONSETTINGS.DISPLAYIPADDRESS, RefereeConfig.Settings.ONSETTINGS.DISPLAYPORT,
                     string.Format("TimeOutHide,{0}", "A"));
                return;
            }
            SocketPublic.SocketSend.SendMessage(RefereeConfig.Settings.ONSETTINGS.DISPLAYIPADDRESS, RefereeConfig.Settings.ONSETTINGS.DISPLAYPORT,
                      string.Format("TimeOut,{0},{1}", "A", timing));
        }

        private void tcTimeOutB_TextTimingChanged(string timing)
        {
            int ltime = tcTimeOutB.GetSecond(DateTime.Parse("00:" + timing));
            if (ltime == 15)
            {
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
                sp.SoundLocation = string.Format(@"{0}\{1}", ApplicationCommon.DirectoryHelper.SoundDirectory, "TimeOut15.wav");
                sp.Play();
            }
            if (ltime == 0)
            {
                //显示回总时间
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
                sp.SoundLocation = string.Format(@"{0}\{1}", ApplicationCommon.DirectoryHelper.SoundDirectory, "TimeOut0.wav");
                sp.Play();

                SocketPublic.SocketSend.SendMessage(RefereeConfig.Settings.ONSETTINGS.DISPLAYIPADDRESS, RefereeConfig.Settings.ONSETTINGS.DISPLAYPORT,
                     string.Format("TimeOutHide,{0}", "B"));
                return;
            }
            SocketPublic.SocketSend.SendMessage(RefereeConfig.Settings.ONSETTINGS.DISPLAYIPADDRESS, RefereeConfig.Settings.ONSETTINGS.DISPLAYPORT,
                      string.Format("TimeOut,{0},{1}", "B", timing));
        }

        private void btAddTimeOutA_Click(object sender, EventArgs e)
        {
            TeamATimeOutCount++;
        }

        private void btSubTimeOutA_Click(object sender, EventArgs e)
        {
            TeamATimeOutCount--;
        }

        private void btAddTimeOutB_Click(object sender, EventArgs e)
        {
            TeamBTimeOutCount++;
        }

        private void btSubTimeOutB_Click(object sender, EventArgs e)
        {
            TeamBTimeOutCount--;
        }
        #endregion

        #region 总时间操作
        private void btPauseTotalTime_Click(object sender, EventArgs e)
        {
            tcTotalTime.Stop();
            btStartTotalTime.Enabled = true;
            btPauseTotalTime.Enabled = false;
        }

        private void btStartTotalTime_Click(object sender, EventArgs e)
        {
            tcTotalTime.Start();
            btStartTotalTime.Enabled = false;
            btPauseTotalTime.Enabled = true;
        }

        private void btResetTotalTime_Click(object sender, EventArgs e)
        {
            tcTotalTime.Reset();
            btStartTotalTime.Enabled = true;
            btPauseTotalTime.Enabled = false;
        }

        private void btSettingTotalTime_Click(object sender, EventArgs e)
        {
            tcTotalTime.Setting();
        }

        private void tcTotalTime_TextTimingChanged(string timing)
        {
            SocketPublic.SocketSend.SendMessage(RefereeConfig.Settings.ONSETTINGS.DISPLAYIPADDRESS, RefereeConfig.Settings.ONSETTINGS.DISPLAYPORT,
                string.Format("TotalTime,{0}", timing));
            if (RefereeConfig.Settings.ONSETTINGS.BTOTALTIME)
                SendToVrs();
        }

        private void tcTotalTime_TimeChanging(int ltime, DateTime dtime)
        {
            //if (ltime == 0)
            //    tcTotalTime.Reset();
        }
        #endregion

        public void SendToVrs()
        {
            if (RefereeConfig.Settings.ONSETTINGS.BTOTALTIME)
            {
                byte[] bs = new byte[7];
                bs[0] = 0xDF;
                bs[1] = byte.Parse(tcTotalTime.Text.Split(':')[0]);
                bs[2] = byte.Parse(tcTotalTime.Text.Split(':')[1]);
                bs[3] = byte.Parse(ScoreA.ToString());
                bs[4] = byte.Parse(ScoreB.ToString());
                bs[5] = byte.Parse(Court.ToString());
                bs[6] = 0xCF;
                SocketPublic.UdpSend.SendMessage(RefereeConfig.Settings.ONSETTINGS.TOTALTIMEIPADDRESS, RefereeConfig.Settings.ONSETTINGS.VRS_TOTALTIMEPORT,
                             bs);
            }
        }

        #region 30秒操作
        private void btThirtyTimeStart_Click(object sender, EventArgs e)
        {
            tcThirtyTime.Start();
            btThirtyTimeStart.Enabled = false;
            btThirtyTimePause.Enabled = true;
        }

        private void btThirtyTimePause_Click(object sender, EventArgs e)
        {
            tcThirtyTime.Stop();
            btThirtyTimeStart.Enabled = true;
            btThirtyTimePause.Enabled = false;
        }

        private void btThirtyTimeReset_Click(object sender, EventArgs e)
        {
            tcThirtyTime.Reset();
            btThirtyTimeStart.Enabled = true;
            btThirtyTimePause.Enabled = false;
        }

        private void btThirtyTimeSetting_Click(object sender, EventArgs e)
        {
            tcThirtyTime.Setting();
        }

        private void tcThirtyTime_TextTimingChanged(string timing)
        {
            #region 20秒
            foreach (AthletesControl ac in tlpTeamA.Controls)
            {
                if (ac.IsStart)
                    ac.TOTALTIME--;
            }
            foreach (AthletesControl ac in tlpTeamB.Controls)
            {
                if (ac.IsStart)
                    ac.TOTALTIME--;
            }
            #endregion

            if (RefereeConfig.Settings.ONSETTINGS.BTIRTYSECONDS)
            {
                byte[] bt = new byte[3];
                bt[0] = 0XEF;
                bt[1] = byte.Parse(timing);
                bt[2] = 0XBF;
                SocketPublic.UdpSend.SendMessage(RefereeConfig.Settings.ONSETTINGS.TIRTYSECONDSIPADDRESS, RefereeConfig.Settings.ONSETTINGS.THIRTYSECONDSPORT,
                   bt);
            }
        }

        private void tcThirtyTime_TimeChanging(int ltime, DateTime dtime)
        {

        }
        #endregion

        #region 暂停操作
        private bool _pause;
        public bool Pause
        {
            get
            {
                return _pause;
            }
            set
            {
                _pause = value;
                if (value)
                {

                }
            }
        }
        #endregion

        #region Delegates
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

        public void EndListening()
        {
            if (TotalCom != null)
                TotalCom.EndListenning();
            if (SecondsCom != null)
                SecondsCom.EndListenning();
        }

        public void WriteLog()
        {
            if (TotalCom != null)
                TotalCom.WriteLogByFinish();
            if (SecondsCom != null)
                SecondsCom.WriteLogByFinish();
        }

        private void btShowTeamA_Click(object sender, EventArgs e)
        {
            //pauseMark = "A";
            //isPauseTime = true;
        }

        private void btShowTeamB_Click(object sender, EventArgs e)
        {
            //pauseMark = "B";
            //isPauseTime = true;
        }

        private void btHideTotalTime_Click(object sender, EventArgs e)
        {
            SocketPublic.SocketSend.SendMessage(RefereeConfig.Settings.ONSETTINGS.DISPLAYIPADDRESS, RefereeConfig.Settings.ONSETTINGS.DISPLAYPORT,
               string.Format("TotalTime,{0}", "Time Out"));
        }
    }
}
