using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientCommon;

namespace SubStance
{
    public class Params : ISqlOperateLog, IDataCheck
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

        private string _class;
        /// <summary>
        /// class
        /// </summary>
        public string CLASS
        {
            get { return _class; }
            set { _class = value; }
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

        private string _attribute;
        /// <summary>
        /// attribute
        /// </summary>
        public string ATTRIBUTE
        {
            get { return _attribute; }
            set { _attribute = value; }
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
            get { return "Params"; }
        }

        public string Remark
        {
            get { return "参数设置"; }
        } 

        public bool DataCheck(out string errMsg)
        {
            errMsg = string.Empty;
            if (_class.Length == 0)
                errMsg += "参数分类不能为空！\r\n";
            if (errMsg.Length > 0)
                return false;
            return true;
        }
    }
}
