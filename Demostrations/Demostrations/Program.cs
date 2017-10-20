using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Newtonsoft.Json;

namespace Demostrations
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var socket = new SocketController();
            socket.StartServer(new SampleProcess(), 123);
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var cki = Console.ReadKey(true);
                    switch (cki.Key)
                    {
                        case ConsoleKey.S:
                            var data = new TestData();
                            data.Name = "Sue";
                            data.Orders = new List<string>();
                            for (int i = 0; i < 10; i++)
                            {
                                data.Orders.Add($"Orders {i}");
                            }
                            SocketController.SendMessage("::1", 123, JsonConvert.SerializeObject(data));
                            break;
                        case ConsoleKey.O:
                            SocketController.SendMessage("::1", 123, "test");
                            break;
                        case ConsoleKey.Q:
                            socket.StopServer();
                            break;
                    }
                }
                Thread.Sleep(100);
            }
        }

        private static void TimingTest()
        {
            var controller = new TimingController
            {
                InitializeSeconds = 5,
                Type = TimingType.Decrease
            };
            controller.DisplayAction = Console.WriteLine;
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var cki = Console.ReadKey(true);
                    switch (cki.Key)
                    {
                        case ConsoleKey.P:
                            Console.WriteLine("Stopping timing");
                            controller.Pause();
                            break;
                        case ConsoleKey.S:
                            Console.WriteLine("Starting timing");
                            controller.Start();
                            break;
                        case ConsoleKey.R:
                            Console.WriteLine("Reseting timing");
                            controller.Reset();
                            break;
                        case ConsoleKey.Q:
                            controller.Quit();
                            break;
                    }
                }
                Thread.Sleep(100);
            }
        }

        private class SampleProcess : SocketController.IRequestProcess
        {
            public void Process(TcpClient client, NetworkStream stream, byte[] bytesReceived)
            {
                string response;
                try
                {
                    var message = Encoding.Unicode.GetString(bytesReceived, 0, bytesReceived.Length);
                    var data = JsonConvert.DeserializeObject<TestData>(message);
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine($"Name: {data.Name}");
                    foreach (var dataOrder in data.Orders)
                    {
                        sb.AppendLine($"\t {dataOrder}");
                    }
                    response = sb.ToString();
                }
                catch (Exception e)
                {
                    response = "error";
                }

                var bytesSent = Encoding.Unicode.GetBytes(response);
                stream.Write(bytesSent, 0, bytesSent.Length);
            }
        }

        private class TestData
        {
            public string Name { get; set; }

            public List<string> Orders { get; set; }
        }
    }
}