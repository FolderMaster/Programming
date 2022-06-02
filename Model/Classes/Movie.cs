using System;
using Programming.Model.Enums;
namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит информацию о фильме: название, время в минутах, год выпуска, жанр, рейтинг.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Время в минутах.
        /// </summary>
        private uint _minutes;

        /// <summary>
        /// Год выпуска.
        /// </summary>
        private int _releaseYear;

        /// <summary>
        /// Рейтинг.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Возвращает и задаёт название.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задаёт время в минутах. Должно быть неотрицательным числом.
        /// </summary>
        public int Minutes
        {
            get
            {
                return (int)_minutes;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Minutes));
                _minutes = (uint)value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт год выпуска. Должно быть в промежутке от 1900 до текущего года (включительно).
        /// </summary>
        public int ReleaseYear
        {
            get
            {
                return _releaseYear;
            }
            set
            {
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, nameof(ReleaseYear));
                _releaseYear = value;
            }
        }

        /// <summary>
        /// Возвращет и задаёт жанр.
        /// </summary>
        public Genre Genre { get; set; }

        /// <summary>
        /// Возвращает и задаёт рейтинг. Должен быть в промежутке от 0 до 10 (включительно).
        /// </summary>
        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
                _rating = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/> по умолчанию.
        /// </summary>
        public Movie()
        {
            Name = "";
            Minutes = 60;
            ReleaseYear = DateTime.Now.Year;
            Genre = Genre.None;
            Rating = 0;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>.
        /// </summary>
        /// <param name="name">Название.</param>
        /// <param name="minutes">Время в минутах.</param>
        /// <param name="releaseYear">Год выпуска. Должен быть в промежутке от 1900 до текущего года (включительно).</param>
        /// <param name="genre">Жанр.</param>
        /// <param name="rating">Рейтинг. Должен быть в промежутке от 0 до 10 (включительно).</param>
        public Movie(string name, int minutes, int releaseYear, Genre genre, double rating)
        {
            Name = name;
            Minutes = minutes;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
        }

        override public string ToString()
        {
            return $"{Name} / {ReleaseYear} / {Genre}";
        }
    }
}