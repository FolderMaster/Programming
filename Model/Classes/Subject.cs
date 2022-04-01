using System;
namespace Programming.Model.Classes
{
    class Subject
    {
        public string Name { get; set; }

        public uint Hours { get; set; }

        public string Grade { get; set; }

        public DateTime ExamDate { get; set; }

        public Subject()
        {
            Name = "";
            Hours = 0;
            Grade = "";
            ExamDate = new DateTime();
        }
        public Subject(string name, uint hours, string grade, DateTime examDate)
        {
            Name = name;
            Hours = hours;
            Grade = grade;
            ExamDate = examDate;
        }
    }
}