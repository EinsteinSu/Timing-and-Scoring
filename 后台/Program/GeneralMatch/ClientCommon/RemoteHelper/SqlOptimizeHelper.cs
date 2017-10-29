using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientCommon
{
    public class SqlOptimizeHelper
    {
        public static bool BHaveInSql(string tableName, params string[] pm)
        {
            RemoteCommon.SqlOptimize so = (RemoteCommon.SqlOptimize)Activator.GetObject(typeof(RemoteCommon.SqlOptimize), RemoteUrl.SqlOptimizeConnect);
            return so.BHaveInSql(tableName, pm);
        }
    }
}
