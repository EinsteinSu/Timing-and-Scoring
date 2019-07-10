using System;
using System.Threading;
using log4net.Config;
using WaterPolo.Simple.Core.DataTransfer.SerialDevice;

namespace WaterPolo.Simple.SerialDevice.Tester
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            Console.WriteLine("Parameters: port, type, Click Q to quit the listening.");
            if (args.Length == 0)
                return;
            var port = int.Parse(args[0]);
            var type = int.Parse(args[1]);
            SerialPortController controller;
            if (type > 0)
                controller = new TotalTimeController(port)
                {
                    DisplayData = data => { Console.WriteLine($"total time:{data.Time}"); }
                };
            else
                controller = new ThirtySecondsTimeController(port)
                {
                    DisplayData = data => { Console.WriteLine($"30s: {data.Seconds}"); }
                };
            controller.StartListening();

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
                            controller?.EndListening();
                            break;
                    }
                }

                Thread.Sleep(100);
            }
        }
    }
}