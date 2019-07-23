using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using WaterPolo.Simple.DataAccess;

namespace WaterPolo.Simple.DataCenter.New.Commons
{
    public class PlayerConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Player)
                return (Player)value;
            return null;
        }
    }

    public class PlayerListConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var items = new List<object>();
            if (value is IList<Player> players)
                foreach (var item in players)
                    items.Add(item);
            return items;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var results = new List<Player>();
            if (value is IList<object> items)
                foreach (var item in items)
                    results.Add((Player)item);

            return results;
        }
    }
}
