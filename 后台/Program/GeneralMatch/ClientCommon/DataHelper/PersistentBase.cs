using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ClientCommon
{
    public abstract class PersistentBase
    {
        protected object Substance;

        public PersistentBase(object obj)
        {
            Substance = obj;
        }

        /// <summary>
        /// 新增sql语句
        /// </summary>
        /// <returns>sql</returns>
        protected abstract String InsertSql();
        /// <summary>
        /// 更新sql语句
        /// </summary>
        /// <returns>sql</returns>
        protected abstract String UpdateSql();
        /// <summary>
        /// 删除sql语句
        /// </summary>
        /// <returns>sql</returns>
        protected abstract String DeleteSql(string guid);
        /// <summary>
        /// 创建基础sql语句
        /// </summary>
        /// <returns>sql</returns>
        protected abstract String BaseSql();

        public void Insert()
        {
            String sSql = InsertSql();
            string id = ApplicationCommon.ReflectionHelper.GetGuid(Substance);
            SqlHelper.RunSql(sSql);
            WriteLog(sSql);
        }

        public void InsertByImages(List<RemoteCommon.ImageSaveInfo> lst)
        {
            String sSql = InsertSql();
            string id = ApplicationCommon.ReflectionHelper.GetGuid(Substance);
            SqlHelper.SaveImagesByBytes(sSql, lst);
            WriteLog(sSql);
        }

        public void Update()
        {
            String sSql = UpdateSql();
            SqlHelper.RunSql(sSql);
            WriteLog(sSql);
        }

        public void UpdateByImages(List<RemoteCommon.ImageSaveInfo> lst)
        {
            String sSql = UpdateSql();
            SqlHelper.SaveImagesByBytes(sSql, lst);
            WriteLog(sSql);
        }

        public void Delete(string id)
        {
            String sSql = DeleteSql(id);
            SqlHelper.RunSql(sSql);
            WriteLog(id, sSql);
        }

        public DataTable GetDataTable()
        {
            DataTable dt = SqlHelper.GetDataTable(BaseSql());
            ISqlOperateLog log = Substance as ISqlOperateLog;
            if (log != null)
                dt.TableName = log.OperateTable;
            return dt;
        }

        public DataTable GetDataTable(string filter)
        {
            DataTable dt = SqlHelper.GetDataTable(BaseSql() + filter);
            ISqlOperateLog log = Substance as ISqlOperateLog;
            if (log != null)
                dt.TableName = log.OperateTable;
            return dt;
        }

        private void WriteLog(string guid, String sSql)
        {
            SqlLogWrite.WriteLog((ISqlOperateLog)Substance, sSql, guid);
        }

        private void WriteLog(String sSql)
        {
            SqlLogWrite.WriteLog((ISqlOperateLog)Substance, sSql, ((ISqlOperateLog)Substance).TableGuid);
        }
    }
}
