namespace WindowsFormsApplication1
{
    partial class ManipulateMembersForm
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
            this.btnListMembers = new System.Windows.Forms.Button();
            this.btnListBooksBorrowed = new System.Windows.Forms.Button();
            this.btnListFine = new System.Windows.Forms.Button();
            this.gridMembers = new System.Windows.Forms.DataGridView();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageListMember = new System.Windows.Forms.TabPage();
            this.btnActiveMember = new System.Windows.Forms.Button();
            this.tabPageListBorrowedBooks = new System.Windows.Forms.TabPage();
            this.gridBooks = new System.Windows.Forms.DataGridView();
            this.tabPageListFine = new System.Windows.Forms.TabPage();
            this.gridFine = new System.Windows.Forms.DataGridView();
            this.btnBack4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridMembers)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageListMember.SuspendLayout();
            this.tabPageListBorrowedBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).BeginInit();
            this.tabPageListFine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFine)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListMembers
            // 
            this.btnListMembers.Location = new System.Drawing.Point(6, 220);
            this.btnListMembers.Name = "btnListMembers";
            this.btnListMembers.Size = new System.Drawing.Size(141, 27);
            this.btnListMembers.TabIndex = 0;
            this.btnListMembers.Text = "List Members";
            this.btnListMembers.UseVisualStyleBackColor = true;
            this.btnListMembers.Click += new System.EventHandler(this.btnListMembers_Click);
            // 
            // btnListBooksBorrowed
            // 
            this.btnListBooksBorrowed.Location = new System.Drawing.Point(18, 16);
            this.btnListBooksBorrowed.Name = "btnListBooksBorrowed";
            this.btnListBooksBorrowed.Size = new System.Drawing.Size(150, 26);
            this.btnListBooksBorrowed.TabIndex = 1;
            this.btnListBooksBorrowed.Text = "Show Books Borrowed";
            this.btnListBooksBorrowed.UseVisualStyleBackColor = true;
            this.btnListBooksBorrowed.Click += new System.EventHandler(this.btnListBooksBorrowed_Click);
            // 
            // btnListFine
            // 
            this.btnListFine.Location = new System.Drawing.Point(13, 18);
            this.btnListFine.Name = "btnListFine";
            this.btnListFine.Size = new System.Drawing.Size(134, 27);
            this.btnListFine.TabIndex = 2;
            this.btnListFine.Text = "Show Fines";
            this.btnListFine.UseVisualStyleBackColor = true;
            this.btnListFine.Click += new System.EventHandler(this.btnListFine_Click);
            // 
            // gridMembers
            // 
            this.gridMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMembers.Location = new System.Drawing.Point(6, 12);
            this.gridMembers.Name = "gridMembers";
            this.gridMembers.ReadOnly = true;
            this.gridMembers.Size = new System.Drawing.Size(623, 202);
            this.gridMembers.TabIndex = 2;
            this.gridMembers.SelectionChanged += new System.EventHandler(this.gridMembers_SelectionChanged);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Location = new System.Drawing.Point(458, 221);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(158, 26);
            this.btnDeleteMember.TabIndex = 1;
            this.btnDeleteMember.Text = "Delete Member";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageListMember);
            this.tabControl1.Controls.Add(this.tabPageListBorrowedBooks);
            this.tabControl1.Controls.Add(this.tabPageListFine);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(643, 279);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageListMember
            // 
            this.tabPageListMember.Controls.Add(this.btnActiveMember);
            this.tabPageListMember.Controls.Add(this.gridMembers);
            this.tabPageListMember.Controls.Add(this.btnDeleteMember);
            this.tabPageListMember.Controls.Add(this.btnListMembers);
            this.tabPageListMember.Location = new System.Drawing.Point(4, 22);
            this.tabPageListMember.Name = "tabPageListMember";
            this.tabPageListMember.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListMember.Size = new System.Drawing.Size(635, 253);
            this.tabPageListMember.TabIndex = 0;
            this.tabPageListMember.Text = "List Member";
            this.tabPageListMember.UseVisualStyleBackColor = true;
            // 
            // btnActiveMember
            // 
            this.btnActiveMember.Location = new System.Drawing.Point(294, 220);
            this.btnActiveMember.Name = "btnActiveMember";
            this.btnActiveMember.Size = new System.Drawing.Size(158, 26);
            this.btnActiveMember.TabIndex = 3;
            this.btnActiveMember.Text = "Active Member";
            this.btnActiveMember.UseVisualStyleBackColor = true;
            this.btnActiveMember.Click += new System.EventHandler(this.btnActiveMember_Click);
            // 
            // tabPageListBorrowedBooks
            // 
            this.tabPageListBorrowedBooks.Controls.Add(this.gridBooks);
            this.tabPageListBorrowedBooks.Controls.Add(this.btnListBooksBorrowed);
            this.tabPageListBorrowedBooks.Location = new System.Drawing.Point(4, 22);
            this.tabPageListBorrowedBooks.Name = "tabPageListBorrowedBooks";
            this.tabPageListBorrowedBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListBorrowedBooks.Size = new System.Drawing.Size(635, 253);
            this.tabPageListBorrowedBooks.TabIndex = 1;
            this.tabPageListBorrowedBooks.Text = "List Borrowed Books";
            this.tabPageListBorrowedBooks.UseVisualStyleBackColor = true;
            // 
            // gridBooks
            // 
            this.gridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBooks.Location = new System.Drawing.Point(18, 49);
            this.gridBooks.Name = "gridBooks";
            this.gridBooks.Size = new System.Drawing.Size(578, 176);
            this.gridBooks.TabIndex = 2;
            // 
            // tabPageListFine
            // 
            this.tabPageListFine.Controls.Add(this.gridFine);
            this.tabPageListFine.Controls.Add(this.btnListFine);
            this.tabPageListFine.Location = new System.Drawing.Point(4, 22);
            this.tabPageListFine.Name = "tabPageListFine";
            this.tabPageListFine.Size = new System.Drawing.Size(635, 253);
            this.tabPageListFine.TabIndex = 2;
            this.tabPageListFine.Text = "List Fine";
            this.tabPageListFine.UseVisualStyleBackColor = true;
            // 
            // gridFine
            // 
            this.gridFine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFine.Location = new System.Drawing.Point(13, 52);
            this.gridFine.Name = "gridFine";
            this.gridFine.Size = new System.Drawing.Size(598, 172);
            this.gridFine.TabIndex = 3;
            // 
            // btnBack4
            // 
            this.btnBack4.Location = new System.Drawing.Point(545, 308);
            this.btnBack4.Name = "btnBack4";
            this.btnBack4.Size = new System.Drawing.Size(75, 23);
            this.btnBack4.TabIndex = 1;
            this.btnBack4.Text = "Back";
            this.btnBack4.UseVisualStyleBackColor = true;
            this.btnBack4.Click += new System.EventHandler(this.btnBack4_Click);
            // 
            // ManipulateMembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 345);
            this.Controls.Add(this.btnBack4);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "ManipulateMembersForm";
            this.Text = "Manipulate Members ";
            ((System.ComponentModel.ISupportInitialize)(this.gridMembers)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageListMember.ResumeLayout(false);
            this.tabPageListBorrowedBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).EndInit();
            this.tabPageListFine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListMembers;
        private System.Windows.Forms.Button btnListBooksBorrowed;
        private System.Windows.Forms.Button btnListFine;
        private System.Windows.Forms.DataGridView gridMembers;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageListMember;
        private System.Windows.Forms.TabPage tabPageListBorrowedBooks;
        private System.Windows.Forms.DataGridView gridBooks;
        private System.Windows.Forms.TabPage tabPageListFine;
        private System.Windows.Forms.DataGridView gridFine;
        private System.Windows.Forms.Button btnActiveMember;
        private System.Windows.Forms.Button btnBack4;
    }
}