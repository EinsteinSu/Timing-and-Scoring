using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterPolo.Simple.Core.Display
{
    public class TeamRaw
    {
        public TeamRaw()
        {

        }

        public static TeamRaw Create()
        {
            return ViewModelSource.Create(() => new TeamRaw());
        }

        //todo process the image url to specify to the root folder/image
        public virtual string Image { get; set; }

        public virtual string Name { get; set; }

        public virtual int Score { get; set; }

        //timeout count
        public virtual int Timeout { get; set; }

        public virtual string PauseTime { get; set; }

        public virtual string CapColor { get; set; }

        public virtual PlayerRaw[] Players { get; set; }

        public void DecreaseFoulTimes()
        {
            foreach (var player in Players)
                player.DecreaseFoulTime();
        }
    }
}
