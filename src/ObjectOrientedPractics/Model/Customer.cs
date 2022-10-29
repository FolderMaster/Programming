using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Покупатель с ФИО, адресом и корзиной.
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
        private readonly int _id = _idGenerator.GetNextId();

        /// <summary>
        /// ФИО.
        /// </summary>
        private string _fullname = "";

        /// <summary>
        /// Адрес.
        /// </summary>
        private Adress _adress = new Adress();

        /// <summary>
        /// Корзина.
        /// </summary>
        private Cart _cart = new Cart();

        /// <summary>
        /// Максимальная длина <see cref="FullName"/>.
        /// </summary>
        public static int MaxFullNameLength { get; } = 200;

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
        /// Возвращает и задаёт адрес.
        /// </summary>
        public Adress Adress
        {
            get => _adress;
            set => _adress = value;
        }

        /// <summary>
        /// Возращает и задаёт корзину.
        /// </summary>
        public Cart Cart
        {
            get => _cart;
            set => _cart = value;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/> по-умолчанию.
        /// </summary>
        public Customer()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullName">ФИО.</param>
        /// <param name="adress">Адрес.</param>
        public Customer(string fullName, Adress adress)
        {
            FullName = fullName;
            Adress = adress;
        }

        public override string ToString()
        {
            return $"{FullName} ({Id})";
        }
    }
}