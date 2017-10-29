using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientCommon;
using SubStance;

namespace Persistent
{
    public class ParamsPst : PersistentBase
    {
        public ParamsPst(object obj)
            : base(obj)
        {

        }

        protected override string InsertSql()
        {
            Params info = (Params)Substance;
            return String.Format("INSERT INTO Params (GUID,CLASS,NAME,ATTRIBUTE,ORDERID,MEMO) VALUES('{0}','{1}','{2}','{3}',{4},'{5}')", info.GUID, info.CLASS, info.NAME, info.ATTRIBUTE, info.ORDERID, info.MEMO);
        }

        protected override string UpdateSql()
        {
            Params info = (Params)Substance;
            return String.Format("UPDATE Params SET CLASS = '{0}',NAME = '{1}',ATTRIBUTE = '{2}',ORDERID = {3},MEMO = '{4}' WHERE GUID = '{5}'", info.CLASS, info.NAME, info.ATTRIBUTE, info.ORDERID, info.MEMO, info.GUID);
        }

        protected override string DeleteSql(string guid)
        {
            return String.Format("DELETE FROM Params WHERE GUID = '{0}'", guid);
        }

        protected override string BaseSql()
        {
            return "SELECT * FROM Params ORDER BY SID";
        }

        public static System.Data.DataTable GetParams(string c)
        {
            System.Data.DataTable dt = ClientCommon.SqlHelper.GetDataTable(string.Format(@"
                                            SELECT * FROM PARAMS WHERE CLASS = '{0}' ORDER BY ORDERID", c));
            return dt;
        }
    }
}
