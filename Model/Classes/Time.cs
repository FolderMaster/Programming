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

        uint _hours;

        public uint Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                if(value < 24)
                {
                    _hours = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        uint _minutes;

        public uint Minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                if(value < 60)
                {
                    _minutes = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        uint _seconds;

        public uint Seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                if(value < 60)
                {
                    _seconds = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}