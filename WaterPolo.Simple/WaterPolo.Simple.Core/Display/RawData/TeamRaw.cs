using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterPolo.Simple.Core.Display.Interface;

namespace WaterPolo.Simple.Core.Display.RawData
{
    public class TeamRaw : ITeamRaw
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Timeout { get; set; }
        public string PauseTime { get; set; }
        public string CapColor { get; set; }
        public List<PlayerRaw> Players { get; set; }
    }
}
