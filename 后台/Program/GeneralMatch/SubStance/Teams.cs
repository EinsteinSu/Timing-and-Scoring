using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientCommon;

namespace SubStance
{
    public class Teams : ISqlOperateLog, IDataCheck
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

        private string _code;
        /// <summary>
        /// code
        /// </summary>
        public string CODE
        {
            get { return _code; }
            set { _code = value; }
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

        private string _shortname;
        /// <summary>
        /// shortname
        /// </summary>
        public string SHORTNAME
        {
            get { return _shortname; }
            set { _shortname = value; }
        }

        private string _startnum;
        /// <summary>
        /// startnum
        /// </summary>
        public string STARTNUM
        {
            get { return _startnum; }
            set { _startnum = value; }
        }

        private string _endnum;
        /// <summary>
        /// endnum
        /// </summary>
        public string ENDNUM
        {
            get { return _endnum; }
            set { _endnum = value; }
        }

        private byte[] _flag;
        /// <summary>
        /// flag
        /// </summary>
        public byte[] FLAG
        {
            get { return _flag; }
            set { _flag = value; }
        }

        private string _gameguid;
        /// <summary>
        /// gameguid
        /// </summary>
        public string GAMEGUID
        {
            get { return _gameguid; }
            set { _gameguid = value; }
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
            get { return "Teams"; }
        }

        public string Remark
        {
            get { return "参赛队伍"; }
        }

        public bool DataCheck(out string errMsg)
        {
            errMsg = string.Empty;
            if (_name.Length == 0)
                errMsg += "队伍名称不能为空！\r\n";
            if (errMsg.Length > 0)
                return false;
            return true;
        }

    }
}
