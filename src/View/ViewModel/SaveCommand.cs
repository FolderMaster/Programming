using System;
using System.Windows.Input;

using View.Model.Services;

namespace View.ViewModel
{
    public class SaveCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter) => JsonSerializer.Save(parameter, ".json");
    }
}
