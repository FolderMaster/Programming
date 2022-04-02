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
                if(value > 0)
                {
                    _minutes = (uint)value;
                }
                else
                {
                    throw new ArgumentException("Movie.Minutes <= 0");
                }
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
                if(value >= 1900 && value <= DateTime.Now.Year)
                {
                    _releaseYear = value;
                }
                else
                {
                    throw new ArgumentException("Movie.ReleaseYear < 1900" +
                        " or Movie.ReleaseYear > DateTime.Now.Year");
                }
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
                if(value >= 0 && value <= 10)
                {
                    _rating = value;
                }
                else
                {
                    throw new ArgumentException("Movie.Rating < 0" +
                        " or Movie.Rating > 10");
                }
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