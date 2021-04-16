using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library_management
{
    public partial class FormBorrowBook : Form
    {
        public FormBorrowBook()
        {
            InitializeComponent();
        }

        private void buttonPickMember_Click(object sender, EventArgs e)
        {
            try
            {
                FormMembersSearch formMemberSearch = new FormMembersSearch();
                formMemberSearch.ShowDialog();

                if (formMemberSearch.DialogResult != DialogResult.OK)
                {
                    throw new Exception("Couldn't get member correctly");
                }
                else
                {
                    Member member = formMemberSearch.Member;
                    textBox1.Text = $"{member.FirstName} {member.LastName}";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPickBook_Click(object sender, EventArgs e)
        {
            try
            {
                FormInventorySearch formInventorySearch = new FormInventorySearch();
                formInventorySearch.ShowDialog();

                if (formInventorySearch.DialogResult != DialogResult.OK)
                {
                    throw new Exception("Couldn't load list of books correctly");
                }
                else
                {
                    List<Item> listOfBooksToBorrow = formInventorySearch.listOfBooksToBorrow;

                    foreach (Item item in listOfBooksToBorrow)
                        listBox1.Items.Add(item.Title);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
