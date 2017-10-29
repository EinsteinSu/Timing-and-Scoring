using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientCommon
{
    public class DatabaseBackupHelper
    {
        public static void BackDatabase(string filePath)
        {
            RemoteCommon.DatabaseBackup sd = (RemoteCommon.DatabaseBackup)Activator.GetObject(typeof(RemoteCommon.DatabaseBackup), RemoteUrl.DatabaseBackupConnect);
            ApplicationCommon.BinaryHelper.ByteToFile(sd.GetBackupData(), filePath);
            sd.DeleteFile();
        }
    }
}
