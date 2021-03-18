using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Library_management
{
    class InventoryDataAccess
    {
        //Connects with stored procedure in database.
        //Takes 10 variables and creates new object of Item class.
        //All values of new Item are being given to stored procedure which puts it into database.
        public void InsertItem(string type, string genre, string title, string author, string publisher, int editionNumber, int pages, string isbn, int copies, string shelf)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Library_management")))
            {               
                connection.Execute("dbo.Insert_Inventory @Type, @Genre, @Title, @Author, @Publisher, @EditionNumber, @Pages, @ISBN, @Copies, @Shelf", new Item(type, genre, title, author, publisher, editionNumber, pages, isbn, copies, shelf));
            }
        }

        //This function is used to search for items in database and return list of items that if found.
        //Connects with stored procedure in database.
        //It takes two values, one is used to identifie which stored procedure it should use (for example dbo.SearchByTitle_Inventory) if you want to search database for item with this title)
        //second value is the value that database looks for.
        public List<Item> SearchInventory(string searchedBy, string searchedValue)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Library_management")))
            {
                return connection.Query<Item>($"dbo.SearchBy{searchedBy}_Inventory @SearchedValue", new { SearchedValue = searchedValue }).ToList();
            }
        }     
    }
}
