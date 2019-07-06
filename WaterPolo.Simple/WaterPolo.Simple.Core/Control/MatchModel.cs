using System;
using DevExpress.Mvvm;
using WaterPolo.Simple.Core.Display;
using WaterPolo.Simple.Core.Timing.Interface;

namespace WaterPolo.Simple.Core.Control
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

            TimingControl = new TimingViewModel(480, TimingType.Decrease, true)
            {
                TimingChanged = time =>
                {
                    TotalTime = time;
                },
                DisplayFontSize = 80
            };

            #region for designing the UI

            //_teamA = new TeamModel { Name = "CHN", PauseTime = "1:00", Timeout = 1 };
            //_teamA.Players = new List<PlayerModel>();
            //for (int i = 0; i < 13; i++)
            //{
            //    _teamA.Players.Add(new PlayerModel { FoulTime = 20, Fouls = 3, Name = $"Player{i}", Number = $"{i + 1}" });
            //}

            //_teamB = new TeamModel { Name = "USA" };

            #endregion
        }

        public TimingViewModel TimingControl { get; set; }

        public Action TotalTimeChanged { get; set; }

        public string TotalTime
        {
            get => _totalTime;
            set
            {
                if (_totalTime != null && !_totalTime.Equals(value))
                {
                    TotalTimeChanged?.Invoke();
                }
                SetProperty(ref _totalTime, value, () => TotalTime);
            }
        }

        public int Court
        {
            get => _court;
            set => SetProperty(ref _court, value, () => Court);
        }

        public string CourtToString
        {
            get
            {
                switch (Court)
                {
                    case 1:
                        return "1st";
                    case 2:
                        return "2nd";
                    case 3:
                        return "3rd";
                    case 4:
                        return "4th";
                }
                return Court.ToInt() > 4 ? $"Extral({Court - 4})" : string.Empty;
            }
        }

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


        public Action<int> ThirtySecondsChanged { get; set; }
        public int ThirtySeconds
        {
            get => _thirtySeconds;
            set
            {
                if (value < _thirtySeconds)
                {
                    ThirtySecondsChanged?.Invoke(value);
                }
                SetProperty(ref _thirtySeconds, value, () => ThirtySeconds);
            }
        }
    }
}