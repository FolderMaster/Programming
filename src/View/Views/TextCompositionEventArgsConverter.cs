using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Input;

using View.ViewModel;

namespace View.Views
{
    /// <summary>
    /// Класс конвертора <see cref="TextCompositionEventArgs"/> к <see cref="TextInputArgs"/>.
    /// </summary>
    public class TextCompositionEventArgsConverter : IValueConverter
    {
        /// <summary>
        /// Конвертирует значение <see cref="TextCompositionEventArgs"/> к
        /// <see cref=TextInputArgs"/>.
        /// </summary>
        /// <param name="value">Значение конвертации.</param>
        /// <param name="targetType">Тип назначения конвертации.</param>
        /// <param name="parameter">Дополнительный параметр.</param>
        /// <param name="culture">Сведения о культуре.</param>
        /// <returns>Аналог <see cref="TextInputArgs"/> к
        /// <see cref="TextCompositionEventArgs"/>.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var args = value as TextCompositionEventArgs;
            return new TextInputArgs(args.Text, (bool h) => args.Handled = h);
        }

        /// <summary>
        /// Конвертирует значение <see cref=TextInputArgs"/> к
        /// <see cref="TextCompositionEventArgs"/> (метод не рабочий!).
        /// </summary>
        /// <param name="value">Значение конвертации.</param>
        /// <param name="targetType">Тип назначения конвертации.</param>
        /// <param name="parameter">Дополнительный параметр.</param>
        /// <param name="culture">Сведения о культуре.</param>
        /// <returns>Ошибка (метод не рабочий!).</returns>
        /// <exception cref="NotImplementedException">Ошибка (метод не рабочий!).</exception>
        public object ConvertBack(object value, Type targetType, object parameter,
            CultureInfo culture) => throw new NotImplementedException();
    }
}