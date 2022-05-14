namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит информацию о времени: количество часов, минут, секунд.
    /// </summary>
    public class Time
    {
        /// <summary>
        /// Количество часов.
        /// </summary>
        private uint _hours;

        /// <summary>
        /// Количество минут.
        /// </summary>
        private uint _minutes;

        /// <summary>
        /// Количество секунд.
        /// </summary>
        private uint _seconds;

        /// <summary>
        /// Возвращает и задаёт количество часов. Должно быть в промежутке от 0 по 23.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задаёт количество минут. Должно быть в промежутке от 0 по 59.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задаёт количество секунд. Должно быть в промежутке от 0 по 59.
        /// </summary>
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

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Time"/> по умолчанию.
        /// </summary>
        public Time()
        {
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Time"/>.
        /// </summary>
        /// <param name="hours">Количество часов. Должно быть в промежутке от 0 до 23.</param>
        /// <param name="minutes">Количетсво минут. Должно быть в промежутке от 0 до 59.</param>
        /// <param name="seconds">Количество секунд. Должно быть в промежутке от 0 до 59.</param>
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
    }
}