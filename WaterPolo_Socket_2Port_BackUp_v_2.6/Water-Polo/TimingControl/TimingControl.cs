using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace TimingControl
{
    public partial class TimingControl : UserControl
    {
        public delegate void TextTimingChangedCallback(string timing);

        public TimingControl()
        {
            InitializeComponent();

        }

        public bool IsInitial => _isInitial;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _isInitial = true;
            lbTime.Text = string.Empty;
            _isInitial = false;
            LTime = GetSecond(DateTime.Parse(SettingTime)) * 100;
            SetEnable(btStart, true);
            SetEnable(btStop, false);
        }

        public void HideButton()
        {
            btReset.Visible = btSetting.Visible = false;
        }

        public void ShowButton()
        {
            btStart.Visible = btStop.Visible = btReset.Visible = btSetting.Visible = true;
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        public void Setting()
        {
            var frm = new FrmSetting(DTime, DisplayFormat);
            if (frm.ShowDialog() == DialogResult.OK)
                LTime = GetSecond(DateTime.Parse(frm.SettingTime)) * 100;
        }

        private void btSetting_Click(object sender, EventArgs e)
        {
            Setting();
        }

        public event TextTimingChangedCallback TextTimingChanged;

        private void lbTime_TextChanged(object sender, EventArgs e)
        {
            if (TextTimingChanged != null)
                TextTimingChanged(lbTime.Text);
        }

        private void timeCount_Tick(object sender, EventArgs e)
        {
            isReset = false;
            SetEnable(btStart, false);
            SetEnable(btStop, true);
            Started?.Invoke();

            #region 时间

            TimeChangingExtend?.Invoke(this, _ltime, _dtime);
            TimeChanging?.Invoke(_ltime, _dtime);
            if (isReset)
            {
                isReset = false;
                LTime = GetSecond(DateTime.Parse(SettingTime)) * 100;
                timeCount.Enabled = false;
            }
            if (!IsAdd && LTime <= 0)
            {
                SetText(lbTime, DTime.ToString(DisplayFormat));
                SetEnable(btStart, true);
                SetEnable(btStop, false);
                timeCount.Enabled = false;
            }
            if (IsAdd)
                LTime += 11;
            else
                LTime -= 11;

            #endregion
        }

        #region Attributes

        /// <summary>
        ///     设置时间
        /// </summary>
        public string SettingTime { get; set; } = "00:00:00";

        public bool IsShowEndTime { get; set; }

        private int _ltime;

        public int LTime
        {
            get => _ltime;
            set
            {
                _ltime = value;
                if (value >= 0)
                {
                    DTime = DateTime.Parse(GetTime(value));
                }
            }
        }

        private DateTime _dtime;

        private DateTime DTime
        {
            get => _dtime;
            set
            {
                _dtime = value;
                //if (!IsAdd && value.Minute == 0 && value.Second < 1 && IsShowEndTime)
                //{
                //    SetText(lbTime, value.ToString("s.fff"));
                //}
                //else
                //{
                SetText(lbTime, value.ToString(DisplayFormat));
                //}
            }
        }

        public string DisplayFormat { get; set; } = "mm:ss";

        public bool IsAdd { get; set; } = false;

        public bool ShowButtons
        {
            get => tlpButtons.Visible;
            set => tlpButtons.Visible = value;
        }

        public override string Text => lbTime.Text;

        #region Timing label attributes

        private Font _timingLabelFont;

        public Font TimingLabelFont
        {
            get => _timingLabelFont;
            set
            {
                _timingLabelFont = value;
                lbTime.Font = value;
            }
        }

        private ContentAlignment _timingTextAlign = ContentAlignment.MiddleCenter;

        public ContentAlignment TimingTextAlign
        {
            get => _timingTextAlign;
            set
            {
                _timingTextAlign = value;
                lbTime.TextAlign = value;
            }
        }

        private Color _timingForeColor;

        public Color TimingForeColor
        {
            get => _timingForeColor;
            set
            {
                _timingForeColor = value;
                lbTime.ForeColor = value;
            }
        }

        private Color _timingBackColor;

        public Color TimingBackColor
        {
            get => _timingBackColor;
            set
            {
                _timingBackColor = value;
                lbTime.BackColor = value;
            }
        }

        #endregion

        #endregion

        #region Operation

        private Thread th;

        public delegate void StartedCallback();

        public event StartedCallback Started;

        public void Start()
        {
            timeCount.Enabled = true;
            isReset = false;
            SetEnable(btStart, false);
            SetEnable(btStop, true);
            if (Started != null)
                Started();
        }

        public delegate void StopedCallback();

        public event StopedCallback Stoped;

        public void Stop()
        {
            //if (th != null)
            //    th.Abort();
            timeCount.Enabled = false;
            SetEnable(btStart, true);
            SetEnable(btStop, false);
            if (Stoped != null)
                Stoped();
        }

        public delegate void ResetedCallback();

        public event ResetedCallback Reseted;
        private bool isReset;
        private bool _isInitial;

        public void Reset()
        {
            isReset = true;
            LTime = GetSecond(DateTime.Parse(SettingTime)) * 100;
            SetEnable(btStart, true);
            SetEnable(btStop, false);
            timeCount.Enabled = false;
            if (Reseted != null)
                Reseted();
        }

        #endregion

        #region Thread method

        public delegate void SetTextCallback(Control ctrl, string text);

        public void SetText(Control ctrl, string text)
        {
            if (ctrl.InvokeRequired)
            {
                SetTextCallback d = SetText;
                ctrl.Invoke(d, ctrl, text);
            }
            else
            {
                ctrl.Text = text;
            }
        }

        public delegate void TimeChangingCallback(int ltime, DateTime dtime);

        public event TimeChangingCallback TimeChanging;

        public delegate void TimeChangingExtendCallback(object sender, int ltime, DateTime dtime);

        public event TimeChangingExtendCallback TimeChangingExtend;

        public void StartByThread()
        {
            while (true)
            {
                if (TimeChangingExtend != null)
                    TimeChangingExtend(this, _ltime, _dtime);
                if (TimeChanging != null)
                    TimeChanging(_ltime, _dtime);
                if (isReset)
                {
                    isReset = false;
                    LTime = GetSecond(DateTime.Parse(SettingTime)) * 100;
                    if (th != null)
                        th.Abort();
                    break;
                }
                if (!IsAdd && LTime == 0)
                {
                    SetText(lbTime, DTime.ToString(DisplayFormat));
                    SetEnable(btStart, true);
                    SetEnable(btStop, false);
                    break;
                }
                if (IsAdd)
                    LTime += 1;
                else
                    LTime -= 1;
                Thread.Sleep(10);
            }
        }

        public delegate void SetEnableCallback(Control ctrl, bool enable);

        public void SetEnable(Control ctrl, bool enable)
        {
            if (ctrl.InvokeRequired)
            {
                SetEnableCallback d = SetEnable;
                ctrl.Invoke(d, ctrl, enable);
            }
            else
            {
                ctrl.Enabled = enable;
            }
        }

        #endregion

        #region Time convert

        public string GetTime(int time)
        {
            var ts = new TimeSpan(0, 0, 0, 0, time * 10);
            return
                $"{ts.Hours.ToString().PadLeft(2, '0')}:{ts.Minutes.ToString().PadLeft(2, '0')}:{ts.Seconds.ToString().PadLeft(2, '0')}.{ts.Milliseconds.ToString().PadLeft(2, '0')}";
        }

        //todo: check wheather a method can solve this problem well
        public int GetSecond(DateTime dt)
        {
            return dt.Second + dt.Minute * 60 + dt.Hour * 3600;
        }

        #endregion
    }
}