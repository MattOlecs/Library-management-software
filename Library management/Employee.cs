using System;
using System.Collections.Generic;
using System.Text;

namespace Medical_Clinic_Management
{
    public class Employee : Person
    {
        public Employee()
        {

        }

        public Employee(string firstName, string lastName, string address, DateTime birthDate, string position): base(firstName, lastName, address, birthDate) 
        {
            Position = position;
        }

        [System.ComponentModel.DisplayName("Employee ID")] //Using it to change column name in datagridview
        public int EmployeeId { get; }

        public string Position { get; }

    }
}
