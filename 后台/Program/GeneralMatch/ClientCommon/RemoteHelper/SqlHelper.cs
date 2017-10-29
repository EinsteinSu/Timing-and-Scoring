using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using RemoteCommon;
using System.Drawing;
using System.Windows.Forms;

namespace ClientCommon
{
    public static class SqlHelper
    {
        public static void RunSql(String sSql)
        {
            SqlManager sm = (SqlManager)Activator.GetObject(typeof(SqlManager), RemoteUrl.SqlConnect);
            sm.RunSql(sSql);
            sm.Dispose();
        }

        public static DataTable GetDataTable(String sSql)
        {
            SqlManager sm = (SqlManager)Activator.GetObject(typeof(SqlManager), RemoteUrl.SqlConnect);
            DataTable dt = new DataTable();
            dt = sm.GetDataTable(sSql);
            sm.Dispose();
            return dt;
        }

        public static void SaveImageByImage(String sSql, Image img,System.Drawing.Imaging.ImageFormat format)
        {
            SqlManager sm = (SqlManager)Activator.GetObject(typeof(SqlManager), RemoteUrl.SqlConnect);
            try
            {
                sm.SaveBinary(sSql, ApplicationCommon.BinaryHelper.ImageToByte(img,format));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                LogWrite.WriteErrorLogs(ex.Message, ErrorLogType.Sql);
            }
            finally
            {
                if (sm != null)
                    sm.Dispose();
            }
        }

        public static void SaveImageByBytes(String sSql, Byte[] imgByte)
        {
            SqlManager sm = (SqlManager)Activator.GetObject(typeof(SqlManager), RemoteUrl.SqlConnect);
            try
            {
                sm.SaveBinary(sSql, imgByte);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                LogWrite.WriteErrorLogs(ex.Message, ErrorLogType.Sql);
            }
            finally
            {
                if (sm != null)
                    sm.Dispose();
            }
        }

        public static void SaveImagesByBytes(String sSql, List<ImageSaveInfo> lst)
        {
            SqlManager sm = (SqlManager)Activator.GetObject(typeof(SqlManager), RemoteUrl.SqlConnect);
            try
            {
                sm.SaveBinarys(sSql, lst);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                LogWrite.WriteErrorLogs(ex.Message, ErrorLogType.Sql);
            }
            finally
            {
                if (sm != null)
                    sm.Dispose();
            }
        }

        public static string GetGuids(DataTable dt, string columnName)
        {
            string guid = "'-1',";
            foreach (DataRow dr in dt.Rows)
            {
                guid += string.Format("'{0}',", dr[columnName].ToString());
            }
            return guid.TrimEnd(',');
        }
    }
}
