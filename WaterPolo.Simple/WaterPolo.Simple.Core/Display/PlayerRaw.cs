using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterPolo.Simple.Core.Display;

namespace WaterPolo.Simple.Core.Display
{
    public class PlayerRaw : Player
    {
        //todo: change it to image and convert to visible or not visible
        public virtual bool Foul1 => Fouls > 0;
        public virtual bool Foul2 => Fouls > 1;
        public virtual bool Foul3 => Fouls > 2;

        public virtual string FoulTimeDisplay => FoulTime == 0 ? string.Empty : FoulTime.ToString();
    }
}
