namespace WaterPolo.Simple.Core
{
    public static class DataConverter
    {
        public static int ToInt(string input)
        {
            var result = 0;
            int.TryParse(input, out result);
            return result;
        }

        public static int ToInt(this object input)
        {
            return ToInt(input?.ToString());
        }
    }
}