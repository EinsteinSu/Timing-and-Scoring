using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClientCommon
{
    public class SystemImages
    {
        static ImageList _onImageList;
        public static ImageList OnImageList
        {
            get
            {
                if (_onImageList == null)
                {
                    _onImageList = new ImageList();
                    RefreshImageList();
                }
                return _onImageList;
            }
            set
            {
                _onImageList = value;
            }
        }

        public static void RefreshImageList()
        {
            _onImageList = new ImageList();
            _onImageList.ImageSize = new System.Drawing.Size(32, 32);
            _onImageList.ColorDepth = ColorDepth.Depth32Bit;
            System.Data.DataTable dt = SqlHelper.GetDataTable("SELECT * FROM FUNCTIONIMAGES");
            dt.DefaultView.Sort = "ImageIndex";
            dt = dt.DefaultView.ToTable();
            foreach (System.Data.DataRow dr in dt.Rows)
            {
                string path = string.Format(@"{0}\{1}.jpg", ApplicationCommon.DirectoryHelper.TempDirectory, dr["Guid"]);
                System.Drawing.Image img = ApplicationCommon.BinaryHelper.ByteToImage(dr["Image"] as Byte[],
                    path);
                if (img != null)
                    _onImageList.Images.Add(img);
                try
                { System.IO.File.Delete(path); }
                catch { }
            }
        }

        public static  System.Drawing.Image GetImage(int index)
        {
            System.Drawing.Image img;
            try
            {
                img = OnImageList.Images[index];
            }
            catch
            {
                img = null;
            }
            return img;
        }
    }
}
