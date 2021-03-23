using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Library_management.DataAccess
{
    class LibraryCardDataAccess
    {
        public void InsertEmployee(LibraryCard card)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Library_management")))
            {
                connection.Execute("dbo.Insert_LibraryCard @CardNumber, @MemberId", card);
            }
        }
    }
}
