using System;
namespace Programming.Model.Classes
{
    class Film
    {
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        uint minutes;
        public uint Minutes
        {
            get
            {
                return minutes;
            }
            set
            {
                minutes = value;
            }
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
        string genre;
        public string Genre
        {
            get
            {
                return genre;
            }
            set
            {
                genre = value;
            }
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