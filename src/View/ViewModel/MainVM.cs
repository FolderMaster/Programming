using System;
using System.Collections.ObjectModel;
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
        /// Контакты.
        /// </summary>
        private ObservableCollection<Contact> _contacts;

        /// <summary>
        /// Выбранный контакт.
        /// </summary>
        private Contact? _selectedContact;

        /// <summary>
        /// Временный контакт.
        /// </summary>
        private Contact? _tempContact;

        /// <summary>
        /// Команда сохранения.
        /// </summary>
        private SaveCommand<ObservableCollection<Contact>> _saveCommand;

        /// <summary>
        /// Команда загрузки.
        /// </summary>
        private LoadCommand<ObservableCollection<Contact>> _loadCommand;

        /// <summary>
        /// Возвращает и задаёт контакты.
        /// </summary>
        public ObservableCollection<Contact> Contacts
        {
            get => _contacts;
            set
            {
                if (Contacts != value)
                {
                    if(Contacts != null)
                    {
                        _loadCommand.OnLoaded -= _loadCommand_OnLoaded;
                    }
                    _contacts = value;
                    _saveCommand.Data = value;
                    if (Contacts != null)
                    {
                        _loadCommand.OnLoaded += _loadCommand_OnLoaded;
                        SelectedContact = Contacts.Count > 0 ? Contacts[0] : null;
                    }
                    else
                    {
                        SelectedContact = null;
                    }
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(Contacts)));
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт выбранный контакт.
        /// </summary>
        public Contact? SelectedContact
        {
            get => _selectedContact;
            set
            {
                if (SelectedContact != value)
                {
                    _selectedContact = value;
                    TempContact = SelectedContact != null ?
                        (Contact)SelectedContact.Clone() : null;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(SelectedContact)));
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт временный контакт.
        /// </summary>
        public Contact? TempContact
        {
            get => _tempContact;
            set
            {
                if (TempContact != value)
                {
                    _tempContact = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(TempContact)));
                }
            }
        }

        /// <summary>
        /// Возвращает команду сохранения.
        /// </summary>
        public SaveCommand<ObservableCollection<Contact>> SaveCommand => _saveCommand;

        /// <summary>
        /// Возвращает команду загрузки.
        /// </summary>
        public LoadCommand<ObservableCollection<Contact>> LoadCommand => _loadCommand;

        /// <summary>
        /// Обработчик события изменения свойства.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainVM"/> по умолчанию.
        /// </summary>
        public MainVM()
        {
            _loadCommand = new LoadCommand<ObservableCollection<Contact>>(_filePath);
            _saveCommand = new SaveCommand<ObservableCollection<Contact>>(_filePath);
            Contacts = new ObservableCollection<Contact>()
            {
                new Contact("Affffff Affffff Affffffff", "", ""),
                new Contact("Affffff Affffff Affffffff", "", ""),
                new Contact("Affffff Affffff Affffffff", "", ""),
                new Contact("Affffff Affffff Affffffff", "", ""),
                new Contact("Affffff Affffff Affffffff", "", ""),
                new Contact("Affffff Affffff Affffffff", "", ""),
                new Contact("Affffff Affffff Affffffff", "", ""),
                new Contact("Affffff Affffff Affffffff", "", ""),
                new Contact("Affffff Affffff Affffffff", "", ""),
                new Contact("Affffff Affffff Affffffff", "", "")
            };
        }

        private void _loadCommand_OnLoaded(object? sender,
            OnLoadedEventArgs<ObservableCollection<Contact>> e)
        {
            Contacts = e.Load != null ? e.Load : Contacts;
        }
    }
}