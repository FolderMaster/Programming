using System;
using Programming.Model.Enums;
namespace Programming.Model.Classes
{
    public class Movie
    {
        private uint _minutes;

        private int _releaseYear;

        private double _rating;

        public string Name { get; set; }

        public int Minutes
        {
            get
            {
                return (int)_minutes;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Movie.Minutes");
                _minutes = (uint)value;
            }
        }


        public int ReleaseYear
        {
            get
            {
                return _releaseYear;
            }
            set
            {
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, "Movie.ReleaseYear");
                _releaseYear = value;
            }
        }

        public Genre Genre { get; set; }

        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 10, "Movie.Rating");
                _rating = value;
            }
        }

        public Movie()
        {
            Name = "";
            Minutes = 60;
            ReleaseYear = DateTime.Now.Year;
            Genre = Genre.None;
            Rating = 0;
        }

        public Movie(string name, int minutes, int releaseYear, Genre genre, double rating)
        {
            Name = name;
            Minutes = minutes;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
        }
    }
}