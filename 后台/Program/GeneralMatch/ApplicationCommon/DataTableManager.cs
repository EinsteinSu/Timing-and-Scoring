using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace ApplicationCommon
{
    public static class DataTableManager
    {
        public static DataTable LoadingData(string fileName)
        {
            DataTable dt = new DataTable();
            string filePath = string.Format(@"{0}\{1}.xml", ApplicationCommon.DirectoryHelper.DataDirectory, fileName);
            try
            {
                dt.ReadXml(filePath);
            }
            catch
            {
                MessageBox.Show("数据读取错误！");
            }
            return dt;
        }

        public delegate DataTable CreateTable();
        public static DataTable LoadingData(string fileName, CreateTable c)
        {
            DataTable dt = new DataTable();
            string filePath = string.Format(@"{0}\{1}.xml", ApplicationCommon.DirectoryHelper.DataDirectory, fileName);
            if (System.IO.File.Exists(filePath))
                dt.ReadXml(filePath);
            else
                dt = c();
            return dt;
        }

        public static void SaveData(string fileName, DataTable dt)
        {
            string filePath = string.Format(@"{0}\{1}.xml", ApplicationCommon.DirectoryHelper.DataDirectory, fileName);
            try
            {
                dt.TableName = fileName;
                dt.AcceptChanges();
                dt.WriteXml(filePath, XmlWriteMode.WriteSchema, false);
                MessageBox.Show("保存成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存失败:" + ex.Message);
            }
        }

        public static void SaveData(IDataOpreate operate)
        {
            SaveData(operate.FileName, operate.SourceTable);
        }

        public static void SaveDataAs(string fileName, DataTable dt)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.FileName = fileName;
            sd.Filter = "Xml文件 (*.xml)|*.xml";
            if (sd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dt.TableName = fileName;
                    dt.AcceptChanges();
                    dt.WriteXml(sd.FileName, XmlWriteMode.WriteSchema, false);
                    MessageBox.Show("保存成功！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("保存失败:" + ex.Message);
                }
            }
        }

        public static void SaveDataAs(IDataOpreate operate)
        {
            SaveDataAs(operate.FileName, operate.SourceTable);
        }
    }
}
