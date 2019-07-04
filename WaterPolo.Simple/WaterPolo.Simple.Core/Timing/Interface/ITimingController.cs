using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterPolo.Simple.Core.Timing.Interface
{
    public interface ITimingController
    {
        void Start();

        void Pause();

        void Reset();
    }

    public enum TimingType
    {
        Increase,
        Decrease
    }
}
