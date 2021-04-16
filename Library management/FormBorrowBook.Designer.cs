
namespace Library_management
{
    partial class FormBorrowBook
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
            this.buttonPickMember = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonPickBooks = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonPickMember
            // 
            this.buttonPickMember.Location = new System.Drawing.Point(12, 13);
            this.buttonPickMember.Name = "buttonPickMember";
            this.buttonPickMember.Size = new System.Drawing.Size(193, 30);
            this.buttonPickMember.TabIndex = 0;
            this.buttonPickMember.Text = "Pick member";
            this.buttonPickMember.UseVisualStyleBackColor = true;
            this.buttonPickMember.Click += new System.EventHandler(this.buttonPickMember_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 23);
            this.textBox1.TabIndex = 1;
            // 
            // buttonPickBooks
            // 
            this.buttonPickBooks.Location = new System.Drawing.Point(229, 15);
            this.buttonPickBooks.Name = "buttonPickBooks";
            this.buttonPickBooks.Size = new System.Drawing.Size(265, 28);
            this.buttonPickBooks.TabIndex = 2;
            this.buttonPickBooks.Text = "Pick books";
            this.buttonPickBooks.UseVisualStyleBackColor = true;
            this.buttonPickBooks.Click += new System.EventHandler(this.buttonPickBook_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(229, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(265, 229);
            this.listBox1.TabIndex = 3;
            // 
            // FormBorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 800);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonPickBooks);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonPickMember);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBorrowBook";
            this.Text = "FormBorrowBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPickMember;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonPickBooks;
        private System.Windows.Forms.ListBox listBox1;
    }
}