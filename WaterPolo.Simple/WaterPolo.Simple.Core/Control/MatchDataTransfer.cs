using WaterPolo.Simple.Core.DataTransfer.Interface;
using WaterPolo.Simple.Core.Display;

namespace WaterPolo.Simple.Core.DataTransfer
{
    public class MatchDataTransfer : IDataTransfer<MatchModel>
    {
        public DataType Type => DataType.TimingAndScoring;
        public MatchModel Data { get; set; }
    }
}