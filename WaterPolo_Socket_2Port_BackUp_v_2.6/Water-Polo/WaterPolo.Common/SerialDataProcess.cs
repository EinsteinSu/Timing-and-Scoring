using System.Collections.Generic;

namespace WaterPolo.Common
{
    public interface ISerialDataProcess<out T>
    {
        T Process(List<string> messages);
    }

    public class ThirtySecondsProcess : ISerialDataProcess<int>
    {
        public int Process(List<string> msg)
        {
            if (msg[0].IsNumeric())
                if (msg[0].Length >= 2)
                {
                    var newMsg = msg[0].Substring(1, 1) + msg[0].Substring(0, 1);
                    var seconds = newMsg.ToInt();
                    return seconds * 100;
                }
                else
                {
                    var seconds = msg[0].ToInt();
                    return seconds * 100;
                }
            return 0;
        }
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
            if (msg.Count <= 5)
                return data;
            if (msg[5].Contains("E") && msg[5].Replace("E", "").IsNumeric())
                data.Court = msg[5].Replace("E", "").ToInt();
            if (msg[5].Contains("C") && msg[5].Replace("C", "").IsNumeric())
            {
                if (!_isAdd)
                {
                    data.TimeoutCountA++;
                    _isAdd = true;
                }
                if (msg[0].IsNumeric() && msg[1].IsNumeric())
                    data.PauseTimeA = $"00:{msg[0]}:{msg[1]}".ToSeconds() * 100;
            }
            if (msg[5].Contains("D") && msg[5].Replace("D", "").IsNumeric())
            {
                if (!_isAdd)
                {
                    data.TimeoutCountB++;
                    _isAdd = true;
                }
                if (msg[0].IsNumeric() && msg[1].IsNumeric())
                    data.PauseTimeB = $"00:{msg[0]}:{msg[1]}".ToSeconds() * 100;
            }
            else
            {
                if (msg[5].IsNumeric())
                    data.Court = msg[5].ToInt();
            }
            if (msg[0].IsNumeric() && msg[1].IsNumeric() && msg[5].Contains("C") &&
                msg[5].Contains("D"))
            {
                _isAdd = false;
                data.TotalTime = $"00:{msg[0]}:{msg[1]}".ToSeconds() * 100;
            }
            if (msg[3].IsNumeric())
                data.ScoreA = msg[3].ToInt();
            if (msg[4].IsNumeric())
                data.ScoreB = msg[4].ToInt();
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