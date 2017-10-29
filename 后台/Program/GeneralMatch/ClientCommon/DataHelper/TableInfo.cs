using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientCommon
{
    public class TableInfo
    {
        public TableInfo()
        {

        }

        public TableInfo(Type info, Type pst)
        {
            _InfoType = info;
            _PstType = pst;
        }

        private Type _InfoType;
        public Type InfoType
        {
            get
            {
                return _InfoType;
            }
            set
            {
                _InfoType = value;
            }
        }

        private Type _PstType;
        public Type PstType
        {
            get
            {
                return _PstType;
            }
            set
            {
                _PstType = value;
            }
        }

        private string _TableName;
        /// <summary>
        /// TableName
        /// </summary>
        public string TableName
        {
            get
            {
                return _TableName;
            }
            set
            {
                _TableName = value;
            }
        }
    }
}
