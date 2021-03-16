using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Library_management
{
    class InventoryDataAccess
    {
        public void InsertItem(string type, string genre, string title, string author, string publisher, int editionNumber, int pages, string isbn, int copies, string shelf)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Library_management")))
            {               
                connection.Execute("dbo.Insert_Inventory @Type, @Genre, @Title, @Author, @Publisher, @EditionNumber, @Pages, @ISBN, @Copies, @Shelf", new Item(type, genre, title, author, publisher, editionNumber, pages, isbn, copies, shelf));
            }
        }
    }
}
