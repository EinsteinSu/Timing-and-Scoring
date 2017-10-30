using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WaterPolo.Common
{
    public interface ISerialDataProcess
    {
        void Process(List<string> messages);
    }

    public class ThirtySecondsProcess : ISerialDataProcess
    {
        public void Process(List<string> messages)
        {
        }
    }
}
