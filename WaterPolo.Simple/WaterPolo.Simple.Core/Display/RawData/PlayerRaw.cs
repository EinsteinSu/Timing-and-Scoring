using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterPolo.Simple.Core.Display.Interface;

namespace WaterPolo.Simple.Core.Display.RawData
{
    public class PlayerRaw : IPlayerRaw
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public int Fouls { get; set; }
        public int FoulTime { get; set; }
    }
}
