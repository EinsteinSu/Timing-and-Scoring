using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WaterPolo.Common.Test
{
    [TestClass]
    public class TotalTimeDeviceDataTest
    {
        [TestMethod]
        public void ToStringTest()
        {
            var data = new TotalTimeDeviceData
            {
                TotalTime = 30000,
                PauseTimeA = 8000,
                ScoreA = 1,
                TimeoutCountA = 1,
                PauseTimeB = 0,
                ScoreB = 2,
                TimeoutCountB = 2,
                Court = 3
            };
            Console.WriteLine(data);
        }
    }
}
