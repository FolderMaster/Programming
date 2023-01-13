using System;

namespace ContactApp
{
    public class Contact
    {
        private string _fullName;

        private string _phoneNumber;

        private string _adress;

        public string FullName
        {
            get => _fullName;
            set
            {
                if (_fullName != value)
                {
                    _fullName = value;
                    FullNameChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value;
                    PhoneNumberChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public string Adress
        {
            get => _adress;
            set
            {
                if(_adress != value)
                {
                    _adress = value;
                    AdressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public event EventHandler FullNameChanged;

        public event EventHandler PhoneNumberChanged;

        public event EventHandler AdressChanged;

        public Contact()
        {
        }
    }
}