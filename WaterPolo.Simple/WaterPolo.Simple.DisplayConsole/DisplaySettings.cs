using DevExpress.Mvvm;
using Newtonsoft.Json;

namespace WaterPolo.Simple.DisplayConsole
{
    public class DisplaySettings
    {
        public double Left { get; set; }

        public double Top { get; set; }

        public double Height { get; set; }

        public double Width { get; set; }

        public int ListeningPort { get; set; }

        public int Campacity { get; set; }

        public bool DebugMode { get; set; }

        public string ListeningAddress { get; set; }

        public int DnsFlushInterval { get; set; }

        public static DisplaySettings InitialDisplaySettings()
        {
            return new DisplaySettings
            {
                Left = 0,
                Top = 0,
                Width = 1920,
                Height = 1080,
                ListeningPort = 1234,
                Campacity = 50000,
                DebugMode = false,
                ListeningAddress = "192.168.1.5",
                DnsFlushInterval = 1800000
            };
        }
    }
}