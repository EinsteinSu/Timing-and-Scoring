using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using WaterPolo.Simple.Core.DataTransfer.Interface;

namespace WaterPolo.Simple.Core.DataTransfer
{
    public class SocketController : ISocketController
    {
        private readonly int _compacity;
        private Server _server;
        private static readonly ILog Log = LogManager.GetLogger("SocketController");
        public SocketController(int compacity)
        {
            _compacity = compacity;
            Log.Info($"Campacity is {compacity}");
        }

        ~SocketController()
        {
            StopListening();
        }

        public void StartListening(IRequestProcess process, int port)
        {
            _server = new Server();
            Task.Factory.StartNew(() =>
            {
                _server.CreateListener(port, process, _compacity);
            });
        }

        public void StopListening()
        {
            _server?.QuitListener();
        }

        public class Server
        {
            private bool _isQuit;

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
                    tcpListener = new TcpListener(ipAddress, port);
                    tcpListener.Start();
                    Log.InfoFormat($"Listening {ipAddress}({port})");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
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
