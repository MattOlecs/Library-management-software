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
            panel_SlideMenu3.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panel_SlideMenu1.Visible == true)
                panel_SlideMenu1.Visible = false;
            
            if (panel_SlideMenu2.Visible == true)
                panel_SlideMenu2.Visible = false;

            if (panel_SlideMenu3.Visible == true)
                panel_SlideMenu3.Visible = false;
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
        
        private void buttonMembersManage_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_SlideMenu2);
        }
        
        private void buttonEmployeesManagement_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_SlideMenu3);
        }

        private void buttonEmployeesList_Click(object sender, EventArgs e)
        {
            Form formEmployeeList = new FormEmployeeList();
            formEmployeeList.Show();
            formEmployeeList.MdiParent = this;
            hideSubMenu();
            formEmployeeList.Dock = DockStyle.Fill;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Form formInventorySearch = new FormInventorySearch();

            formInventorySearch.Show();
            formInventorySearch.MdiParent = this;
            hideSubMenu();
            formInventorySearch.Dock = DockStyle.Fill;
        }

        private void buttonAddNewItem_Click(object sender, EventArgs e)
        {
            Form formInventoryAdd = new FormInventoryAdd();

            formInventoryAdd.Show();
            formInventoryAdd.MdiParent = this;
            hideSubMenu();
            formInventoryAdd.Dock = DockStyle.Fill;
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();

            Form form = new FormSingleEmployeeInfo(employee, false);
            form.ShowDialog();
        }

        private void buttonSearchMember_Click(object sender, EventArgs e)
        {
            Form form = new FormMembersSearch();
            form.ShowDialog();
        }

        //Opens Form in which you can add new member
        //Form takse two values, first is Member class object, second is bool
        //if bool = true Form is prepared for adding new member, if false, to edit existing member
        private void buttonAddMember_Click(object sender, EventArgs e)
        {
            Member member = new Member();

            Form form = new FormSingleMemberInfo(member, false);
            form.ShowDialog();
        }
    }
}
