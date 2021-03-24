using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library_management
{
    public partial class FormSingleMemberInfo : Form
    {
        public FormSingleMemberInfo(Member member, bool edit)
        {
            InitializeComponent();

            //Modifies Form to either Add new member (bool false) or edit existing one (bool true)
            if (edit)
            {
                textBoxFirstName.Text = member.FirstName;
                textBoxLastName.Text = member.LastName;
                textBoxAddress.Text = member.Address;
                textBoxPhoneNumber.Text = member.PhoneNumber;
                textBoxEmail.Text = member.Email;
                textBoxCardNumber.Text = member.LibraryCardNumber;

                buttonConfirm.Visible = true;
            }
            else
            {
                buttonAdd.Visible = true;
                buttonGenerateNewCard.Visible = true;
            }

        }

        //Checks if all Textboxes have value in it
        //doesn't check textboxCardNumber because it's readonly
        //user doesn't input card number
        private bool checkIfTextboxesNull()
        {
            foreach (Control control in this.Controls)
            {
                TextBox textBox = control as TextBox;
                if (textBox != null && textBox != textBoxCardNumber)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        MessageBox.Show(textBox.Name + " Text box can't be empty");
                        return false;
                    }
                }
            }

            return true;
        }

        //Activates function that adds new member
        //Button visible if bool edit = false
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkIfTextboxesNull()) 
                {
                    Member member = new Member(textBoxFirstName.Text, textBoxLastName.Text, textBoxAddress.Text, textBoxPhoneNumber.Text, textBoxEmail.Text);

                    MemberDataAccess mda = new MemberDataAccess();

                    mda.InsertMember(member);
                }
 
            }
            catch(ArgumentNullException anx)
            {
                MessageBox.Show(anx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Activates function that edit selected member
        //You can select member to edit in form FormMembersSearch
        //Button visible if bool edit = true
        private void buttonConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
