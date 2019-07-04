namespace WaterPolo.Simple.Core.Display
{
    public interface IPlayerRaw
    {
        string Number { get; set; }

        string Name { get; set; }

        int Fouls { get; set; }

        int FoulTime { get; set; }

        int OrderNumber { get; set; }
    }
}
