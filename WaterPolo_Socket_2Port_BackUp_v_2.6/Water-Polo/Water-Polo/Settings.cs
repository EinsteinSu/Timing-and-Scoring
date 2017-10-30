using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Water_Polo
{
    public class Settings : ApplicationCommon.IXmlHelper
    {
        private string _RefereeIPAddress;
        /// <summary>
        /// 裁判控制台IP地址
        /// </summary>
        public string REFEREEIPADDRESS
        {
            get { return _RefereeIPAddress; }
            set { _RefereeIPAddress = value; }
        }

        private int _RefereePort;
        /// <summary>
        /// 裁判控制台端口号
        /// </summary>
        public int REFEREEPORT
        {
            get { return _RefereePort; }
            set { _RefereePort = value; }
        }

        private int _ListeningPort;
        /// <summary>
        /// 侦听端口号
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
                _OnSettings = new Settings();
                _OnSettings.Load();
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
            Settings ms = new Settings();
            if (System.IO.File.Exists(ApplicationCommon.XmlHelper.GetFileName(ms)))
                _OnSettings = (Settings)ApplicationCommon.XmlHelper.LoadXml(ms);
        }
    }
}
