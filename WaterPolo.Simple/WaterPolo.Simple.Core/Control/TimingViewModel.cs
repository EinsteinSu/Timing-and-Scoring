using System;
using DevExpress.Mvvm;
using WaterPolo.Simple.Core.Timing;
using WaterPolo.Simple.Core.Timing.Interface;

namespace WaterPolo.Simple.Core.Control
{
    public class TimingViewModel : ViewModelBase
    {
        private readonly TimingController _timing;
        private int _displayFontSize;
        private string _displayTime;

        public TimingViewModel(long totalTime, TimingType type = TimingType.Decrease,
            bool showTimeWhenInitialized = false)
        {
            _timing = new TimingController
            {
                InitializeSeconds = totalTime,
                Type = type,
                DisplayAction = time => { DisplayTime = time; },
            };
            if (showTimeWhenInitialized) DisplayTime = _timing.DisplayTime;
            _displayFontSize = 10;
            ResetCommand = new DelegateCommand(Reset);
            PauseCommand = new DelegateCommand(Pause, () => IsStarted);
            StartCommand = new DelegateCommand(Start, () => !IsStarted);
            CleanDisplayCommand = new DelegateCommand(CleanDisplay);
        }

        public Action<string> TimingChanged { get; set; }

        public Action Timesup
        {
            get => _timing?.TimesupAction;
            set => _timing.TimesupAction = value;
        }

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
            _timing.Start();
        }

        public void CleanDisplay()
        {
            Reset();
            DisplayTime = "";
        }

        public Action Reseted { get; set; }
        public void Reset()
        {
            IsStarted = false;
            _timing.Reset();
            DisplayTime = _timing.DisplayTime;
            _timing.Pause();
            Reseted?.Invoke();
        }

        public void Pause()
        {
            IsStarted = false;
            _timing.Pause();
        }
    }
}