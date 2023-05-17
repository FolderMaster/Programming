using System;

namespace View.ViewModel
{
    /// <summary>
    /// Класс аргументов ввода текста с новым текстом и логическим значением отмены.
    /// </summary>
    public class TextInputArgs : EventArgs
    {
        /// <summary>
        /// Метод сеттера к логическому значению отмены.
        /// </summary>
        private readonly Action<bool> _setIsCancel;

        /// <summary>
        /// Возвращает и задаёт новый текст.
        /// </summary>
        public string NewText { get; private set; }

        /// <summary>
        /// Задаёт логическое значение отмены.
        /// </summary>
        public bool IsCancel
        {
            set => _setIsCancel(value);
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="TextInputArgs"/>.
        /// </summary>
        /// <param name="newText">Новый текст.</param>
        /// <param name="setIsCancel">Метод сеттера к логическому значению отмены.</param>
        public TextInputArgs(string newText, Action<bool> setIsCancel)
        {
            _setIsCancel = setIsCancel;
            NewText = newText;
        }
    }
}