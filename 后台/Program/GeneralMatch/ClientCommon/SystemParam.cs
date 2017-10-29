using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientCommon
{
    public class SystemParam : ApplicationCommon.IXmlHelper
    {
        private string _TitleName;
        /// <summary>
        /// TitleName
        /// </summary>
        public string TITLENAME
        {
            get { return _TitleName; }
            set { _TitleName = value; }
        }


        private string _TitleNameEn;
        /// <summary>
        /// TitleNameEn
        /// </summary>
        public string TITLENAMEEN
        {
            get { return _TitleNameEn; }
            set { _TitleNameEn = value; }
        }

        private string _ImageRoot;
        /// <summary>
        /// ImageRoot
        /// </summary>
        public string IMAGEROOT
        {
            get { return _ImageRoot; }
            set { _ImageRoot = value; }
        }

        private System.Windows.Forms.ImageLayout _Layout;
        /// <summary>
        /// Layout
        /// </summary>
        public System.Windows.Forms.ImageLayout LAYOUT
        {
            get { return _Layout; }
            set { _Layout = value; }
        } 

        private static SystemParam _OnParam;
        /// <summary>
        /// OnParam
        /// </summary>
        public static SystemParam ONPARAM
        {
            get
            {
                if (_OnParam == null)
                {
                    _OnParam = new SystemParam();
                    _OnParam.Load();
                }
                return _OnParam;
            }
            set
            {
                _OnParam = value;
                ApplicationCommon.XmlHelper.SaveXml(_OnParam);
            }
        }


        public string FilePath
        {
            get { return ApplicationCommon.DirectoryHelper.DataDirectory; }
        }

        public string FileName
        {
            get { return "SystemParam"; }
        }

        public void Load()
        {
            SystemParam s = new SystemParam();
            if (System.IO.File.Exists(ApplicationCommon.XmlHelper.GetFileName(s)))
                _OnParam = (SystemParam)ApplicationCommon.XmlHelper.LoadXml(s);
        }
    }
}
