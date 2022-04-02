using System;
using Programming.Model.Enums;
namespace Programming.Model.Classes
{
    public class Subject
    {
        private uint _hours;

        public string Name { get; set; }

        public int Hours
        {
            get
            {
                return (int)_hours;
            }
            set
            {
                if (value > 0)
                {
                    _hours = (uint)value;
                }
                else
                {
                    throw new ArgumentException("Subject.Hours <= 0");
                }
            }
        }

        public Mark Mark { get; set; }

        public DateTime ExamDate { get; set; }

        public Subject()
        {
            Name = "";
            Hours = 1;
            Mark = Mark.None;
            ExamDate = new DateTime();
        }
        public Subject(string name, int hours, Mark mark, DateTime examDate)
        {
            Name = name;
            Hours = hours;
            Mark = mark;
            ExamDate = examDate;
        }
    }
}