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

        //Public property that's gonna be returned for the FormBorrowBook
        public List<Item> listOfBooksToBorrow = new List<Item>();

        //Choose items that gonna be borrowed
        private void buttonPickBook_Click(object sender, EventArgs e)
        {
            try
            {
                Item selectedBook = (Item)dataGridView1.CurrentRow.DataBoundItem;
                this.listOfBooksToBorrow.Add(selectedBook);
                listBox1.Items.Add($"{selectedBook.Title}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonConfirmSelection_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
