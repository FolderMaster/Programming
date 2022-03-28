using System;
namespace Programming.Model.Classes
{
    class Time
    {
        uint _hours;

        uint _minutes;

        uint _seconds;

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

        public uint Minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                if (value < 60)
                {
                    _minutes = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

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

        public Time()
        {
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
        }

        public Time(uint hours, uint minutes, uint seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
    }
}