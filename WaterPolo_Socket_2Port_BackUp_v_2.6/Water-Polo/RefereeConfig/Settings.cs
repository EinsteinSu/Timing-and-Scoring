using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefereeConfig
{
    public class Settings : ApplicationCommon.IXmlHelper
    {

        private bool _BTotalTime;
        /// <summary>
        /// 是否发送总计时到VRS
        /// </summary>
        public bool BTOTALTIME
        {
            get { return _BTotalTime; }
            set { _BTotalTime = value; }
        }

        private string _TotalTimeIPAddress;
        /// <summary>
        /// VRS 总计时 IP地址
        /// </summary>
        public string TOTALTIMEIPADDRESS
        {
            get { return _TotalTimeIPAddress; }
            set { _TotalTimeIPAddress = value; }
        }

        private int _VRS_TotalTimePort;
        /// <summary>
        /// VRS 总计时 端口
        /// </summary>
        public int VRS_TOTALTIMEPORT
        {
            get { return _VRS_TotalTimePort; }
            set { _VRS_TotalTimePort = value; }
        } 

        private bool _BTirtySeconds;
        /// <summary>
        /// 是否发送30秒信息到VRS
        /// </summary>
        public bool BTIRTYSECONDS
        {
            get { return _BTirtySeconds; }
            set { _BTirtySeconds = value; }
        }

        private string _TirtySecondsIPAddress;
        /// <summary>
        /// VRS 30秒显示 IP地址
        /// </summary>
        public string TIRTYSECONDSIPADDRESS
        {
            get { return _TirtySecondsIPAddress; }
            set { _TirtySecondsIPAddress = value; }
        }

        private int _ThirtySecondsPort;
        /// <summary>
        /// VRS 30秒显示 端口
        /// </summary>
        public int THIRTYSECONDSPORT
        {
            get { return _ThirtySecondsPort; }
            set { _ThirtySecondsPort = value; }
        } 

        private bool _BTwentySeconds;
        /// <summary>
        /// 是否发送20秒信息到VRS
        /// </summary>
        public bool BTWENTYSECONDS
        {
            get { return _BTwentySeconds; }
            set { _BTwentySeconds = value; }
        }

        private string _TwentySecondsIPAddress;
        /// <summary>
        /// VRS 20秒显示 IP地址
        /// </summary>
        public string TWENTYSECONDSIPADDRESS
        {
            get { return _TwentySecondsIPAddress; }
            set { _TwentySecondsIPAddress = value; }
        }

        private int _TwentySecondsPort;
        /// <summary>
        /// VRS 20秒显示 端口
        /// </summary>
        public int TWENTYSECONDSPORT
        {
            get { return _TwentySecondsPort; }
            set { _TwentySecondsPort = value; }
        } 

        private string _MajorIPAddress;
        /// <summary>
        /// 主控端IP地址
        /// </summary>
        public string MAJORIPADDRESS
        {
            get { return _MajorIPAddress; }
            set { _MajorIPAddress = value; }
        }

        private string _DisplayIPAddress;
        /// <summary>
        /// 显示端IP地址
        /// </summary>
        public string DISPLAYIPADDRESS
        {
            get { return _DisplayIPAddress; }
            set { _DisplayIPAddress = value; }
        }

        private int _MajorPort;
        /// <summary>
        /// 主控端 端口号
        /// </summary>
        public int MAJORPORT
        {
            get { return _MajorPort; }
            set { _MajorPort = value; }
        }

        private int _DisplayPort;
        /// <summary>
        /// 显示端 端口号
        /// </summary>
        public int DISPLAYPORT
        {
            get { return _DisplayPort; }
            set { _DisplayPort = value; }
        }

        private string _DisplayIPAddressExtend;
        /// <summary>
        /// 测试用
        /// </summary>
        public string DISPLAYIPADDRESSEXTEND
        {
            get { return _DisplayIPAddressExtend; }
            set { _DisplayIPAddressExtend = value; }
        }

        private int _DisplayPortExtend;
        /// <summary>
        /// 测试用
        /// </summary>
        public int DISPLAYPORTEXTEND
        {
            get { return _DisplayPortExtend; }
            set { _DisplayPortExtend = value; }
        } 

        private int _TotalTimePort;
        /// <summary>
        /// 总计时COM口
        /// </summary>
        public int TOTALTIMEPORT
        {
            get { return _TotalTimePort; }
            set { _TotalTimePort = value; }
        }

        private int _TotalBit;
        /// <summary>
        /// 总计时比特率
        /// </summary>
        public int TOTALBIT
        {
            get { return _TotalBit; }
            set { _TotalBit = value; }
        }

        private string _TotalHeader;
        /// <summary>
        /// 总计时起始符
        /// </summary>
        public string TOTALHEADER
        {
            get { return _TotalHeader; }
            set { _TotalHeader = value; }
        }

        private string _TotalTail;
        /// <summary>
        /// 总计时结束符
        /// </summary>
        public string TOTALTAIL
        {
            get { return _TotalTail; }
            set { _TotalTail = value; }
        } 

        private int _SecondsTimePort;
        /// <summary>
        /// 30秒COM口
        /// </summary>
        public int SECONDSTIMEPORT
        {
            get { return _SecondsTimePort; }
            set { _SecondsTimePort = value; }
        }

        private int _SecondsBit;
        /// <summary>
        /// 30秒比特率
        /// </summary>
        public int SECONDSBIT
        {
            get { return _SecondsBit; }
            set { _SecondsBit = value; }
        }

        private string _SecondsHeader;
        /// <summary>
        /// 30秒起始符
        /// </summary>
        public string SECONDSHEADER
        {
            get { return _SecondsHeader; }
            set { _SecondsHeader = value; }
        } 

        private string _SecondsTail;
        /// <summary>
        /// 30秒结束符
        /// </summary>
        public string SECONDSTAIL
        {
            get { return _SecondsTail; }
            set { _SecondsTail = value; }
        } 

        private int _ListeningPort;
        /// <summary>
        /// 裁判控制台监听端口
        /// </summary>
        public int LISTENINGPORT
        {
            get { return _ListeningPort; }
            set { _ListeningPort = value; }
        } 

        private static Settings _OnSettings;
        /// <summary>
        /// OnSettings
        /// </summary>
        public static Settings ONSETTINGS
        {
            get
            {
                if (_OnSettings == null)
                {
                    _OnSettings = new Settings();
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
            get { return "Settings"; }
        }

        public string FilePath
        {
            get { return ApplicationCommon.DirectoryHelper.DataDirectory; }
        }

        public void Load()
        {
            Settings s = new Settings();
            if (System.IO.File.Exists(ApplicationCommon.XmlHelper.GetFileName(s)))
                _OnSettings = (Settings)ApplicationCommon.XmlHelper.LoadXml(s);
        }
    }
}
