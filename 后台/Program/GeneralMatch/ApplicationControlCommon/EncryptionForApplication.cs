using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationControlCommon
{
    public class EncryptionForApplication : ApplicationCommon.IXmlHelper
    {
        private string _CPUID;
        /// <summary>
        /// DiskID
        /// </summary>
        public string CPUID
        {
            get { return _CPUID; }
            set { _CPUID = value; }
        }

        private string _Key;
        /// <summary>
        /// Key
        /// </summary>
        public string KEY
        {
            get { return _Key; }
            set { _Key = value; }
        }


        private static EncryptionForApplication _OnEncryption;
        /// <summary>
        /// OnEncryption
        /// </summary>
        public static EncryptionForApplication ONENCRYPTION
        {
            get
            {
                if (_OnEncryption == null)
                {
                    _OnEncryption = new EncryptionForApplication();
                    _OnEncryption.Load();
                }
                return _OnEncryption;
            }
            set
            {
                _OnEncryption = value;
                ApplicationCommon.XmlHelper.SaveXml(_OnEncryption);
            }
        }

        public string FilePath
        {
            get { return ApplicationCommon.DirectoryHelper.DataDirectory; }
        }

        public string FileName
        {
            get { return "Register"; }
        }

        public void Load()
        {
            EncryptionForApplication s = new EncryptionForApplication();
            if (System.IO.File.Exists(ApplicationCommon.XmlHelper.GetFileName(s)))
                _OnEncryption = (EncryptionForApplication)ApplicationCommon.XmlHelper.LoadXml(s);
        }
    }
}
