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
        uint issueyear;
        public uint IssueYear
        {
            get
            {
                return issueyear;
            }
            set
            {
                if(value >= 1900)
                {
                    issueyear = value;
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
        float rating;
        public float Rating
        {
            get
            {
                return rating;
            }
            set
            {
                if(value >= 0 && value <= 10)
                {
                    rating = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}