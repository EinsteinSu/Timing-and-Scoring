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