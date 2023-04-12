using System;
using System.ComponentModel;

namespace View.Model
{
    /// <summary>
    /// Класс контактов с ФИО, номером телефона и электронной почтой.
    /// </summary>
    public class Contact : INotifyPropertyChanged, ICloneable, IAssignable
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
        /// Возвращает и задаёт ФИО.
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
        /// Возвращает и задаёт номер телефона.
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
        /// Возвращает и задаёт электронную почту.
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
                if(Email != value)
                {
                    _email = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(Email)));
                }
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

        /// <summary>
        /// Присваивает объект текущему экземпляру.
        /// </summary>
        /// <param name="obj">Объект присвоения.</param>
        public void Assign(object obj)
        {
            if(obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            if (obj != this)
            {
                if (obj is Contact contact)
                {
                    Name = contact.Name;
                    PhoneNumber = contact.PhoneNumber;
                    Email = contact.Email;
                }
                else
                {
                    throw new ArgumentException(nameof(obj));
                }
            }
        }
    }
}