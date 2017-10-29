using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace RemoteCommon
{
    public class SqlOptimize : MarshalByRefObject
    {
        public SqlOptimize()
        {

        }

        public bool BHaveInSql(string tableName, params string[] pm)
        {
            string filter = "0=0";
            string temp = string.Empty;
            int i = 0;
            foreach (string str in pm)
            {
                if (i % 2 == 0)
                    temp = string.Format(" and {0}=", str);
                else
                {
                    temp += string.Format("'{0}'", str);
                    filter += temp;
                }
                i++;
            }
            SqlManager sm = new SqlManager();
            DataTable GetDataTable = sm.GetDataTable(string.Format("SELECT * FROM {0} WHERE {1}", tableName, filter));
            sm.Dispose();
            if (GetDataTable.Rows.Count > 0)
                return true;
            return false;
        }

        public string GetItemSubString(string itemGuid, string subItemGuid)
        {
            string str = string.Empty;
            SqlManager sm = new SqlManager();
            DataTable GetDataTable = sm.GetDataTable(string.Format("SELECT * FROM ComSubItem WHERE ItemGuid = '{0}'", itemGuid));
            if (GetDataTable.Rows.Count > 0)
            {
                int index = 0;
                foreach (DataRow dr in GetDataTable.Rows)
                {
                    if (dr["subguid"].ToString() == subItemGuid)
                    {
                        index = GetDataTable.Rows.IndexOf(dr);
                        break;
                    }
                }
                str = string.Format("{0}/{1}", index + 1, GetDataTable.Rows.Count);
            }
            sm.Dispose();
            return str;
        }

        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
}
