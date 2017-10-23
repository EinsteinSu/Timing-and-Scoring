using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RefereeConsole
{
    public class TwentyTime
    {
        public TwentyTime()
        {

        }

        private int _Number;
        /// <summary>
        /// Number
        /// </summary>
        public int NUMBER
        {
            get { return _Number; }
            set { _Number = value; }
        }

        private Timer _TimingControl;
        /// <summary>
        /// TimingControl
        /// </summary>
        public Timer TIMINGCONTROL
        {
            get { return _TimingControl; }
            set { _TimingControl = value; }
        }

        private int _TotalTime;
        /// <summary>
        /// TotalTime
        /// </summary>
        public int TOTALTIME
        {
            get { return _TotalTime; }
            set { _TotalTime = value; }
        }

        private int _RowIndex;
        /// <summary>
        /// RowIndex
        /// </summary>
        public int ROWINDEX
        {
            get { return _RowIndex; }
            set { _RowIndex = value; }
        }

        public void CancelDisplay()
        {
            if (_TimingControl != null)
            {
                _TimingControl.Stop();
                _TimingControl.Dispose();
            }
            //send to display console

        }
    }
}
