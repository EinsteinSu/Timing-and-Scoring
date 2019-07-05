using System.Collections.Generic;
using DevExpress.Mvvm;
using WaterPolo.Simple.Core.Control;
using WaterPolo.Simple.Core.Display.Interface;
using WaterPolo.Simple.Core.Timing.Interface;

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
        private TimingViewModel _timingControl;

        public MatchModel()
        {
            TotalTime = TotalTimeValue;
            ThirtySeconds = ThirtySecondsValue;

            _timingControl = new TimingViewModel(480, TimingType.Decrease, true)
            {
                TimingChanged = (time) =>
                {
                    if (time == "0:00")
                    {
                        TotalTime = string.Empty;
                    }
                    else
                    {
                        TotalTime = time;
                    }
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

        public TimingViewModel TimingControl
        {
            get => _timingControl;
            set => _timingControl = value;
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