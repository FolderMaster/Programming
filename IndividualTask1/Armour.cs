namespace IndividualTask1
{
    public class Armour
    {
        private string _name = "";

        private ArmourType _type = ArmourType.Helmet;

        private int _cost = 0;

        public string Name
        { 
            get => _name;
            set => _name = value;
        }

        public ArmourType Type
        {
            get => _type;
            set => _type = value;
        }

        public int Cost
        {
            get => _cost;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Стоимость не может быть отрицательной!");
                }
                _cost = value;
            }
        }

        public Armour(string name, ArmourType type, int cost)
        {
            Name = name;
            Type = type;
            Cost = cost;
        }
    }
}