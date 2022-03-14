namespace Programming.Model.Classes
{
    class Subject
    {
        Subject()
        {
            this.Name = "";
            this.Hours = 0;
            this.Grade = "";
            this.ExamDate = "";
        }
        Subject(string Name, uint Hours, string Grade, string ExamDate)
        {
            this.Name = Name;
            this.Hours = Hours;
            this.Grade = Grade;
            this.ExamDate = ExamDate;
        }

        public string Name
        {
            get;
            set;
        }

        public uint Hours
        {
            get;
            set;
        }

        public string Grade
        {
            get;
            set;
        }

        public string ExamDate
        {
            get;
            set;
        }
    }
}