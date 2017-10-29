using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

namespace ApplicationCommon
{
    public class BinaryHelper
    {
        public static Byte[] FileToByte(String fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                Byte[] data = new byte[fs.Length];
                fs.Read(data, 0, (int)fs.Length);
                return data;
            }
        }

        public static void ByteToFile(Byte[] data, string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write))
            {
                fs.Write(data, 0, data.Length);
            }
        }

        public static Byte[] ImageToByte(Image img,System.Drawing.Imaging.ImageFormat format)
        {
            if (img != null)
            {
                System.IO.MemoryStream Ms = new System.IO.MemoryStream();
                img.Save(Ms, format);
                Byte[] imgByte = new byte[Ms.Length];
                Ms.Position = 0;
                Ms.Read(imgByte, 0, Convert.ToInt32(Ms.Length));
                Ms.Close();
                return imgByte;
            }
            return new Byte[0];
        }

        public static Image ByteToImage(Byte[] data, String SavePath)
        {
            ByteToFile(data, SavePath);
            try
            {
                return Image.FromFile(SavePath, true);
            }
            catch
            {
                return null;
            }
        }
    }
}
