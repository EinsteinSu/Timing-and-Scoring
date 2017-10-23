using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Water_Polo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ApplicationControlCommon.SplashScreenHelper.ShowSplashScreen("SHENZHEN 2011 UNIVERSIADE WATER-POLO MAJOR CONSOLE",
                Properties.Resources.Watchword);
            ApplicationControlCommon.SplashScreenHelper.SplashScreen.QueueLoadingMessage("Loading data ...");
            System.Threading.Thread.Sleep(3000);

            ApplicationControlCommon.SplashScreenHelper.InitialiseSplashScreenCloseSequence();

            Application.Run(new HomePage());

            
        }
    }
}
