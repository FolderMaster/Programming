namespace Programming.Model.Classes
{
    class Subject
    {
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        uint hours;
        public uint Hours
        {
            get
            {
                return hours;
            }
            set
            {
                hours = value;
            }
        }
        string grade;
        public string Grade
        {
            get
            {
                return grade;
            }
            set
            {
                grade = value;
            }
        }
        string examdate;
        public string ExamDate
        {
            get
            {
                return examdate;
            }
            set
            {
                examdate = value;
            }
        }
    }
}