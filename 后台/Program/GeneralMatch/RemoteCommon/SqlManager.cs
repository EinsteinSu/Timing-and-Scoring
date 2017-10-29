using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace RemoteCommon
{
    public class SqlManager : MarshalByRefObject
    {
        private SqlConnection SqlCn;
        private SqlDataAdapter SqlDap;
        private SqlCommand SqlCmd;

        private bool Connect()
        {
            try
            {
                SqlCn = new SqlConnection();
                SqlCn.ConnectionString = SqlConnect.ConnectString;
                SqlCn.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable GetDataTable(String sSql)
        {
            DataTable dt = new DataTable();
            if (Connect())
            {
                try
                {
                    SqlDap = new SqlDataAdapter(sSql, SqlCn);
                    SqlDap.Fill(dt);
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    SqlCn.Close();
                }
            }
            return dt;
        }

        public SqlDataReader GetDataReader(String sSql)
        {
            if (Connect())
            {
                try
                {
                    SqlCmd = new SqlCommand();
                    SqlCmd.Connection = SqlCn;
                    SqlCmd.CommandText = sSql;
                    SqlDataReader dr = SqlCmd.ExecuteReader();
                    return dr;
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return null;
        }

        #region Binary data operate
        public void SaveBinary(String sSql, byte[] imgByte)
        {
            if (Connect())
            {
                try
                {
                    SqlCmd = new SqlCommand(sSql, SqlCn);
                    SqlCmd.Parameters.Add("@i", SqlDbType.Binary, imgByte.Length);
                    SqlCmd.Parameters["@i"].Value = imgByte;
                    SqlCmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    SqlCn.Close();
                }
            }
        }

        public void SaveBinarys(string sSql, List<ImageSaveInfo> img)
        {
            if (Connect())
            {
                try
                {
                    SqlCmd = new SqlCommand(sSql, SqlCn);
                    for (int i = 0; i < img.Count; i++)
                    {
                        SqlCmd.Parameters.Add("@" + img[i].COLUMN, SqlDbType.Binary, img[i].BINARY.Length);
                        SqlCmd.Parameters["@" + img[i].COLUMN].Value = img[i].BINARY;
                    }
                    SqlCmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    SqlCn.Close();
                }
            }
        }

        public byte[] GetBinary(String sSql)
        {
            if (Connect())
            {
                try
                {
                    DataTable dt = GetDataTable(sSql);
                    if (dt.Rows.Count > 0)
                    {
                        byte[] data = new byte[0];
                        data = (byte[])dt.Rows[0][0];
                        return data;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return null;
        }
        #endregion

        public void RunSql(String sSql)
        {
            if (Connect())
            {
                try
                {
                    SqlCmd = new SqlCommand();
                    SqlCmd.Connection = SqlCn;
                    SqlCmd.CommandText = sSql;
                    SqlCmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    SqlCn.Close();
                }
            }
        }

        public void Dispose()
        {
            if (SqlCn != null)
            {
                if (SqlCn.State == ConnectionState.Open)
                {
                    SqlCn.Close();
                }
            }
        }

        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
}
