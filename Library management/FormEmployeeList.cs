using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library_management
{
    public partial class FormEmployeeList : Form
    {
        public FormEmployeeList()
        {
            InitializeComponent();
        }

        private void Form_2_Load(object sender, EventArgs e)
        {

            
            comboBoxSearchByType.SelectedIndex = 0;
        }

        private void button_OpenEmployeeWindow_Click(object sender, EventArgs e)
        {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    Employee employee = (Employee)dataGridView1.CurrentRow.DataBoundItem;
                    Form form = new FormSingleEmployeeInfo(employee, true);
                    form.ShowDialog();
                }
                else
                MessageBox.Show("You have to select one employee!", "Error");
        }

        private void buttonSearchEmployee_Click(object sender, EventArgs e)
        {


            try
            {
                EmployeeDataAccess eDA = new EmployeeDataAccess();

                string searchBy = "EmployeeId";
                List<Employee> foundEmployees = new List<Employee>();
                dataGridView1.DataSource = foundEmployees;


                switch (comboBoxSearchByType.SelectedIndex)
                {
                    case 0:
                        searchBy = "EmployeeId";
                        break;
                    case 1:
                        searchBy = "FirstName";
                        break;
                    case 2:
                        searchBy = "LastName";
                        break;
                    case 3:
                        searchBy = "Address";
                        break;
                    case 4:
                        searchBy = "Position";
                        break;
                }

                
                foundEmployees = eDA.SearchEmployees(searchBy, textBoxSearchedValue.Text);
                if (foundEmployees.Count == 0)
                {
                    MessageBox.Show("No items found.");
                }
                else
                    dataGridView1.DataSource = foundEmployees;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
