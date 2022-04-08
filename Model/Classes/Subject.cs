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
                Validator.AssertOnPositiveValue(value, nameof(Hours));
                _hours = (uint)value;
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