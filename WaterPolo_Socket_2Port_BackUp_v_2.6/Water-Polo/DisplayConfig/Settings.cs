using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DisplayConfig
{
    public class Settings : ApplicationCommon.IXmlHelper
    {
        //private string _RefereeIPAddress;
        ///// <summary>
        ///// RefereeIPAddress
        ///// </summary>
        //public string REFEREEIPADDRESS
        //{
        //    get { return _RefereeIPAddress; }
        //    set { _RefereeIPAddress = value; }
        //}

        //private int _RefereePort;
        ///// <summary>
        ///// RefereePort
        ///// </summary>
        //public int REFEREEPORT
        //{
        //    get { return _RefereePort; }
        //    set { _RefereePort = value; }
        //}

        private int _X;
        /// <summary>
        /// X
        /// </summary>
        public int X
        {
            get { return _X; }
            set { _X = value; }
        }

        private int _Y;
        /// <summary>
        /// Y
        /// </summary>
        public int Y
        {
            get { return _Y; }
            set { _Y = value; }
        } 

        private int _Width;
        /// <summary>
        /// Width
        /// </summary>
        public int WIDTH
        {
            get { return _Width; }
            set { _Width = value; }
        }

        private int _Height;
        /// <summary>
        /// Height
        /// </summary>
        public int HEIGHT
        {
            get { return _Height; }
            set { _Height = value; }
        }

        private int _ListeningPort;
        /// <summary>
        /// ListeningPort
        /// </summary>
        public int LISTENINGPORT
        {
            get { return _ListeningPort; }
            set { _ListeningPort = value; }
        }

        private int _ListeningPortExtend;
        /// <summary>
        /// ListeningPortExtend
        /// </summary>
        public int LISTENINGPORTEXTEND
        {
            get { return _ListeningPortExtend; }
            set { _ListeningPortExtend = value; }
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
