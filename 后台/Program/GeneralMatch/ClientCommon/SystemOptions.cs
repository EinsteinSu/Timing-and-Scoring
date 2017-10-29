using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientCommon
{
    public class SystemOptions : ApplicationCommon.IXmlHelper
    {
        private string _LoginUserGuid;
        /// <summary>
        /// 登录用户GUID
        /// </summary>
        public string LOGINUSERGUID
        {
            get { return _LoginUserGuid; }
            set { _LoginUserGuid = value; }
        }

        private string _UserPassWord;
        /// <summary>
        /// 密码
        /// </summary>
        public string USERPASSWORD
        {
            get { return _UserPassWord; }
            set { _UserPassWord = value; }
        }

        private bool _RememberPassWord;
        /// <summary>
        /// RememberPassWord
        /// </summary>
        public bool REMEMBERPASSWORD
        {
            get { return _RememberPassWord; }
            set { _RememberPassWord = value; }
        }

        private bool _AutoLogin;
        /// <summary>
        /// AutoLogin
        /// </summary>
        public bool AUTOLOGIN
        {
            get { return _AutoLogin; }
            set { _AutoLogin = value; }
        }

        private string _PassWord;
        /// <summary>
        /// PassWord
        /// </summary>
        public string PASSWORD
        {
            get { return _PassWord; }
            set { _PassWord = value; }
        } 

        private static SystemOptions _OnOptions;
        /// <summary>
        /// OnOptions
        /// </summary>
        public static SystemOptions ONOPTIONS
        {
            get
            {
                if (_OnOptions == null)
                {
                    _OnOptions = new SystemOptions();
                    _OnOptions.Load();
                }
                return _OnOptions;
            }
            set
            {
                _OnOptions = value;
                ApplicationCommon.XmlHelper.SaveXml(_OnOptions);
            }
        }

        public string FilePath
        {
            get { return ApplicationCommon.DirectoryHelper.DataDirectory; }
        }

        public string FileName
        {
            get { return "SystemOptions"; }
        }

        public void Load()
        {
            SystemOptions s = new SystemOptions();
            if (System.IO.File.Exists(ApplicationCommon.XmlHelper.GetFileName(s)))
                _OnOptions = (SystemOptions)ApplicationCommon.XmlHelper.LoadXml(s);
        }
    }
}
