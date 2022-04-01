using System;
namespace Programming.Model.Classes
{
    class Subject
    {
        public string Name { get; set; }

        public uint Hours { get; set; }

        public string Mark { get; set; }

        public DateTime ExamDate { get; set; }

        public Subject()
        {
            Name = "";
            Hours = 0;
            Mark = "";
            ExamDate = new DateTime();
        }
        public Subject(string name, uint hours, string mark, DateTime examDate)
        {
            Name = name;
            Hours = hours;
            Mark = mark;
            ExamDate = examDate;
        }
    }
}