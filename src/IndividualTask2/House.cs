namespace IndividualTask2
{
    public class House
    {
        private string _address = "";

        private string _owner = "";

        private int _countOfRooms = 1;

        public string Address
        {
            get => _address;
            set => _address = value;
        }

        public string Owner
        {
            get => _owner;
            set
            {
                foreach(char c in value)
                {
                    if(!char.IsLetter(c))
                    {
                        throw new ArgumentException("Имя собственника не может содержать не " +
                            "буквы!");
                    }
                }
                _owner = value;
            }
        }

        public int CountOfRooms
        {
            get => _countOfRooms;
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Цена за комнату должна быть положительная!");
                }
                _countOfRooms = value;
            }
        }

        public House(string address, string owner, int countOfRooms)
        {
            Address = address;
            Owner = owner;
            CountOfRooms = countOfRooms;
        }
    }
}