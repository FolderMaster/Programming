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
        /// Возвращает и задаёт команду сохранения <see cref="Contacts"/>.
        /// </summary>
        public ICommand SaveCommand { get; private set; }

        /// <summary>
        /// Возвращает и задаёт команду загрузки <see cref="Contacts"/>.
        /// </summary>
        public ICommand LoadCommand { get; private set; }

        /// <summary>
        /// Возвращает и задаёт команду добавления нового контакта.
        /// </summary>
        public ICommand AddCommand { get; private set; }

        /// <summary>
        /// Возвращает и задаёт команду изменения контакта <see cref="SelectedContact"/>.
        /// </summary>
        public ICommand EditCommand { get; private set; }

        /// <summary>
        /// Возвращает и задаёт команду удаления контакта <see cref="SelectedContact"/>.
        /// </summary>
        public ICommand RemoveCommand { get; private set; }

        /// <summary>
        /// Возвращает и задаёт команду применения <see cref="AddCommand"/> или
        /// <see cref="EditCommand"/>.
        /// </summary>
        public ICommand ApplyCommand { get; private set; }

        /// <summary>
        /// Возвращает и задаёт команду отмены <see cref="AddCommand"/> или
        /// <see cref="EditCommand"/>.
        /// </summary>
        public ICommand CancelCommand { get; private set; }

        /// <summary>
        /// Возвращает и задаёт команду обработки ввода <see cref="Contact.PhoneNumber"/>.
        /// </summary>
        public ICommand PhoneNumberTextInputCommand { get; private set; }

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
            SaveCommand = new RelayCommand((object? obj) =>
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
            LoadCommand = new RelayCommand((object? obj) =>
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
            AddCommand = new RelayCommand((object? obj) =>
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
            EditCommand = new RelayCommand((object? obj) =>
                {
                    _applyAction = () =>
                    {
                        int selectedIndex = Contacts.IndexOf(SelectedContact);
                        Contacts[selectedIndex] = TempContact;
                        SelectedContact = Contacts[selectedIndex];
                    };
                    IsActionUnselected = false;
                }, (object? obj) => IsActionUnselected && Contacts.Count > 0);
            RemoveCommand = new RelayCommand((object? obj) =>
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
            ApplyCommand = new RelayCommand((object? obj) =>
            {
                _applyAction();
                IsActionUnselected = true;
            }, (object? obj) => !IsActionUnselected && string.IsNullOrEmpty(TempContact.Error));
            CancelCommand = new RelayCommand((object? obj) =>
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
            PhoneNumberTextInputCommand = new RelayCommand((object? obj) =>
            {
                var args = obj as TextInputArgs;
                if (!ValueValidator.AssertCharsIsForPhoneNumber(args.NewText))
                {
                    args.IsCancel = true;
                }
            }, (object? obj) => !IsActionUnselected);

            LoadCommand.Execute(null);
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