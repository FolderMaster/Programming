using System.ComponentModel;
using View.Model;

namespace View.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        private const string _filePath = ".json";

        private Contact _contact;

        private SaveCommand _saveCommand;

        private LoadCommand _loadCommand;

        public Contact Contact
        {
            get => _contact;
            set
            {
                if (_contact != value)
                {
                    _contact = value;
                    _saveCommand.Save = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(Name)));
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(PhoneNumber)));
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(Email)));
                }
            }
        }

        public string Name
        {
            get => _contact.Name;
            set
            {
                if (_contact.Name != value)
                {
                    _contact.Name = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(Name)));
                }
            }
        }

        public string PhoneNumber
        {
            get => _contact.PhoneNumber;
            set
            {
                if (_contact.PhoneNumber != value)
                {
                    _contact.PhoneNumber = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(PhoneNumber)));
                }
            }
        }

        public string Email
        {
            get => _contact.Email;
            set
            {
                if (_contact.Email != value)
                {
                    _contact.Email = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(Email)));
                }
            }
        }

        public MainVM This => this;

        public SaveCommand SaveCommand => _saveCommand;

        public LoadCommand LoadCommand => _loadCommand;

        public event PropertyChangedEventHandler? PropertyChanged;

        public MainVM()
        {
            _loadCommand = new LoadCommand(_filePath);
            _saveCommand = new SaveCommand(_filePath);
            Contact = new Contact();
            _loadCommand.OnLoaded += _loadCommand_OnLoaded;
        }

        private void _loadCommand_OnLoaded(object? sender, LoadCommand.OnLoadedEventArgs e)
        {
            Contact = e.Load;
        }
    }
}