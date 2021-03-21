
namespace Library_management
{
    partial class FormEmployeeList
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_OpenEmployeeWindow = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxSearchedValue = new System.Windows.Forms.TextBox();
            this.comboBoxSearchByType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearchEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(826, 671);
            this.dataGridView1.TabIndex = 2;
            // 
            // button_OpenEmployeeWindow
            // 
            this.button_OpenEmployeeWindow.Location = new System.Drawing.Point(722, 88);
            this.button_OpenEmployeeWindow.Name = "button_OpenEmployeeWindow";
            this.button_OpenEmployeeWindow.Size = new System.Drawing.Size(116, 23);
            this.button_OpenEmployeeWindow.TabIndex = 4;
            this.button_OpenEmployeeWindow.Text = "Show Details";
            this.button_OpenEmployeeWindow.UseVisualStyleBackColor = true;
            this.button_OpenEmployeeWindow.Click += new System.EventHandler(this.button_OpenEmployeeWindow_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripOptions,
            this.toolStripEmployee});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(850, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripOptions
            // 
            this.toolStripOptions.DropDown = this.contextMenuStrip1;
            this.toolStripOptions.Name = "toolStripOptions";
            this.toolStripOptions.Size = new System.Drawing.Size(61, 20);
            this.toolStripOptions.Text = "Options";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripRefresh});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.OwnerItem = this.toolStripOptions;
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 26);
            // 
            // toolStripRefresh
            // 
            this.toolStripRefresh.Name = "toolStripRefresh";
            this.toolStripRefresh.Size = new System.Drawing.Size(113, 22);
            this.toolStripRefresh.Text = "Refresh";
            // 
            // toolStripEmployee
            // 
            this.toolStripEmployee.Name = "toolStripEmployee";
            this.toolStripEmployee.Size = new System.Drawing.Size(39, 20);
            this.toolStripEmployee.Text = "Edit";
            // 
            // textBoxSearchedValue
            // 
            this.textBoxSearchedValue.Location = new System.Drawing.Point(12, 88);
            this.textBoxSearchedValue.Name = "textBoxSearchedValue";
            this.textBoxSearchedValue.Size = new System.Drawing.Size(452, 23);
            this.textBoxSearchedValue.TabIndex = 6;
            // 
            // comboBoxSearchByType
            // 
            this.comboBoxSearchByType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchByType.FormattingEnabled = true;
            this.comboBoxSearchByType.Items.AddRange(new object[] {
            "ID",
            "First Name",
            "Last Name",
            "Address",
            "Position"});
            this.comboBoxSearchByType.Location = new System.Drawing.Point(12, 59);
            this.comboBoxSearchByType.Name = "comboBoxSearchByType";
            this.comboBoxSearchByType.Size = new System.Drawing.Size(197, 23);
            this.comboBoxSearchByType.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search by:";
            // 
            // buttonSearchEmployee
            // 
            this.buttonSearchEmployee.Location = new System.Drawing.Point(470, 87);
            this.buttonSearchEmployee.Name = "buttonSearchEmployee";
            this.buttonSearchEmployee.Size = new System.Drawing.Size(116, 23);
            this.buttonSearchEmployee.TabIndex = 9;
            this.buttonSearchEmployee.Text = "Search";
            this.buttonSearchEmployee.UseVisualStyleBackColor = true;
            this.buttonSearchEmployee.Click += new System.EventHandler(this.buttonSearchEmployee_Click);
            // 
            // FormEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 800);
            this.Controls.Add(this.buttonSearchEmployee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSearchByType);
            this.Controls.Add(this.textBoxSearchedValue);
            this.Controls.Add(this.button_OpenEmployeeWindow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormEmployeeList";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Form_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_OpenEmployeeWindow;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripOptions;
        private System.Windows.Forms.ToolStripMenuItem toolStripEmployee;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripRefresh;
        private System.Windows.Forms.TextBox textBoxSearchedValue;
        private System.Windows.Forms.ComboBox comboBoxSearchByType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearchEmployee;
    }
}