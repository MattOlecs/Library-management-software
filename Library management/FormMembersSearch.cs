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

        }
    }
}
