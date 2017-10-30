using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientCommon;
using SubStance;

namespace Persistent
{
    public class SchedulePst : PersistentBase
    {
        public SchedulePst(object obj)
            : base(obj)
        {
        }

        protected override string InsertSql()
        {
            Schedule info = (Schedule)Substance;
            return String.Format("INSERT INTO Schedule (GUID,PGUID,NAME,GAMEDATE,GAMETIME,NUM,TEAMAGUID,TEAMACOLOR,TEAMASCORE,TEAMBGUID,TEAMBCOLOR,TEAMBSCORE,GYMNASIUMGUID,AREAGUID,STATE,MEMO) VALUES('{0}','{1}','{2}','{3}','{4}',{5},'{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}')", info.GUID, info.PGUID, info.NAME, info.GAMEDATE, info.GAMETIME, info.NUM, info.TEAMAGUID, info.TEAMACOLOR, info.TEAMASCORE, info.TEAMBGUID, info.TEAMBCOLOR, info.TEAMBSCORE, info.GYMNASIUMGUID, info.AREAGUID, info.STATE, info.MEMO);
        }

        protected override string UpdateSql()
        {
            Schedule info = (Schedule)Substance;
            return String.Format("UPDATE Schedule SET PGUID = '{0}',NAME = '{1}',GAMEDATE = '{2}',GAMETIME = '{3}',NUM = {4},TEAMAGUID = '{5}',TEAMACOLOR = '{6}',TEAMASCORE = '{7}',TEAMBGUID = '{8}',TEAMBCOLOR = '{9}',TEAMBSCORE = '{10}',GYMNASIUMGUID = '{11}',AREAGUID = '{12}',STATE = '{13}',MEMO = '{14}' WHERE GUID = '{15}'", info.PGUID, info.NAME, info.GAMEDATE, info.GAMETIME, info.NUM, info.TEAMAGUID, info.TEAMACOLOR, info.TEAMASCORE, info.TEAMBGUID, info.TEAMBCOLOR, info.TEAMBSCORE, info.GYMNASIUMGUID, info.AREAGUID, info.STATE, info.MEMO, info.GUID); 
        }

        protected override string DeleteSql(string guid)
        {
            return String.Format("DELETE FROM Schedule WHERE GUID = '{0}'", guid); 
        }

        protected override string BaseSql()
        {
            return "SELECT * FROM V_Schedule order by gametime";
        }
    }
}
