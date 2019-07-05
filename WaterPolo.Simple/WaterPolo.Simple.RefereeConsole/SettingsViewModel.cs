using System;
using System.IO;
using DevExpress.Mvvm;
using WaterPolo.Simple.Core;
using WaterPolo.Simple.Core.Control;

namespace WaterPolo.Simple.RefereeConsole
{
    public class SettingsViewModel : ViewModelBase
    {
        private Settings _settings;
        private readonly string rootFolder;
        protected string RootPath = AppDomain.CurrentDomain.BaseDirectory;

        public SettingsViewModel()
        {
            rootFolder = Path.Combine(RootPath, "Data");
            var raw = SettingsHelper.LoadData<SettingsRaw>(rootFolder, "Configs.config");
            _settings = new Settings();
            if (raw != null)
            {
                _settings.DisplayConsoleSettings.IpAddress = raw.IpAddress;
                _settings.DisplayConsoleSettings.Port = raw.Port;
            }
        }

        public Settings Settings
        {
            get => _settings;
            set => SetProperty(ref _settings, value, () => Settings);
        }

        public void Save()
        {
            var raw = new SettingsRaw();
            raw.IpAddress = Settings.DisplayConsoleSettings.IpAddress;
            raw.Port = Settings.DisplayConsoleSettings.Port;

            raw.SaveData(rootFolder, "Configs.config");
        }
    }

    public class SettingsRaw
    {
        public string IpAddress { get; set; }

        public int Port { get; set; }
    }

    public class Settings : ViewModelBase
    {
        private TransferSettings _displayConsoleSettings;

        public Settings()
        {
            _displayConsoleSettings = new TransferSettings();
        }

        public TransferSettings DisplayConsoleSettings
        {
            get => _displayConsoleSettings;
            set => SetProperty(ref _displayConsoleSettings, value, () => DisplayConsoleSettings);
        }
    }
}