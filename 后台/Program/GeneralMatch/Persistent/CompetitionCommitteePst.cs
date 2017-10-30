using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientCommon;
using SubStance;

namespace Persistent
{
    public class CompetitionCommitteePst : PersistentBase
    {
        public CompetitionCommitteePst(object obj)
            : base(obj)
        {

        }
        
        protected override string InsertSql()
        {
            CompetitionCommittee info = (CompetitionCommittee)Substance;
            return String.Format("INSERT INTO CompetitionCommittee (GUID,NAME,SEX,PHOTO,POSITION,PARTTIME,WORKPLACE,ADRESS,TEL,MOBILE,MEMO) VALUES('{0}','{1}','{2}',@PHOTO,'{3}',{4},'{5}','{6}','{7}','{8}','{9}')", info.GUID, info.NAME, info.SEX, info.POSITION, info.PARTTIME, info.WORKPLACE, info.ADRESS, info.TEL, info.MOBILE, info.MEMO);
        }

        protected override string UpdateSql()
        {
            CompetitionCommittee info = (CompetitionCommittee)Substance;
            return String.Format("UPDATE CompetitionCommittee SET NAME = '{0}',SEX = '{1}',PHOTO = @PHOTO,POSITION = '{2}',PARTTIME = {3},WORKPLACE = '{4}',ADRESS = '{5}',TEL = '{6}',MOBILE = '{7}',MEMO = '{8}' WHERE GUID = '{9}'", info.NAME, info.SEX, info.POSITION, info.PARTTIME, info.WORKPLACE, info.ADRESS, info.TEL, info.MOBILE, info.MEMO, info.GUID); 
        }

        protected override string DeleteSql(string guid)
        {
            return String.Format("DELETE FROM CompetitionCommittee WHERE GUID = '{0}'", guid); 
        }

        protected override string BaseSql()
        {
            return "SELECT * FROM V_CompetitionCommittee";
        }
    }
}
