using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using log4net.Config;

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
            XmlConfigurator.Configure();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //ApplicationControlCommon.SplashScreenHelper.ShowSplashScreen("欢迎使用云南体拓科技有限公司 水球管理软件 TTKJ-WP-SO-III",
                //Properties.Resources.Watchword);
            //ApplicationControlCommon.SplashScreenHelper.SplashScreen.QueueLoadingMessage("数据加载中 ...");
            System.Threading.Thread.Sleep(3000);

            //ApplicationControlCommon.SplashScreenHelper.InitialiseSplashScreenCloseSequence();

            Application.Run(new HomePage());

            
        }
    }
}
