using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library_management
{
    public partial class FormMembersSearch : Form
    {
        public FormMembersSearch()
        {
            InitializeComponent();
        }

        private void FormMembersSearch_Load(object sender, EventArgs e)
        {
            comboBoxSearchBy.SelectedIndex = 0;
        }
        private void buttonSearchMembers_Click(object sender, EventArgs e)
        {
            try
            {
                MemberDataAccess mDA = new MemberDataAccess();

                string searchBy;
                List<Member> foundMembers = new List<Member>();
                dataGridViewMembers.DataSource = foundMembers;

                switch (comboBoxSearchBy.SelectedIndex)
                {
                    default:
                        searchBy = "FirstName";
                        break;
                    case 1:
                        searchBy = "LastName";
                        break;
                    case 2:
                        searchBy = "Address";
                        break;
                    case 3:
                        searchBy = "PhoneNumber";
                        break;
                    case 4:
                        searchBy = "Email";
                        break;
                    case 5:
                        searchBy = "CardNumber";
                        break;
                }

                foundMembers = mDA.SearchMembers(searchBy, textBox1.Text);

                //Need to create own exception
                if (foundMembers.Count == 0)
                {
                    MessageBox.Show("No member found.");
                }
                else
                {
                    dataGridViewMembers.DataSource = foundMembers;
                    dataGridViewMembers.Columns[4].DisplayIndex = 1;
                    dataGridViewMembers.Columns[5].DisplayIndex = 2;
                    dataGridViewMembers.Columns[6].DisplayIndex = 3;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridViewMembers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewMembers.SelectedRows.Count != 1)
            {
                buttonChoose.Enabled = false;
            }
            else
                buttonChoose.Enabled = true;
        }

        //Public property that's gonna be returned for the FormBorrowBook
        public Member Member { get; set; }

        //Choose a member to whom book is gonna be borrowed
        private void buttonChoose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Member = (Member)dataGridViewMembers.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
