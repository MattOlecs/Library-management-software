using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library_management
{
    public partial class FormInventoryAdd : Form
    {
        public FormInventoryAdd()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                InventoryDataAccess inventoryData = new InventoryDataAccess();
                
                inventoryData.InsertItem(comboBoxType.Text, comboBoxGenre.Text, textBoxTitle.Text, textBoxAuthor.Text, textBoxPublisher.Text, Int32.Parse(textBoxEditionNumber.Text), Int32.Parse(textBoxPages.Text), textBoxISBN.Text, Int32.Parse(textBoxCopies.Text), textBoxShelf.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Invalid input data: {ex.Message}");
            }


        }    
    }
}
