using System;
using Programming.Model.Enums;
namespace Programming.Model.Classes
{
    class Subject
    {
        public string Name { get; set; }

        public uint Hours { get; set; }

        public Mark Mark { get; set; }

        public DateTime ExamDate { get; set; }

        public Subject()
        {
            Name = "";
            Hours = 0;
            Mark = Mark.None;
            ExamDate = new DateTime();
        }
        public Subject(string name, uint hours, Mark mark, DateTime examDate)
        {
            Name = name;
            Hours = hours;
            Mark = mark;
            ExamDate = examDate;
        }
    }
}