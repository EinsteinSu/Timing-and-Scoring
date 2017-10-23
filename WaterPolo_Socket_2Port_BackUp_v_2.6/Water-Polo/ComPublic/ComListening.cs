using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace ComPublic
{
    public class ComListening
    {
        public string Name { get; set; }

        public System.IO.Ports.SerialPort SCom { get; set; }

        public string Header { get; set; }

        public string Tail { get; set; }

        public int ByteTotal = 0;

        string FileName = string.Empty;
        string Record;
        public ComListening(int port, int bit)
        {
            SCom = new System.IO.Ports.SerialPort("COM" + port.ToString(), bit, System.IO.Ports.Parity.None, 8);
            FileName = string.Format("COM{0}_{1}", port, bit);
            Record = string.Empty;
        }

        public bool Open()
        {
            try
            {
                SCom.Open();
                return true;
            }
            catch (Exception ex)
            {
                Record += ex.Message + "\r\n";
                return false;
            }
        }

        public bool Close()
        {
            try
            {
                SCom.Close();
                return true;
            }
            catch (Exception ex)
            {
                Record += ex.Message;
                return false;
            }
        }

        public delegate void DataChangingCallback(List<string> msg);
        public event DataChangingCallback DataChanging;

        public void Listening()
        {
            while (true)
            {
                string str = string.Empty;
                List<string> lst;
                string mark = Convert.ToString(SCom.ReadByte(), 16).PadLeft(2, '0').ToUpper();
                if (mark == Header)
                {
                    int i = 0;
                    while (true)
                    {
                        mark = Convert.ToString(SCom.ReadByte(), 16).PadLeft(2, '0').ToUpper();
                        i++;
                        if (mark == Tail || i > 6)
                            break;
                        str += string.Format("{0},", mark);
                    }
                    Record += string.Format("[{0}]:{2},{1},{3}\r\n", DateTime.Now.ToString("HH:mm:ss"), str.TrimEnd(','), Header, Tail);
                    lst = new List<string>();
                    foreach (string s in str.Split(','))
                    {
                        lst.Add(s);
                    }
                    if (DataChanging != null)
                        DataChanging(lst);
                }
            }
        }

        Thread th;
        public void StartListening()
        {
            th = new Thread(Listening);
            th.IsBackground = true;
            th.Start();
            Record += string.Format("Start Listening.\r\n");
        }

        public void EndListenning()
        {
            WriteLog(Record + "\r\n");
            if (th != null)
                th.Abort();
            SCom.Close();
        }

        public void WriteLogByFinish()
        {
            Record += "End listening.\r\n";
            Record += "Finish game.\r\n";
            WriteLog(Record + "\r\n");
        }

        public void Dispose()
        {
            EndListenning();
            if (SCom != null)
                SCom.Close();
        }

        public void WriteLog(string text)
        {
            string fileName = string.Format(@"{0}\{1}{2}.log", ApplicationCommon.DirectoryHelper.LogDirectory, FileName, DateTime.Now.ToString("yyyyMMdd"));
            if (!File.Exists(fileName))
            {
                File.Create(fileName).Close();
            }
            using (StreamWriter sw = new StreamWriter(fileName, true))
            {
                sw.Write(string.Format("[{0}]:{1}\r\n", DateTime.Now.ToString("HH:mm:ss"), text));
            }
        }
    }
}
