using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientCommon;
using SubStance;

namespace Persistent
{
    public class TeamFlowersPst : PersistentBase
    {
        public TeamFlowersPst(object obj)
            : base(obj)
        {

        }

        protected override string InsertSql()
        {
            TeamFlowers info = (TeamFlowers)Substance;
            return String.Format("INSERT INTO TeamFlowers (GUID,NAME,SEX,POSITION,TEAMGUID,PHOTO,MEMO) VALUES('{0}','{1}','{2}','{3}','{4}',@PHOTO,'{5}')", info.GUID, info.NAME, info.SEX, info.POSITION, info.TEAMGUID, info.MEMO);
        }

        protected override string UpdateSql()
        {
            TeamFlowers info = (TeamFlowers)Substance;
            return String.Format("UPDATE TeamFlowers SET NAME = '{0}',SEX = '{1}',POSITION = '{2}',TEAMGUID = '{3}',PHOTO = @PHOTO,MEMO = '{4}' WHERE GUID = '{5}'", info.NAME, info.SEX, info.POSITION, info.TEAMGUID, info.MEMO, info.GUID); 
        }

        protected override string DeleteSql(string guid)
        {
            return String.Format("DELETE FROM TeamFlowers WHERE GUID = '{0}'", guid); 
        }

        protected override string BaseSql()
        {
            return "SELECT * FROM TeamFlowers";
        }
    }
}
