using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace View.Converter
{
    /// <summary>
    /// Класс конвертора <see cref="bool"/> и <see cref="Visibility"/>.
    /// </summary>
    class BoolToVisibilityConverter : IValueConverter
    {
        /// <summary>
        /// Конвертирует значение <see cref="bool"/> к <see cref="Visibility"/>.
        /// </summary>
        /// <param name="value">Значение конвертации.</param>
        /// <param name="targetType">Тип назначения конвертации.</param>
        /// <param name="parameter">Дополнительный параметр.</param>
        /// <param name="culture">Сведения о культуре.</param>
        /// <returns><see cref="Visibility.Hidden"/> при true, в обратном случае
        /// <see cref="Visibility.Visible"/>.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            => (bool)value ? Visibility.Hidden : Visibility.Visible;

        /// <summary>
        /// Конвертирует значение <see cref="Visibility"/> к <see cref="bool"/>.
        /// </summary>
        /// <param name="value">Значение конвертации.</param>
        /// <param name="targetType">Тип назначения конвертации.</param>
        /// <param name="parameter">Дополнительный параметр.</param>
        /// <param name="culture">Сведения о культуре.</param>
        /// <returns>При  <see cref="Visibility.Hidden"/> и <see cref="Visibility.Hidden"/> true, а
        /// при <see cref="Visibility.Visible"/> - false.</returns>
        /// <exception cref="ArgumentException"></exception>
        public object ConvertBack(object value, Type targetType, object parameter,
            CultureInfo culture)
        {
            Visibility visibility = (Visibility)value;
            switch (visibility)
            {
                case Visibility.Visible:
                    return false;
                case Visibility.Hidden:
                case Visibility.Collapsed:
                    return true;
                default: throw new ArgumentException();
            }
        }
    }
}