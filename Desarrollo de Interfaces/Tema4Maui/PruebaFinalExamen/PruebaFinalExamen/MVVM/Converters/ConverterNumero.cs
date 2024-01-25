using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaFinalExamen.MVVM.Converters
{
    public class ConverterNumero : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if ((int)value == 0)
            {
                return "cero";
            }
            else if ((int)value == 1)
            {
                return "uno";
            }

            return "nada";
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value.ToString().Equals("cero"))
            {
                return 0;
            }
            else if (value.ToString().Equals("uno"))
            {
                return 1;
            }

            return -1;
        }
    }
}
