using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using ApplicationCommon;
using Common;
using ComPublic;
using DevExpress.XtraGrid;
using log4net;
using RefereeConfig;
using SocketPublic;
using WaterPolo.Common;

namespace RefereeConsole
{
    public partial class MatchControlExtend : UserControl
    {
        private static readonly ILog Log = LogManager.GetLogger("MatchControlExtend");
        private readonly ComListening _secondsCom;
        private readonly ComListening _totalCom;
        private string _scheduleGuid;
        private ScheduleOperate _s;
        private readonly ThirtySecondsProcess _thirtySecondsProcess = new ThirtySecondsProcess();
        public MatchControlExtend()
        {
            InitializeComponent();

            #region 总计时

            try
            {
                Log.Info($"Start listen serial device for display total time {Settings.ONSETTINGS.TOTALTIMEPORT}({Settings.ONSETTINGS.TOTALBIT}) Header{Settings.ONSETTINGS.TOTALHEADER} Tail{Settings.ONSETTINGS.TOTALTAIL}");
                _totalCom = new ComListening(Settings.ONSETTINGS.TOTALTIMEPORT, Settings.ONSETTINGS.TOTALBIT)
                {
                    Header = Settings.ONSETTINGS.TOTALHEADER,
                    Tail = Settings.ONSETTINGS.TOTALTAIL
                };
                if (_totalCom.Open())
                {
                    _totalCom.StartListening();

                    _totalCom.DataChanging += delegate (List<string> msg)
                    {
                        var isAdd = false;
                        var timeoutA = 0;
                        var timeoutB = 0;
                        var process = new TotalTimeProcess(isAdd, timeoutA, timeoutB);
                        var data = process.Process(msg);
                        tcTotalTime.LTime = data.TotalTime;
                    };
                }
            }
            catch (Exception ex)
            {
                Log.Error($"Could not listen this serial device. {ex.Message}");
            }

            #endregion

            #region 30秒

            try
            {
                Log.Info($"Start listen serial device for display total time {Settings.ONSETTINGS.SECONDSTIMEPORT}({Settings.ONSETTINGS.SECONDSBIT}) Header{Settings.ONSETTINGS.SECONDSHEADER} Tail{Settings.ONSETTINGS.SECONDSTAIL}");
                _secondsCom =
                    new ComListening(Settings.ONSETTINGS.SECONDSTIMEPORT, Settings.ONSETTINGS.SECONDSBIT)
                    {
                        Header = Settings.ONSETTINGS.SECONDSHEADER,
                        Tail = Settings.ONSETTINGS.SECONDSTAIL
                    };
                if (_secondsCom.Open())
                {
                    _secondsCom.StartListening();
                    _secondsCom.DataChanging += delegate (List<string> msg)
                    {
                        //display 30 seconds
                        var data = _thirtySecondsProcess.Process(msg);
                        tcThirtyTime.LTime = data.Seconds;
                        _isStopped = data.IsStopped;

                    };
                }
            }
            catch (Exception ex)
            {
                Log.Error($"Could not listen this serial device. {ex.Message}");
            }

            #endregion

            tcTotalTime_TextTimingChanged(tcTotalTime.SettingTime.ToDateTime().ToString(tcTotalTime.DisplayFormat));
            tcThirtyTime_TextTimingChanged("30");
        }

        ~MatchControlExtend()
        {
            EndListening();
        }

        public string ScheduleGuid
        {
            get => _scheduleGuid;
            set
            {
                _scheduleGuid = value;

                ClearAthletes();
                //发送信息到显示控制台
                SocketSend.SendMessage(Settings.ONSETTINGS.DISPLAYIPADDRESS, Settings.ONSETTINGS.DISPLAYPORT,
                    $"ScheduleLoad,{value}");

                _s = new ScheduleOperate(value);
                SetControlText(lbTeamA, $"{_s.GetTeam(ScheduleOperate.TeamType.Host).SHORTNAME}   ({_s.OnSchedule.TEAMACOLOR})");
                SetControlText(lbTeamB, $"{_s.GetTeam(ScheduleOperate.TeamType.Guest).SHORTNAME}   ({_s.OnSchedule.TEAMBCOLOR})");
                CreateAthletes(CreateTable(_s.GetTeamTable(ScheduleOperate.TeamType.Host)), "A");
                CreateAthletes(CreateTable(_s.GetTeamTable(ScheduleOperate.TeamType.Guest)), "B");

                Court = 1;
                ScoreA = 0;
                ScoreB = 0;
                TeamATimeOutCount = 0;
                TeamBTimeOutCount = 0;
                tcTimeOutA.Refresh();
                tcTimeOutB.Refresh();
            }
        }

