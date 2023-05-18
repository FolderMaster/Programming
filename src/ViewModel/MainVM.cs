using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using System.Xml.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using GalaSoft.MvvmLight.CommandWpf;

using Model;
using Model.Service;

namespace ViewModel
{
    /// <summary>
    /// Класс логики обработки процессов основного окна приложения с контактом, командами
    /// сохранения, загрузки и другими.
    /// </summary>
    public class MainVM : ObservableObject
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
                    SetProperty(ref _contacts, value);
                    if (Contacts != null)
                    {
                        SelectedContact = Contacts.Count > 0 ? Contacts[0] : null;
                    }
                    else
                    {
                        SelectedContact = null;
                    }
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
                    SetProperty(ref _selectedContact, value);
                    IsActionUnselected = true;
                    TempContact = SelectedContact != null ?
                        (Contact)SelectedContact.Clone() : null;
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт временный контакт.
        /// </summary>
        public Contact? TempContact
        {
            get => _tempContact;
            set => SetProperty(ref _tempContact, value);
        }

        /// <summary>
        /// Возвращает и задаёт логическое значение, указывающее, выбрано ли действие.
        /// </summary>
        public bool IsActionUnselected
        {
            get => _isActionUnselected;
            set => SetProperty(ref _isActionUnselected, value);
        }

        /// <summary>
        /// Возвращает и задаёт команду сохранения <see cref="Contacts"/>.
        /// </summary>
        public RelayCommand SaveCommand { get; private set; }

        /// <summary>
        /// Возвращает и задаёт команду загрузки <see cref="Contacts"/>.
        /// </summary>
        public RelayCommand LoadCommand { get; private set; }

        /// <summary>
        /// Возвращает и задаёт команду добавления нового контакта.
        /// </summary>
        public RelayCommand AddCommand { get; private set; }

        /// <summary>
        /// Возвращает и задаёт команду изменения контакта <see cref="SelectedContact"/>.
        /// </summary>
        public RelayCommand EditCommand { get; private set; }

        /// <summary>
        /// Возвращает и задаёт команду удаления контакта <see cref="SelectedContact"/>.
        /// </summary>
        public RelayCommand RemoveCommand { get; private set; }

        /// <summary>
        /// Возвращает и задаёт команду применения <see cref="AddCommand"/> или
        /// <see cref="EditCommand"/>.
        /// </summary>
        public RelayCommand ApplyCommand { get; private set; }

        /// <summary>
        /// Возвращает и задаёт команду отмены <see cref="AddCommand"/> или
        /// <see cref="EditCommand"/>.
        /// </summary>
        public RelayCommand CancelCommand { get; private set; }

        /// <summary>
        /// Возвращает и задаёт интерфейс отображения сообщений.
        /// </summary>
        public IMessageShowable? MessageShowable { get; set; } = null;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        /// <param name="messageShowable">Интерфейс отображения сообщений.</param>
        public MainVM(IMessageShowable? messageShowable)
        {
            MessageShowable = messageShowable;

            SaveCommand = new RelayCommand(() =>
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
            LoadCommand = new RelayCommand(() =>
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
            AddCommand = new RelayCommand(() =>
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
            }, () => IsActionUnselected);
            EditCommand = new RelayCommand(() =>
            {
                _applyAction = () =>
                {
                    int selectedIndex = Contacts.IndexOf(SelectedContact);
                    Contacts[selectedIndex] = TempContact;
                    SelectedContact = Contacts[selectedIndex];
                };
                IsActionUnselected = false;
            }, () => IsActionUnselected && Contacts.Count > 0);
            RemoveCommand = new RelayCommand(() =>
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
            }, () => IsActionUnselected && Contacts.Count > 0);
            ApplyCommand = new RelayCommand(() =>
            {
                _applyAction();
                IsActionUnselected = true;
            }, () => !IsActionUnselected && string.IsNullOrEmpty(TempContact.Error));
            CancelCommand = new RelayCommand(() =>
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
            }, () => !IsActionUnselected);

            LoadCommand.Execute(null);
        }
    }
}