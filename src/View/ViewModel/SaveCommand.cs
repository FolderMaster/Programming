using System;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    public class SaveCommand : ICommand
    {
        private string _filePath;

        private Contact? _contact;

        public string FilePath
        {
            get => _filePath;
            set => _filePath = value;
        }

        public Contact? Save
        {
            get => _contact;
            set => _contact = value;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter) => JsonSerializer.Save(Save, FilePath);

        public SaveCommand() { }

        public SaveCommand(string filePath)
        {
            FilePath = filePath;
        }
    }
}
