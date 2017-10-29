using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace TestingConsole
{
    public class TestStringOrder
    {
        public TestStringOrder(int num, string str)
        {
            Num = num;
            //Str = AthleticsCommon.AthleticsHelper.GetTrackScore(str, 2);
        }
        public int Num { get; set; }

        public string Str { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            String HDid;
            ManagementClass cimobject1 = new ManagementClass("Win32_DiskDrive");
            ManagementObjectCollection moc1 = cimobject1.GetInstances();
            foreach (ManagementObject mo in moc1)
            {
                HDid = (string)mo.Properties["Model"].Value;
                Console.Write("硬盘序列号：" + HDid.ToString() + "\r\n");
            }

            string cpuInfo = "";//cpu序列号
            ManagementClass cimobject = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = cimobject.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                cpuInfo = mo.Properties["ProcessorId"].Value.ToString();
                //Console.Write("cpu序列号：" + cpuInfo.ToString());
            }
            Console.Read();
            //DateTime dt1 = DateTime.Parse("00:23:00");
            //DateTime dt2 = DateTime.Parse("00:25:01");
            //if (dt1 <= dt2)
            //{
            //    Console.Read();
            //}
            //Console.Write("请输入成绩：");
            //string score = Console.ReadLine();
            //int count = 2;
            //Console.Write("Score:{0}", GetTrackScore(score, count));
            //Console.Read();
        }

        public static string GetTrackScore(string score, int count)
        {
            string dScore = "0";
            int start = 0;

            #region 整理不要的0
            for (int i = 0; i < score.Length; i++)
            {
                int num = 0;
                try
                {
                    num = int.Parse(score.Substring(start, 1));
                }
                catch { }
                if (num > 0)
                    break;
                start++;
            }
            #endregion

            #region 整理小数位数
            dScore = score.Substring(start, score.Length - start);
            start = dScore.IndexOf(".");
            string str1 = dScore.Substring(0, start);
            string str2 = dScore.Substring(start + 1, dScore.Length - start - 1);
            if (str2.Length > count)
            {
                if (int.Parse(str2.Substring(count, 1)) > 0)
                {
                    str2 = str2.Substring(0, count - 1) + (int.Parse(str2.Substring(count - 1, 1)) + 1).ToString();
                }
                str2 = str2.Substring(0, count);
            }
            dScore = str1 + "." + str2;
            #endregion

            return dScore;
        }

        //TestStringOrder str1 = new TestStringOrder(0, "0:00:13.3380");
        //    TestStringOrder str2 = new TestStringOrder(1, "0:00:12.9070");
        //    List<TestStringOrder> list = new List<TestStringOrder>();
        //    list.Add(str1);
        //    list.Add(str2);
        //    var c = from data in list
        //            orderby data.Str
        //            select data;
        //    int i = 0;
        //    foreach (TestStringOrder t in c.ToList())
        //    {
        //        t.Num = i + 1;
        //        Console.WriteLine("Num:{0} Score:{1}", t.Num, t.Str);
        //        i++;
        //    }
        //    Console.Read();

        //Console.Write(ApplicationCommon.SystemLanguage.ONSYSTEMLANGUAGE.ONLANGUAGE.ToString());
        //Console.Read();
        //ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
        //ManagementObjectCollection nics = mc.GetInstances();
        //foreach (ManagementObject nic in nics)
        //{
        //    if (Convert.ToBoolean(nic["ipEnabled"]) == true)
        //    {
        //        try
        //        {
        //            Console.WriteLine((nic["IPAddress"] as String[])[0]);
        //            //Console.WriteLine((nic["IPSubnet"] as String[])[0]);
        //            //Console.WriteLine((nic["DefaultIPGateway"] as String[])[0]);
        //        }
        //        catch { }
        //    }
        //}
        //Console.Read();
    }
}
