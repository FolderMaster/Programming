namespace Programming.Model.Classes
{
    public class Flight
    {
        private uint _minutes;

        public string Departure { get; set; }

        public string Destination { get; set; }

        public int Minutes
        {
            get
            {
                return (int)_minutes;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Flight.Minutes");
                _minutes = (uint)value;
            }
        }

        public Flight()
        {
            Departure = "";
            Destination = "";
            Minutes = 60;
        }

        public Flight(string departure, string destination, int minutes)
        {
            Departure = departure;
            Destination = destination;
            Minutes = minutes;
        }
    }
}