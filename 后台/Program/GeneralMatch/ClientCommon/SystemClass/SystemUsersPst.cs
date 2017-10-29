using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientCommon
{
    public class SystemUsersPst:PersistentBase
    {
        public SystemUsersPst(object obj)
            : base(obj)
        {

        }

        protected override string InsertSql()
        {
            SystemUsers info = (SystemUsers)Substance;
            ApplicationCommon.PasswordHelper ph = new ApplicationCommon.PasswordHelper();
            info.PASSWORD = ph.EncryptString(info.PASSWORD);
            return String.Format("INSERT INTO SystemUsers (GUID,USERNAME,PASSWORD,ROLEGUIDS,REMARKS) VALUES('{0}','{1}','{2}','{3}','{4}')", info.GUID, info.USERNAME, info.PASSWORD, info.ROLEGUIDS, info.REMARKS);
        }

        protected override string UpdateSql()
        {
            SystemUsers info = (SystemUsers)Substance;
            ApplicationCommon.PasswordHelper ph = new ApplicationCommon.PasswordHelper();
            info.PASSWORD = ph.EncryptString(info.PASSWORD);
            return String.Format("UPDATE SystemUsers SET USERNAME = '{0}',PASSWORD = '{1}',ROLEGUIDS = '{2}',REMARKS = '{3}' WHERE GUID = '{4}'", info.USERNAME, info.PASSWORD, info.ROLEGUIDS, info.REMARKS, info.GUID); 
        }

        protected override string DeleteSql(string guid)
        {
            return String.Format("DELETE FROM SystemUsers WHERE GUID = '{0}'", guid); 
        }

        protected override string BaseSql()
        {
            return "SELECT * FROM SystemUsers";
        }
    }
}
