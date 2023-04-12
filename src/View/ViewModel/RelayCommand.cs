using System;
using System.Windows.Input;

namespace View.ViewModel
{
    /// <summary>
    /// Класс команды с реализованным интерфейсом <see cref="ICommand"/>.
    /// </summary>
    class RelayCommand : ICommand
    {
        /// <summary>
        /// Действие выполнения.
        /// </summary>
        private Action<object?> _execute;

        /// <summary>
        /// Предикат проверки возможности выполнения.
        /// </summary>
        private Predicate<object?>? _canExecute;

        /// <summary>
        /// Обработчик события изменения возможности выполнения команды.
        /// </summary>
        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="RelayCommand"/>.
        /// </summary>
        /// <param name="execute">Действие выполнения.</param>
        /// <param name="canExecute">Предикат проверки возможности выполнения.</param>
        public RelayCommand(Action<object?> execute, Predicate<object?>? canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        /// <summary>
        /// Проверяет, возможно ли выполнение команды.
        /// </summary>
        /// <param name="parameter">Параметры команды.</param>
        /// <returns>Логическое значение, указывающее, возможно ли выполнение команды.</returns>
        public bool CanExecute(object? parameter) => _canExecute == null || _canExecute(parameter);

        /// <summary>
        /// Выполняет команду.
        /// </summary>
        /// <param name="parameter">Параметры команды.</param>
        public void Execute(object? parameter) => _execute(parameter);
    }
}