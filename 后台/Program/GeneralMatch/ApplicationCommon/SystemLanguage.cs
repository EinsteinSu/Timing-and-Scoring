using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationCommon
{
    public class SystemLanguage:IXmlHelper
    {
        private Language _OnLanguage;
        /// <summary>
        /// OnLanguage
        /// </summary>
        public Language ONLANGUAGE
        {
            get { return _OnLanguage; }
            set { _OnLanguage = value; }
        }

        private static SystemLanguage _OnSystemLanguage;
        /// <summary>
        /// OnSystemLanguage
        /// </summary>
        public static SystemLanguage ONSYSTEMLANGUAGE
        {
            get
            {
                if (_OnSystemLanguage == null)
                {
                    _OnSystemLanguage = new SystemLanguage();
                    _OnSystemLanguage.Load();
                }
                return _OnSystemLanguage;
            }
            set
            {
                _OnSystemLanguage = value;
                XmlHelper.SaveXml(_OnSystemLanguage);
            }
        }


        public string FilePath
        {
            get { return DirectoryHelper.DataDirectory; }
        }

        public string FileName
        {
            get { return "SystemLanguage"; }
        }

        public void Load()
        {
            _OnSystemLanguage = new SystemLanguage();
            _OnSystemLanguage = (SystemLanguage)XmlHelper.LoadXml(_OnSystemLanguage);
        }
    }

    public enum Language
    {
        ChineseSimplified, English
    }
}
