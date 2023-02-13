namespace IndividualTask2
{
    public class Flat : House
    {
        private int _floor = 0;

        public int Floor
        {
            get => _floor;
            set => _floor = value;
        }

        public Flat(string address, string owner, int countOfRooms, int floor) : base(address, 
            owner, countOfRooms)
        {
            Floor = floor;
        }
    }
}