using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace RefereeConsole
{
    public partial class AthletesControl : UserControl
    {
        public AthletesControl()
        {
            InitializeComponent();
        }

        public AthletesControl(DataRow dr, string mark)
        {
            InitializeComponent();
            MARK = mark;
            NUMBER = int.Parse(dr["NUM"].ToString());
            NAME = dr["Name"].ToString();
        }

        #region Attributes

        private int _Number;
        /// <summary>
        /// Number
        /// </summary>
        public int NUMBER
        {
            get { return _Number; }
            set
            {
                _Number = value;
                SetControlText(lbNumber, value.ToString());
            }
        }

        private String _Name;
        /// <summary>
        /// Name
        /// </summary>
        public String NAME
        {
            get { return _Name; }
            set
            {
                _Name = value;
                SetControlText(lbName, value);
            }
        }

        private String _Mark;
        /// <summary>
        /// Mark
        /// </summary>
        public String MARK
        {
            get { return _Mark; }
            set { _Mark = value; }
        }

        private int _OrderID;
        /// <summary>
        /// OrderID
        /// </summary>
        public int ORDERID
        {
            get { return _OrderID; }
            set { _OrderID = value; }
        }

        public delegate void TimeOverCallback(AthletesControl ac);
        public event TimeOverCallback TimeOver;
        private int _TotalTime = 20;
        /// <summary>
        /// TotalTime
        /// </summary>
        public int TOTALTIME
        {
            get { return _TotalTime; }
            set
            {
                string str = "";
                if (value <= 0)
                {
                    #region 停止
                    IsStart = false;

                    #region 发送到VRS停止信息
                    if (TimeOver != null)
                        TimeOver(this);
                    #endregion

                    #region 以后优化
                    SetControlText(lbTwentyTime, str);
                    SocketPublic.SocketSend.SendMessage(RefereeConfig.Settings.ONSETTINGS.DISPLAYIPADDRESS, RefereeConfig.Settings.ONSETTINGS.DISPLAYPORT,
                    string.Format("TwentyTime,{0},{1},{2}", MARK, NUMBER, str));
                    #endregion

                    SetControlEnabled(btStart, true);
                    SetControlEnabled(btCancel, false);
                    Stop();
                    #endregion
                }
                else
                {
                    _TotalTime = value;
                    str = value.ToString();
                    #region VRS
                    if (RefereeConfig.Settings.ONSETTINGS.BTWENTYSECONDS)
                    {
                        byte bMark = new byte();
                        if (MARK == "A")
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
                        bs[2] = byte.Parse(NUMBER.ToString());
                        bs[3] = byte.Parse(ORDERID.ToString());
                        bs[4] = byte.Parse(_TotalTime.ToString());
                        bs[5] = 0xAF;

                        SocketPublic.UdpSend.SendMessage(RefereeConfig.Settings.ONSETTINGS.TWENTYSECONDSIPADDRESS,
                            RefereeConfig.Settings.ONSETTINGS.TWENTYSECONDSPORT, bs);
                    }
                    #endregion
                }
                SetControlText(lbTwentyTime, str);

                //发送信息到显示控制台
                SocketPublic.SocketSend.SendMessage(RefereeConfig.Settings.ONSETTINGS.DISPLAYIPADDRESS, RefereeConfig.Settings.ONSETTINGS.DISPLAYPORT,
                    string.Format("TwentyTime,{0},{1},{2}", MARK, NUMBER, str));


            }
        }

        #region Fouls
        private int _Fouls;
        /// <summary>
        /// 犯规
        /// </summary>
        public int FOULS
        {
            get { return _Fouls; }
            set
            {
                if (value <= 2 && value >= 0)
                {
                    _Fouls = value;
                    SetControlText(lbFoulsCount, value.ToString());
                    //发送信息到显示控制台和主控台
                    SocketPublic.SocketSend.SendMessage(RefereeConfig.Settings.ONSETTINGS.MAJORIPADDRESS, RefereeConfig.Settings.ONSETTINGS.MAJORPORT,
                        string.Format("Foul,{0},{1},{2}", MARK, NUMBER, value));
                    SocketPublic.SocketSend.SendMessage(RefereeConfig.Settings.ONSETTINGS.DISPLAYIPADDRESS, RefereeConfig.Settings.ONSETTINGS.DISPLAYPORT,
                        string.Format("Foul,{0},{1},{2}", MARK, NUMBER, value));
                }
            }
        }

        private int _Serious;
        /// <summary>
        /// 严重犯规
        /// </summary>
        public int SERIOUS
        {
            get { return _Serious; }
            set
            {
                _Serious = value;

                //发送信息到显示控制台和主控台
                SocketPublic.SocketSend.SendMessage(RefereeConfig.Settings.ONSETTINGS.MAJORIPADDRESS, RefereeConfig.Settings.ONSETTINGS.MAJORPORT,
                    string.Format("Serious,{0},{1},{2}", MARK, NUMBER, value));
                SocketPublic.SocketSend.SendMessage(RefereeConfig.Settings.ONSETTINGS.DISPLAYIPADDRESS, RefereeConfig.Settings.ONSETTINGS.DISPLAYPORT,
                    string.Format("Serious,{0},{1},{2}", MARK, NUMBER, value));
            }
        }
        #endregion

        private bool _isStart;
        public bool IsStart
        {
            get
            {
                return _isStart;
            }
            set
            {
                _isStart = value;
            }
        }
        #endregion

        Thread th;
        public void Start()
        {
            th = new Thread(StartByTread);
            th.IsBackground = true;
            th.Start();
        }

        public void Stop()
        {
            if (th != null)
                th.Abort();
        }

        public void StartByTread()
        {
            while (true)
            {
                TOTALTIME--;
                Thread.Sleep(1000);
            }
        }

        public delegate void StartTwentyTimeCallback(AthletesControl ac);
        public event StartTwentyTimeCallback StartTwentyTime;
        private void btStart_Click(object sender, EventArgs e)
        {
            IsStart = true;
            TOTALTIME = 20;
            if (StartTwentyTime != null)
                StartTwentyTime(this);
            SetControlEnabled(btStart, false);
            SetControlEnabled(btCancel, true);
        }

        private void btSubFoul_Click(object sender, EventArgs e)
        {
            FOULS--;
        }

        private void btAddFoul_Click(object sender, EventArgs e)
        {
            FOULS++;
            IsStart = true;
            TOTALTIME = 20;
            if (StartTwentyTime != null)
                StartTwentyTime(this);
            SetControlEnabled(btStart, false);
            SetControlEnabled(btCancel, true);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            IsStart = false;
            TOTALTIME = 0;
        }

        private void cbSerious_CheckedChanged(object sender, EventArgs e)
        {
            int serious = int.Parse(cbSerious.EditValue.ToString());
            SERIOUS = serious;
        }

        #region Delegates
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            TOTALTIME--;
        }

        private void lbTwentyTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void btAddTime_Click(object sender, EventArgs e)
        {
            if (TOTALTIME < 20)
                TOTALTIME++;
        }

        private void btSubTime_Click(object sender, EventArgs e)
        {
            if (TOTALTIME > 0)
                TOTALTIME--;
        }
    }
}
