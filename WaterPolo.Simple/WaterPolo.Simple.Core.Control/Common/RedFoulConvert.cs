using System;
using System.Globalization;
using System.Windows.Data;
using WaterPolo.Simple.Core.Control.Control;

namespace WaterPolo.Simple.Core.Control.Common
{
    public class RedFoulConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool result)
            {
                if (result)
                    return RedFoulButton.Dot;
            }
            return string.Empty;
           
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && value.ToString().Equals(RedFoulButton.Dot))
            {
                return true;
            }

            return false;
        }
    }
}
