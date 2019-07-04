using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterPolo.Simple.Core.DataTransfer;
using WaterPolo.Simple.Core.DataTransfer.Interface;
using System.Net.Sockets;

namespace WaterPolo.Simple.Socket.Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var cki = Console.ReadKey(true);
                    int port = 0;
                    switch (cki.Key)
                    {
                        case ConsoleKey.S:
                            Console.WriteLine("Enter an Ip Address");
                            var ipAddress = Console.ReadLine();
                            Console.WriteLine("Enter a port");
                            port = int.Parse(Console.ReadLine());
                            SocketHelper.SendMessage(ipAddress, port, "Testing", 512);
                            break;
                        case ConsoleKey.L:
                            Console.WriteLine("Enter a port");
                             port = int.Parse(Console.ReadLine());
                            SocketController controller = new SocketController(1024);
                            controller.StartListening(new DataProcess(), port);
                            break;
                    }
                }
            }
        }

        public class DataProcess : IRequestProcess
        {
            public void Process(TcpClient client, NetworkStream stream, byte[] bytesReceived)
            {
                string response = "I got it";
                try
                {
                    var message = Encoding.Unicode.GetString(bytesReceived, 0, bytesReceived.Length);
                    Console.WriteLine(message);
                }
                catch (Exception e)
                {
                    response = "error";
                }

                var bytesSent = Encoding.Unicode.GetBytes(response);
                stream.Write(bytesSent, 0, bytesSent.Length);
            }
        }
    }
}
