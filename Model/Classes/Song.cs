namespace Programming.Model.Classes
{
    class Song
    {
        public string Name { get; set; }

        public string Author { get; set; }

        public string Album { get; set; }

        public Time Duration { get; set; }

        public Song()
        {
            Name = "";
            Author = "";
            Album = "";
            Duration = new Time();
        }

        public Song(string name, string author, string album, Time duration)
        {
            Name = name;
            Author = author;
            Album = album;
            Duration = duration;
        }
    }
}