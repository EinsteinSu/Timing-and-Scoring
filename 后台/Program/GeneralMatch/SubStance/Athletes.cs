using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientCommon;

namespace SubStance
{
    public class Athletes : ISqlOperateLog, IDataCheck
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

        private string _nameen;
        /// <summary>
        /// nameen
        /// </summary>
        public string NAMEEN
        {
            get { return _nameen; }
            set { _nameen = value; }
        }

        private string _registnum;
        /// <summary>
        /// registnum
        /// </summary>
        public string REGISTNUM
        {
            get { return _registnum; }
            set { _registnum = value; }
        }

        private string _bibnum;
        /// <summary>
        /// bibnum
        /// </summary>
        public string BIBNUM
        {
            get { return _bibnum; }
            set { _bibnum = value; }
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

        private string _sex;
        /// <summary>
        /// sex
        /// </summary>
        public string SEX
        {
            get { return _sex; }
            set { _sex = value; }
        }

        private double _weight;
        /// <summary>
        /// weight
        /// </summary>
        public double WEIGHT
        {
            get { return _weight; }
            set { _weight = value; }
        }

        private double _height;
        /// <summary>
        /// height
        /// </summary>
        public double HEIGHT
        {
            get { return _height; }
            set { _height = value; }
        }

        private DateTime _birthdate;
        /// <summary>
        /// birthdate
        /// </summary>
        public DateTime BIRTHDATE
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }

        private DateTime _bonedate;
        /// <summary>
        /// bonedate
        /// </summary>
        public DateTime BONEDATE
        {
            get { return _bonedate; }
            set { _bonedate = value; }
        }

        private string _oldscore;
        /// <summary>
        /// oldscore
        /// </summary>
        public string OLDSCORE
        {
            get { return _oldscore; }
            set { _oldscore = value; }
        }

        private string _level;
        /// <summary>
        /// level
        /// </summary>
        public string LEVEL
        {
            get { return _level; }
            set { _level = value; }
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

        private string _personcardclass;
        /// <summary>
        /// personcardclass
        /// </summary>
        public string PERSONCARDCLASS
        {
            get { return _personcardclass; }
            set { _personcardclass = value; }
        }

        private string _personcard;
        /// <summary>
        /// personcard
        /// </summary>
        public string PERSONCARD
        {
            get { return _personcard; }
            set { _personcard = value; }
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
            get { return "Athletes"; }
        }

        public string Remark
        {
            get { return "运动员信息"; }
        }

        public bool DataCheck(out string errMsg)
        {
            errMsg = string.Empty;
            if (_name.Length == 0)
                errMsg += "运动员姓名不能为空！\r\n";
            if (errMsg.Length > 0)
                return false;
            return true;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
