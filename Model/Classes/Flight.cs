using System;
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
                if(value > 0)
                {
                    _minutes = (uint)value;
                }
                else
                {
                    throw new ArgumentException("Programming.Model.Classes.Flight.Minutes <= 0");
                }
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