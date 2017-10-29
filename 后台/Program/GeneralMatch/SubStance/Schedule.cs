using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientCommon;

namespace SubStance
{
    public class Schedule : ISqlOperateLog, IDataCheck
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

        private string _pguid;
        /// <summary>
        /// pguid
        /// </summary>
        public string PGUID
        {
            get { return _pguid; }
            set { _pguid = value; }
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

        private DateTime _gamedate;
        /// <summary>
        /// gamedate
        /// </summary>
        public DateTime GAMEDATE
        {
            get { return _gamedate; }
            set { _gamedate = value; }
        }

        private DateTime _gametime;
        /// <summary>
        /// gametime
        /// </summary>
        public DateTime GAMETIME
        {
            get { return _gametime; }
            set { _gametime = value; }
        }

        private int _num;
        /// <summary>
        /// num
        /// </summary>
        public int NUM
        {
            get { return _num; }
            set { _num = value; }
        }

        private string _teamaguid;
        /// <summary>
        /// teamaguid
        /// </summary>
        public string TEAMAGUID
        {
            get { return _teamaguid; }
            set { _teamaguid = value; }
        }

        private string _teamacolor;
        /// <summary>
        /// teamacolor
        /// </summary>
        public string TEAMACOLOR
        {
            get { return _teamacolor; }
            set { _teamacolor = value; }
        }

        private string _teamascore;
        /// <summary>
        /// teamascore
        /// </summary>
        public string TEAMASCORE
        {
            get { return _teamascore; }
            set { _teamascore = value; }
        }

        private string _teambguid;
        /// <summary>
        /// teambguid
        /// </summary>
        public string TEAMBGUID
        {
            get { return _teambguid; }
            set { _teambguid = value; }
        }

        private string _teambcolor;
        /// <summary>
        /// teambcolor
        /// </summary>
        public string TEAMBCOLOR
        {
            get { return _teambcolor; }
            set { _teambcolor = value; }
        }

        private string _teambscore;
        /// <summary>
        /// teambscore
        /// </summary>
        public string TEAMBSCORE
        {
            get { return _teambscore; }
            set { _teambscore = value; }
        }

        private string _gymnasiumguid;
        /// <summary>
        /// gymnasiumguid
        /// </summary>
        public string GYMNASIUMGUID
        {
            get { return _gymnasiumguid; }
            set { _gymnasiumguid = value; }
        }

        private string _areaguid;
        /// <summary>
        /// areaguid
        /// </summary>
        public string AREAGUID
        {
            get { return _areaguid; }
            set { _areaguid = value; }
        }

        private string _state;
        /// <summary>
        /// state
        /// </summary>
        public string STATE
        {
            get { return _state; }
            set { _state = value; }
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

        private int _sid;
        /// <summary>
        /// sid
        /// </summary>
        public int SID
        {
            get { return _sid; }
            set { _sid = value; }
        }

        #endregion 
        
        #region ISqlOperateLog 成员
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
            get { return "Schedule"; }
        }

        public string Remark
        {
            get { return "赛事信息"; }
        }
        #endregion

        #region IDataCheck 成员
        public bool DataCheck(out string errMsg)
        {
            errMsg = string.Empty;
            if (errMsg.Length > 0)
                return false;
            return true;
        }
        #endregion
    }
}
