namespace Programming.Model.Classes
{
    class Time
    {
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
            }
        }
    }
}