using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientCommon
{
    public class Games : ISqlOperateLog, IDataCheck
    {
        #region Attributes

        private string _guid;
        /// <summary>
        /// guid
        /// </summary>
        public string GUID
        {
            get { return _guid; }
            set { _guid = value; }
        }

        private string _name;
        /// <summary>
        /// name
        /// </summary>
        public string NAME
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _isoutside;
        /// <summary>
        /// isoutside
        /// </summary>
        public int ISOUTSIDE
        {
            get { return _isoutside; }
            set { _isoutside = value; }
        }

        private string _host_organizer;
        /// <summary>
        /// host_organizer
        /// </summary>
        public string HOST_ORGANIZER
        {
            get { return _host_organizer; }
            set { _host_organizer = value; }
        }

        private string _undertake_organizer;
        /// <summary>
        /// undertake_organizer
        /// </summary>
        public string UNDERTAKE_ORGANIZER
        {
            get { return _undertake_organizer; }
            set { _undertake_organizer = value; }
        }

        private string _co_organizer;
        /// <summary>
        /// co_organizer
        /// </summary>
        public string CO_ORGANIZER
        {
            get { return _co_organizer; }
            set { _co_organizer = value; }
        }

        private string _textroot;
        /// <summary>
        /// textroot
        /// </summary>
        public string TEXTROOT
        {
            get { return _textroot; }
            set { _textroot = value; }
        }

        private string _webroot;
        /// <summary>
        /// webroot
        /// </summary>
        public string WEBROOT
        {
            get { return _webroot; }
            set { _webroot = value; }
        }

        private string _screenroot;
        /// <summary>
        /// screenroot
        /// </summary>
        public string SCREENROOT
        {
            get { return _screenroot; }
            set { _screenroot = value; }
        }

        private byte[] _emblem;
        /// <summary>
        /// emblem
        /// </summary>
        public byte[] EMBLEM
        {
            get { return _emblem; }
            set { _emblem = value; }
        }

        private byte[] _mascot;
        /// <summary>
        /// mascot
        /// </summary>
        public byte[] MASCOT
        {
            get { return _mascot; }
            set { _mascot = value; }
        }

        private byte[] _logo;
        /// <summary>
        /// logo
        /// </summary>
        public byte[] LOGO
        {
            get { return _logo; }
            set { _logo = value; }
        }

        private int _sid;
        /// <summary>
        /// sid
        /// </summary>
        public int SID
        {
            get { return _sid; }
            set { _sid = value; }
        }

        private string _memo;
        /// <summary>
        /// memo
        /// </summary>
        public string MEMO
        {
            get { return _memo; }
            set { _memo = value; }
        }

        #endregion

        public delegate void GameChangedCallback(Games game);
        public static event GameChangedCallback GameChanged;
        private static Games _OnGame;
        /// <summary>
        /// OnGame
        /// </summary>
        public static Games OnGame
        {
            get
            {
                if (_OnGame == null)
                {
                    _OnGame = new Games();
                    string fileName = string.Format("{0}{1}.xml", ApplicationCommon.DirectoryHelper.DataDirectory, "Games");
                    if (System.IO.File.Exists(fileName))
                        _OnGame.GUID = (string)ApplicationCommon.XmlHelper.LoadXml(fileName, typeof(string));
                    System.Data.DataTable dt = new GamesPst(null).GetDataTable(string.Format(" WHERE GUID = '{0}'", _OnGame.GUID));
                    if (dt.Rows.Count > 0)
                    {
                        _OnGame = (Games)ApplicationCommon.ReflectionHelper.ReflectionFromDataRow(dt.Rows[0], typeof(Games));
                    }
                }
                return _OnGame;
            }
            set
            {
                _OnGame = value;
                string fileName = string.Format("{0}{1}.xml", ApplicationCommon.DirectoryHelper.DataDirectory, "Games");
                ApplicationCommon.XmlHelper.SaveXml(fileName, _OnGame.GUID, typeof(string));
                if (GameChanged != null)
                    GameChanged(_OnGame);
            }
        }

        public string TableGuid
        {
            get { return _guid; }
        }

        SystemOperateType _opr;
        public SystemOperateType OperateType
        {
            get
            {
                return _opr;
            }
            set
            {
                _opr = value;
            }
        }

        public string OperateTable
        {
            get { return "Games"; }
        }

        public string Remark
        {
            get { return "运动会信息"; }
        }

        public bool DataCheck(out string errMsg)
        {
            errMsg = string.Empty;
            if (_name.Length == 0)
                errMsg += "运动会名称不能为空！";
            if (errMsg.Length > 0)
                return false;
            return true;
        }
    }
}
