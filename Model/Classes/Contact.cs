using System;
using System.Text.RegularExpressions;
namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит информацию о человеке: имя, фамилию, отчество, номер телефона.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Номер телефона.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Имя.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Отчество.
        /// </summary>
        private string _patronymic;

        /// <summary>
        /// Возвращает и задаёт номер телефона. Должен быть представлен как "+0-(000)-000-00-00".
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                Match match = 
                    new Regex(@"(\d{1})\s*(\d{3})\s*(\d{3})\s*(\d{2})\s*(\d{2})").Match(value);
                if(match.Success)
                {
                    _phoneNumber = "+" + match.Groups[1].Value
                        + "-(" + match.Groups[2].Value
                        + ")-" + match.Groups[3].Value
                        + "-" + match.Groups[4].Value
                        + "-" + match.Groups[5].Value;
                }
                else
                {
                    throw new ArgumentException(nameof(PhoneNumber) +
                        " must be pattern as \"+0-(000)-000-00-00\"");
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт имя. Должно состоять только из букв.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт фамилию. Должна состоять только из букв.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(Surname));
                _surname = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт отчество. Должно состоять только из букв.
        /// </summary>
        public string Patronymic
        {
            get
            {
                return _patronymic;
            }
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(Patronymic));
                _patronymic = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/> по умолчанию.
        /// </summary>
        public Contact()
        {
            PhoneNumber = "+0-(000)-000-00-00";
            Name = "";
            Surname = "";
            Patronymic = "";
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="phoneNumber">Номер телефона. Должен быть представлен как
        /// "+0-(000)-000-00-00".</param>
        /// <param name="name">Имя. Должно состоять только из букв.</param>
        /// <param name="surname">Фамилия. Должна состоять только из букв.</param>
        /// <param name="patronymic">Отчество. Должно состоять только из букв.</param>
        public Contact(string phoneNumber, string name, string surname, string patronymic)
        {
            PhoneNumber = phoneNumber;
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
        }

        /// <summary>
        /// Проверяет, что строка состоит только из букв.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="name">Имя поля.</param>
        /// <exception cref="ArgumentException"></exception>
        private void AssertStringContainsOnlyLetters(string value, string name)
        {
            for(int n = 0; n < value.Length; n++)
            {
                if(!char.IsLetter(value[n]))
                {
                    throw new ArgumentException($"{name} must contain only letters");
                }
            }
        }
    }
}