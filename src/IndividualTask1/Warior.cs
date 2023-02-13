namespace IndividualTask1
{
    public class Warior
    {
        private string _name = "";

        private int _hp = 0;

        private int _damage = 0;

        private List<Armour> _equipment = new List<Armour>();

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int HP
        {
            get => _hp;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Здоровье не может быть отрицательным!");
                }
                _hp = value;
            }
        }

        public int Damage
        {
            get => _damage;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Урон должен быть положительным!");
                }
                _damage = value;
            }
        }

        public List<Armour> Equipment
        {
            get => _equipment;
            set => _equipment = value;
        }

        public Warior(string name, int hP, int damage, List<Armour> equipment)
        {
            Name = name;
            HP = hP;
            Damage = damage;
            Equipment = equipment;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Name} (hp = {HP}, damage = {Damage})");
            foreach(Armour armour in Equipment)
            {
                Console.WriteLine($"{armour.Name} (type = {armour.Type}, cost = {armour.Cost})");
            }
        }
    }
}