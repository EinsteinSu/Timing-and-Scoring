using System.IO.Ports;
using System.Threading.Tasks;
using log4net;

namespace WaterPolo.Simple.Core.DataTransfer.SerialDevice
{
    public abstract class SerialPortController
    {
        private readonly int _port;
        private readonly SerialPort _serialPort;

        private static readonly ILog Log = LogManager.GetLogger("SerialPortController");
        public SerialPortController(int port, int bitRate = 4800, int dataBits = 8)
        {
            _port = port;
            _serialPort = new SerialPort($"COM{port}", bitRate, Parity.None, dataBits);
        }

        protected abstract int Header { get; }


        protected abstract int Tail { get; }

        protected virtual int Length => 6;

        protected bool IsQuit { get; set; }

        protected abstract void ProcessData(int[] ints);

        public void StartListening()
        {
            _serialPort.Open();
            Task.Factory.StartNew(Listen);
            Log.Info($"Start Listening Port{_port}");
        }

        protected virtual void Listen()
        {
            while (true)
            {
                if (IsQuit)
                    break;
                if (_serialPort.ReadByte() == Header)
                {
                    var i = 0;
                    var bytes = new int[Length];
                    while (true)
                    {
                        var data = _serialPort.ReadByte();
                        if (data == Tail || i > Length)
                            break;
                        bytes[i] = data;
                        i++;
                    }
                    Log.Debug(string.Join(",", bytes));
                    ProcessData(bytes);
                }
            }
        }

        ~SerialPortController()
        {
            EndListening();
        }

        public void EndListening()
        {
            IsQuit = true;
            _serialPort?.Close();
            Log.Info($"Stop Listening Port ${_port}");
        }
    }
}