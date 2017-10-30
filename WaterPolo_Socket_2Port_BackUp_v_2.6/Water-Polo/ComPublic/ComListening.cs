using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Threading;
using ApplicationCommon;
using log4net;

namespace ComPublic
{
    public class ComListening
    {
        private static readonly ILog Log = LogManager.GetLogger("ComListening");

        public delegate void DataChangingCallback(List<string> msg);

        public int ByteTotal = 0;

        private readonly string _fileName;

        private Thread _thread;

        public ComListening(int port, int bit)
        {
            SCom = new SerialPort("COM" + port, bit, Parity.None, 8);
            _fileName = $"COM{port}_{bit}";
        }

        public string Name { get; set; }

        public SerialPort SCom { get; set; }

        public string Header { get; set; }

        public string Tail { get; set; }

        public bool Open()
        {
            try
            {
                SCom.Open();
                return true;
            }
            catch (Exception ex)
            {
                Log.Error($"Could not open com. {ex.Message}");
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
                Log.Error($"Could not close com. {ex.Message}");
                return false;
            }
        }

        public event DataChangingCallback DataChanging;

        public void Listening()
        {
            while (true)
            {
                var str = string.Empty;
                var mark = Convert.ToString(SCom.ReadByte(), 16).PadLeft(2, '0').ToUpper();
                Log.Debug($"Mark = {mark}");
                if (mark == Header)
                {
                    var i = 0;
                    while (true)
                    {
                        mark = Convert.ToString(SCom.ReadByte(), 16).PadLeft(2, '0').ToUpper();
                        Log.Debug($"Got the head then mark is {0}");
                        i++;
                        if (mark == Tail || i > 6)
                            break;
                        str += $"{mark},";
                    }
                    Log.Debug($"{Header},{ str.TrimEnd(',')},{Tail}");
                    var lst = new List<string>();
                    foreach (var s in str.Split(','))
                        lst.Add(s);
                    DataChanging?.Invoke(lst);
                }
            }
        }

        public void StartListening()
        {
            _thread = new Thread(Listening) { IsBackground = true };
            _thread.Start();
            Log.InfoFormat("Start listening");
        }

        public void EndListenning()
        {
            Log.InfoFormat("End Listening");
            _thread?.Abort();
            SCom.Close();
        }

        public void Dispose()
        {
            EndListenning();
            SCom?.Close();
        }
    }
}