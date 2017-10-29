using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ApplicationClient
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
            Login frm = new Login();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new HomePage());
            }
        }
    }
}
