namespace WaterPolo.Simple.Core.Control.Common
{
    public static class ActionHelper
    {
        public static object Increase(object content, int max = 0)
        {
            var item = content.ToInt();
            var value = item + 1;
            if (max > 0 && value > max)
                return max;
            return value.ToString();
        }

        public static object Decrease(object content, int min = 0)
        {
            var item = content.ToInt();
            var value = item - 1;
            if (min >= 0 && value < min)
                return min;
            return value.ToString();
        }

        public static object DecreaseTwentySeconds(object content)
        {
            return 0;
        }
    }
}