using System;
using System.Globalization;
using Xamarin.Forms;

namespace XamarinUI.Converters
{
    public class Converter_ReverseBoolean : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !((bool)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}