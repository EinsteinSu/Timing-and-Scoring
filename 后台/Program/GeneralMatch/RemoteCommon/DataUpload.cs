using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemoteCommon
{
    public class DataUpload : MarshalByRefObject
    {
        public DataUpload()
        {

        }

        public bool UploadDataSet(byte[] bt, string fileName)
        {
            try
            {
                ApplicationCommon.BinaryHelper.ByteToFile(bt, string.Format("{0}", fileName));
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
