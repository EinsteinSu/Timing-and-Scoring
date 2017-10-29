using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientCommon;

namespace SubStance
{
    public class Gymnasium : ISqlOperateLog, IDataCheck
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

        private byte[] _photo;
        /// <summary>
        /// photo
        /// </summary>
        public byte[] PHOTO
        {
            get { return _photo; }
            set { _photo = value; }
        }

        private string _ipaddress;
        /// <summary>
        /// ipaddress
        /// </summary>
        public string IPADDRESS
        {
            get { return _ipaddress; }
            set { _ipaddress = value; }
        }

        private string _port;
        /// <summary>
        /// port
        /// </summary>
        public string PORT
        {
            get { return _port; }
            set { _port = value; }
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
            get { return "Gymnasium"; }
        }

        public string Remark
        {
            get { return "场馆信息"; }
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
