
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
            this.dateTimePickerBorrow = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerReturn = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPickMember
            // 
            this.buttonPickMember.FlatAppearance.BorderSize = 0;
            this.buttonPickMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPickMember.Location = new System.Drawing.Point(117, 71);
            this.buttonPickMember.Name = "buttonPickMember";
            this.buttonPickMember.Size = new System.Drawing.Size(121, 30);
            this.buttonPickMember.TabIndex = 0;
            this.buttonPickMember.Text = "Pick member";
            this.buttonPickMember.UseVisualStyleBackColor = true;
            this.buttonPickMember.Click += new System.EventHandler(this.buttonPickMember_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(256, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 23);
            this.textBox1.TabIndex = 1;
            // 
            // buttonPickBooks
            // 
            this.buttonPickBooks.FlatAppearance.BorderSize = 0;
            this.buttonPickBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPickBooks.Location = new System.Drawing.Point(117, 141);
            this.buttonPickBooks.Name = "buttonPickBooks";
            this.buttonPickBooks.Size = new System.Drawing.Size(121, 28);
            this.buttonPickBooks.TabIndex = 2;
            this.buttonPickBooks.Text = "Pick books";
            this.buttonPickBooks.UseVisualStyleBackColor = true;
            this.buttonPickBooks.Click += new System.EventHandler(this.buttonPickBook_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(256, 141);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(324, 229);
            this.listBox1.TabIndex = 3;
            // 
            // dateTimePickerBorrow
            // 
            this.dateTimePickerBorrow.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBorrow.Location = new System.Drawing.Point(256, 399);
            this.dateTimePickerBorrow.Name = "dateTimePickerBorrow";
            this.dateTimePickerBorrow.Size = new System.Drawing.Size(324, 23);
            this.dateTimePickerBorrow.TabIndex = 4;
            // 
            // dateTimePickerReturn
            // 
            this.dateTimePickerReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerReturn.Location = new System.Drawing.Point(256, 453);
            this.dateTimePickerReturn.Name = "dateTimePickerReturn";
            this.dateTimePickerReturn.Size = new System.Drawing.Size(324, 23);
            this.dateTimePickerReturn.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date of borrow:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date of return:";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.FlatAppearance.BorderSize = 0;
            this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirm.Location = new System.Drawing.Point(303, 505);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(224, 28);
            this.buttonConfirm.TabIndex = 8;
            this.buttonConfirm.Text = "Confirm order";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // FormBorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 800);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerReturn);
            this.Controls.Add(this.dateTimePickerBorrow);
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
        private System.Windows.Forms.DateTimePicker dateTimePickerBorrow;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConfirm;
    }
}