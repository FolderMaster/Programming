namespace ViewModel
{
    /// <summary>
    /// Интерфейс отображения сообщений.
    /// </summary>
    public interface IMessageShowable
    {
        /// <summary>
        /// Отображает сообщение.
        /// </summary>
        /// <param name="message">Текст сообщения.</param>
        public void Show(string message);
    }
}