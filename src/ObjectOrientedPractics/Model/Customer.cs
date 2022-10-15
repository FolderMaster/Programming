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
        /// Адрес.
        /// </summary>
        private string _adress;

        /// <summary>
        /// Максимальная длина <see cref="FullName"/>.
        /// </summary>
        public static int MaxFullNameLength { get; } = 200;

        /// <summary>
        /// Максимальная длина <see cref="Adress"/>.
        /// </summary>
        public static int MaxAdressLength { get; } = 500;

        /// <summary>
        /// Возвращает уникальный индентификатор экземпляра класса.
        /// </summary>
        public int Id
        {
            get => _id;
        }

        /// <summary>
        /// Возвращает и задаёт ФИО. Длина строки должна быть не больше 
        /// <see cref="MaxFullNameLength"/>.
        /// </summary>
        public string FullName
        {
            get => _fullname;
            set
            {
                ValueValidator.AssertStringOnLessLength(value, MaxFullNameLength,
                    nameof(FullName));
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес. Длина строки должна быть не больше 
        /// <see cref="MaxAdressLength"/>.
        /// </summary>
        public string Adress
        {
            get => _adress;
            set
            {
                ValueValidator.AssertStringOnLessLength(value, MaxAdressLength, nameof(Adress));
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
        /// <param name="adress">Адрес.</param>
        public Customer(string fullName, string adress)
        {
            _id = _idGenerator.GetNextId();
            FullName = fullName;
            Adress = adress;
        }

        public override string ToString()
        {
            return $"{FullName} ({Id})";
        }
    }
}