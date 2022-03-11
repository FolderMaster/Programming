using System;
namespace Programming.Model.Classes
{
    class Time
    {
        public Time()
        {
            this.Hours = 0;
            this.Minutes = 0;
            this.Seconds = 0;
        }
        public Time(uint Hours, uint Minutes, uint Seconds)
        {
            this.Hours = Hours;
            this.Minutes = Minutes;
            this.Seconds = Seconds;
        }
        uint hours;
        public uint Hours
        {
            get
            {
                return hours;
            }
            set
            {
                if(value < 24)
                {
                    hours = value;
                }
                else
                {
                    throw new ArgumentException();
                }
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
                if(value < 60)
                {
                    minutes = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        uint seconds;
        public uint Seconds
        {
            get
            {
                return seconds;
            }
            set
            {
                if(value < 60)
                {
                    seconds = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}