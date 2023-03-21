using System;
using System.ComponentModel;

using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// Класс логики обработки процессов основного окна приложения <see cref="MainWindow"/> с
    /// контактом, командами сохранения и загрузки.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Путь к файлу.
        /// </summary>
        private readonly string _filePath =
            Environment.GetFolderPath(Environment.SpecialFolder.Personal).ToString() +
            "\\Contacts\\contacts.json";

        /// <summary>
        /// Контакт.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Команда сохранения.
        /// </summary>
        private SaveCommand<Contact> _saveCommand;

        /// <summary>
        /// Команда загрузки.
        /// </summary>
        private LoadCommand<Contact> _loadCommand;

        /// <summary>
        /// Возращает и создаёт контакт.
        /// </summary>
        public Contact Contact
        {
            get => _contact;
            set
            {
                if (_contact != value)
                {
                    _contact = value;
                    _saveCommand.Data = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(Name)));
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(PhoneNumber)));
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(Email)));
                }
            }
        }

        /// <summary>
        /// Возращает и создаёт ФИО контакта.
        /// </summary>
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

        /// <summary>
        /// Возращает и создаёт номер телефона контакта.
        /// </summary>
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

        /// <summary>
        /// Возращает и создаёт электронную почту контакта.
        /// </summary>
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

        /// <summary>
        /// Возращает команду сохранения.
        /// </summary>
        public SaveCommand<Contact> SaveCommand => _saveCommand;

        /// <summary>
        /// Возращает команду загрузки.
        /// </summary>
        public LoadCommand<Contact> LoadCommand => _loadCommand;

        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainVM"/> по умолчанию.
        /// </summary>
        public MainVM()
        {
            _loadCommand = new LoadCommand<Contact>(_filePath);
            _saveCommand = new SaveCommand<Contact>(_filePath);
            Contact = new Contact();
            _loadCommand.OnLoaded += _loadCommand_OnLoaded;
        }

        private void _loadCommand_OnLoaded(object? sender, OnLoadedEventArgs<Contact> e)
        {
            Contact = e.Load != null ? e.Load : Contact;
        }
    }
}