using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;

<<<<<<< HEAD:Library management/DataAccess/EmployeeDataAccess.cs
=======

>>>>>>> c16c64a70576d974d0ba3717b8019d02bad86a69:Library management/Data_access.cs
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
                //connection.Execute("dbo.Insert_Employee @FirstName, @LastName, @Address, @BirthDate, @Position", new Employee {FirstName = firstName, LastName = lastName, Address = address, BirthDate = birthDate, Position = position});
                connection.Execute("dbo.Insert_Employee @FirstName, @LastName, @Address, @BirthDate, @Position", new Employee(firstName, lastName, address, birthDate, position));

            }
        }

<<<<<<< HEAD:Library management/DataAccess/EmployeeDataAccess.cs
        //test function
=======
>>>>>>> c16c64a70576d974d0ba3717b8019d02bad86a69:Library management/Data_access.cs
        private IDbConnection GiveCon()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Library_management")))
            {
                return connection;
            }
        }
<<<<<<< HEAD:Library management/DataAccess/EmployeeDataAccess.cs
=======

>>>>>>> c16c64a70576d974d0ba3717b8019d02bad86a69:Library management/Data_access.cs
    }
}
