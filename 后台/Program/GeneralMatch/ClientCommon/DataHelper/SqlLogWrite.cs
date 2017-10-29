using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientCommon
{
    public static class SqlLogWrite
    {
        public static void WriteLog(ISqlOperateLog log, string sql, string tableID)
        {
            try
            {
                string sSql = String.Format(@"INSERT INTO SqlLogs (GUID,OPERATETYPE,TABLEGUID,TABLENAME,OPERATEUSERGUID,
                            OPERATEUSER,OPERATESQL,REMARKS) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                            Guid.NewGuid(), log.OperateType, tableID, log.OperateTable, SystemUsers.ONUSERS.GUID,
                            SystemUsers.ONUSERS.USERNAME,
                            sql.Replace("'", "''"), log.Remark);
                SqlHelper.RunSql(sSql);
            }
            catch (Exception ex)
            {
                LogWrite.WriteErrorLogs("写入数据库日志失败：" + ex.Message, ErrorLogType.Sql);
            }
        }
    }
}
