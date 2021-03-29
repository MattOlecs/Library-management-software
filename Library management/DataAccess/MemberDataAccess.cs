using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Library_management
{
    class MemberDataAccess
    {
        //Function that adds new member to database
        //Sends request to database to use stored procedure "dbo.Insert_Member"
        //It passess necessery variables to it, and the stored procedure does the rest
        //IMPORTANT: Member id is being assigned on database level
        //If you want to get member's Id number, he needs to be added to database first
        public void InsertMember(Member member)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Library_management")))
            {
                connection.Execute("dbo.Insert_Member @FirstName, @LastName, @Address, @PhoneNumber, @Email", member);
            }
        }

        public List<Member> SearchMembers(string searchedBy, string searchedValue)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Library_management")))
            {
                return connection.Query<Member>($"dbo.SearchBy{searchedBy}_Employees @SearchedValue", new { SearchedValue = searchedValue }).ToList();
            }
        }
    }
}
