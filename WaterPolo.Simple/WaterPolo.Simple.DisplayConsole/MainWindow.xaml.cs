using System;
using System.IO;
using System.Windows;
using log4net.Config;
using WaterPolo.Simple.Core;

namespace WaterPolo.Simple.DisplayConsole
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        protected string RootPath = AppDomain.CurrentDomain.BaseDirectory;

        public MainWindow()
        {
            InitializeComponent();
            XmlConfigurator.Configure();
            var rootFolder = Path.Combine(RootPath, "Data");
            var settigns = SettingsHelper.LoadData<DisplaySettings>(rootFolder, "settings.config") ??
                           DisplaySettings.InitialDisplaySettings();
            Top = settigns.Top;
            Left = settigns.Left;
            Width = settigns.Width;
            Height = settigns.Height;
        }
    }
}