using System.IO;
using ApplicationCommon;

namespace Water_Polo
{
    public class Settings : IXmlHelper
    {
        private static Settings _OnSettings;

        /// <summary>
        ///     裁判控制台IP地址
        /// </summary>
        public string REFEREEIPADDRESS { get; set; }

        /// <summary>
        ///     裁判控制台端口号
        /// </summary>
        public int REFEREEPORT { get; set; }

        /// <summary>
        ///     侦听端口号
        /// </summary>
        public int LISTENINGPORT { get; set; }

        /// <summary>
        ///     OnSettings
        /// </summary>
        public static Settings ONSETTINGS
        {
            get
            {
                if (Settings._OnSettings == null)
                {
                    _OnSettings = new Settings();
                    _OnSettings.Load();
                }
                return _OnSettings;
            }
            set
            {
                _OnSettings = value;
                XmlHelper.SaveXml(_OnSettings);
            }
        }


        public string FileName => "Settings";

        public string FilePath => DirectoryHelper.DataDirectory;

        public void Load()
        {
            var ms = new Settings();
            if (File.Exists(XmlHelper.GetFileName(ms)))
            {
                _OnSettings = (Settings)XmlHelper.LoadXml(ms);
            }
        }
    }
}