using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientCommon
{
    public class RolePst:PersistentBase
    {
        public RolePst(object obj)
            : base(obj)
        {

        }

        protected override string InsertSql()
        {
            Role info = (Role)Substance;
            return String.Format("INSERT INTO Role (GUID,NAME,MEMO) VALUES('{0}','{1}','{2}')", info.GUID, info.NAME, info.MEMO);
        }

        protected override string UpdateSql()
        {
            Role info = (Role)Substance;
            return String.Format("UPDATE Role SET NAME = '{0}',MEMO = '{1}' WHERE GUID = '{2}'", info.NAME, info.MEMO, info.GUID); 
        }

        protected override string DeleteSql(string guid)
        {
            return String.Format("DELETE FROM Role WHERE GUID = '{0}' DELETE FROM ROLEFUNCTION WHERE ROLEGUID = '{0}'", guid); 
        }

        protected override string BaseSql()
        {
            return "SELECT * FROM Role ORDER BY SID";
        }
    }
}
