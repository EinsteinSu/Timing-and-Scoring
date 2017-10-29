using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientCommon
{
    public class FunctionImages : ISqlOperateLog, IDataCheck
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

        private int _imageindex;
        /// <summary>
        /// imageindex
        /// </summary>
        public int IMAGEINDEX
        {
            get { return _imageindex; }
            set { _imageindex = value; }
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

        private byte[] _image;
        /// <summary>
        /// image
        /// </summary>
        public byte[] IMAGE
        {
            get { return _image; }
            set { _image = value; }
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
            get { return "SystemImages"; }
        }

        public string Remark
        {
            get { return "系统图片"; }
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
