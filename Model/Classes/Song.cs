namespace Programming.Model.Classes
{
    class Song
    {
        public Song()
        {
            this.Name = "";
            this.Author = "";
            this.Album = "";
            this.Lenght = new Time();
        }

        public Song(string Name, string Author, string Album, Time Lenght)
        {
            this.Name = Name;
            this.Author = Author;
            this.Album = Album;
            this.Lenght = Lenght;
        }
        public string Name
        {
            get;
            set;
        }

        public string Author
        {
            get;
            set;
        }

        public string Album
        {
            get;
            set;
        }

        public Time Lenght
        {
            get;
            set;
        }
    }
}