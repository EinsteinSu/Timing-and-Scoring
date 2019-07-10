using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using WaterPolo.Simple.Core.DataTransfer.Interface;

namespace WaterPolo.Simple.Core.DataTransfer
{
    public class SocketController : ISocketController
    {
        private static readonly ILog Log = LogManager.GetLogger("SocketController");
        private readonly int _compacity;
        private Server _server;

        public SocketController(int compacity)
        {
            _compacity = compacity;
            Log.Info($"Campacity is {compacity}");
        }

        public string IpAddress { get; set; }

        public void StartListening(IRequestProcess process, int port)
        {
            _server = new Server();
            if (!string.IsNullOrEmpty(IpAddress))
                _server.IpAddress = IpAddress;
            Task.Factory.StartNew(() => { _server.CreateListener(port, process, _compacity); });
        }

        public void StopListening()
        {
            _server?.QuitListener();
        }



        ~SocketController()
        {
            StopListening();
        }

        private class Server
        {
            private bool _isQuit;
            public string IpAddress { get; set; }

            /// <summary>
            ///     create a listener to retreive the request
            /// </summary>
            /// <param name="port">listening port</param>
            /// <param name="requestProcess">the interface that how to process the request</param>
            /// <param name="campacity">how big can be processed in per times.</param>
            public void CreateListener(int port, IRequestProcess requestProcess, int campacity)
            {
                TcpListener tcpListener;
                var ipAddress = Dns.GetHostEntry("localhost").AddressList[0];
                try
                {
                    if (!string.IsNullOrEmpty(IpAddress))
                        ipAddress = IPAddress.Parse(IpAddress);
                    tcpListener = new TcpListener(ipAddress, port);
                    tcpListener.Start();
                    Log.InfoFormat($"Listening {ipAddress}({port})");
                }
                catch (Exception e)
                {
                    Log.Error(e);
                    throw;
                }

                while (true)
                {
                    if (_isQuit)
                        break;
                    Thread.Sleep(10);
                    var tcpClient = tcpListener.AcceptTcpClient();
                    var bytes = new byte[campacity];
                    var stream = tcpClient.GetStream();
                    stream.Read(bytes, 0, bytes.Length);
                    requestProcess.Process(tcpClient, stream, bytes);
                }
            }

            public void QuitListener()
            {
                _isQuit = true;
            }
        }
    }
}