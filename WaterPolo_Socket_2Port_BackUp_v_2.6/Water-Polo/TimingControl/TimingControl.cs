using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace TimingControl
{
    public partial class TimingControl : UserControl
    {
        public TimingControl()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LTime = GetSecond(DateTime.Parse(settingTime)) * 100;
            SetEnable(btStart, true);
            SetEnable(btStop, false);
        }

        #region Attributes
        private string settingTime = "00:00:00";
        /// <summary>
        /// 设置时间
        /// </summary>
        public string SettingTime
        {
            get
            {
                return settingTime;
            }
            set
            {
                settingTime = value;
            }
        }

        private bool _isShowEndTime;
        public bool IsShowEndTime
        {
            get
            {
                return _isShowEndTime;
            }
            set
            {
                _isShowEndTime = value;
            }
        }

        private int _ltime = 0;
        public int LTime
        {
            get
            {
                return _ltime;
            }
            set
            {
                _ltime = value;
                if (value >= 0)
                {
                    string a = GetTime(value);
                    DTime = DateTime.Parse(GetTime(value));
                }
            }
        }
        private DateTime _dtime;
        private DateTime DTime
        {
            get
            {
                return _dtime;
            }
            set
            {
                _dtime = value;
                if (!isAdd && value.Minute == 0 && value.Second < 1 && _isShowEndTime)
                    SetText(lbTime, value.ToString("s.fff"));
                else
                    SetText(lbTime, value.ToString(displayFormat));
            }
        }

        private string displayFormat = "HH:mm:ss fff";
        public string DisplayFormat
        {
            get
            {
                return displayFormat;
            }
            set
            {
                displayFormat = value;
            }
        }

        private bool isAdd = false;
        public bool IsAdd
        {
            get
            {
                return isAdd;
            }
            set
            {
                isAdd = value;
            }
        }

        public bool ShowButtons
        {
            get
            {
                return tlpButtons.Visible;
            }
            set
            {
                tlpButtons.Visible = value;
            }
        }

        public override string Text
        {
            get
            {
                return lbTime.Text;
            }
        }

        #region Timing label attributes
        private Font _timingLabelFont;
        public Font TimingLabelFont
        {
            get
            {
                return _timingLabelFont;
            }
            set
            {
                _timingLabelFont = value;
                lbTime.Font = value;
            }
        }

        private ContentAlignment _timingTextAlign = ContentAlignment.MiddleCenter;
        public ContentAlignment TimingTextAlign
        {
            get
            {
                return _timingTextAlign;
            }
            set
            {
                _timingTextAlign = value;
                lbTime.TextAlign = value;
            }
        }

        private Color _timingForeColor;
        public Color TimingForeColor
        {
            get
            {
                return _timingForeColor;
            }
            set
            {
                _timingForeColor = value;
                lbTime.ForeColor = value;
            }
        }

        private Color _timingBackColor;
        public Color TimingBackColor
        {
            get
            {
                return _timingBackColor;
            }
            set
            {
                _timingBackColor = value;
                lbTime.BackColor = value;
            }
        }
        #endregion
        #endregion

        #region Operation
        Thread th;
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
        bool isReset = false;
        public void Reset()
        {
            isReset = true;
            LTime = GetSecond(DateTime.Parse(settingTime)) * 100;
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
                SetTextCallback d = new SetTextCallback(SetText);
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
                    LTime = GetSecond(DateTime.Parse(settingTime)) * 100;
                    if (th != null)
                        th.Abort();
                    break;
                }
                if (!isAdd && LTime == 0)
                {
                    SetText(lbTime, DTime.ToString(displayFormat));
                    SetEnable(btStart, true);
                    SetEnable(btStop, false);
                    break;
                }
                if (isAdd)
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
                SetEnableCallback d = new SetEnableCallback(SetEnable);
                ctrl.Invoke(d, ctrl, enable);
            }
            else
                ctrl.Enabled = enable;
        }

        #endregion

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
            FrmSetting frm = new FrmSetting(DTime, displayFormat);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LTime = GetSecond(DateTime.Parse(frm.SettingTime)) * 100;
            }
        }

        private void btSetting_Click(object sender, EventArgs e)
        {
            Setting();
        }

        #region Time convert
        public string GetTime(int time)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, time * 10);
            return string.Format("{0}:{1}:{2}.{3}", ts.Hours.ToString().PadLeft(2, '0'), ts.Minutes.ToString().PadLeft(2, '0'),
                ts.Seconds.ToString().PadLeft(2, '0'), ts.Milliseconds.ToString().PadLeft(2, '0'));
        }

        public int GetSecond(DateTime dt)
        {
            int second = 0;
            second = dt.Second + dt.Minute * 60 + dt.Hour * 3600;
            return second;
        }
        #endregion

        public delegate void TextTimingChangedCallback(string timing);
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
            if (Started != null)
                Started();

            #region 时间
            if (TimeChangingExtend != null)
                TimeChangingExtend(this, _ltime, _dtime);
            if (TimeChanging != null)
                TimeChanging(_ltime, _dtime);
            if (isReset)
            {
                isReset = false;
                LTime = GetSecond(DateTime.Parse(settingTime)) * 100;
                timeCount.Enabled = false;
            }
            if (!isAdd && LTime <= 0)
            {
                SetText(lbTime, DTime.ToString(displayFormat));
                SetEnable(btStart, true);
                SetEnable(btStop, false);
                timeCount.Enabled = false;
            }
            if (isAdd)
                LTime += 11;
            else
                LTime -= 11;
            #endregion
        }
    }
}
