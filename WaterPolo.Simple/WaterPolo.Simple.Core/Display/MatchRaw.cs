using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.POCO;

namespace WaterPolo.Simple.Core.Display
{
    public class MatchRaw
    {
        public MatchRaw()
        {

        }

        public static MatchRaw Create()
        {
            return ViewModelSource.Create(() => new MatchRaw());
        }

        public virtual string TotalTime { get; set; }

        public virtual int Court { get; set; }

        public virtual bool IsTimeout { get; set; }

        public virtual TeamRaw TeamA { get; set; }

        public virtual TeamRaw TeamB { get; set; }

        public virtual int ThirtySeconds { get; set; }
    }
}
