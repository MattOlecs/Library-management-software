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
            EmployeeDataAccess emp = new EmployeeDataAccess();
            dataGridView1.DataSource = emp.GetAllEmployees();
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

                eDA.SearchEmployees(comboBoxSearchByType.SelectedItem.ToString(), textBoxSearchedValue.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
