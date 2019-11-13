using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace PersonasComboBox
{
    public class BooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value.ToString().ToLower())
            {
                case "mujer":
                    return "Recursos\\mujer.png";
                case "hombre":
                    return "Recursos\\hombre.png";
            }

            return "error";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.ToString().Contains("mujer.png"))
                return "mujer";
            else
                return "hombre";


        }
    }
}
