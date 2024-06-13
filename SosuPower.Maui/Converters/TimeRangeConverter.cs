using System.Globalization;

namespace SosuPower.Maui.Converters
{
    public class TimeRangeConverter : IMultiValueConverter
    {
        /// <summary>
        /// Converts an array of DateTime values into a formatted string representing the time range.
        /// </summary>
        /// <param name="values">The array of DateTime values representing the start and end time.</param>
        /// <param name="targetType">The type of the binding target property.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>A formatted string representing the time range.</returns>
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Length != 2)
            {
                throw new ArgumentException("TimeRangeConverter requires two values");
            }

            if (values[0] is DateTime && values[1] is DateTime)
            {
                DateTime start = (DateTime)values[0];
                DateTime end = (DateTime)values[1];

                return $"{start:t} - {end:t}";
            }

            return null;
        }

        /// <summary>
        /// Not implemented
        /// </summary>
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
