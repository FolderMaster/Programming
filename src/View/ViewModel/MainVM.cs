using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using View.Model;

namespace View.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        private Contact _contact = new Contact();

        private ICommand _saveCommand = new SaveCommand();

        private ICommand _loadCommand = new LoadCommand();

        public Contact Contact
        {
            get => _contact;
            set
            {
                if (_contact != value)
                {
                    _contact = value;
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

        public ICommand SaveCommand => _saveCommand;

        public ICommand LoadCommand => _loadCommand;

        public event PropertyChangedEventHandler? PropertyChanged;

        public MainVM()
        {
        }
    }
}