using System;
namespace Programming.Model.Classes
{
    class Film
    {
        string name;
        public string Name
        {
            get;
            set;
        }
        uint minutes;
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
        string genre;
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