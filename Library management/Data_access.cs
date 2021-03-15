using System;
using System.Configuration;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Dapper;
using System.Linq;

namespace Medical_Clinic_Management
{
    public class Data_Access
    {



        public List<Employee> GetAllEmployees()
        {
            //Had to add Microsoft.Data.SqlClient through Nuget
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Library_management")))
            {
                var output = connection.Query<Employee>("select * from Employees").ToList();
                return output;

            }
        }

        public Employee GetEmployeeByNumber(int employeeNumber)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Library_management")))
            {
                return (Employee)connection.Query<Employee>("dbo.Employee_GetByNumber @EmployeeNumber", new { EmployeeNumber = employeeNumber });
            }
        }

        public void InsertEmployee(string firstName, string lastName, string address, string position, DateTime birthDate)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Library_management")))
            {
                //connection.Execute("dbo.Insert_Employee @FirstName, @LastName, @Address, @BirthDate, @Position", new Employee {FirstName = firstName, LastName = lastName, Address = address, BirthDate = birthDate, Position = position});
                connection.Execute("dbo.Insert_Employee @FirstName, @LastName, @Address, @BirthDate, @Position", new Employee(firstName, lastName, address, birthDate, position));

            }
        }

        
    }
}
