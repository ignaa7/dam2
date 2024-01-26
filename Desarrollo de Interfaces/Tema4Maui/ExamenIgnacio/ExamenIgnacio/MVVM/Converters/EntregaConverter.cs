using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIgnacio.MVVM.Converters
{
    public class EntregaConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if ((bool)value)
            {
                return "Justo a tiempo";
            }
            else
            {
                return "Queda poco";
            }
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value.ToString().Equals("Justo a tiempo"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
