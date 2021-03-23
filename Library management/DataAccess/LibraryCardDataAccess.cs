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
        public void InsertLibraryCard(LibraryCard card)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Library_management")))
            {
                connection.Execute("dbo.Insert_LibraryCard @CardNumber, @MemberId", card);
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
