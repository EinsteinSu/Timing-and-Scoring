using DevExpress.Mvvm;
using WaterPolo.Simple.Core.Display.Interface;

namespace WaterPolo.Simple.Core.Display
{
    public class MatchModel : ViewModelBase
    {
        public const string TotalTimeValue = "8:00";
        public const int ThirtySecondsValue = 30;
        private int _court;
        private bool _isTimeout;
        private TeamModel _teamA;
        private TeamModel _teamB;
        private int _thirtySeconds;
        private string _totalTime;

        public MatchModel()
        {
            TotalTime = TotalTimeValue;
            ThirtySeconds = ThirtySecondsValue;
        }

        public string TotalTime
        {
            get => _totalTime;
            set => SetProperty(ref _totalTime, value, () => TotalTime);
        }

        public int Court
        {
            get => _court;
            set => SetProperty(ref _court, value, () => Court);
        }

        public string CourtToString => Court.ToString();

        public bool IsTimeout
        {
            get => _isTimeout;
            set => SetProperty(ref _isTimeout, value, () => IsTimeout);
        }

        public TeamModel TeamA
        {
            get => _teamA;
            set => SetProperty(ref _teamA, value, () => TeamA);
        }

        public TeamModel TeamB
        {
            get => _teamB;
            set => SetProperty(ref _teamB, value, () => TeamB);
        }

        public int ThirtySeconds
        {
            get => _thirtySeconds;
            set => SetProperty(ref _thirtySeconds, value, () => ThirtySeconds);
        }
    }
}