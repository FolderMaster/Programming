using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Покупатель с ФИО и адресом.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Генератор уникального индентификатора экземпляра класса.
        /// </summary>
        private static IdGenerator _idGenerator = new IdGenerator();

        /// <summary>
        /// Уникальный индентификатор экземпляра класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// ФИО.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адресс.
        /// </summary>
        private string _adress;

        /// <summary>
        /// Возвращает уникальный индентификатор экземпляра класса.
        /// </summary>
        public int Id
        {
            get => _id;
        }

        /// <summary>
        /// Возвращает и задаёт ФИО. Длина строки должна быть не больше 200 символов.
        /// </summary>
        public string FullName
        {
            get => _fullname;
            set
            {
                Validator.AssertStringOnLessLength(value, 200, nameof(FullName));
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт адресс. Длина строки должна быть не больше 500 символов.
        /// </summary>
        public string Adress
        {
            get => _adress;
            set
            {
                Validator.AssertStringOnLessLength(value, 500, nameof(Adress));
                _adress = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/> по-умолчанию.
        /// </summary>
        public Customer()
        {
            _id = _idGenerator.GetNextId();
            FullName = "";
            Adress = "";
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullName">ФИО.</param>
        /// <param name="adress">Адресс.</param>
        public Customer(string fullName, string adress)
        {
            _id = _idGenerator.GetNextId();
            FullName = fullName;
            Adress = adress;
        }

        public override string ToString()
        {
            return $"{Id} {FullName}";
        }
    }
}