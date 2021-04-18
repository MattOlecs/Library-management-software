using Library_management.DataAccess;
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

        private Member member = new Member();
        private List<Item> listOfBooksToBorrow = new List<Item>();

        //Gets member from FormMembersSearch
        private void buttonPickMember_Click(object sender, EventArgs e)
        {
            try
            {
                FormMembersSearch formMemberSearch = new FormMembersSearch();
                formMemberSearch.ShowDialog();
                
                //If dialog result is OK it means that form was closed correctly and it will return object class Member which is librarys member who wants to borrow items
                if (formMemberSearch.DialogResult != DialogResult.OK)
                {
                    throw new Exception("Couldn't load member correctly");
                }
                else
                {
                    member = formMemberSearch.Member;
                    textBox1.Text = $"{member.FirstName} {member.LastName}";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //If dialog result is OK it means that form was closed correctly and it will return list of class objects Item which are items that will be borrowed
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
                    //assigns values from list of books to borrow from formInventorySearch to this forms list
                    listOfBooksToBorrow = formInventorySearch.listOfBooksToBorrow;

                    foreach (Item item in listOfBooksToBorrow)
                        listBox1.Items.Add(item.Title);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {

                if (dateTimePickerBorrow.Value < dateTimePickerReturn.Value)
                {
                    foreach (Item item in listOfBooksToBorrow)
                    {
                        Order order = new Order(member.MemberId, item.BookId, dateTimePickerBorrow.Value, dateTimePickerReturn.Value);

                        OrderDataAccess.InsertOrder(order);
                    }

                    MessageBox.Show("Order placed succesfully");

                    this.Close();
                }
                else
                    MessageBox.Show("Date of placing order can't be earlier than date of returning order");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
