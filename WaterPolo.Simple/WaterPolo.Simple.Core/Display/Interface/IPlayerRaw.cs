namespace WaterPolo.Simple.Core.Display.Interface
{
    public interface IPlayerRaw
    {
        string Number { get; set; }

        string Name { get; set; }

        int Fouls { get; set; }

        int FoulTime { get; set; }
    }
}