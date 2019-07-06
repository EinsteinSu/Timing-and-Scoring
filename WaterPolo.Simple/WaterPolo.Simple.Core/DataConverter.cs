namespace WaterPolo.Simple.Core
{
    public static class DataConverter
    {
        public static int ToInt(string input)
        {
            int.TryParse(input, out var result);
            return result;
        }

        public static int ToInt(this object input)
        {
            return ToInt(input?.ToString());
        }
    }
}