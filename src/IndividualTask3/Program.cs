using IndividualTask3;

Console.WriteLine("Введите скорость для первого калькулятора:");
double speed1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите скорость для второго калькулятора:");
double speed2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите ускорение для второго калькулятора:");
double acceleration = double.Parse(Console.ReadLine());

List<DistanceCalculatorBase> calculatorBases = new List<DistanceCalculatorBase>()
{
    new UniformDistanceCalculator(speed1),
    new AcceleratedDistanceCalculator(speed2, acceleration)
};

Console.WriteLine("Введите время:");
double time = double.Parse(Console.ReadLine());

Console.WriteLine("Результаты подсчётов калкуляторов:");
calculatorBases.ForEach((calculator) => Console.WriteLine(calculator.Calculate(time)));