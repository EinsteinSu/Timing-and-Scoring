using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientCommon;
using SubStance;

namespace Persistent
{
    public class ScheduleAthletesPst : PersistentBase
    {
        public ScheduleAthletesPst(object obj)
            : base(obj)
        {

        }

        protected override string InsertSql()
        {
            ScheduleAthletes info = (ScheduleAthletes)Substance;
            return String.Format("INSERT INTO ScheduleAthletes (GUID,SCHEDULEGUID,TEAMMARK,ATHLETESGUID,ORDERID,MEMO) VALUES('{0}','{1}','{2}','{3}',{4},'{5}')", info.GUID, info.SCHEDULEGUID, info.TEAMMARK, info.ATHLETESGUID, info.ORDERID, info.MEMO);
        }

        protected override string UpdateSql()
        {
            ScheduleAthletes info = (ScheduleAthletes)Substance;
            return String.Format("UPDATE ScheduleAthletes SET SCHEDULEGUID = '{0}',TEAMMARK = '{1}',ATHLETESGUID = '{2}',ORDERID = {3},MEMO = '{4}' WHERE GUID = '{5}'", info.SCHEDULEGUID, info.TEAMMARK, info.ATHLETESGUID, info.ORDERID, info.MEMO, info.GUID); 
        }

        protected override string DeleteSql(string guid)
        {
            return String.Format("DELETE FROM ScheduleAthletes WHERE GUID = '{0}'", guid); 
        }

        protected override string BaseSql()
        {
            return "SELECT * FROM V_ScheduleAthletes";
        }
    }
}
