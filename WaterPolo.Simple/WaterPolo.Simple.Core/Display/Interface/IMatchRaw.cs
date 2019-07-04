using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterPolo.Simple.Core.Display.RawData;

namespace WaterPolo.Simple.Core.Display.Interface
{
    public interface IMatchRaw
    {
        string TotalTime { get; set; }

        int Court { get; set; }

        bool IsTimeout { get; set; }

        TeamRaw TeamA { get; set; }

        TeamRaw TeamB { get; set; }

        int ThirtySeconds { get; set; }
    }
}
