using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemoteCommon
{
    public delegate void BroadCastEventHandler(string info);

    public interface IBroadCast
    {
        event BroadCastEventHandler BroadCastEvent;
        void BroadCastingInfo(string info);
    }
}
