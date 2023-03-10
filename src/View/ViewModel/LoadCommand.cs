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
        private string _filePath;

        public string FilePath
        {
            get => _filePath;
            set => _filePath = value;
        }

        public event EventHandler<OnLoadedEventArgs>? OnLoaded;

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter) =>
            OnLoaded?.Invoke(this, new OnLoadedEventArgs(JsonSerializer.Load<Contact>(FilePath)));

        public class OnLoadedEventArgs : EventArgs
        {
            public Contact? Load { get; set; }

            public OnLoadedEventArgs(Contact? load)
            {
                Load = load;
            }
        }

        public LoadCommand() {}

        public LoadCommand(string filePath)
        {
            FilePath = filePath;
        }
    }
}