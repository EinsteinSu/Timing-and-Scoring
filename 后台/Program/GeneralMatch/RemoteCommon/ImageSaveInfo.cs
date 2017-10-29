using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemoteCommon
{
    [Serializable]
    public class ImageSaveInfo
    {
        public ImageSaveInfo()
        {

        }

        public ImageSaveInfo(string column)
        {
            this.COLUMN = column;
        }

        public ImageSaveInfo(string column, Byte[] bt)
        {
            this.COLUMN = column;
            this.BINARY = bt;
        }

        private String _Column;
        /// <summary>
        /// Column
        /// </summary>
        public String COLUMN
        {
            get { return _Column; }
            set { _Column = value; }
        }

        private Byte[] _Binary;
        /// <summary>
        /// Binary
        /// </summary>
        public Byte[] BINARY
        {
            get { return _Binary; }
            set { _Binary = value; }
        }
    }
}
