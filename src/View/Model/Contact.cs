namespace View.Model
{
    /// <summary>
    /// Класс контактов с ФИО, номером телефона и электронной почтой.
    /// </summary>
    public class Contact
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
        /// Возращает и задаёт ФИО.
        /// </summary>
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        /// <summary>
        /// Возращает и задаёт номер телефона.
        /// </summary>
        public string PhoneNumber
        {
            get => _phoneNumber;
            set => _phoneNumber = value;
        }

        /// <summary>
        /// Возращает и задаёт электронную почту.
        /// </summary>
        public string Email
        {
            get => _email;
            set => _email = value;
        }

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
    }
}