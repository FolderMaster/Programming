namespace Programming.Model.Classes
{
    class Flight
    {
        string departure;
        public string Departure
        {
            get
            {
                return departure;
            }
            set
            {
                departure = value;
            }
        }
        string destination;
        public string Destination
        {
            get
            {
                return destination;
            }
            set
            {
                destination = value;
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
    }
}