        public void SendToVrs()
        {
            if (Settings.ONSETTINGS.BTOTALTIME)
            {
                var bs = new byte[7];
                bs[0] = 0xDF;
                bs[1] = byte.Parse(tcTotalTime.Text.Split(':')[0]);
                bs[2] = byte.Parse(tcTotalTime.Text.Split(':')[1]);
                bs[3] = byte.Parse(ScoreA.ToString());
                bs[4] = byte.Parse(ScoreB.ToString());
                bs[5] = byte.Parse(Court.ToString());
                bs[6] = 0xCF;
                UdpSend.SendMessage(Settings.ONSETTINGS.TOTALTIMEIPADDRESS, Settings.ONSETTINGS.VRS_TOTALTIMEPORT,
                    bs);
            }
        }

        private void EndListening()
        {
            _totalCom?.EndListenning();
            _secondsCom?.EndListenning();
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
            SocketSend.SendMessage(Settings.ONSETTINGS.DISPLAYIPADDRESS, Settings.ONSETTINGS.DISPLAYPORT,
                string.Format("TotalTime,{0}", "Time Out"));
        }

        #region 总计时和30秒

        private bool _isAdd;
        private bool _isStopped;

        /// <summary>
        ///     总计时
        /// </summary>
        /// <param name="msg"></param>
        private void Original_ProcessTotalTimeFromSerialCom(List<string> msg)
        {
            if (msg.Count <= 5)
            {
                return;
            }
            _isStopped = msg[2].Contains("FA");
            if (msg[5].IndexOf("E", StringComparison.Ordinal) >= 0 && cbCourt.Checked)
                if (IsNumeric(msg[5].Replace("E", "")))
                    Court = msg[5].Replace("E", "").ToInt();
            if (msg[5].IndexOf("C", StringComparison.Ordinal) >= 0 && IsNumeric(msg[5].Replace("C", "")))
            {
                if (!_isAdd)
                {
                    TeamATimeOutCount++;
                    _isAdd = true;
                }
                if (IsNumeric(msg[0]) && IsNumeric(msg[1]))
                {
                    var time = $"00:{msg[0]}:{msg[1]}";
                    tcTimeOutA.LTime = tcTimeOutA.GetSecond(time.ToDateTime()) * 100;
                }
            }
            if (msg[5].IndexOf("D", StringComparison.Ordinal) >= 0 && IsNumeric(msg[5].Replace("D", "")))
            {
                if (!_isAdd)
                {
                    TeamBTimeOutCount++;
                    _isAdd = true;
                }
                if (IsNumeric(msg[0]) && IsNumeric(msg[1]))
                {
                    var time = $"00:{msg[0]}:{msg[1]}";
                    tcTimeOutB.LTime = tcTimeOutB.GetSecond(time.ToDateTime()) * 100;
                }
            }
            else
            {
                if (IsNumeric(msg[5]) && cbCourt.Checked)
                    Court = msg[5].ToInt();
            }
            if (IsNumeric(msg[0]) && IsNumeric(msg[1]) && msg[5].IndexOf("C", StringComparison.Ordinal) < 0 &&
                msg[5].IndexOf("D", StringComparison.Ordinal) < 0)
            {
                _isAdd = false;
                var time = $"00:{msg[0]}:{msg[1]}";
                tcTotalTime.LTime = tcTotalTime.GetSecond(time.ToDateTime()) * 100;
            }
            if (IsNumeric(msg[3]) && cbScore.Checked)
                ScoreA = msg[3].ToInt();
            if (IsNumeric(msg[4]) && cbScore.Checked)
                ScoreB = msg[4].ToInt();
        }

        public static bool IsNumeric(string str)
        {
            if (str.Length == 0)
                return false;
            var ch = new char[str.Length];
            ch = str.ToCharArray();
            foreach (char t in ch)
                if (t < 48 || t > 57)
                    return false;
            return true;
        }

        #endregion

