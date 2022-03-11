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
        uint grade;
        public uint Grade
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
        string exandate;
        public string ExamDate
        {
            get
            {
                return exandate;
            }
            set
            {
                examdate = value;
            }
        }
    }
}