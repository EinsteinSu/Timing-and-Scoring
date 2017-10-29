using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientCommon
{
    public class SystemUsers : ISqlOperateLog, ApplicationCommon.IXmlHelper
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

        private string _username;
        /// <summary>
        /// username
        /// </summary>
        public string USERNAME
        {
            get { return _username; }
            set { _username = value; }
        }

        private string _password;
        /// <summary>
        /// password
        /// </summary>
        public string PASSWORD
        {
            get { return _password; }
            set { _password = value; }
        }

        private string _roleguids;
        /// <summary>
        /// roleguids
        /// </summary>
        public string ROLEGUIDS
        {
            get { return _roleguids; }
            set { _roleguids = value; }
        }

        private string _remarks;
        /// <summary>
        /// remarks
        /// </summary>
        public string REMARKS
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

        #endregion


        private DateTime _LoginTime = DateTime.Now;
        /// <summary>
        /// LoginTime
        /// </summary>
        public DateTime LOGINTIME
        {
            get { return _LoginTime; }
            set { _LoginTime = value; }
        }

        public override string ToString()
        {
            return _username;
        }

        private static SystemUsers _OnUsers;
        /// <summary>
        /// OnUsers
        /// </summary>
        public static SystemUsers ONUSERS
        {
            get
            {
                if (_OnUsers == null)
                {
                    _OnUsers = new SystemUsers();
                    _OnUsers.Load();
                }
                return _OnUsers;
            }
            set
            {
                _OnUsers = value;
                ApplicationCommon.XmlHelper.SaveXml(_OnUsers);
                string roleguids = "'-1',";
                foreach (string str in _OnUsers.ROLEGUIDS.Split(','))
                {
                    roleguids += string.Format("'{0}',", str.Trim());
                }
                System.Data.DataTable dt = SqlHelper.GetDataTable(string.Format("SELECT * FROM ROLEFUNCTION WHERE ROLEGUID IN ({0})",roleguids.TrimEnd(',')));
                _OnRoles = new List<RoleFunction>();
                foreach (System.Data.DataRow dr in dt.Rows)
                {
                    RoleFunction rf = (RoleFunction)ApplicationCommon.ReflectionHelper.ReflectionFromDataRow(dr, typeof(RoleFunction));
                    _OnRoles.Add(rf);
                }
            }
        }


        private static List<RoleFunction> _OnRoles;
        /// <summary>
        /// OnRoles
        /// </summary>
        public static List<RoleFunction> ONROLES
        {
            get { return _OnRoles; }
            set { _OnRoles = value; }
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
            get { return "SystemUsers"; }
        }

        public string Remark
        {
            get { return "系统用户"; }
        }

        public string FilePath
        {
            get { return ApplicationCommon.DirectoryHelper.DataDirectory; }
        }

        public string FileName
        {
            get { return "SystemUsers"; }
        }

        public void Load()
        {
            _OnUsers = new SystemUsers();
            if (System.IO.File.Exists(ApplicationCommon.XmlHelper.GetFileName(_OnUsers)))
                _OnUsers = (SystemUsers)ApplicationCommon.XmlHelper.LoadXml(_OnUsers);
        }
    }
}
