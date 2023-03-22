using System;
using System.Windows.Input;

using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Класс команды загрузки с путём к файлу и обработчиком события загрузки данных.
    /// </summary>
    /// <typeparam name="T">Тип данных.</typeparam>
    public class LoadCommand<T> : ICommand
    {
        /// <summary>
        /// Путь к файлу.
        /// </summary>
        private string _filePath;

        /// <summary>
        /// Возращает и задаёт путь к файлу.
        /// </summary>
        public string FilePath
        {
            get => _filePath;
            set => _filePath = value;
        }

        /// <summary>
        /// Обработчик события загрузки данных.
        /// </summary>
        public event EventHandler<OnLoadedEventArgs<T>>? OnLoaded;

        /// <summary>
        /// Обработчик события изменения возможности выполнения команды.
        /// </summary>
        public event EventHandler? CanExecuteChanged;

        /// <summary>
        /// Проверяет, возможно ли выполнение комманды.
        /// </summary>
        /// <param name="parameter">Параметры команды.</param>
        /// <returns>Логическое значение, указывающее, возможно ли выполнение команды.</returns>
        public bool CanExecute(object? parameter) => true;

        /// <summary>
        /// Выполняет команду.
        /// </summary>
        /// <param name="parameter">Параметры команды.</param>
        public void Execute(object? parameter) =>
            OnLoaded?.Invoke(this, new OnLoadedEventArgs<T>(JsonSerializer.Load<T>(FilePath)));

        /// <summary>
        /// Создаёт экземпляр класса <see cref="LoadCommand{T}"/> по умолчанию.
        /// </summary>
        public LoadCommand() {}

        /// <summary>
        /// Создаёт экземпляр класса <see cref="LoadCommand{T}"/>.
        /// </summary>
        /// <param name="filePath">Путь к файлу.</param>
        public LoadCommand(string filePath)
        {
            FilePath = filePath;
        }
    }
}