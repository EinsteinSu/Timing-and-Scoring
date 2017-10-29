using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientCommon
{
    public class GamesPst:PersistentBase
    {
        public GamesPst(object obj)
            : base(obj)
        {

        }

        protected override string InsertSql()
        {
            Games info = (Games)Substance;
            return String.Format("INSERT INTO Games (GUID,NAME,ISOUTSIDE,HOST_ORGANIZER,UNDERTAKE_ORGANIZER,CO_ORGANIZER,TEXTROOT,WEBROOT,SCREENROOT,EMBLEM,MASCOT,LOGO,MEMO) VALUES('{0}','{1}',{2},'{3}','{4}','{5}','{6}','{7}','{8}',@EMBLEM,@MASCOT,@LOGO,'{9}')", info.GUID, info.NAME, info.ISOUTSIDE, info.HOST_ORGANIZER, info.UNDERTAKE_ORGANIZER, info.CO_ORGANIZER, info.TEXTROOT, info.WEBROOT, info.SCREENROOT, info.MEMO);
        }

        protected override string UpdateSql()
        {
            Games info = (Games)Substance;
            return String.Format("UPDATE Games SET NAME = '{0}',ISOUTSIDE = {1},HOST_ORGANIZER = '{2}',UNDERTAKE_ORGANIZER = '{3}',CO_ORGANIZER = '{4}',TEXTROOT = '{5}',WEBROOT = '{6}',SCREENROOT = '{7}',EMBLEM = @EMBLEM,MASCOT = @MASCOT,LOGO = @LOGO,MEMO = '{8}' WHERE GUID = '{9}'", info.NAME, info.ISOUTSIDE, info.HOST_ORGANIZER, info.UNDERTAKE_ORGANIZER, info.CO_ORGANIZER, info.TEXTROOT, info.WEBROOT, info.SCREENROOT, info.MEMO, info.GUID); 
        }

        protected override string DeleteSql(string guid)
        {
            return String.Format("DELETE FROM Games WHERE GUID = '{0}'", guid); 
        }

        protected override string BaseSql()
        {
            return "SELECT * FROM Games";
        }
    }
}
