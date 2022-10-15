namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит информацию о полёте: время в минутах, пункты вылета и назначения.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Время в минутах.
        /// </summary>
        private uint _minutes;

        /// <summary>
        /// Название пункта вылета.
        /// </summary>
        public string Departure { get; set; }

        /// <summary>
        /// Название пункта назначения.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Возвращает и задаёт время в минутах. Должно быть неотрицательным числом.
        /// </summary>
        public int Minutes
        {
            get
            {
                return (int)_minutes;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Minutes));
                _minutes = (uint)value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/> по умолчанию.
        /// </summary>
        public Flight()
        {
            Departure = "";
            Destination = "";
            Minutes = 60;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/>.
        /// </summary>
        /// <param name="departure">Название пункта вылета.</param>
        /// <param name="destination">Название пункта назначения.</param>
        /// <param name="minutes">Время в минутах. Должно быть неотрицательным числом.</param>
        public Flight(string departure, string destination, int minutes)
        {
            Departure = departure;
            Destination = destination;
            Minutes = minutes;
        }
    }
}