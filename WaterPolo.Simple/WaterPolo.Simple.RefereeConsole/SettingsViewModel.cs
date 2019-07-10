using System;
using System.IO;
using DevExpress.Mvvm;
using WaterPolo.Simple.Core;
using WaterPolo.Simple.Core.Control;

namespace WaterPolo.Simple.RefereeConsole
{
    public class SettingsViewModel : ViewModelBase
    {
        private readonly string _rootFolder;
        private Settings _settings;
        protected string RootPath = AppDomain.CurrentDomain.BaseDirectory;

        public SettingsViewModel()
        {
            _rootFolder = Path.Combine(RootPath, "Data");
            var raw = SettingsHelper.LoadData<SettingsRaw>(_rootFolder, "Configs.config");
            _settings = new Settings();
            if (raw != null)
            {
                _settings.DisplayConsoleSettings.IpAddress = raw.IpAddress;
                _settings.DisplayConsoleSettings.Port = raw.Port;
                _settings.ThirtySecondsDevicePort = raw.ThirtySecondsDevicePort;
                _settings.TotalTimeDevicePort = raw.TotalTimeDevicePort;
                _settings.AutoShowTwentySeconds = raw.AutoShowTwentySeconds;
                _settings.SendToDisplayConsole = raw.SendToDisplayConsole;
                _settings.TwentySecondsRelatedToTotalTime = raw.TwentySecondsRelatedToTotalTime;
                _settings.AutoIncreasePauseCount = raw.AutoIncreasePauseCount;
                _settings.SendMessageInterval = raw.SendMessageInterval;
                _settings.DebugMode = raw.DebugMode;
                _settings.ScoreRelatedGoals = raw.ScoreRelatedGoals;
            }
        }

        public Settings Settings
        {
            get => _settings;
            set => SetProperty(ref _settings, value, () => Settings);
        }

        public void Save()
        {
            var raw = new SettingsRaw
            {
                IpAddress = Settings.DisplayConsoleSettings.IpAddress,
                Port = Settings.DisplayConsoleSettings.Port,
                TotalTimeDevicePort = Settings.TotalTimeDevicePort,
                ThirtySecondsDevicePort = Settings.ThirtySecondsDevicePort,
                AutoShowTwentySeconds = Settings.AutoShowTwentySeconds,
                SendToDisplayConsole = Settings.SendToDisplayConsole,
                TwentySecondsRelatedToTotalTime = Settings.TwentySecondsRelatedToTotalTime,
                AutoIncreasePauseCount = Settings.AutoIncreasePauseCount,
                SendMessageInterval = Settings.SendMessageInterval,
                DebugMode = Settings.DebugMode,
                ScoreRelatedGoals = Settings.ScoreRelatedGoals,
            };
            raw.SaveData(_rootFolder, "Configs.config");
        }
    }

    public class SettingsRaw
    {
        public string IpAddress { get; set; }

        public int Port { get; set; }

        public int TotalTimeDevicePort { get; set; }

        public int ThirtySecondsDevicePort { get; set; }

        public bool AutoShowTwentySeconds { get; set; }
        public bool SendToDisplayConsole { get; set; }

        public bool TwentySecondsRelatedToTotalTime { get; set; }

        public bool AutoIncreasePauseCount { get; set; }

        public int SendMessageInterval { get; set; }

        public bool DebugMode { get; set; }


        public bool ScoreRelatedGoals { get; set; }


        public static SettingsRaw InitialSettings()
        {
            return new SettingsRaw
            {
                IpAddress = "192.168.1.2",
                Port = 1234,
                TotalTimeDevicePort = 0,
                ThirtySecondsDevicePort = 0,
                AutoShowTwentySeconds = true,
                SendToDisplayConsole = true,
                TwentySecondsRelatedToTotalTime = false,
                AutoIncreasePauseCount = true,
                SendMessageInterval = 300,
                DebugMode = false,
                ScoreRelatedGoals = true,
            };

        }
    }

    public class Settings : ViewModelBase
    {
        private TransferSettings _displayConsoleSettings;
        private int _totalTimeDevicePort;
        private int _thirtySecondsDevicePort;
        private bool _autoShowTwentySeconds;
        private bool _sendToDisplayConsole;
        private bool _twentySecondsRelatedToTotalTime;
        private bool _autoIncreasePauseCount;
        private int _sendMessageInterval;
        private bool _debugMode;
        private bool _scoreRelatedGoals;

        public Settings()
        {
            _displayConsoleSettings = new TransferSettings();
        }

        public TransferSettings DisplayConsoleSettings
        {
            get => _displayConsoleSettings;
            set => SetProperty(ref _displayConsoleSettings, value, () => DisplayConsoleSettings);
        }

        public int TotalTimeDevicePort
        {
            get => _totalTimeDevicePort;
            set { SetProperty(ref _totalTimeDevicePort, value, () => TotalTimeDevicePort); }
        }

        public int ThirtySecondsDevicePort
        {
            get => _thirtySecondsDevicePort;
            set { SetProperty(ref _thirtySecondsDevicePort, value, () => ThirtySecondsDevicePort); }
        }

        public bool AutoShowTwentySeconds
        {
            get => _autoShowTwentySeconds;
            set { SetProperty(ref _autoShowTwentySeconds, value, () => AutoShowTwentySeconds); }
        }

        public bool SendToDisplayConsole
        {
            get => _sendToDisplayConsole;
            set { SetProperty(ref _sendToDisplayConsole, value, () => SendToDisplayConsole); }
        }

        public bool TwentySecondsRelatedToTotalTime
        {
            get => _twentySecondsRelatedToTotalTime;
            set { SetProperty(ref _twentySecondsRelatedToTotalTime, value, () => TwentySecondsRelatedToTotalTime); }
        }

        public bool AutoIncreasePauseCount
        {
            get => _autoIncreasePauseCount;
            set { SetProperty(ref _autoIncreasePauseCount, value, () => AutoIncreasePauseCount); }
        }

        public int SendMessageInterval
        {
            get => _sendMessageInterval;
            set => SetProperty(ref _sendMessageInterval, value, () => SendMessageInterval);
        }

        public bool DebugMode
        {
            get => _debugMode;
            set => SetProperty(ref _debugMode, value, () => DebugMode);
        }

        public bool ScoreRelatedGoals
        {
            get => _scoreRelatedGoals;
            set { SetProperty(ref _scoreRelatedGoals, value, () => ScoreRelatedGoals); }
        }
        
    }
}