using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientCommon;

namespace SubStance
{
    public class ScheduleAthletes : ISqlOperateLog, IDataCheck
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

        private string _scheduleguid;
        /// <summary>
        /// scheduleguid
        /// </summary>
        public string SCHEDULEGUID
        {
            get { return _scheduleguid; }
            set { _scheduleguid = value; }
        }

        private string _teammark;
        /// <summary>
        /// teammark
        /// </summary>
        public string TEAMMARK
        {
            get { return _teammark; }
            set { _teammark = value; }
        }

        private string _athletesguid;
        /// <summary>
        /// athletesguid
        /// </summary>
        public string ATHLETESGUID
        {
            get { return _athletesguid; }
            set { _athletesguid = value; }
        }

        private int _orderid;
        /// <summary>
        /// orderid
        /// </summary>
        public int ORDERID
        {
            get { return _orderid; }
            set { _orderid = value; }
        }

        private string _sid;
        /// <summary>
        /// sid
        /// </summary>
        public string SID
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
            get { return "ScheduleAthletes"; }
        }

        public string Remark
        {
            get { return "参赛人员"; }
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
