using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientCommon;
using SubStance;

namespace Persistent
{
    public class AreaPst : PersistentBase
    {
        public AreaPst(object obj)
            : base(obj)
        {

        }

        protected override string InsertSql()
        {
            Area info = (Area)Substance;
            return String.Format("INSERT INTO Area (GUID,NAME,IPADDRESS,PORT,MEMO) VALUES('{0}','{1}','{2}','{3}','{4}')", info.GUID, info.NAME, info.IPADDRESS, info.PORT, info.MEMO);
        }

        protected override string UpdateSql()
        {
            Area info = (Area)Substance;
            return String.Format("UPDATE Area SET NAME = '{0}',IPADDRESS = '{1}',PORT = '{2}',MEMO = '{3}' WHERE GUID = '{4}'", info.NAME, info.IPADDRESS, info.PORT, info.MEMO, info.GUID); 
        }

        protected override string DeleteSql(string guid)
        {
            return String.Format("DELETE FROM Area WHERE GUID = '{0}'", guid); 
        }

        protected override string BaseSql()
        {
            return "SELECT * FROM Area ORDER BY Sid";
        }
    }
}
