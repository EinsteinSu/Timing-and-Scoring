using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemoteCommon
{
    public class EventWrapper : MarshalByRefObject
    {
        public event BroadCastEventHandler LocalBroadCastEvent;

        //[OneWay]
        public void BroadCasting(string message)
        {
            LocalBroadCastEvent(message);
        }

        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
}
