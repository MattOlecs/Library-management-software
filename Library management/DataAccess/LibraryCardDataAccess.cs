using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Library_management
{
    class LibraryCardDataAccess
    {
        //This function is used for creating FIRST library card for NEW member
        public void InsertLibraryCard(string cardNumber)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Library_management")))
            {
                connection.Execute("dbo.Insert_LibraryCard @CardNumber", new { CardNumber = cardNumber });
            }
        }

        public List<string> GetLibaryCardsNumbers()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Library_management")))
            {
                return connection.Query<string>("SELECT CardNumber FROM [dbo].[LibraryCards]").ToList();
            }
        }
    }
}
