using System;

using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Адресс с почтовым индексом, страной/регионом, населённым пунктом, улицей, номером дома,
    /// номером помещения.
    /// </summary>
    public class Adress : ICloneable, IEquatable<object>
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
                if(_index != value)
                {
                    _index = value;
                    AdressChanged?.Invoke(value, EventArgs.Empty);
                }
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
                if(_country != value)
                {
                    _country = value;
                    AdressChanged?.Invoke(value, EventArgs.Empty);
                }
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
                if(_city != value)
                {
                    _city = value;
                    AdressChanged?.Invoke(value, EventArgs.Empty);
                }
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
                if(_street != value)
                {
                    _street = value;
                    AdressChanged?.Invoke(value, EventArgs.Empty);
                }
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
                if(_building != value)
                {
                    _building = value;
                    AdressChanged?.Invoke(value, EventArgs.Empty);
                }
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
                if(_apartment != value)
                {
                    _apartment = value;
                    AdressChanged?.Invoke(value, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Обработчик события изменения класса.
        /// </summary>
        public event EventHandler AdressChanged;

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
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public override string ToString()
        {
            return $"{Index} {Country} {City} {Street} {Building} {Apartment}";
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public object Clone()
        {
            return new Adress(Index, Country, City, Street, Building, Apartment);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="other"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public override bool Equals(object other)
        {
            if (other == null)
            {
                return false;
            }

            Adress adress = other as Adress;
            if (adress == null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Index == adress.Index && Country == adress.Country && City == adress.City &&
                Street == adress.Street && Building == adress.Building && 
                Apartment == adress.Apartment;
        }
    }
}