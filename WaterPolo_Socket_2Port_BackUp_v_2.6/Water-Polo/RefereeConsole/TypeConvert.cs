using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefereeConsole
{
    public static class TypeConvert
    {
        public static int ToInt(this string item)
        {
            int i;
            int.TryParse(item, out i);
            return i;
        }

        public static DateTime ToDateTime(this string item)
        {
            DateTime time;
            DateTime.TryParse(item, out time);
            return time;
        }
    }
}
