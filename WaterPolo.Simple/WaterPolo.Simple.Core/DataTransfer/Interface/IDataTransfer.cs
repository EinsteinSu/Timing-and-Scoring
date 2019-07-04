namespace WaterPolo.Simple.Core.DataTransfer.Interface
{
    public interface IDataTransfer<T>
    {
        DataType Type { get;  }

        T Data { get; set; }
    }

    public enum DataType
    {
        TimingAndScoring,
        Setting
    }
}