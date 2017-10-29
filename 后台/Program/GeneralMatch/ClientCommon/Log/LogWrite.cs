using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientCommon
{
    public static class LogWrite
    {
        private static string GetFileDirectory()
        {
            string fileDirectory = string.Format(@"{0}\{1}\{2}\", ApplicationCommon.DirectoryHelper.LogDirectory, DateTime.Now.Year,
                DateTime.Now.Month.ToString().PadLeft(2,'0'));
            if (!System.IO.Directory.Exists(fileDirectory))
                System.IO.Directory.CreateDirectory(fileDirectory);
            return fileDirectory;
        }

        public static void WriteErrorLogs(string log, ErrorLogType t)
        {
            string fileName = GetFileDirectory() + DateTime.Now.Day.ToString().PadLeft(2,'0') + ".log";
            if (!System.IO.File.Exists(fileName))
                System.IO.File.Create(fileName).Close();
            using (System.IO.StreamWriter sw = System.IO.File.AppendText(fileName))
            {
                sw.WriteLine(string.Format("Error:{0} {1} {2}", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss "), t.ToString(), log));
            }
        }

        public static void WriteBroadcastLogs(string log)
        {
            string fileName = string.Format(@"{0}\{1}.log", ApplicationCommon.DirectoryHelper.BroadCastDirectory, DateTime.Now.ToString("yyyy_MM_dd"));
            if (!System.IO.File.Exists(fileName))
                System.IO.File.Create(fileName).Close();
            using (System.IO.StreamWriter sw = System.IO.File.AppendText(fileName))
            {
                sw.WriteLine(log);
            }
        }
    }
}
