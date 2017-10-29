using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientCommon
{
    public static class SystemUpdateHelper
    {
        public static bool GetUpdateFile(RemoteCommon.SystemRelease release)
        {
            RemoteCommon.SystemUpdate au = (RemoteCommon.SystemUpdate)Activator.GetObject(typeof(RemoteCommon.SystemUpdate), RemoteUrl.UpdateConnect);
            ApplicationCommon.BinaryHelper.ByteToFile(au.GetUpdateFile(release), ApplicationCommon.DirectoryHelper.RunDirectory + @"\" + release.FILENAME);
            return true;
        }

        public static bool BUpdate(RemoteCommon.SystemRelease release, out RemoteCommon.SystemRelease newRelease)
        {
            RemoteCommon.SystemUpdate au = (RemoteCommon.SystemUpdate)Activator.GetObject(typeof(RemoteCommon.SystemUpdate), RemoteUrl.UpdateConnect);
            return au.BUpdate(release, out newRelease);
        }
    }
}
