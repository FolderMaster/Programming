namespace IndividualTask3
{
    public class AcceleratedDistanceCalculator : DistanceCalculatorBase
    {
        private double _speed = 0;

        private double _acceleration = 0;

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

        public double Acceleration
        {
            get => _acceleration;
            set => _acceleration = value;
        }

        public AcceleratedDistanceCalculator(double speed, double acceleration)
        {
            Speed = speed;
            Acceleration = acceleration;
        }

        public double Calculate(double time)
        {
            return Speed * time + Acceleration * time * time / 2;
        }
    }
}
