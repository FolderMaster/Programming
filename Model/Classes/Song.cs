namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит информацию об песне:
    /// название песни, автора, название альбома, продолжительность по времени.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Возвращает и задаёт название песни.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задаёт автора.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Возвращает и задаёт название альбома.
        /// </summary>
        public string Album { get; set; }

        /// <summary>
        /// Возвращает и задаёт продолжительность по времени.
        /// </summary>
        public Time Duration { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/> по умолчанию.
        /// </summary>
        public Song()
        {
            Name = "";
            Author = "";
            Album = "";
            Duration = new Time();
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="name">Название песни.</param>
        /// <param name="author">Автор.</param>
        /// <param name="album">Название альбома.</param>
        /// <param name="duration">Продолжительность по времени.</param>
        public Song(string name, string author, string album, Time duration)
        {
            Name = name;
            Author = author;
            Album = album;
            Duration = duration;
        }
    }
}