using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RemoteCommon
{
    public class DatabaseBackup : MarshalByRefObject
    {
        public DatabaseBackup()
        {
        }

        static string _file;
        public Byte[] GetBackupData()
        {
            SqlManager sm = new SqlManager();
            sm.RunSql(string.Format(@"BACKUP DATABASE {0} TO DISK = '{1}\backup.bak'", SqlConnect.ONSQLCONNECT.DATABASENAME, ApplicationCommon.DirectoryHelper.TempDirectory));
            sm.Dispose();
            try
            {
                string file = string.Format(@"{0}\backup.bak", ApplicationCommon.DirectoryHelper.TempDirectory);
                Byte[] bt = ApplicationCommon.BinaryHelper.FileToByte(string.Format(file));
                _file = file;
                return bt;
            }
            catch { return null; }
        }

        public bool DeleteFile()
        {
            try
            {
                File.Delete(_file);
                return true;
            }
            catch { return false; }
        }

        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
}
