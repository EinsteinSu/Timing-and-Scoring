using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demostrations
{
    public class SocketController : IDisposable
    {
        public const int Compacity = 256;

        private Server _server;
        public void StartServer(IRequestProcess process, int port)
        {
            _server = new Server(process);
            Task.Factory.StartNew(() =>
            {

                _server.CreateListener(port);
            });
        }

        public void StopServer()
        {
            _server?.QuitListener();
        }

        public static void SendMessage(string ipAddress, int port, string message)
        {
            try
            {
                var client = new TcpClient(ipAddress, port);
                var data = Encoding.Unicode.GetBytes(message);
                var stream = client.GetStream();
                stream.Write(data, 0, data.Length);
                Console.WriteLine("already sent message");
                data = new byte[Compacity];
                var bytes = stream.Read(data, 0, data.Length);
                var responseData = Encoding.Unicode.GetString(data, 0, bytes);
                Console.WriteLine(responseData);
                stream.Close();
                client.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Dispose()
        {
            StopServer();
        }

        public class Server
        {
            private readonly IRequestProcess _process;
            private bool _isQuit;
            public Server(IRequestProcess process)
            {
                _process = process;
            }

            public void CreateListener(int port)
            {
                TcpListener tcpListener;
                var ipAddress = Dns.GetHostEntry("localhost").AddressList[0];
                try
                {
                    tcpListener = new TcpListener(ipAddress, port);
                    tcpListener.Start();
                    Console.WriteLine("Listening ...");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

                while (true)
                {
                    if (_isQuit)
                    {
                        break;
                    }
                    Thread.Sleep(10);
                    var tcpClient = tcpListener.AcceptTcpClient();
                    var bytes = new byte[Compacity];
                    var stream = tcpClient.GetStream();
                    stream.Read(bytes, 0, bytes.Length);
                    _process.Process(tcpClient, stream, bytes);
                }
            }

            public void QuitListener()
            {
                _isQuit = true;
            }
        }

        public interface IRequestProcess
        {
            void Process(TcpClient client, NetworkStream stream, byte[] bytesReceived);
        }
    }

}
