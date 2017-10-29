using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientCommon
{
    public class RoleFunction : ISqlOperateLog, IDataCheck
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

        private string _roleguid;
        /// <summary>
        /// roleguid
        /// </summary>
        public string ROLEGUID
        {
            get { return _roleguid; }
            set { _roleguid = value; }
        }

        private string _functionguid;
        /// <summary>
        /// functionguid
        /// </summary>
        public string FUNCTIONGUID
        {
            get { return _functionguid; }
            set { _functionguid = value; }
        }

        private int _ishave;
        /// <summary>
        /// ishave
        /// </summary>
        public int ISHAVE
        {
            get { return _ishave; }
            set { _ishave = value; }
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
            get { return "RoleFunction"; }
        }

        public string Remark
        {
            get { return "权限设置"; }
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
