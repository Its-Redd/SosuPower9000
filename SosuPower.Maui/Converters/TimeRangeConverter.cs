using System.Globalization;

namespace SosuPower.Maui.Converters
{
    public class TimeRangeConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Length != 2)
            {
                throw new ArgumentException("TimeRangeConverter requires two values");
            }

            if (values[0] == null || values[1] == null)
            {
                return null;
            }

            if (values[0] is DateTime && values[1] is DateTime)
            {
                DateTime start = (DateTime)values[0];
                DateTime end = (DateTime)values[1];

                return $"{start.ToString("t")} - {end.ToString("t")}";
            }

            return null;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
