using WaterPolo.Simple.Core.Display.Interface;

namespace WaterPolo.Simple.Core.Display.RawData
{
    public class MatchRaw : IMatchRaw
    {
        public string TotalTime { get; set; }
        public int Court { get; set; }
        public bool IsTimeout { get; set; }
        public TeamRaw TeamA { get; set; }
        public TeamRaw TeamB { get; set; }
        public int ThirtySeconds { get; set; }
    }
}