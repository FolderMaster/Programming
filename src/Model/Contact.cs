using System;
using System.Collections.Generic;
using System.ComponentModel;

using Model.Service;

namespace Model
{
    /// <summary>
    /// Класс контактов с ФИО, номером телефона и электронной почтой.
    /// </summary>
    public class Contact : INotifyPropertyChanged, ICloneable, IDataErrorInfo
    {
        /// <summary>
        /// ФИО.
        /// </summary>
        private string _name = "";

        /// <summary>
        /// Номер телефона.
        /// </summary>
        private string _phoneNumber = "";

        /// <summary>
        /// Электронная почта.
        /// </summary>
        private string _email = "";

        /// <summary>
        /// Возвращает и задаёт ФИО. Должно быть не длиннее 100 символов.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (Name != value)
                {
                    _name = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(Name)));
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер телефона. Должен быть не длиннее 100 символов и
        /// соответствовать как паттерну "+7-(913)-813-10-68".
        /// </summary>
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                if (PhoneNumber != value)
                {
                    _phoneNumber = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(PhoneNumber)));
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт электронную почту. Должно быть не длиннее 100 символов и
        /// соответствовать паттерну "folder-master_2002@mail.com".
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
                if (Email != value)
                {
                    _email = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(Email)));
                }
            }
        }

        /// <summary>
        /// Возвращает ошибку. Если пустая строка, то её нет.
        /// </summary>
        public string Error
        {
            get
            {
                var errorTexts = new List<string>()
                {
                    ValueValidator.AssertStringIsName(Name, nameof(Name)),
                    ValueValidator.AssertStringIsPhoneNumber(PhoneNumber, nameof(PhoneNumber)),
                    ValueValidator.AssertStringIsEmail(Email, nameof(Email))
                };
                errorTexts.RemoveAll(string.IsNullOrEmpty);
                return string.Join("\n", errorTexts);
            }
        }

        /// <summary>
        /// Возвращает ошибку свойства. Если пустая строка, то её нет.
        /// </summary>
        /// <param name="propertyName">Название свойства.</param>
        /// <returns></returns>
        public string this[string propertyName]
        {
            get
            {
                string text = "";
                switch(propertyName)
                {
                    case nameof(Name): text = ValueValidator.AssertStringIsName(Name,
                        nameof(Name)); break;
                    case nameof(PhoneNumber): text = ValueValidator.AssertStringIsPhoneNumber
                        (PhoneNumber, nameof(PhoneNumber)); break;
                    case nameof(Email): text = ValueValidator.AssertStringIsEmail(Email,
                        nameof(Email)); break;
                    default: break;
                }
                return text;
            }
        }

        /// <summary>
        /// Обработчик события изменения свойства.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/> по умолчанию.
        /// </summary>
        public Contact() {}

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">ФИО.</param>
        /// <param name="phoneNumber">Номер телефона.</param>
        /// <param name="email">Электронная почта.</param>
        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        /// <summary>
        /// Клонирует текущий экземпляр.
        /// </summary>
        /// <returns>Клон текущего экземпляра.</returns>
        public object Clone() => new Contact(Name, PhoneNumber, Email);
    }
}