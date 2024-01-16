using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_EjemploMVVM.MVVM.Converters
{
    public class BoolConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object parameter, CultureInfo culture)
        {
            var answer = value.ToString();

            if (answer == "yes")
                return true;
            return false;
        }

        public object? ConvertBack(object? value, Type targetType, object parameter, CultureInfo culture)
        {
            var boolean = (bool)value;

            if (boolean)
                return "yes";
            return "no";
        }
    }
}
