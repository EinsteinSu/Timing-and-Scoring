using System;
using DevExpress.Mvvm;

namespace WaterPolo.Simple.Core.Control
{
    public class PlayerModel : ViewModelBase
    {
        public const int TwSeconds = 20;

        private int _fouls;
        private int _foulTime;
        private string _name;
        private string _number;

        public string Number
        {
            get => _number;
            set => SetProperty(ref _number, value, () => Number);
        }

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value, () => Name);
        }

        public Action<int, int> FoulsChanged { get; set; }

        public int Fouls
        {
            get => _fouls;
            set
            {
                FoulsChanged?.Invoke(_fouls, value);
                SetProperty(ref _fouls, value, () => Fouls);
            }
        }

        public int FoulTime
        {
            get => _foulTime;
            set => SetProperty(ref _foulTime, value, () => FoulTime);
        }

        //todo: change it to image and convert to visible or not visible
        public bool Foul1 => Fouls > 0;
        public bool Foul2 => Fouls > 1;
        public bool Foul3 => Fouls > 2;

        public string FoulTimeDisplay => FoulTime == 0 ? string.Empty : FoulTime.ToString();

        public void DecreaseFoulTime()
        {
            if (FoulTime > 0) FoulTime--;
        }
    }
}