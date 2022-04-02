﻿using System;
using System.Text.RegularExpressions;
namespace Programming.Model.Classes
{
    public class Contact
    {
        private string _phoneNumber;

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

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Patronymic { get; set; }

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
    }
}