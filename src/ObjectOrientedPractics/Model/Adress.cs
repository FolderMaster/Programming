using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    public class Adress
    {
        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private int _index = 0;

        /// <summary>
        /// Страна/регион.
        /// </summary>
        private string _country = "";

        /// <summary>
        /// Населённый пункт.
        /// </summary>
        private string _city = "";

        /// <summary>
        /// Улица.
        /// </summary>
        private string _street = "";

        /// <summary>
        /// Номер дома.
        /// </summary>
        private string _building = "";

        /// <summary>
        /// Номер помещения.
        /// </summary>
        private string _apartment = "";

        /// <summary>
        /// Нижняя граница для <see cref="Index"/>.
        /// </summary>
        public static int MinIndex { get; } = 0;

        /// <summary>
        /// Верхняя граница для <see cref="Index"/>.
        /// </summary>
        public static int MaxIndex { get; } = 1000000;

        /// <summary>
        /// Максимальная длина <see cref="Country"/>.
        /// </summary>
        public static int MaxCountryLength { get; } = 50;

        /// <summary>
        /// Максимальная длина <see cref="City"/>.
        /// </summary>
        public static int MaxCityLength { get; } = 50;

        /// <summary>
        /// Максимальная длина <see cref="Street"/>.
        /// </summary>
        public static int MaxStreetLength { get; } = 100;

        /// <summary>
        /// Максимальная длина <see cref="Building"/>.
        /// </summary>
        public static int MaxBuildingLength { get; } = 10;

        /// <summary>
        /// Максимальная длина <see cref="Apartment"/>.
        /// </summary>
        public static int MaxApartmentLength { get; } = 10;

        /// <summary>
        /// Возвращает и задаёт почтовый индекс. Должно быть от <see cref="MinIndex"/> до
        /// <see cref="MaxIndex"/>.
        /// </summary>
        public int Index
        {
            get => _index;
            set
            {
                ValueValidator.AssertValueInRange(value, MinIndex, MaxIndex, nameof(Index));
                _index = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт страну/регион. Длина строки должна быть не больше 
        /// <see cref="MaxCountryLength"/>.
        /// </summary>
        public string Country
        {
            get => _country;
            set
            {
                ValueValidator.AssertStringOnLessLength(value, MaxCountryLength, nameof(Country));
                _country = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт населённый пункт. Длина строки должна быть не больше 
        /// <see cref="MaxInfoLength"/>.
        /// </summary>
        public string City
        {
            get => _city;
            set
            {
                ValueValidator.AssertStringOnLessLength(value, MaxCityLength, nameof(City));
                _city = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт улицу. Длина строки должна быть не больше 
        /// <see cref="MaxStreetLength"/>.
        /// </summary>
        public string Street
        {
            get => _street;
            set
            {
                ValueValidator.AssertStringOnLessLength(value, MaxStreetLength, nameof(Street));
                _street = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер дома. Длина строки должна быть не больше 
        /// <see cref="MaxBuildingLength"/>.
        /// </summary>
        public string Building
        {
            get => _building;
            set
            {
                ValueValidator.AssertStringOnLessLength(value, MaxBuildingLength,
                    nameof(Building));
                _building = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер помещения. Длина строки должна быть не больше 
        /// <see cref="MaxApartmentLength"/>.
        /// </summary>
        public string Apartment
        {
            get => _apartment;
            set
            {
                ValueValidator.AssertStringOnLessLength(value, MaxApartmentLength,
                    nameof(Apartment));
                _apartment = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Adress"/> по-умолчанию.
        /// </summary>
        public Adress()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Adress"/>.
        /// </summary>
        /// <param name="index">Почтовый индекс.</param>
        /// <param name="country">Страна.</param>
        /// <param name="city">Населённый пункт.</param>
        /// <param name="street">Улица.</param>
        /// <param name="building">Номер дома.</param>
        /// <param name="apartment">Номер помещения.</param>
        public Adress(int index, string country, string city, string street, string building,
            string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
    }
}
