namespace WindowsFormsApplication1
{
    partial class ManipulateBooksForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxBookName = new System.Windows.Forms.TextBox();
            this.tbxBookAuthor = new System.Windows.Forms.TextBox();
            this.tbxBookCodePostFix = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBack3 = new System.Windows.Forms.Button();
            this.cmbBookCategory = new System.Windows.Forms.ComboBox();
            this.gridBooks = new System.Windows.Forms.DataGridView();
            this.lblLibrarianName = new System.Windows.Forms.Label();
            this.tbxBookCodePrefix = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Book Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Book Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Book Code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Book Category:";
            // 
            // tbxBookName
            // 
            this.tbxBookName.Location = new System.Drawing.Point(96, 59);
            this.tbxBookName.Name = "tbxBookName";
            this.tbxBookName.Size = new System.Drawing.Size(151, 20);
            this.tbxBookName.TabIndex = 1;
            // 
            // tbxBookAuthor
            // 
            this.tbxBookAuthor.Location = new System.Drawing.Point(96, 90);
            this.tbxBookAuthor.Name = "tbxBookAuthor";
            this.tbxBookAuthor.Size = new System.Drawing.Size(151, 20);
            this.tbxBookAuthor.TabIndex = 2;
            // 
            // tbxBookCodePostFix
            // 
            this.tbxBookCodePostFix.Location = new System.Drawing.Point(166, 29);
            this.tbxBookCodePostFix.Name = "tbxBookCodePostFix";
            this.tbxBookCodePostFix.Size = new System.Drawing.Size(81, 20);
            this.tbxBookCodePostFix.TabIndex = 0;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(16, 207);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(183, 207);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(97, 207);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBack3
            // 
            this.btnBack3.Location = new System.Drawing.Point(667, 258);
            this.btnBack3.Name = "btnBack3";
            this.btnBack3.Size = new System.Drawing.Size(75, 23);
            this.btnBack3.TabIndex = 7;
            this.btnBack3.Text = "Back";
            this.btnBack3.UseVisualStyleBackColor = true;
            this.btnBack3.Click += new System.EventHandler(this.btnBack3_Click);
            // 
            // cmbBookCategory
            // 
            this.cmbBookCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookCategory.FormattingEnabled = true;
            this.cmbBookCategory.Location = new System.Drawing.Point(97, 124);
            this.cmbBookCategory.Name = "cmbBookCategory";
            this.cmbBookCategory.Size = new System.Drawing.Size(150, 21);
            this.cmbBookCategory.TabIndex = 3;
            this.cmbBookCategory.SelectedIndexChanged += new System.EventHandler(this.cmbBookCategory_SelectedIndexChanged);
            // 
            // gridBooks
            // 
            this.gridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBooks.Location = new System.Drawing.Point(264, 50);
            this.gridBooks.Name = "gridBooks";
            this.gridBooks.ReadOnly = true;
            this.gridBooks.Size = new System.Drawing.Size(478, 202);
            this.gridBooks.TabIndex = 8;
            // 
            // lblLibrarianName
            // 
            this.lblLibrarianName.Location = new System.Drawing.Point(432, 9);
            this.lblLibrarianName.Name = "lblLibrarianName";
            this.lblLibrarianName.Size = new System.Drawing.Size(176, 23);
            this.lblLibrarianName.TabIndex = 13;
            // 
            // tbxBookCodePrefix
            // 
            this.tbxBookCodePrefix.Location = new System.Drawing.Point(96, 29);
            this.tbxBookCodePrefix.Name = "tbxBookCodePrefix";
            this.tbxBookCodePrefix.ReadOnly = true;
            this.tbxBookCodePrefix.Size = new System.Drawing.Size(55, 20);
            this.tbxBookCodePrefix.TabIndex = 15;
            // 
            // ManipulateBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 293);
            this.Controls.Add(this.tbxBookCodePrefix);
            this.Controls.Add(this.lblLibrarianName);
            this.Controls.Add(this.gridBooks);
            this.Controls.Add(this.cmbBookCategory);
            this.Controls.Add(this.btnBack3);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.tbxBookCodePostFix);
            this.Controls.Add(this.tbxBookAuthor);
            this.Controls.Add(this.tbxBookName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ManipulateBooksForm";
            this.Text = "Manipulate Books ";
            this.Load += new System.EventHandler(this.ManipulateBooksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxBookName;
        private System.Windows.Forms.TextBox tbxBookAuthor;
        private System.Windows.Forms.TextBox tbxBookCodePostFix;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack3;
        private System.Windows.Forms.ComboBox cmbBookCategory;
        private System.Windows.Forms.DataGridView gridBooks;
        public System.Windows.Forms.Label lblLibrarianName;
        private System.Windows.Forms.TextBox tbxBookCodePrefix;
    }
}