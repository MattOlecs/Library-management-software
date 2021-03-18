using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library_management
{
    public partial class FormInventorySearch : Form
    {
        public FormInventorySearch()
        {
            InitializeComponent();
        }

        enum SearchBy
        {
            Type, Genre, Title, Author, Publisher, ISBN
        }

        private void FormInventorySearch_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            dataGridView1.ReadOnly = true; 
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                List<Item> foundItems = new List<Item>();
                dataGridView1.DataSource = foundItems;
                
                InventoryDataAccess iDA = new InventoryDataAccess();
                
                foundItems = iDA.SearchInventory(comboBox1.SelectedItem.ToString(), textBoxSearchInput.Text);

                if(foundItems.Count == 0)
                {
                    MessageBox.Show("No items found.");
                }
                else
                dataGridView1.DataSource = foundItems;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
