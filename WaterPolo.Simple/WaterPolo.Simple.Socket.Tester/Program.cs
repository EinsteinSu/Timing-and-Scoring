﻿using System;
using System.Net.Sockets;
using System.Text;
using log4net.Config;
using WaterPolo.Simple.Core.DataTransfer;
using WaterPolo.Simple.Core.DataTransfer.Interface;

namespace WaterPolo.Simple.Socket.Tester
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            while (true)
                if (Console.KeyAvailable)
                {
                    var cki = Console.ReadKey(true);
                    var port = 0;
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
                            var controller = new SocketController(1024);
                            controller.StartListening(new DataProcess(), port);
                            break;
                    }
                }
        }

        public class DataProcess : IRequestProcess
        {
            public void Process(TcpClient client, NetworkStream stream, byte[] bytesReceived)
            {
                var response = "I got it";
                try
                {
                    var message = Encoding.Unicode.GetString(bytesReceived, 0, bytesReceived.Length);
                    Console.WriteLine(message);
                }
                catch (Exception e)
                {
                    response = "error";
                }
            }
        }
    }
}