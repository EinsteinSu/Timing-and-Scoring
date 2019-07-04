using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WaterPolo.Simple.Core.Control.Common
{
    public class VisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool result)
                if (result)
                    return Visibility.Visible;
            return Visibility.Hidden;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Visibility result)
                if (result == Visibility.Visible)
                    return true;
            return false;
        }
    }
}