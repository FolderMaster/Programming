namespace Programming.Model.Classes
{
    class Contact
    {
        public string PhoneNumber { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Patronymic { get; set; }

        public Contact()
        {
            PhoneNumber = "";
            Name = "";
            Surname = "";
            Patronymic = "";
        }

        public Contact(string phoneNumber, string name, string surname, string patronymic)
        {
            PhoneNumber = phoneNumber;
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
        }
    }
}