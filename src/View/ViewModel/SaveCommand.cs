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
        /// Возвращает и задаёт путь к файлу.
        /// </summary>
        public string FilePath
        {
            get => _filePath;
            set => _filePath = value;
        }

        /// <summary>
        /// Возвращает и задаёт данные.
        /// </summary>
        public T? Data
        {
            get => _data;
            set => _data = value;
        }

        /// <summary>
        /// Обработчик события изменения возможности выполнения команды.
        /// </summary>
        public event EventHandler? CanExecuteChanged;

        /// <summary>
        /// Проверяет, возможно ли выполнение команды.
        /// </summary>
        /// <param name="parameter">Параметры команды.</param>
        /// <returns>Логическое значение, указывающее, возможно ли выполнение команды.</returns>
        public bool CanExecute(object? parameter) => true;

        /// <summary>
        /// Выполняет команду.
        /// </summary>
        /// <param name="parameter">Параметры команды.</param>
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
