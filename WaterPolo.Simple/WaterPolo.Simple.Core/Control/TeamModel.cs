using System.Collections.Generic;
using DevExpress.Mvvm;

namespace WaterPolo.Simple.Core.Control
{
    public class TeamModel : ViewModelBase
    {
        private string _capColor;
        private string _name;
        private string _pauseTime;
        private List<PlayerModel> _players;
        private int _score;
        private int _timeout;

        public TeamModel()
        {
            Score = 0;
            Timeout = 0;
            TimingControl = new TimingViewModel(61)
            {
                TimingChanged = time =>
                {
                    //todo: play sound
                    PauseTime = time;
                },
                DisplayFontSize = 50,
                Timesup = () => { PauseTime = string.Empty; },
                Reseted = () => { PauseTime = string.Empty; }
            };
        }

        public TimingViewModel TimingControl { get; set; }


        //todo process the image url to specify to the root folder/image
        public string Image
        {
            get
            {
                return $"pack://application:,,,/WaterPolo.Simple.Core.Control;component/Flags/{Name}.png";

            }
        }

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value, () => Name);
        }

        public int Score
        {
            get => _score;
            set => SetProperty(ref _score, value, () => Score);
        }

        //timeout count
        public int Timeout
        {
            get => _timeout;
            set => SetProperty(ref _timeout, value, () => Timeout);
        }

        public string PauseTime
        {
            get => _pauseTime;
            set => SetProperty(ref _pauseTime, value, () => PauseTime);
        }

        public string CapColor
        {
            get => _capColor;
            set => SetProperty(ref _capColor, value, () => CapColor);
        }

        public List<PlayerModel> Players
        {
            get => _players;
            set => SetProperty(ref _players, value, () => Players);
        }

        public void DecreaseFoulTimes()
        {
            foreach (var player in Players)
                player.DecreaseFoulTime();
        }
    }
}