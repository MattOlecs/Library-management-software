using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Dapper;

namespace Library_management.DataAccess
{
    class OrderDataAccess
    {
        public static void InsertOrder(Order order)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Library_management")))
            {
                connection.Execute("dbo.Insert_Order @MemberId, @BookId, @DateOfBorrow, @DateOfReturn", order);
            }
        }
    }
}
