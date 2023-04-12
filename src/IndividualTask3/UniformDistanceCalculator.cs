namespace IndividualTask3
{
    public class UniformDistanceCalculator : DistanceCalculatorBase
    {
        private double _speed = 0;

        public double Speed
        {
            get => _speed;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Скорость не может быть отрицательной!");
                }
                _speed = value;
            }

        }

        public UniformDistanceCalculator(double speed)
        {
            Speed = speed;
        }

        public double Calculate(double time)
        {
            return Speed * time;
        }
    }
}