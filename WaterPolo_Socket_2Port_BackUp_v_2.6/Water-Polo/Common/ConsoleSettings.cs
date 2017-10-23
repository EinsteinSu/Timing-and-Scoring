using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class ConsoleSettings : ApplicationCommon.IXmlHelper
    {
        private string _ControlCenterIPAddress;
        /// <summary>
        /// 中控IP地址
        /// </summary>
        public string CONTROLCENTERIPADDRESS
        {
            get { return _ControlCenterIPAddress; }
            set { _ControlCenterIPAddress = value; }
        }

        private int _ControlCenterPort;
        /// <summary>
        /// 中控端口号
        /// </summary>
        public int CONTROLCENTERPORT
        {
            get { return _ControlCenterPort; }
            set { _ControlCenterPort = value; }
        }

        private string _Title;
        /// <summary>
        /// 软件名称
        /// </summary>
        public string TITLE
        {
            get { return _Title; }
            set { _Title = value; }
        }

        private int _ConsolePort;
        /// <summary>
        /// 计时记分控制台端口号
        /// </summary>
        public int CONSOLEPORT
        {
            get { return _ConsolePort; }
            set { _ConsolePort = value; }
        }

        private string _ReadyTime;
        /// <summary>
        /// 准备时间
        /// </summary>
        public string READYTIME
        {
            get { return _ReadyTime; }
            set { _ReadyTime = value; }
        }

        private string _PauseTime;
        /// <summary>
        /// 暂停时间
        /// </summary>
        public string PAUSETIME
        {
            get { return _PauseTime; }
            set { _PauseTime = value; }
        }

        private int _RoundCount;
        /// <summary>
        /// 比赛总局数
        /// </summary>
        public int ROUNDCOUNT
        {
            get { return _RoundCount; }
            set { _RoundCount = value; }
        }

        private int _PDPHeight;
        /// <summary>
        /// PDP像素高度
        /// </summary>
        public int PDPHEIGHT
        {
            get { return _PDPHeight; }
            set { _PDPHeight = value; }
        }

        private int _PDPWidth;
        /// <summary>
        /// PDP像素宽度
        /// </summary>
        public int PDPWIDTH
        {
            get { return _PDPWidth; }
            set { _PDPWidth = value; }
        }

        private bool _IsControlCenter;
        /// <summary>
        /// 是否带中控
        /// </summary>
        public bool ISCONTROLCENTER
        {
            get { return _IsControlCenter; }
            set { _IsControlCenter = value; }
        }

        private bool _DisplayTotalTime;
        /// <summary>
        /// 显示比赛用时
        /// </summary>
        public bool DISPLAYTOTALTIME
        {
            get { return _DisplayTotalTime; }
            set { _DisplayTotalTime = value; }
        }

        private bool _DisplayReadyTime;
        /// <summary>
        /// 显示准备时间
        /// </summary>
        public bool DISPLAYREADYTIME
        {
            get { return _DisplayReadyTime; }
            set { _DisplayReadyTime = value; }
        }

        private bool _DisplayPauseTime;
        /// <summary>
        /// 显示暂停时间
        /// </summary>
        public bool DISPLAYPAUSETIME
        {
            get { return _DisplayPauseTime; }
            set { _DisplayPauseTime = value; }
        }

        private int _TotalTimeX;
        /// <summary>
        /// 比赛用时X坐标
        /// </summary>
        public int TOTALTIMEX
        {
            get { return _TotalTimeX; }
            set { _TotalTimeX = value; }
        }

        private int _TotalTimeY;
        /// <summary>
        /// 比赛用时Y坐标
        /// </summary>
        public int TOTALTIMEY
        {
            get { return _TotalTimeY; }
            set { _TotalTimeY = value; }
        } 

        private static ConsoleSettings _OnSettings;
        /// <summary>
        /// OnSettings
        /// </summary>
        public static ConsoleSettings ONSETTINGS
        {
            get
            {
                if (_OnSettings == null)
                {
                    _OnSettings = new ConsoleSettings();
                    _OnSettings.Load();
                }
                return _OnSettings;
            }
            set
            {
                _OnSettings = value;
                ApplicationCommon.XmlHelper.SaveXml(_OnSettings);
            }
        }

        public string FileName
        {
            get { return "ConsoleSettings"; }
        }

        public string FilePath
        {
            get { return ApplicationCommon.DirectoryHelper.DataDirectory; }
        }

        public void Load()
        {
            ConsoleSettings s = new ConsoleSettings();
            if (System.IO.File.Exists(ApplicationCommon.XmlHelper.GetFileName(s)))
                _OnSettings = (ConsoleSettings)ApplicationCommon.XmlHelper.LoadXml(s);
        }
    }
}
