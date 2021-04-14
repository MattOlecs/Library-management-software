using System;
using System.Collections.Generic;
using System.Text;

namespace Library_management
{
    public class Employee : Person
    {
        private int _employeeId;
        private DateTime _birthDate;


        public Employee()
        {}

        public Employee(string firstName, string lastName, string address, DateTime birthDate)//: base(firstName, lastName, address, birthDate) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.BirthDate = birthDate;
        }

        public Employee(int employeeId, string firstName, string lastName, string address, DateTime birthDate) //: base(firstName, lastName, address, birthDate)
        {
            this.EmployeeId = employeeId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.BirthDate = birthDate;
        }


        [System.ComponentModel.DisplayName("Employee ID")] //Using it to change column name in datagridview
        public int EmployeeId
        {
            get => _employeeId;

            set => _employeeId = value;
        }

        [System.ComponentModel.DisplayName("Birth Date")]
        public DateTime BirthDate  
        {
            get => _birthDate;

            set => _birthDate = value;
        }

}
}
