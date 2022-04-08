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
                Validator.AssertValueInRange(value, 0, 23, nameof(Hours));
                _hours = (uint)value;
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
                Validator.AssertValueInRange(value, 0, 59, nameof(Minutes));
                _minutes = (uint)value;
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
                Validator.AssertValueInRange(value, 0, 59, nameof(Seconds));
                _seconds = (uint)value;
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