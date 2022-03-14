namespace Programming.Model.Classes
{
    class Flight
    {
        public Flight()
        {
            this.Departure = "";
            this.Destination = "";
            this.Minutes = 0;
        }

        public Flight(string Departure, string Destination, uint Minutes)
        {
            this.Departure = Departure;
            this.Destination = Destination;
            this.Minutes = Minutes;
        }

        public string Departure
        {
            get;
            set;
        }

        public string Destination
        {
            get;
            set;
        }

        public uint Minutes
        {
            get;
            set;
        }
    }
}