        #region 创建临时表

        public void ClearAthletes()
        {
            foreach (Control ctrl in tlpTeamA.Controls)
            {
                var a = ctrl as AthletesControl;
                if (a != null)
                {
                    a.StartTwentyTime -= ac_StartTwentyTime;
                    a.TimeOver -= ac_TimeOver;
                }
            }

            foreach (Control ctrl in tlpTeamB.Controls)
            {
                var a = ctrl as AthletesControl;
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
            var row = 0;

            foreach (DataRow dr in dt.Rows)
            {
                var ac = new AthletesControl(dr, mark);
                TableLayoutPanelAddControl(tlp, ac, 0, row);
                SetControlDock(ac, DockStyle.Fill);
                ac.StartTwentyTime += ac_StartTwentyTime;
                ac.TimeOver += ac_TimeOver;
                row++;
            }
        }

        private void ac_TimeOver(AthletesControl ac)
        {
            var tlp = ac.MARK == "A" ? tlpTeamA : tlpTeamB;

            #region 获取排序

            var num = 1;
            var lst = new List<AthletesControl>();
            var lstUn = new List<AthletesControl>();
            foreach (Control ctrl in tlp.Controls)
            {
                var a = ctrl as AthletesControl;
                if (a != null)
                    if (a.IsStart)
                        lst.Add(a);
                    else
                        lstUn.Add(a);
            }

            var c = from data in lst
                    orderby data.ORDERID
                    select data;
            foreach (var actrl in c)
            {
                actrl.ORDERID = num;
                num++;
            }

            #endregion

            #region

            var lstbs = new List<byte[]>();
            foreach (var a in lst)
            {
                var bMark = new byte();
                if (a.MARK == "A")
                    bMark = 0x00;
                else
                    bMark = 0x01;
                var bs = new byte[6];
                bs[0] = 0xFF;
                bs[1] = bMark;
                bs[2] = byte.Parse(a.NUMBER.ToString());
                bs[3] = byte.Parse(a.ORDERID.ToString());
                bs[4] = byte.Parse(a.TOTALTIME.ToString());
                bs[5] = 0xAF;
                lstbs.Add(bs);
            }

            foreach (var a in lstUn)
            {
                var bMark = new byte();
                if (a.MARK == "A")
                    bMark = 0x00;
                else
                    bMark = 0x01;
                var bs = new byte[6];
                bs[0] = 0xFF;
                bs[1] = bMark;
                bs[2] = byte.Parse(a.NUMBER.ToString());
                bs[3] = byte.Parse(num.ToString());
                bs[4] = 0x00;
                bs[5] = 0xAF;
                lstbs.Add(bs);
                num++;
            }

            var bts = new byte[13 * 7];
            var k = 0;
            foreach (var b in lstbs)
                foreach (var bcs in b)
                {
                    bts[k] = bcs;
                    k++;
                }
            if (Settings.ONSETTINGS.BTWENTYSECONDS)
                UdpSend.SendMessage(Settings.ONSETTINGS.TWENTYSECONDSIPADDRESS,
                    Settings.ONSETTINGS.TWENTYSECONDSPORT, bts);

            #endregion
        }

        private void ac_StartTwentyTime(AthletesControl ac)
        {
            TableLayoutPanel tlp;
            if (ac.MARK == "A")
                tlp = tlpTeamA;
            else
                tlp = tlpTeamB;
            var num = 0;
            foreach (Control ctrl in tlp.Controls)
            {
                var a = ctrl as AthletesControl;
                if (a != null && a.IsStart)
                    num++;
            }
            ac.ORDERID = num;

            #region 获取排序

            num = 1;
            var lst = new List<AthletesControl>();
            var lstUn = new List<AthletesControl>();
            foreach (Control ctrl in tlp.Controls)
            {
                var a = ctrl as AthletesControl;
                if (a != null)
                    if (a.IsStart)
                        lst.Add(a);
                    else
                        lstUn.Add(a);
            }

            var c = from data in lst
                    orderby data.ORDERID
                    select data;
            foreach (var actrl in c)
            {
                actrl.ORDERID = num;
                num++;
            }

            #endregion

            #region

            var lstbs = new List<byte[]>();
            foreach (var a in lst)
            {
                var bMark = new byte();
                if (a.MARK == "A")
                    bMark = 0x00;
                else
                    bMark = 0x01;
                var bs = new byte[6];
                bs[0] = 0xFF;
                bs[1] = bMark;
                bs[2] = byte.Parse(a.NUMBER.ToString());
                bs[3] = byte.Parse(a.ORDERID.ToString());
                bs[4] = byte.Parse(a.TOTALTIME.ToString());
                bs[5] = 0xAF;
                lstbs.Add(bs);
            }

            foreach (var a in lstUn)
            {
                var bMark = new byte();
                if (a.MARK == "A")
                    bMark = 0x00;
                else
                    bMark = 0x01;
                var bs = new byte[6];
                bs[0] = 0xFF;
                bs[1] = bMark;
                bs[2] = byte.Parse(a.NUMBER.ToString());
                bs[3] = byte.Parse(num.ToString());
                bs[4] = 0x00;
                bs[5] = 0xAF;
                lstbs.Add(bs);
                num++;
            }

            var bts = new byte[13 * 7];
            var k = 0;
            foreach (var b in lstbs)
                foreach (var bcs in b)
                {
                    bts[k] = bcs;
                    k++;
                }
            if (Settings.ONSETTINGS.BTWENTYSECONDS)
                UdpSend.SendMessage(Settings.ONSETTINGS.TWENTYSECONDSIPADDRESS,
                    Settings.ONSETTINGS.TWENTYSECONDSPORT, bts);

            #endregion
        }

        public DataTable CreateTable(DataTable dt)
        {
            var dtTeam = new DataTable();
            dtTeam.Columns.Add("NUM", typeof(int));
            dtTeam.Columns.Add("NAME", typeof(string));
            dtTeam.Columns.Add("FOULS", typeof(int));
            dtTeam.Columns.Add("SERIOUS", typeof(int));
            dtTeam.Columns.Add("TTIME", typeof(string));
            foreach (DataRow dr in dt.Rows)
            {
                var drn = dtTeam.NewRow();
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
            get => _scoreA;
            set
            {
                if (value >= 0)
                {
                    _scoreA = value;
                    SetControlText(lbScoreA, value.ToString());
                    //发送信息到显示控制台和主控台

                    SocketSend.SendMessage(Settings.ONSETTINGS.DISPLAYIPADDRESS, Settings.ONSETTINGS.DISPLAYPORT,
                        string.Format("Score,{0},{1}", "A", value));
                    SendToVrs();
                }
            }
        }

        private int _scoreB;

        public int ScoreB
        {
            get => _scoreB;
            set
            {
                if (value >= 0)
                {
                    _scoreB = value;
                    SetControlText(lbScoreB, value.ToString());
                    //发送信息到显示控制台和主控台

                    SocketSend.SendMessage(Settings.ONSETTINGS.DISPLAYIPADDRESS, Settings.ONSETTINGS.DISPLAYPORT,
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
            get => _court;
            set
            {
                if (value > 0)
                {
                    _court = value;
                    var court = string.Empty;
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

                    SocketSend.SendMessage(Settings.ONSETTINGS.DISPLAYIPADDRESS, Settings.ONSETTINGS.DISPLAYPORT,
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
            get => _teamATimeOutCount;
            set
            {
                _teamATimeOutCount = value;
                SetControlText(lbTimeOutA, value.ToString());
                //send to display console
                SocketSend.SendMessage(Settings.ONSETTINGS.DISPLAYIPADDRESS, Settings.ONSETTINGS.DISPLAYPORT,
                    string.Format("TimeOutCount,{0},{1}", value, TeamBTimeOutCount));

            }
        }

        private int _teamBTimeOutCount;

        public int TeamBTimeOutCount
        {
            get => _teamBTimeOutCount;
            set
            {
                _teamBTimeOutCount = value;
                SetControlText(lbTimeOutB, value.ToString());
                //send to display console
                SocketSend.SendMessage(Settings.ONSETTINGS.DISPLAYIPADDRESS, Settings.ONSETTINGS.DISPLAYPORT,
                    string.Format("TimeOutCount,{0},{1}", TeamATimeOutCount, value));

            }
        }

        private void btHideTimeOutA_Click(object sender, EventArgs e)
        {
            tcTimeOutA.Stop();
            tcTimeOutA.Reset();
            SocketSend.SendMessage(Settings.ONSETTINGS.DISPLAYIPADDRESS, Settings.ONSETTINGS.DISPLAYPORT,
                string.Format("TimeOutHide,{0}", "A"));

        }

        private void btHideTimeOutB_Click(object sender, EventArgs e)
        {
            tcTimeOutB.Stop();
            tcTimeOutB.Reset();
            SocketSend.SendMessage(Settings.ONSETTINGS.DISPLAYIPADDRESS, Settings.ONSETTINGS.DISPLAYPORT,
                string.Format("TimeOutHide,{0}", "B"));

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
            var ltime = tcTimeOutA.GetSecond(("00:" + timing).ToDateTime());
            if (ltime == 15)
            {
                var sp = new SoundPlayer();
                sp.SoundLocation = string.Format(@"{0}\{1}", DirectoryHelper.SoundDirectory, "TimeOut15.wav");
                sp.Play();
            }
            if (ltime == 0 && !tcTimeOutA.IsInitial)
            {
                var sp = new SoundPlayer { SoundLocation = $@"{DirectoryHelper.SoundDirectory}\{"TimeOut0.wav"}" };
                sp.Play();

                SocketSend.SendMessage(Settings.ONSETTINGS.DISPLAYIPADDRESS, Settings.ONSETTINGS.DISPLAYPORT,
                    string.Format("TimeOutHide,{0}", "A"));

                return;
            }
            SocketSend.SendMessage(Settings.ONSETTINGS.DISPLAYIPADDRESS, Settings.ONSETTINGS.DISPLAYPORT,
                string.Format("TimeOut,{0},{1}", "A", timing));

        }

        private void tcTimeOutB_TextTimingChanged(string timing)
        {
            var ltime = tcTimeOutB.GetSecond(("00:" + timing).ToDateTime());
            if (ltime == 15)
            {
                var sp = new SoundPlayer { SoundLocation = $@"{DirectoryHelper.SoundDirectory}\{"TimeOut15.wav"}" };
                sp.Play();
            }
            if (ltime == 0 && !tcTimeOutB.IsInitial)
            {
                //显示回总时间
                var sp = new SoundPlayer { SoundLocation = $@"{DirectoryHelper.SoundDirectory}\{"TimeOut0.wav"}" };
                sp.Play();

                SocketSend.SendMessage(Settings.ONSETTINGS.DISPLAYIPADDRESS, Settings.ONSETTINGS.DISPLAYPORT,
                    "TimeOutHide,B");

                return;
            }
            SocketSend.SendMessage(Settings.ONSETTINGS.DISPLAYIPADDRESS, Settings.ONSETTINGS.DISPLAYPORT,
                $"TimeOut,B,{timing}");

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



            SocketSend.SendMessage(Settings.ONSETTINGS.DISPLAYIPADDRESS, Settings.ONSETTINGS.DISPLAYPORT,
                string.Format("TotalTime,{0}", timing));

            if (Settings.ONSETTINGS.BTOTALTIME)
                SendToVrs();
        }

        private void tcTotalTime_TimeChanging(int ltime, DateTime dtime)
        {
            //if (ltime == 0)
            //    tcTotalTime.Reset();
        }

        #endregion

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

        //if you want to associate with total time, you should add this logical in total time changing method
        private void tcThirtyTime_TextTimingChanged(string timing)
        {
            #region 20秒

            if (!_isStopped)
            {
                foreach (AthletesControl ac in tlpTeamA.Controls)
                {
                    if (ac.IsStart)
                    {
                        ac.TOTALTIME--;
                    }
                }
                foreach (AthletesControl ac in tlpTeamB.Controls)
                {
                    if (ac.IsStart)
                    {
                        ac.TOTALTIME--;
                    }
                }
            }


            #endregion
            if (Settings.ONSETTINGS.BTIRTYSECONDS)
            {
                var bt = new byte[3];
                bt[0] = 0XEF;
                bt[1] = byte.Parse(timing);
                bt[2] = 0XBF;
                UdpSend.SendMessage(Settings.ONSETTINGS.TIRTYSECONDSIPADDRESS, Settings.ONSETTINGS.THIRTYSECONDSPORT,
                    bt);
            }
        }

        private void tcThirtyTime_TimeChanging(int ltime, DateTime dtime)
        {
        }

        #endregion

        #region Delegates

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