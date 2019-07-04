using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;
using WaterPolo.Simple.DataAccess;

namespace WaterPolo.Simple.DataCenter.DataEdit.EditWindow
{
    public class PlayerConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var items = new List<object>();
            if (value is IList<Player> players)
            {
                foreach (Player item in players)
                {
                    items.Add(item);
                }
            }
            return items;


        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var results = new List<Player>();
            if (value is IList<object> items)
            {
                foreach (object item in items)
                {
                    results.Add((Player)item);
                }
            }

            return results;

        }
    }
}