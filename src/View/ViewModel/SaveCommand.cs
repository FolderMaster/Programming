using System;
using System.Windows.Input;

using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Класс команды сохранения с путём к файлу и данными.
    /// </summary>
    /// <typeparam name="T">Тип данных.</typeparam>
    public class SaveCommand<T> : ICommand
    {
        /// <summary>
        /// Путь к файлу.
        /// </summary>
        private string _filePath;

        /// <summary>
        /// Данные.
        /// </summary>
        private T? _data;

        /// <summary>
        /// Возращает и задаёт путь к файлу.
        /// </summary>
        public string FilePath
        {
            get => _filePath;
            set => _filePath = value;
        }

        /// <summary>
        /// Возращает и задаёт данные.
        /// </summary>
        public T? Data
        {
            get => _data;
            set => _data = value;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter) => JsonSerializer.Save(Data, FilePath);

        /// <summary>
        /// Создаёт экземпляр класса <see cref="SaveCommand{T}"/> по умолчанию.
        /// </summary>
        public SaveCommand() { }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="SaveCommand{T}"/>.
        /// </summary>
        /// <param name="filePath">Путь к файлу.</param>
        public SaveCommand(string filePath)
        {
            FilePath = filePath;
        }
    }
}
