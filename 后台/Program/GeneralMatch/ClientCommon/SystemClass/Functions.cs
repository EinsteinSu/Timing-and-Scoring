using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientCommon
{
    public class Functions : ISqlOperateLog, IDataCheck
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

        private string _name_en;
        /// <summary>
        /// name_en
        /// </summary>
        public string NAME_EN
        {
            get { return _name_en; }
            set { _name_en = value; }
        }

        private string _type;
        /// <summary>
        /// type
        /// </summary>
        public string TYPE
        {
            get { return _type; }
            set { _type = value; }
        }

        private string _dll;
        /// <summary>
        /// dll
        /// </summary>
        public string DLL
        {
            get { return _dll; }
            set { _dll = value; }
        }

        private string _modle;
        /// <summary>
        /// modle
        /// </summary>
        public string MODLE
        {
            get { return _modle; }
            set { _modle = value; }
        }

        private string _method;
        /// <summary>
        /// method
        /// </summary>
        public string METHOD
        {
            get { return _method; }
            set { _method = value; }
        }

        private int _imageindex;
        /// <summary>
        /// imageindex
        /// </summary>
        public int IMAGEINDEX
        {
            get { return _imageindex; }
            set { _imageindex = value; }
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

        private int _orderid;
        /// <summary>
        /// orderid
        /// </summary>
        public int ORDERID
        {
            get { return _orderid; }
            set { _orderid = value; }
        }

        #endregion


        private static List<Functions> _OnFunctions;
        /// <summary>
        /// OnFunctions
        /// </summary>
        public static List<Functions> ONFUNCTIONS
        {
            get
            {
                if (_OnFunctions == null)
                {
                    ReloadFunction();
                }
                return _OnFunctions;
            }
            set
            {
                _OnFunctions = value;
            }
        }

        public static void ReloadFunction()
        {
            _OnFunctions = new List<Functions>();
            System.Data.DataTable dt = new FunctionsPst(null).GetDataTable();
            foreach (System.Data.DataRow dr in dt.Rows)
            {
                Functions f = (Functions)ApplicationCommon.ReflectionHelper.ReflectionFromDataRow(dr, typeof(Functions));
                _OnFunctions.Add(f);
            }
        }

        public override string ToString()
        {
            return _name;
        }

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
            get { return "Functions"; }
        }

        public string Remark
        {
            get { return "系统功能"; }
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
