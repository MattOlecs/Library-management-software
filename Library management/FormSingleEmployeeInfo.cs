using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library_management
{
    public partial class FormSingleEmployeeInfo : Form
    {
        public FormSingleEmployeeInfo(Employee employee, bool edit)
        {
            InitializeComponent();

            if (edit)
            {
                textBoxNumber.Text = employee.EmployeeId.ToString();
                textBoxFirstName.Text = employee.FirstName;
                textBoxLastName.Text = employee.LastName;
                textBoxAddress.Text = employee.Address;
                textBoxPosition.Text = employee.Position;
                textBoxNumber.Text = employee.EmployeeId.ToString();
                maskedTextBoxBirthDate.Text = employee.BirthDate.ToString();
            }
            else
                buttonAddEmployee.Visible = true;

        }

        private void textboxReadOnly()
        {
            if(textBoxFirstName.ReadOnly)
            {
                textBoxFirstName.ReadOnly = false;
                textBoxLastName.ReadOnly = false;
                textBoxAddress.ReadOnly = false;
                textBoxPosition.ReadOnly = false;
                maskedTextBoxBirthDate.ReadOnly = false;
            }
            else
            {
                textBoxFirstName.ReadOnly = true;
                textBoxLastName.ReadOnly = true;
                textBoxAddress.ReadOnly = true;
                textBoxPosition.ReadOnly = true;
                maskedTextBoxBirthDate.ReadOnly = true;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            textboxReadOnly();
            buttonConfirmEdit.Visible = true;
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {      
            try
            {
                EmployeeDataAccess dA = new EmployeeDataAccess();

                dA.InsertEmployee(textBoxFirstName.Text, textBoxLastName.Text, textBoxAddress.Text, textBoxPosition.Text, DateTime.ParseExact(maskedTextBoxBirthDate.Text, "d", null));

                MessageBox.Show("Employee added succesfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Incorrect employee information. {ex.Message}", "Error");
            }
        }

        private void buttonConfirmEdit_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeDataAccess dA = new EmployeeDataAccess();
                
                DialogResult result = MessageBox.Show("Are you sure you want to change this employee personal information?", "Confirm data change", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    dA.UpdateEmployee(textBoxNumber.Text, textBoxFirstName.Text, textBoxLastName.Text, textBoxAddress.Text, textBoxPosition.Text, DateTime.ParseExact(maskedTextBoxBirthDate.Text, "d", null));
                    
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
            }
                
        }


    }
}
