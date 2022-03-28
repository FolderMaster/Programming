namespace Programming.Model.Classes
{
    class Subject
    {
        public string Name { get; set; }

        public uint Hours { get; set; }

        public string Grade { get; set; }

        public string ExamDate { get; set; }

        Subject()
        {
            Name = "";
            Hours = 0;
            Grade = "";
            ExamDate = "";
        }
        Subject(string name, uint hours, string grade, string examdate)
        {
            Name = name;
            Hours = hours;
            Grade = grade;
            ExamDate = examdate;
        }
    }
}