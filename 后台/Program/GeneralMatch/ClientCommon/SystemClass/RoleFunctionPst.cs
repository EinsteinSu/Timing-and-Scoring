using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientCommon
{
    public class RoleFunctionPst:PersistentBase
    {
        public RoleFunctionPst(object obj)
            : base(obj)
        {

        }

        protected override string InsertSql()
        {
            RoleFunction info = (RoleFunction)Substance;
            return String.Format("INSERT INTO RoleFunction (GUID,ROLEGUID,FUNCTIONGUID,ISHAVE) VALUES('{0}','{1}','{2}',{3})", info.GUID, info.ROLEGUID, info.FUNCTIONGUID, info.ISHAVE);
        }

        protected override string UpdateSql()
        {
            RoleFunction info = (RoleFunction)Substance;
            return String.Format("UPDATE RoleFunction SET ROLEGUID = '{0}',FUNCTIONGUID = '{1}',ISHAVE = {2} WHERE GUID = '{3}'", info.ROLEGUID, info.FUNCTIONGUID, info.ISHAVE, info.GUID); 
        }

        protected override string DeleteSql(string guid)
        {
            return String.Format("DELETE FROM RoleFunction WHERE GUID = '{0}'", guid); 
        }

        protected override string BaseSql()
        {
            return "SELECT RF.*,F.NAME AS NAME,F.GUID AS FGUID,F.PGUID AS FPGUID,F.ORDERID FROM RoleFunction AS RF INNER JOIN Functions AS F ON RF.FUNCTIONGUID = F.GUID";
        }

        public string UpdateRoleFunction()
        {
            return @"INSERT INTO ROLEFUNCTION(GUID,ROLEGUID,FUNCTIONGUID,ISHAVE)
                        SELECT NEWID(),R.GUID AS ROLEGUID,F.GUID AS FUNCTIONGUID,0 FROM ROLE AS R LEFT JOIN FUNCTIONS AS F ON 1=1
                        WHERE R.GUID NOT IN(SELECT ROLEGUID FROM ROLEFUNCTION) AND F.GUID 
                        NOT IN (SELECT FUNCTIONGUID FROM ROLEFUNCTION)";
        }
    }
}
