using System;
using System.Collections.Generic;
using System.Text;

namespace Library_management
{
    public class Person
    {
        private string _firstName, _lastName, _address;
        

        public Person()
        {

        }

        public Person(string firstName, string lastName, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }


        [System.ComponentModel.DisplayName("First Name")]
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

    }
}
