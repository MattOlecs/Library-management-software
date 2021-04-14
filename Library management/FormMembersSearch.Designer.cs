
namespace Library_management
{
    partial class FormMembersSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewMembers = new System.Windows.Forms.DataGridView();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearchMembers = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMembers
            // 
            this.dataGridViewMembers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMembers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewMembers.Location = new System.Drawing.Point(0, 125);
            this.dataGridViewMembers.Name = "dataGridViewMembers";
            this.dataGridViewMembers.RowTemplate.Height = 25;
            this.dataGridViewMembers.Size = new System.Drawing.Size(850, 675);
            this.dataGridViewMembers.TabIndex = 0;
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Address",
            "Phone number",
            "E-mail",
            "Card number"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(0, 27);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(202, 23);
            this.comboBoxSearchBy.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(629, 23);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search by:";
            // 
            // buttonSearchMembers
            // 
            this.buttonSearchMembers.Location = new System.Drawing.Point(635, 56);
            this.buttonSearchMembers.Name = "buttonSearchMembers";
            this.buttonSearchMembers.Size = new System.Drawing.Size(203, 23);
            this.buttonSearchMembers.TabIndex = 4;
            this.buttonSearchMembers.Text = "Search";
            this.buttonSearchMembers.UseVisualStyleBackColor = true;
            this.buttonSearchMembers.Click += new System.EventHandler(this.buttonSearchMembers_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.textBox1);
            this.panelSearch.Controls.Add(this.buttonSearchMembers);
            this.panelSearch.Controls.Add(this.comboBoxSearchBy);
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(850, 87);
            this.panelSearch.TabIndex = 5;
            // 
            // FormMembersSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 800);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.dataGridViewMembers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMembersSearch";
            this.Text = "FormMembersSearch";
            this.Load += new System.EventHandler(this.FormMembersSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMembers;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearchMembers;
        private System.Windows.Forms.Panel panelSearch;
    }
}