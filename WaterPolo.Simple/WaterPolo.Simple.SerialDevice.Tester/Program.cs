using System;
using System.Threading;
using WaterPolo.Simple.Core.DataTransfer.SerialDevice;

namespace WaterPolo.Simple.SerialDevice.Tester
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var port = int.Parse(args[0]);
            var serialPort = new TotalTimeController(port);
            serialPort.StartListening();
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var cki = Console.ReadKey(true);
                    switch (cki.Key)
                    {
                        case ConsoleKey.S:

                            break;
                        case ConsoleKey.O:
                            //SocketController.SendMessage("::1", 123, "test");
                            break;
                        case ConsoleKey.Q:
                            serialPort.EndListening();
                            break;
                    }
                }

                Thread.Sleep(100);
            }
        }
    }
}