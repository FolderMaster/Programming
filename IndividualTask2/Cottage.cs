namespace IndividualTask2
{
    public class Cottage : House
    {
        private int _garageArea = 0;

        private int _backyardArea = 0;

        private bool _dogHouse = false;

        public int GarageArea
        {
            get => _garageArea;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Площадь гаража не может быть отрицательной!");
                }
                _garageArea = value;
            }
        }

        public int BackyardArea
        {
            get => _backyardArea;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Площадь заднего двора не может быть " +
                        "отрицательной!");
                }
                _backyardArea = value;
            }
        }

        public bool DogHouse
        {
            get => _dogHouse;
            set => _dogHouse = value;
        }

        public Cottage(string address, string owner, int countOfRooms, int garageArea, int 
            backyardArea, bool dogHouse) : base(address, owner, countOfRooms)
        {
            GarageArea = garageArea;
            BackyardArea = backyardArea;
            DogHouse = dogHouse;
        }
    }
}