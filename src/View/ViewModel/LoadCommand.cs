using System;
using System.Reflection;
using System.Windows;
using System.Windows.Input;

using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    public class LoadCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
            if(parameter is MainVM mainVM)
            {
                mainVM.Contact = JsonSerializer.Load<Contact>(".json");
            }
        }
            
    }
}
