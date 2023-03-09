using System;

namespace View.Model
{
    public class Contact
    {
        private string _name = "";

        private string _phoneNumber = "";

        private string _email = "";

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string PhoneNumber
        {
            get => _phoneNumber;
            set => _phoneNumber = value;
        }

        public string Email
        {
            get => _email;
            set => _email = value;
        }

        public Contact() {}

        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}