namespace Programming.Model.Classes
{
    class Flight
    {
        public string Departure { get; set; }

        public string Destination { get; set; }

        public uint Minutes { get; set; }

        public Flight()
        {
            Departure = "";
            Destination = "";
            Minutes = 0;
        }

        public Flight(string departure, string destination, uint minutes)
        {
            Departure = departure;
            Destination = destination;
            Minutes = minutes;
        }
    }
}