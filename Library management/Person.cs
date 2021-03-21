using System;
using System.Collections.Generic;
using System.Text;

namespace Library_management
{
    public class Person
    {
        private string _firstName, _lastName, _address;
        private DateTime _birthDate;

        public Person()
        {

        }

        public Person(string firstName, string lastName, string address, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            BirthDate = birthDate;
        }


        [System.ComponentModel.DisplayName("FirstName")]
        public string FirstName
        {
            get => _firstName;

            set => _firstName = value;
        }
        [System.ComponentModel.DisplayName("Last Name")]
        public string LastName
        {
            get => _lastName;

            set => _lastName = value;
        }
        
        [System.ComponentModel.DisplayName("Address")]
        public string Address
        {
            get => _address;

            set => _address = value;
        }
        
        [System.ComponentModel.DisplayName("Birth date")]
        public DateTime BirthDate
        {
            get => _birthDate;

            set => _birthDate = value;
        }

    }
}
