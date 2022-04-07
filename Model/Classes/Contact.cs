using System;
using System.Text.RegularExpressions;
namespace Programming.Model.Classes
{
    public class Contact
    {
        private string _phoneNumber;

        private string _name;

        private string _surname;

        private string _patronymic;

        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                // Contact.PhoneNumber must be pattern as "+0-(000)-000-00-00"
                Match match = 
                    new Regex(@"(\d{1})\s+(\d{3})\s+(\d{3})\s+(\d{2})\s+(\d{2})").Match(value);
                if(match != null)
                {
                    _phoneNumber = "+" + match.Groups[1].Value
                        + "-(" + match.Groups[2].Value
                        + ")-" + match.Groups[3].Value
                        + "-" + match.Groups[4].Value
                        + "-" + match.Groups[5].Value;
                }
                else
                {
                    throw new ArgumentException("Contact.PhoneNumber must be pattern as \"+0-(000)-000-00-00\"");
                }
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(AssertStringContainsOnlyLetters(value))
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Contact.Name must contain only letters");
                }
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if(AssertStringContainsOnlyLetters(value))
                {
                    _surname = value;
                }
                else
                {
                    throw new ArgumentException("Contact.Surname must contain only letters");
                }
            }
        }

        public string Patronymic
        {
            get
            {
                return _patronymic;
            }
            set
            {
                if(AssertStringContainsOnlyLetters(value))
                {
                    _patronymic = value;
                }
                else
                {
                    throw new ArgumentException("Contact.Patronymic must contain only letters");
                }
            }
        }

        public Contact()
        {
            PhoneNumber = "+0-(000)-000-00-00";
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

        private bool AssertStringContainsOnlyLetters(string value)
        {
            for(int n = 0; n < value.Length; n++)
            {
                if(!char.IsLetter(value[n]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}