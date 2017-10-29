using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientCommon
{
    public static class RemoteUrl
    {
        public static string SqlConnect = RemoteConnect.GetRemoteUrl("SqlService");
        public static string DatabaseBackupConnect = RemoteConnect.GetRemoteUrl("DatabaseBackup");
        public static string HelpConnect = RemoteConnect.GetRemoteUrl("Help");
        public static string SqlOptimizeConnect = RemoteConnect.GetRemoteUrl("SqlOptimize");
        public static string UpdateConnect = RemoteConnect.GetRemoteUrl("SystemUpdate");

        public static void RefreshUrl()
        {
            SqlConnect = RemoteConnect.GetRemoteUrl("SqlService");
            DatabaseBackupConnect = RemoteConnect.GetRemoteUrl("DatabaseBackup");
            HelpConnect = RemoteConnect.GetRemoteUrl("Help");
            SqlOptimizeConnect = RemoteConnect.GetRemoteUrl("SqlOptimize");
            UpdateConnect = RemoteConnect.GetRemoteUrl("SystemUpdate");
        }
    }
}
