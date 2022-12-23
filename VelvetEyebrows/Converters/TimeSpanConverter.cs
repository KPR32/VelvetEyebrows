using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace VelvetEyebrows.Converters
{
    internal class TimeSpanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var timeSpan = (TimeSpan)value;
            int hour = (int)timeSpan.TotalSeconds / 3600;
            int minutes = (int)timeSpan.TotalSeconds / 60 - hour * 60;
            return hour.ToString().PadLeft(2, '0') + ":" + minutes.ToString().PadLeft(2, '0');
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
