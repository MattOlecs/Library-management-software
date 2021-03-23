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
        public FormSingleMemberInfo()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            LibraryCard card = new LibraryCard(1, textBoxCardNumber.Text);

            LibraryCardDataAccess dA = new LibraryCardDataAccess();

            dA.InsertLibraryCard(card);
        }
    }
}
