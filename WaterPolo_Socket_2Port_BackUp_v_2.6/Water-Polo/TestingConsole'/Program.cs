using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Text.RegularExpressions;
using System.Xml;
using System.IO;

namespace TestingConsole
{
    class Program
    {
        static Thread th;
        static System.IO.Ports.SerialPort com;
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\Administrator\Desktop\水球VRS_数据\VRS_数据\Athletes_CHN.xml");

            foreach (XmlAttribute atr in doc.DocumentElement.Attributes)
            {
                string a = atr.Name.ToString() + ":" + atr.Value.ToString();
                Console.Write(a);
            }

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                string guid = node.Attributes["GUID"].Value.ToString();
                Console.Write(guid  + "\r\n"); 
               
            }
            Console.Read();
        }

        public static string Read(string fileName, string node, string attribute)
        {
            string value = "";
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(fileName);
                XmlNode xn = doc.SelectSingleNode(node);
                value = (attribute.Equals("") ? xn.InnerText : xn.Attributes[attribute].Value);
            }
            catch { }
            return value;
        }

        public static object LoadXml(string fileName, System.Type type)
        {
            if (!System.IO.File.Exists(fileName))
                return null;
            using (System.IO.StreamReader reader = new System.IO.StreamReader(fileName))
            {
                System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(type);
                object obj = xs.Deserialize(reader);
                reader.Close();
                return obj;
            }
        }

        public static bool IsInt(string value)
        {
            return Regex.IsMatch(value, @"^[+-]?/d*$");
        }

        public static bool IsNumeric(string str)
        {
            char[] ch = new char[str.Length];
            ch = str.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] < 48 || ch[i] > 57)
                    return false;
            }
            return true;
        }

        ////通过串口取数据
        //private void SynReceiveData()
        //{
        //    MessageBox.Show("接收数据" + k);
        //    k++;
        //    string inputData = serialPort.ReadExisting();
        //    try
        //    {
        //        if (inputData != string.Empty)
        //        {
        //            if (inputData.Trim().Length == 45)
        //            {
        //                SetText(inputData);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //com = new System.IO.Ports.SerialPort("COM18", 4800, System.IO.Ports.Parity.None, 8);
        //    //Common.mycom c = new Common.mycom();
        //    //c.PortNum = 18;
        //    //c.BaudRate = 4800;
        //    //c.ByteSize = 0x8;
        //    //c.Parity = 0x0;
        //    //c.StopBits = 0x1;
        //    //c.ReadTimeout = 10;
        //    try
        //    {
        //        int a = 0;
        //        //a = int.Parse("01");
        //        //a = int.Parse("00");
        //        com.Open();
        //        //com.ReadBufferSize = 8;
        //        Console.Write("Open success!\r\n");
        //        while (true)
        //        {
        //            string str = string.Empty;
        //            //str = Convert.ToString(com.ReadByte(), 16).PadLeft(2, '0').ToUpper();
        //            string mark = Convert.ToString(com.ReadByte(), 16).PadLeft(2, '0').ToUpper();
        //            if (mark == "DF")
        //            {
        //                while (true)
        //                {
        //                    mark = Convert.ToString(com.ReadByte(), 16).PadLeft(2, '0').ToUpper();
        //                    if (mark == "CF")
        //                        break;
        //                    str += string.Format("{0},",mark);//Convert.ToString(com.ReadChar(), 16));
        //                }
        //                Console.Write(str.TrimEnd(',') + "\r\n");
        //            }
        //            if (mark == "EF")
        //            {
        //                while (true)
        //                {
        //                    mark = Convert.ToString(com.ReadByte(), 16).PadLeft(2, '0').ToUpper();
        //                    if (mark == "BF")
        //                        break;
        //                    str += string.Format("{0},", mark);//Convert.ToString(com.ReadChar(), 16));
        //                }
        //                Console.Write(str.TrimEnd(',') + "\r\n");
        //            }
        //            //else if (Convert.ToString(com.ReadByte(), 16).PadLeft(2, '0').ToUpper() == "BF")
        //            //{
        //            //    for (int i = 0; i < 5; i++)
        //            //    {
        //            //        str += string.Format("{0}", Convert.ToString(com.ReadByte(), 16).PadLeft(2, '0').ToUpper());//Convert.ToString(com.ReadChar(), 16));
        //            //    }
        //            //    Console.Write(str + "\r\n");
        //            //}
        //            //byte[] bt= c.Read(128);
        //        }
        //    }
        //    catch (Exception ex) { Console.Write("Open failed:{0}", ex); }
        //    Console.Read();
    }
}
