using System;
using System.Collections.Generic;
using System.Text;

namespace Library_management
{
    public class Employee : Person
    {
        private string _position;
        private int _employeeId;


        public Employee()
        {}

        public Employee(string firstName, string lastName, string address, DateTime birthDate, string position): base(firstName, lastName, address, birthDate) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.BirthDate = birthDate;
            this.Position = position;
        }

        public Employee(int employeeId, string firstName, string lastName, string address, DateTime birthDate, string position) : base(firstName, lastName, address, birthDate)
        {
            this.EmployeeId = employeeId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.BirthDate = birthDate;
            this.Position = position;
        }


        [System.ComponentModel.DisplayName("Employee ID")] //Using it to change column name in datagridview
        public int EmployeeId
        {
            get => _employeeId;

            set => _employeeId = value;
        }

        public string Position
        {
            get => _position;

            set => _position = value;
        }

    }
}
