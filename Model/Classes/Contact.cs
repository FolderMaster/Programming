namespace Programming.Model.Classes
{
    class Contact
    {
        string phonenumber;
        public string PhoneNumber
        {
            get
            {
                return phonenumber;
            }
            set
            {
                phonenumber = value;
            }
        }
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
        string surname;
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        string patronymic;
        public string Patronymic
        {
            get
            {
                return patronymic;
            }
            set
            {
                patronymic = value;
            }
        }
    }
}