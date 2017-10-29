using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientCommon;

namespace SubStance
{
    public class CompetitionCommittee : ISqlOperateLog, IDataCheck
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

        private byte[] _photo;
        /// <summary>
        /// photo
        /// </summary>
        public byte[] PHOTO
        {
            get { return _photo; }
            set { _photo = value; }
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

        private int _parttime;
        /// <summary>
        /// parttime
        /// </summary>
        public int PARTTIME
        {
            get { return _parttime; }
            set { _parttime = value; }
        }

        private string _workplace;
        /// <summary>
        /// workplace
        /// </summary>
        public string WORKPLACE
        {
            get { return _workplace; }
            set { _workplace = value; }
        }

        private string _adress;
        /// <summary>
        /// adress
        /// </summary>
        public string ADRESS
        {
            get { return _adress; }
            set { _adress = value; }
        }

        private string _tel;
        /// <summary>
        /// tel
        /// </summary>
        public string TEL
        {
            get { return _tel; }
            set { _tel = value; }
        }

        private string _mobile;
        /// <summary>
        /// mobile
        /// </summary>
        public string MOBILE
        {
            get { return _mobile; }
            set { _mobile = value; }
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
            get { return "CompetitionCommittee"; }
        }

        public string Remark
        {
            get { return "竞委会设置"; }
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
