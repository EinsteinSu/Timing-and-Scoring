using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientCommon;
using SubStance;

namespace Persistent
{
    public class TeamsPst : PersistentBase
    {
        public TeamsPst(object obj)
            : base(obj)
        {

        }

        protected override string InsertSql()
        {
            Teams info = (Teams)Substance;
            return String.Format("INSERT INTO Teams (GUID,CODE,NAME,SHORTNAME,STARTNUM,ENDNUM,FLAG,GAMEGUID,MEMO) VALUES('{0}','{1}','{2}','{3}','{4}','{5}',@FLAG,'{6}','{7}')", info.GUID, info.CODE, info.NAME, info.SHORTNAME, info.STARTNUM, info.ENDNUM, info.GAMEGUID, info.MEMO);
        }

        protected override string UpdateSql()
        {
            Teams info = (Teams)Substance;
            return String.Format("UPDATE Teams SET CODE = '{0}',NAME = '{1}',SHORTNAME = '{2}',STARTNUM = '{3}',ENDNUM = '{4}',FLAG = @FLAG,GAMEGUID = '{5}',MEMO = '{6}' WHERE GUID = '{7}'", info.CODE, info.NAME, info.SHORTNAME, info.STARTNUM, info.ENDNUM, info.GAMEGUID, info.MEMO, info.GUID); 
        }

        protected override string DeleteSql(string guid)
        {
            return String.Format("DELETE FROM Teams WHERE GUID = '{0}' DELETE FROM Athletes WHERE TeamGuid = '{0}'", guid); 
        }

        protected override string BaseSql()
        {
            return "SELECT * FROM Teams ORDER BY SID";
        }
    }
}
