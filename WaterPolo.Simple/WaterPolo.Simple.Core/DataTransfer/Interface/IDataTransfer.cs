using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterPolo.Simple.Core.DataTransfer.Interface
{
    public interface IDataTransfer<T>
    {
        DataType Type { get; set; }

        T Data { get; set; }
    }

    public enum DataType
    {
        TimingAndScoring, Setting
    }
}
