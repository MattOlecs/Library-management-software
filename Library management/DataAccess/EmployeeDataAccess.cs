using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;

namespace Library_management
{
    class EmployeeDataAccess
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
                connection.Execute("dbo.Insert_Employee @FirstName, @LastName, @Address, @BirthDate, @Position", new Employee(firstName, lastName, address, birthDate));
            }
        }

        public void UpdateEmployee(string employeeId, string firstName, string lastName, string address, string position, DateTime birthDate)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Library_management")))
            {
                connection.Execute("dbo.UpdateEmployee_Employees @EmployeeId, @FirstName, @LastName, @Address, @BirthDate, @Position", new { EmployeeId = employeeId, FirstName = firstName, LastName = lastName, Address = address, BirthDate = birthDate, Position = position });
            }
        }

        public List<Employee> SearchEmployees(string searchedBy, string searchedValue)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Library_management")))
            {
                return connection.Query<Employee>($"dbo.SearchBy{searchedBy}_Employees @SearchedValue", new { SearchedValue = searchedValue }).ToList();
            }
        }

    }
}
