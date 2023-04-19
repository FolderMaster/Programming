using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

using View.Model;
using View.Model.Services;
using View.Views;

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
        private ObservableCollection<Contact> _contacts = new ObservableCollection<Contact>();

        /// <summary>
        /// Выбранный контакт.
        /// </summary>
        private Contact? _selectedContact = null;

        /// <summary>
        /// Команда сохранения <see cref="Contacts"/>.
        /// </summary>
        private ICommand _saveCommand;

        /// <summary>
        /// Команда загрузки <see cref="Contacts"/>.
        /// </summary>
        private ICommand _loadCommand;

        /// <summary>
        /// Команда добавления нового контакта.
        /// </summary>
        private ICommand _addCommand;

        /// <summary>
        /// Команда изменения контакта <see cref="SelectedContact"/>.
        /// </summary>
        private ICommand _editCommand;

        /// <summary>
        /// Команда удаления контакта <see cref="SelectedContact"/>.
        /// </summary>
        private ICommand _removeCommand;

        /// <summary>
        /// Команда применения <see cref="AddCommand"/> или <see cref="EditCommand"/>.
        /// </summary>
        private ICommand _applyCommand;

        /// <summary>
        /// Команда отмены <see cref="AddCommand"/> или <see cref="EditCommand"/>.
        /// </summary>
        private ICommand _cancelCommand;

        /// <summary>
        /// Временный контакт.
        /// </summary>
        private Contact? _tempContact = null;

        /// <summary>
        /// Действие использующееся в <see cref="ApplyCommand"/>.
        /// </summary>
        private Action _applyAction;

        /// <summary>
        /// Выбранный контакт до действия.
        /// </summary>
        private Contact? _selectedContactBeforeAdd = null;

        /// <summary>
        /// Логическое значение, указывающее, выбрано ли действие.
        /// </summary>
        private bool _isActionUnselected = true;

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
                    _contacts = value;
                    if (Contacts != null)
                    {
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
                    IsActionUnselected = true;
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
        /// Возвращает и задаёт логическое значение, указывающее, выбрано ли действие.
        /// </summary>
        public bool IsActionUnselected
        {
            get => _isActionUnselected;
            set
            {
                if (IsActionUnselected != value)
                {
                    _isActionUnselected = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(IsActionUnselected)));
                }
            }
        }

        /// <summary>
        /// Возвращает команду сохранения <see cref="Contacts"/>.
        /// </summary>
        public ICommand SaveCommand => _saveCommand;

        /// <summary>
        /// Возвращает команду загрузки <see cref="Contacts"/>.
        /// </summary>
        public ICommand LoadCommand => _loadCommand;

        /// <summary>
        /// Возвращает команду добавления нового контакта.
        /// </summary>
        public ICommand AddCommand => _addCommand;

        /// <summary>
        /// Возвращает команду изменения контакта <see cref="SelectedContact"/>.
        /// </summary>
        public ICommand EditCommand => _editCommand;

        /// <summary>
        /// Возвращает команду удаления контакта <see cref="SelectedContact"/>.
        /// </summary>
        public ICommand RemoveCommand => _removeCommand;

        /// <summary>
        /// Возвращает команду применения <see cref="AddCommand"/> или <see cref="EditCommand"/>.
        /// </summary>
        public ICommand ApplyCommand => _applyCommand;

        /// <summary>
        /// Возвращает команду отмены <see cref="AddCommand"/> или <see cref="EditCommand"/>.
        /// </summary>
        public ICommand CancelCommand => _cancelCommand;

        /// <summary>
        /// Возвращает и задаёт интерфейс отображения сообщений.
        /// </summary>
        public IMessageShowable? MessageShowable { get; set; } = null;

        /// <summary>
        /// Обработчик события изменения свойства.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainVM"/> по умолчанию.
        /// </summary>
        public MainVM()
        {
            _saveCommand = new RelayCommand((object? obj) =>
            {
                try
                {
                    JsonSerializer.Save(Contacts, _filePath);
                }
                catch (Exception ex)
                {
                    if (MessageShowable != null)
                    {
                        MessageShowable.Show(ex.Message);
                    }
                }
            });

            _loadCommand = new RelayCommand((object? obj) =>
                {
                    try
                    {
                        Contacts = JsonSerializer.Load<ObservableCollection<Contact>>(_filePath) ??
                            new ObservableCollection<Contact>();
                    }
                    catch (Exception ex)
                    {
                        if (MessageShowable != null)
                        {
                            MessageShowable.Show(ex.Message);
                        }
                    }
                });

            _addCommand = new RelayCommand((object? obj) =>
                {
                    _selectedContactBeforeAdd = SelectedContact;
                    SelectedContact = null;
                    TempContact = new Contact();
                    _applyAction = () =>
                    {
                        Contacts.Add(TempContact);
                        SelectedContact = TempContact;
                    };
                    IsActionUnselected = false;
                }, (object? obj) => IsActionUnselected);

            _editCommand = new RelayCommand((object? obj) =>
                {
                    _applyAction = () =>
                    {
                        int selectedIndex = Contacts.IndexOf(SelectedContact);
                        Contacts[selectedIndex] = TempContact;
                        SelectedContact = Contacts[selectedIndex];
                    };
                    IsActionUnselected = false;
                }, (object? obj) => IsActionUnselected && Contacts.Count > 0);

            _removeCommand = new RelayCommand((object? obj) =>
                {
                    int selectedIndex = Contacts.IndexOf(SelectedContact);
                    Contacts.Remove(SelectedContact);
                    if (Contacts.Count > 0)
                    {
                        SelectedContact = selectedIndex < Contacts.Count ? Contacts[selectedIndex] :
                            Contacts[Contacts.Count - 1];
                    }
                    else
                    {
                        SelectedContact = null;
                    }
                }, (object? obj) => IsActionUnselected && Contacts.Count > 0);

            _applyCommand = new RelayCommand((object? obj) =>
                {
                    _applyAction();
                    IsActionUnselected = true;
                }, (object? obj) => !IsActionUnselected);

            _cancelCommand = new RelayCommand((object? obj) =>
                {
                    if (SelectedContact != null)
                    {
                        TempContact = (Contact)SelectedContact.Clone();
                    }
                    else
                    {
                        SelectedContact = _selectedContactBeforeAdd;
                    }
                    IsActionUnselected = true;
                }, (object? obj) => !IsActionUnselected);
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        /// <param name="messageShowable">Интерфейс отображения сообщений.</param>
        public MainVM(IMessageShowable? messageShowable) : this()
        {
            MessageShowable = messageShowable;
        }
    }
}