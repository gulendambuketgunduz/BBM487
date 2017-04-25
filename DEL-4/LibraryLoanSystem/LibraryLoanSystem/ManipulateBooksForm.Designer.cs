namespace LibraryLoanSystem
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
            this.lblBooksName = new System.Windows.Forms.Label();
            this.lblBooksAuthor = new System.Windows.Forms.Label();
            this.lblBooksCode = new System.Windows.Forms.Label();
            this.lblBooksCategory = new System.Windows.Forms.Label();
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
            // lblBooksName
            // 
            this.lblBooksName.AutoSize = true;
            this.lblBooksName.Location = new System.Drawing.Point(12, 59);
            this.lblBooksName.Name = "lblBooksName";
            this.lblBooksName.Size = new System.Drawing.Size(66, 13);
            this.lblBooksName.TabIndex = 11;
            this.lblBooksName.Text = "Book Name:";
            // 
            // lblBooksAuthor
            // 
            this.lblBooksAuthor.AutoSize = true;
            this.lblBooksAuthor.Location = new System.Drawing.Point(12, 90);
            this.lblBooksAuthor.Name = "lblBooksAuthor";
            this.lblBooksAuthor.Size = new System.Drawing.Size(69, 13);
            this.lblBooksAuthor.TabIndex = 10;
            this.lblBooksAuthor.Text = "Book Author:";
            // 
            // lblBooksCode
            // 
            this.lblBooksCode.AutoSize = true;
            this.lblBooksCode.Location = new System.Drawing.Point(15, 29);
            this.lblBooksCode.Name = "lblBooksCode";
            this.lblBooksCode.Size = new System.Drawing.Size(63, 13);
            this.lblBooksCode.TabIndex = 12;
            this.lblBooksCode.Text = "Book Code:";
            // 
            // lblBooksCategory
            // 
            this.lblBooksCategory.AutoSize = true;
            this.lblBooksCategory.Location = new System.Drawing.Point(10, 127);
            this.lblBooksCategory.Name = "lblBooksCategory";
            this.lblBooksCategory.Size = new System.Drawing.Size(80, 13);
            this.lblBooksCategory.TabIndex = 9;
            this.lblBooksCategory.Text = "Book Category:";
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
            this.Controls.Add(this.lblBooksCategory);
            this.Controls.Add(this.lblBooksCode);
            this.Controls.Add(this.lblBooksAuthor);
            this.Controls.Add(this.lblBooksName);
            this.MaximizeBox = false;
            this.Name = "ManipulateBooksForm";
            this.Text = "Manipulate Books ";
            this.Load += new System.EventHandler(this.ManipulateBooksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBooksName;
        private System.Windows.Forms.Label lblBooksAuthor;
        private System.Windows.Forms.Label lblBooksCode;
        private System.Windows.Forms.Label lblBooksCategory;
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