using System;
namespace Programming.Model.Classes
{
    class Film
    {
        public Film()
        {
            this.Name = "";
            this.Minutes = 0;
            this.IssueYear = 1900;
            this.Genre = "";
            this.Rating = 0;
        }

        public Film(string Name, uint Minutes, uint IssueYear, string Genre, float Rating)
        {
            this.Name = Name;
            this.Minutes = Minutes;
            this.IssueYear = IssueYear;
            this.Genre = Genre;
            this.Rating = Rating;
        }

        public string Name
        {
            get;
            set;
        }

        public uint Minutes
        {
            get;
            set;
        }

        uint _issueyear;

        public uint IssueYear
        {
            get
            {
                return _issueyear;
            }
            set
            {
                if(value >= 1900)
                {
                    _issueyear = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public string Genre
        {
            get;
            set;
        }

        float _rating;

        public float Rating
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
    }
}