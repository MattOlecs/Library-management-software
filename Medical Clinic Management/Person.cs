using System;
using System.Collections.Generic;
using System.Text;

namespace Medical_Clinic_Management
{
    public class Person
    {

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

        [System.ComponentModel.DisplayName("Expire")]
        public string FirstName { get; set; }

        [System.ComponentModel.DisplayName("Last Name")]
        public string LastName { get; set; }
        public string Address { get; set; }

        [System.ComponentModel.DisplayName("Birth date")]
        public DateTime BirthDate { get; set; }

    }
}
