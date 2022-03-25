using System;
namespace Programming.Model.Classes
{
    class Film
    {
        public Film()
        {
            Name = "";
            Minutes = 0;
            IssueYear = 1900;
            Genre = "";
            Rating = 0;
        }

        public Film(string name, uint minutes, uint issueYear, string genre, float rating)
        {
            this.Name = name;
            this.Minutes = minutes;
            this.IssueYear = issueYear;
            this.Genre = genre;
            this.Rating = rating;
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