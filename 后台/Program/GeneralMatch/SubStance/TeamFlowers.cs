using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientCommon;

namespace SubStance
{
    public class TeamFlowers : ISqlOperateLog, IDataCheck
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

        private string _sex;
        /// <summary>
        /// sex
        /// </summary>
        public string SEX
        {
            get { return _sex; }
            set { _sex = value; }
        }

        private string _position;
        /// <summary>
        /// position
        /// </summary>
        public string POSITION
        {
            get { return _position; }
            set { _position = value; }
        }

        private string _teamguid;
        /// <summary>
        /// teamguid
        /// </summary>
        public string TEAMGUID
        {
            get { return _teamguid; }
            set { _teamguid = value; }
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
            get { return "TeamFlowers"; }
        }

        public string Remark
        {
            get { return "随队人员"; }
        }

        public bool DataCheck(out string errMsg)
        {
            errMsg = string.Empty;
            if (_name.Length == 0)
                errMsg += "姓名不能为空！\r\n";
            if (errMsg.Length > 0)
                return false;
            return true;
        }
    }
}
