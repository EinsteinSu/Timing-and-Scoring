using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using WaterPolo.Simple.Core.Timing;
using WaterPolo.Simple.Core.Timing.Interface;

namespace WaterPolo.Simple.Core.Control
{
    public class TimingViewModel : ViewModelBase
    {
        private string _displayTime;
        private readonly TimingController timing;
        private int _displayFontSize;

        public TimingViewModel(long totalTime, TimingType type = TimingType.Decrease, bool showTimeWhenInitialized = false)
        {
            timing = new TimingController
            {
                InitializeSeconds = totalTime,
                Type = type,
                DisplayAction = time =>
                {
                    DisplayTime = time;
                }

            };
            if (showTimeWhenInitialized)
            {
                DisplayTime = timing.DisplayTime;
            }
            _displayFontSize = 10;
            ResetCommand = new DelegateCommand(Reset);
            PauseCommand = new DelegateCommand(Pause, () => IsStarted);
            StartCommand = new DelegateCommand(Start, () => !IsStarted);
            CleanDisplayCommand = new DelegateCommand(CleanDisplay);
        }

        public Action<string> TimingChanged { get; set; }
        public string DisplayTime
        {
            get => _displayTime;
            set
            {
                SetProperty(ref _displayTime, value, () => DisplayTime);
                TimingChanged?.Invoke(value);
            }
        }

        public int DisplayFontSize
        {
            get => _displayFontSize;
            set => SetProperty(ref _displayFontSize, value, () => DisplayFontSize);
        }

        protected bool IsStarted { get; set; }

        public DelegateCommand ResetCommand { get; set; }

        public DelegateCommand StartCommand { get; set; }

        public DelegateCommand PauseCommand { get; set; }

        public DelegateCommand CleanDisplayCommand { get; set; }

        public void Start()
        {
            IsStarted = true;
            timing.Start();
        }

        public void CleanDisplay()
        {
            Reset();
            DisplayTime = "";
        }

        public void Reset()
        {
            IsStarted = false;
            timing.Reset();
            DisplayTime = timing.DisplayTime;
            timing.Pause();
        }

        public void Pause()
        {
            IsStarted = false;
            timing.Pause();
        }
    }
}
