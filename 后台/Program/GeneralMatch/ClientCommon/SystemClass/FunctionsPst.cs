using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientCommon
{
    public class FunctionsPst:PersistentBase
    {
        public FunctionsPst(object obj)
            : base(obj)
        {
        }

        protected override string InsertSql()
        {
            Functions info = (Functions)Substance;
            return String.Format("INSERT INTO Functions (GUID,PGUID,NAME,NAME_EN,TYPE,DLL,MODLE,METHOD,IMAGEINDEX,MEMO,ORDERID) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',{8},'{9}',{10})", info.GUID, info.PGUID, info.NAME, info.NAME_EN, info.TYPE, info.DLL, info.MODLE, info.METHOD, info.IMAGEINDEX, info.MEMO, info.ORDERID);
        }

        protected override string UpdateSql()
        {
            Functions info = (Functions)Substance;
            return String.Format("UPDATE Functions SET PGUID = '{0}',NAME = '{1}',NAME_EN = '{2}',TYPE = '{3}',DLL = '{4}',MODLE = '{5}',METHOD = '{6}',IMAGEINDEX = {7},MEMO = '{8}',ORDERID = {9} WHERE GUID = '{10}'", info.PGUID, info.NAME, info.NAME_EN, info.TYPE, info.DLL, info.MODLE, info.METHOD, info.IMAGEINDEX, info.MEMO, info.ORDERID, info.GUID); 
        }

        protected override string DeleteSql(string guid)
        {
            return String.Format("DELETE FROM Functions WHERE GUID = '{0}' DELETE FROM ROLEFUNCTION WHERE FUNCTIONGUID = '{0}'", guid); 
        }

        protected override string BaseSql()
        {
            return "SELECT * FROM Functions ORDER BY ORDERID";
        }
    }
}
