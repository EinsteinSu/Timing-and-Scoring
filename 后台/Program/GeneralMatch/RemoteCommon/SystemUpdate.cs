using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RemoteCommon
{
    public class SystemUpdate : MarshalByRefObject
    {
        public SystemUpdate()
        {

        }

        public bool BUpdate(SystemRelease release, out SystemRelease newRelese)
        {
            newRelese = release;
            var r = from data in SystemRelease.ONRELEASE
                    where double.Parse(data.RELEASE) > double.Parse(release.RELEASE)
                    orderby data.RELEASE
                    select data;
            foreach (SystemRelease rls in r)
            {
                newRelese = rls;
                return true;
            }
            return false;
        }

        public Byte[] GetUpdateFile(SystemRelease release)
        {
            try
            {
                Byte[] bt = ApplicationCommon.BinaryHelper.FileToByte(string.Format(ApplicationCommon.DirectoryHelper.UpdateDirectory + release.FILENAME));
                return bt;
            }
            catch { return null; }
        }

        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
}
