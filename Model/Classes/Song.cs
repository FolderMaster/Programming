namespace Programming.Model.Classes
{
    class Song
    {
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        string author;
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        string album;
        public string Album
        {
            get
            {
                return album;
            }
            set
            {
                album = value;
            }
        }
        Time lenght;
        public Time Lenght
        {
            get
            {
                return lenght;
            }
            set
            {
                lenght = value;
            }
        }
    }
}