using ComPublic;
using WaterPolo.Common;

namespace WaterPolo.SerialDevice.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var type = args[0];
            var port = args[1].ToInt();
            var bit = args[2].ToInt();
            var head = args[3];
            var tail = args[4];
            var com = new ComListening(port, bit) { Header = head, Tail = tail };
            System.Console.WriteLine("Start");
            if (com.Open())
            {
                System.Console.WriteLine("Start Listenings");
                com.StartListening();
                com.DataChanging += msg =>
                {
                    if (type == "30")
                    {
                        var process = new ThirtySecondsProcess();
                        System.Console.WriteLine(process.Process(msg));
                    }
                    else
                    {
                        var isAdd = false;
                        var timeoutA = 0;
                        var timeoutB = 0;
                        System.Console.WriteLine(string.Join(",",msg));
                        var process = new TotalTimeProcess(isAdd, timeoutA, timeoutB);
                        System.Console.WriteLine($"IsAdd:{isAdd}");
                        System.Console.WriteLine(process);
                    }
                };
            }

            System.Console.Read();
        }
    }
}