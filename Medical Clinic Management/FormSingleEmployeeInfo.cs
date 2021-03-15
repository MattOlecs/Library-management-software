using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Medical_Clinic_Management
{
    public partial class FormSingleEmployeeInfo : Form
    {
        public FormSingleEmployeeInfo(Employee employeee, bool edit)
        {
            InitializeComponent();

            if (edit)
            {
                textBoxFirstName.Text = employeee.FirstName;
                textBoxLastName.Text = employeee.LastName;
                textBoxNumber.Text = employeee.EmployeeId.ToString();
                maskedTextBoxBirthDate.Text = employeee.BirthDate.ToString();
            }
        }

        private void textboxReadOnly()
        {   
            textBoxFirstName.ReadOnly = false;
            textBoxLastName.ReadOnly = false;
            textBoxAddress.ReadOnly = false;
            textBoxPosition.ReadOnly = false;
            maskedTextBoxBirthDate.ReadOnly = false;
        }

        private void Single_Employee_Info_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            textboxReadOnly();
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            Data_Access da = new Data_Access();

            try
            {
                da.InsertEmployee(textBoxFirstName.Text, textBoxLastName.Text, textBoxAddress.Text, textBoxPosition.Text, DateTime.ParseExact(maskedTextBoxBirthDate.Text, "d", null));

                MessageBox.Show("Employee added succesfully.");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Incorrect employee information.", "Error");
            }
    
        }
    }
}
