using System.Windows;

using ViewModel;

namespace View.MessageShowable
{
    /// <summary>
    /// Класс отображения сообщения ошибки с <see cref="MessageBox"/>.
    /// </summary>
    class ErrorMessageBox : IMessageShowable
    {
        /// <summary>
        /// Отображает сообщение ошибки.
        /// </summary>
        /// <param name="message">Текст сообщения.</param>
        public void Show(string message) => MessageBox.Show(message, "Error", MessageBoxButton.OK,
            MessageBoxImage.Error);
    }
}