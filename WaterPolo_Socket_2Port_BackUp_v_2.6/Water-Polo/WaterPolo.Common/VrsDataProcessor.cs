using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SocketPublic;

namespace WaterPolo.Common
{
    public interface IVrsDataProcessor
    {
        void SendTotalTime(Machine machine, string totalTimeA, string totalTimeB, int scoreA, int scoreB, int court);
    }

    public class VrsDataProcessor : IVrsDataProcessor
    {

        public void SendTotalTime(Machine machine, string totalTimeA, string totalTimeB, int scoreA, int scoreB, int court)
        {
            var bs = new byte[7];
            bs[0] = 0xDF;
            bs[1] = byte.Parse(totalTimeA.Split(':')[0]);
            bs[2] = byte.Parse(totalTimeB.Split(':')[1]);
            bs[3] = byte.Parse(scoreA.ToString());
            bs[4] = byte.Parse(scoreB.ToString());
            bs[5] = byte.Parse(court.ToString());
            bs[6] = 0xCF;
            machine.SendMessage(bs);
        }
    }
}
