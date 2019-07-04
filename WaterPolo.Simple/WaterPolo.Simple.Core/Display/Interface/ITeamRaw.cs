﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterPolo.Simple.Core.Display.RawData;

namespace WaterPolo.Simple.Core.Display.Interface
{
    public interface ITeamRaw
    {
        string Name { get; set; }

        int Score { get; set; }

        int Timeout { get; set; }

        string PauseTime { get; set; }

        string CapColor { get; set; }

        List<PlayerRaw> Players { get; set; }
    }
}