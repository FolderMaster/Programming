namespace Programming.Model.Classes
{
    class Contact
    {
        public Contact()
        {
            this.PhoneNumber = "";
            this.Name = "";
            this.Surname = "";
            this.Patronymic = "";
        }
        public Contact(string PhoneNumber, string Name, string Surname, string Patronymic)
        {
            this.PhoneNumber = PhoneNumber;
            this.Name = Name;
            this.Surname = Surname;
            this.Patronymic = Patronymic;
        }
        public string PhoneNumber
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string Surname
        {
            get;
            set;
        }
        public string Patronymic
        {
            get;
            set;
        }
    }
}