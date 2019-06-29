using System.Collections.Generic;

namespace WaterPolo.Common
{
    public interface ISerialDataProcess<out T>
    {
        T Process(List<string> messages);
    }

    public class ThirtySecondsProcess : ISerialDataProcess<ThirySecondsData>
    {
        public ThirySecondsData Process(List<string> msg)
        {
            var data = new ThirySecondsData();
            if (msg[0].IsNumeric())
            {
                if (msg[0].Length >= 2)
                {
                    var newMsg = msg[0];
                    var seconds = newMsg.ToInt();
                    data.Seconds = seconds * 100;
                }
                else
                {
                    var seconds = msg[0].ToInt();
                    data.Seconds = seconds * 100;
                }
            }
            if (msg.Count > 2)
            {
                data.IsStopped = msg[2].Contains("FB");
            }
            return data;
        }
    }

    public class ThirySecondsData
    {
        public int Seconds { get; set; }

        public bool IsStopped { get; set; }
    }

    public class TotalTimeProcess : ISerialDataProcess<TotalTimeDeviceData>
    {
        private readonly int _timeoutCountA;
        private readonly int _timeoutCountB;
        private bool _isAdd;

        public TotalTimeProcess(bool isAdd, int timeoutCountA, int timeoutCountB)
        {
            _isAdd = isAdd;
            _timeoutCountA = timeoutCountA;
            _timeoutCountB = timeoutCountB;
        }

        public TotalTimeDeviceData Process(List<string> msg)
        {
            var data = new TotalTimeDeviceData { TimeoutCountA = _timeoutCountA, TimeoutCountB = _timeoutCountB };
            if (msg.Count <= 3)
                return data;

            data.TotalTime = $"00:{msg[0]}:{msg[1]}".ToSeconds() * 100;
            return data;
        }
    }

    public class TotalTimeDeviceData
    {
        public int TotalTime { get; set; }

        public int PauseTimeA { get; set; }

        public int PauseTimeB { get; set; }

        public int TimeoutCountA { get; set; }

        public int TimeoutCountB { get; set; }

        public int Court { get; set; }

        public int ScoreA { get; set; }

        public int ScoreB { get; set; }

        public override string ToString()
        {
            return
                $"Total:{TotalTime.ToDateTimeString()} Court: {Court}\r\nA: Timeout Count: {TimeoutCountA} Pause Time: {PauseTimeA.ToDateTimeString()} Score: {ScoreA} \r\nB: Timeout Count: {TimeoutCountB} Pause Time: {PauseTimeB.ToDateTimeString()} Score: {ScoreB} \r\n";
        }
    }
}