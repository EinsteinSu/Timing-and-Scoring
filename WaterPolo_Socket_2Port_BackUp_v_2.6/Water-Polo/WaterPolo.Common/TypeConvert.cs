using System;

namespace WaterPolo.Common
{
    public static class TypeConvert
    {
        public static int ToInt(this string item)
        {
            int.TryParse(item, out var i);
            return i;
        }

        public static DateTime ToDateTime(this string item)
        {
            DateTime.TryParse(item, out var time);
            return time;
        }
        public static bool IsNumeric(this string str)
        {
            if (str.Length == 0)
                return false;
            var ch = str.ToCharArray();
            foreach (char t in ch)
                if (t < 48 || t > 57)
                    return false;
            return true;
        }
    }
}