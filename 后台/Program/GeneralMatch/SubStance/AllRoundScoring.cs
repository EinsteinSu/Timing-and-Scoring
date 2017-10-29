using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientCommon;

namespace SubStance
{
    public class AllRoundScoring : ISqlOperateLog, IDataCheck
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

        private string _eventguid;
        /// <summary>
        /// eventguid
        /// </summary>
        public string EVENTGUID
        {
            get { return _eventguid; }
            set { _eventguid = value; }
        }

        private int _subnum;
        /// <summary>
        /// subnum
        /// </summary>
        public int SUBNUM
        {
            get { return _subnum; }
            set { _subnum = value; }
        }

        private string _num;
        /// <summary>
        /// num
        /// </summary>
        public string NUM
        {
            get { return _num; }
            set { _num = value; }
        }

        private string _itemguid;
        /// <summary>
        /// itemguid
        /// </summary>
        public string ITEMGUID
        {
            get { return _itemguid; }
            set { _itemguid = value; }
        }

        private string _scoringguid;
        /// <summary>
        /// scoringguid
        /// </summary>
        public string SCORINGGUID
        {
            get { return _scoringguid; }
            set { _scoringguid = value; }
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
            get { return "AllRoundScoring"; }
        }

        public string Remark
        {
            get { return "全能项目评分表"; }
        }

        public bool DataCheck(out string errMsg)
        {
            errMsg = string.Empty;
            if (errMsg.Length > 0)
                return false;
            return true;
        }
    }
}
