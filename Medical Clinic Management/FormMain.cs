using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_management
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
            IsMdiContainer = true;
        }

        private void customizeDesign()
        {
            panel_SlideMenu1.Visible = false;
            panel_SlideMenu2.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panel_SlideMenu1.Visible == true)
                panel_SlideMenu1.Visible = false;
            
            if (panel_SlideMenu2.Visible == true)
                panel_SlideMenu2.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void buttonInventory_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_SlideMenu1);
        }

        private void buttonEmployeesManagement_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_SlideMenu2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form test = new FormEmployeeList();
            test.Show();
            test.MdiParent = this;
            hideSubMenu();
            test.Dock = DockStyle.Fill;
        }












        //private void openChildForm(Form childForm)
        //{
        //    if (activeForm != null)
        //        activeForm.Close();
        //    activeForm = childForm;
        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;
        //    panel_ChildForm.Controls.Add(childForm);
        //    panel_ChildForm.Tag = childForm;
        //    childForm.BringToFront();
        //    childForm.Show();
        //}

    }
}
