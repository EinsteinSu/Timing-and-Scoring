using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientCommon;
using SubStance;

namespace Persistent
{
    public class AthletesPst: PersistentBase
    {
        public AthletesPst(object obj)
            : base(obj)
        {

        }

        protected override string InsertSql()
        {
            Athletes info = (Athletes)Substance;
            return String.Format("INSERT INTO Athletes (GUID,NAME,NAMEEN,REGISTNUM,BIBNUM,TEAMGUID,SEX,WEIGHT,HEIGHT,BIRTHDATE,BONEDATE,OLDSCORE,LEVEL,PHOTO,PERSONCARDCLASS,PERSONCARD,MEMO) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7},{8},'{9}','{10}','{11}','{12}',@PHOTO,'{13}','{14}','{15}')", info.GUID, info.NAME, info.NAMEEN, info.REGISTNUM, info.BIBNUM, info.TEAMGUID, info.SEX, info.WEIGHT, info.HEIGHT, info.BIRTHDATE, info.BONEDATE, info.OLDSCORE, info.LEVEL, info.PERSONCARDCLASS, info.PERSONCARD, info.MEMO);
        }

        protected override string UpdateSql()
        {
            Athletes info = (Athletes)Substance;
            return String.Format("UPDATE Athletes SET NAME = '{0}',NAMEEN = '{1}',REGISTNUM = '{2}',BIBNUM = '{3}',TEAMGUID = '{4}',SEX = '{5}',WEIGHT = {6},HEIGHT = {7},BIRTHDATE = '{8}',BONEDATE = '{9}',OLDSCORE = '{10}',LEVEL = '{11}',PHOTO = @PHOTO,PERSONCARDCLASS = '{12}',PERSONCARD = '{13}',MEMO = '{14}' WHERE GUID = '{15}'", info.NAME, info.NAMEEN, info.REGISTNUM, info.BIBNUM, info.TEAMGUID, info.SEX, info.WEIGHT, info.HEIGHT, info.BIRTHDATE, info.BONEDATE, info.OLDSCORE, info.LEVEL, info.PERSONCARDCLASS, info.PERSONCARD, info.MEMO, info.GUID); 
        }

        protected override string DeleteSql(string guid)
        {
            return String.Format("DELETE FROM Athletes WHERE GUID = '{0}'", guid); 
        }

        protected override string BaseSql()
        {
            return "SELECT * FROM Athletes ORDER BY Sid";
        }
    }
}
