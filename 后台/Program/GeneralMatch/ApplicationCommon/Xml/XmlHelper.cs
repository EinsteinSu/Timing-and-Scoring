using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationCommon
{
    public static class XmlHelper
    {
        public static void SaveXml(object obj)
        {
            IXmlHelper iXml = obj as IXmlHelper;
            SaveXml(string.Format(@"{0}\{1}.xml", iXml.FilePath, iXml.FileName), obj);
        }

        public static string GetFileName(object obj)
        {
             IXmlHelper iXml = obj as IXmlHelper;
             return string.Format(@"{0}\{1}.xml", iXml.FilePath, iXml.FileName);
        }

        public static object LoadXml(object obj)
        {
            IXmlHelper iXml = obj as IXmlHelper;
            Type t = obj.GetType();
            return LoadXml(string.Format(@"{0}\{1}.xml", iXml.FilePath, iXml.FileName), t);
        }

        public static void SaveXml(string filePath, object obj)
        {
            SaveXml(filePath, obj, obj.GetType());
        }

        public static void SaveXml(string filePath, object obj, System.Type type)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(filePath))
            {
                System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(type);
                xs.Serialize(writer, obj);
                writer.Close();
            }
        }
        // XML -> OBJECT
        public static object LoadXml(string filePath, System.Type type)
        {
            if (!System.IO.File.Exists(filePath))
                return null;
            using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
            {
                System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(type);
                object obj = xs.Deserialize(reader);
                reader.Close();
                return obj;
            }
        }
    }
}
