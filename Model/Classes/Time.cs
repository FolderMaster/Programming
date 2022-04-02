using System;
namespace Programming.Model.Classes
{
    public class Time
    {
        private uint _hours;

        private uint _minutes;

        private uint _seconds;

        public int Hours
        {
            get
            {
                return (int)_hours;
            }
            set
            {
                if(value >= 0 && value < 24)
                {
                    _hours = (uint)value;
                }
                else
                {
                    throw new ArgumentException("Programming.Model.Classes.Time.Hours < 0 or Programming.Model.Classes.Time.Hours >= 24");
                }
            }
        }

        public int Minutes
        {
            get
            {
                return (int)_minutes;
            }
            set
            {
                if (value >= 0 && value < 60)
                {
                    _minutes = (uint)value;
                }
                else
                {
                    throw new ArgumentException("Programming.Model.Classes.Time.Minutes < 0 or Programming.Model.Classes.Time.Minutes >= 60");
                }
            }
        }

        public int Seconds
        {
            get
            {
                return (int)_seconds;
            }
            set
            {
                if(value >= 0 && value < 60)
                {
                    _seconds = (uint)value;
                }
                else
                {
                    throw new ArgumentException("Programming.Model.Classes.Time.Hours < 0 or Programming.Model.Classes.Time.Hours >= 60");
                }
            }
        }

        public Time()
        {
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
        }

        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
    }
}