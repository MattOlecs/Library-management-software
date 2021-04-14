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
            
            EmployeeDataAccess dA = new EmployeeDataAccess();
            dataGridViewEmployees.DataSource = dA.GetAllEmployees();
            dataGridViewEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEmployees.AutoGenerateColumns = false;
            dataGridViewEmployees.Columns[1].DisplayIndex = 4;
        }

        private void button_OpenEmployeeWindow_Click(object sender, EventArgs e)
        {
                if (dataGridViewEmployees.SelectedRows.Count == 1)
                {
                    Employee employee = (Employee)dataGridViewEmployees.CurrentRow.DataBoundItem;
                    Form form = new FormSingleEmployeeInfo(employee, true);
                    form.ShowDialog();
                }
                else
                MessageBox.Show("No employee selected", "Error");
        }

        private void buttonSearchEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeDataAccess eDA = new EmployeeDataAccess();

                string searchBy = "EmployeeId";
                List<Employee> foundEmployees = new List<Employee>();
                dataGridViewEmployees.DataSource = foundEmployees;

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
                }

                foundEmployees = eDA.SearchEmployees(searchBy, textBoxSearchedValue.Text);
                if (foundEmployees.Count == 0)
                {
                    MessageBox.Show("No employee found.");
                }
                else
                    dataGridViewEmployees.DataSource = foundEmployees;

                //due to order in class properties, had to set displayindex of this column
                dataGridViewEmployees.Columns[1].DisplayIndex = 4;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
