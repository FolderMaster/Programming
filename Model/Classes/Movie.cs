using System;
namespace Programming.Model.Classes
{
    class Movie
    {
        uint _releaseYear;

        double _rating;

        public string Name { get; set; }

        public uint Minutes { get; set; }

        public uint ReleaseYear
        {
            get
            {
                return _releaseYear;
            }
            set
            {
                if(value >= 1900)
                {
                    _releaseYear = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public string Genre { get; set; }

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
                    throw new ArgumentException();
                }
            }
        }

        public Movie()
        {
            Name = "";
            Minutes = 0;
            ReleaseYear = 1900;
            Genre = "";
            Rating = 0;
        }

        public Movie(string name, uint minutes, uint releaseYear, string genre, double rating)
        {
            Name = name;
            Minutes = minutes;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
        }
    }
}