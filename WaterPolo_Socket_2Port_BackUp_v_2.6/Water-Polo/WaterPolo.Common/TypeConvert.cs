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

        public static string ToDateTimeString(this int seconds)
        {
            var ts = new TimeSpan(0, 0, 0, 0, seconds * 10);
            return
                $"{ts.Hours.ToString().PadLeft(2, '0')}:{ts.Minutes.ToString().PadLeft(2, '0')}:{ts.Seconds.ToString().PadLeft(2, '0')}.{ts.Milliseconds.ToString().PadLeft(2, '0')}";
        }

        public static int ToSeconds(this string item)
        {
            var date = item.ToDateTime();
             return date.Second + date.Minute * 60 + date.Hour * 3600;
        }
    }
}