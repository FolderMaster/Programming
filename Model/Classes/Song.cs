namespace Programming.Model.Classes
{
    class Song
    {
        public string Name { get; set; }

        public string Author { get; set; }

        public string Album { get; set; }

        public Time Lenght { get; set; }

        public Song()
        {
            Name = "";
            Author = "";
            Album = "";
            Lenght = new Time();
        }

        public Song(string name, string author, string album, Time lenght)
        {
            Name = name;
            Author = author;
            Album = album;
            Lenght = lenght;
        }
    }
}