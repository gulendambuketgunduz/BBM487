namespace LibraryLoanSystem
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
            this.btnInactiveMember = new System.Windows.Forms.Button();
            this.tabManipulateMember = new System.Windows.Forms.TabControl();
            this.tabPageListMember = new System.Windows.Forms.TabPage();
            this.tbxMoney = new System.Windows.Forms.TextBox();
            this.btnFund = new System.Windows.Forms.Button();
            this.btnActiveMember = new System.Windows.Forms.Button();
            this.tabPageListBorrowedBooks = new System.Windows.Forms.TabPage();
            this.gridBooks = new System.Windows.Forms.DataGridView();
            this.tabPageListFine = new System.Windows.Forms.TabPage();
            this.gridFine = new System.Windows.Forms.DataGridView();
            this.btnBack4 = new System.Windows.Forms.Button();
            this.lblLibrarianName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridMembers)).BeginInit();
            this.tabManipulateMember.SuspendLayout();
            this.tabPageListMember.SuspendLayout();
            this.tabPageListBorrowedBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).BeginInit();
            this.tabPageListFine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFine)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListMembers
            // 
            this.btnListMembers.BackColor = System.Drawing.Color.White;
            this.btnListMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListMembers.Location = new System.Drawing.Point(16, 307);
            this.btnListMembers.Name = "btnListMembers";
            this.btnListMembers.Size = new System.Drawing.Size(141, 37);
            this.btnListMembers.TabIndex = 0;
            this.btnListMembers.Text = "List Members";
            this.btnListMembers.UseVisualStyleBackColor = false;
            this.btnListMembers.Click += new System.EventHandler(this.btnListMembers_Click);
            // 
            // btnListBooksBorrowed
            // 
            this.btnListBooksBorrowed.BackColor = System.Drawing.Color.White;
            this.btnListBooksBorrowed.Location = new System.Drawing.Point(18, 23);
            this.btnListBooksBorrowed.Name = "btnListBooksBorrowed";
            this.btnListBooksBorrowed.Size = new System.Drawing.Size(150, 37);
            this.btnListBooksBorrowed.TabIndex = 1;
            this.btnListBooksBorrowed.Text = "Show Books Borrowed";
            this.btnListBooksBorrowed.UseVisualStyleBackColor = false;
            this.btnListBooksBorrowed.Click += new System.EventHandler(this.btnListBooksBorrowed_Click);
            // 
            // btnListFine
            // 
            this.btnListFine.BackColor = System.Drawing.Color.White;
            this.btnListFine.Location = new System.Drawing.Point(13, 22);
            this.btnListFine.Name = "btnListFine";
            this.btnListFine.Size = new System.Drawing.Size(148, 35);
            this.btnListFine.TabIndex = 2;
            this.btnListFine.Text = "Show Fines";
            this.btnListFine.UseVisualStyleBackColor = false;
            this.btnListFine.Click += new System.EventHandler(this.btnListFine_Click);
            // 
            // gridMembers
            // 
            this.gridMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMembers.Location = new System.Drawing.Point(16, 6);
            this.gridMembers.Name = "gridMembers";
            this.gridMembers.ReadOnly = true;
            this.gridMembers.Size = new System.Drawing.Size(888, 278);
            this.gridMembers.TabIndex = 2;
            this.gridMembers.SelectionChanged += new System.EventHandler(this.gridMembers_SelectionChanged);
            // 
            // btnInactiveMember
            // 
            this.btnInactiveMember.BackColor = System.Drawing.Color.White;
            this.btnInactiveMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInactiveMember.Location = new System.Drawing.Point(785, 341);
            this.btnInactiveMember.Name = "btnInactiveMember";
            this.btnInactiveMember.Size = new System.Drawing.Size(109, 36);
            this.btnInactiveMember.TabIndex = 1;
            this.btnInactiveMember.Text = "Inactive Member";
            this.btnInactiveMember.UseVisualStyleBackColor = false;
            this.btnInactiveMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // tabManipulateMember
            // 
            this.tabManipulateMember.Controls.Add(this.tabPageListMember);
            this.tabManipulateMember.Controls.Add(this.tabPageListBorrowedBooks);
            this.tabManipulateMember.Controls.Add(this.tabPageListFine);
            this.tabManipulateMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabManipulateMember.Location = new System.Drawing.Point(12, 12);
            this.tabManipulateMember.Name = "tabManipulateMember";
            this.tabManipulateMember.SelectedIndex = 0;
            this.tabManipulateMember.Size = new System.Drawing.Size(929, 418);
            this.tabManipulateMember.TabIndex = 0;
            // 
            // tabPageListMember
            // 
            this.tabPageListMember.Controls.Add(this.tbxMoney);
            this.tabPageListMember.Controls.Add(this.btnFund);
            this.tabPageListMember.Controls.Add(this.btnActiveMember);
            this.tabPageListMember.Controls.Add(this.gridMembers);
            this.tabPageListMember.Controls.Add(this.btnInactiveMember);
            this.tabPageListMember.Controls.Add(this.btnListMembers);
            this.tabPageListMember.Location = new System.Drawing.Point(4, 24);
            this.tabPageListMember.Name = "tabPageListMember";
            this.tabPageListMember.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListMember.Size = new System.Drawing.Size(921, 390);
            this.tabPageListMember.TabIndex = 0;
            this.tabPageListMember.Text = "List Member";
            this.tabPageListMember.UseVisualStyleBackColor = true;
            // 
            // tbxMoney
            // 
            this.tbxMoney.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxMoney.ForeColor = System.Drawing.Color.Blue;
            this.tbxMoney.Location = new System.Drawing.Point(662, 312);
            this.tbxMoney.Name = "tbxMoney";
            this.tbxMoney.Size = new System.Drawing.Size(117, 23);
            this.tbxMoney.TabIndex = 4;
            this.tbxMoney.Text = "0,0";
            this.tbxMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMoney_KeyPress);
            // 
            // btnFund
            // 
            this.btnFund.BackColor = System.Drawing.Color.White;
            this.btnFund.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFund.Location = new System.Drawing.Point(785, 307);
            this.btnFund.Name = "btnFund";
            this.btnFund.Size = new System.Drawing.Size(109, 29);
            this.btnFund.TabIndex = 2;
            this.btnFund.Text = "Fund";
            this.btnFund.UseVisualStyleBackColor = false;
            this.btnFund.Click += new System.EventHandler(this.btnFund_Click);
            // 
            // btnActiveMember
            // 
            this.btnActiveMember.BackColor = System.Drawing.Color.White;
            this.btnActiveMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnActiveMember.Location = new System.Drawing.Point(662, 341);
            this.btnActiveMember.Name = "btnActiveMember";
            this.btnActiveMember.Size = new System.Drawing.Size(117, 36);
            this.btnActiveMember.TabIndex = 3;
            this.btnActiveMember.Text = "Active Member";
            this.btnActiveMember.UseVisualStyleBackColor = false;
            this.btnActiveMember.Click += new System.EventHandler(this.btnActiveMember_Click);
            // 
            // tabPageListBorrowedBooks
            // 
            this.tabPageListBorrowedBooks.Controls.Add(this.gridBooks);
            this.tabPageListBorrowedBooks.Controls.Add(this.btnListBooksBorrowed);
            this.tabPageListBorrowedBooks.Location = new System.Drawing.Point(4, 24);
            this.tabPageListBorrowedBooks.Name = "tabPageListBorrowedBooks";
            this.tabPageListBorrowedBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListBorrowedBooks.Size = new System.Drawing.Size(921, 390);
            this.tabPageListBorrowedBooks.TabIndex = 1;
            this.tabPageListBorrowedBooks.Text = "List Borrowed Books";
            this.tabPageListBorrowedBooks.UseVisualStyleBackColor = true;
            // 
            // gridBooks
            // 
            this.gridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBooks.Location = new System.Drawing.Point(18, 85);
            this.gridBooks.Name = "gridBooks";
            this.gridBooks.Size = new System.Drawing.Size(883, 249);
            this.gridBooks.TabIndex = 2;
            // 
            // tabPageListFine
            // 
            this.tabPageListFine.Controls.Add(this.gridFine);
            this.tabPageListFine.Controls.Add(this.btnListFine);
            this.tabPageListFine.Location = new System.Drawing.Point(4, 24);
            this.tabPageListFine.Name = "tabPageListFine";
            this.tabPageListFine.Size = new System.Drawing.Size(921, 390);
            this.tabPageListFine.TabIndex = 2;
            this.tabPageListFine.Text = "List Fine";
            this.tabPageListFine.UseVisualStyleBackColor = true;
            // 
            // gridFine
            // 
            this.gridFine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFine.Location = new System.Drawing.Point(13, 75);
            this.gridFine.Name = "gridFine";
            this.gridFine.Size = new System.Drawing.Size(885, 256);
            this.gridFine.TabIndex = 3;
            // 
            // btnBack4
            // 
            this.btnBack4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack4.Image = global::LibraryLoanSystem.Properties.Resources.back;
            this.btnBack4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack4.Location = new System.Drawing.Point(829, 436);
            this.btnBack4.Name = "btnBack4";
            this.btnBack4.Size = new System.Drawing.Size(112, 36);
            this.btnBack4.TabIndex = 1;
            this.btnBack4.Text = "Back";
            this.btnBack4.UseVisualStyleBackColor = false;
            this.btnBack4.Click += new System.EventHandler(this.btnBack4_Click);
            // 
            // lblLibrarianName
            // 
            this.lblLibrarianName.AutoSize = true;
            this.lblLibrarianName.Location = new System.Drawing.Point(179, 447);
            this.lblLibrarianName.Name = "lblLibrarianName";
            this.lblLibrarianName.Size = new System.Drawing.Size(0, 13);
            this.lblLibrarianName.TabIndex = 5;
            // 
            // ManipulateMembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 484);
            this.Controls.Add(this.lblLibrarianName);
            this.Controls.Add(this.btnBack4);
            this.Controls.Add(this.tabManipulateMember);
            this.MaximizeBox = false;
            this.Name = "ManipulateMembersForm";
            this.Text = "Manipulate Members ";
            ((System.ComponentModel.ISupportInitialize)(this.gridMembers)).EndInit();
            this.tabManipulateMember.ResumeLayout(false);
            this.tabPageListMember.ResumeLayout(false);
            this.tabPageListMember.PerformLayout();
            this.tabPageListBorrowedBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).EndInit();
            this.tabPageListFine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListMembers;
        private System.Windows.Forms.Button btnListBooksBorrowed;
        private System.Windows.Forms.Button btnListFine;
        private System.Windows.Forms.DataGridView gridMembers;
        private System.Windows.Forms.Button btnInactiveMember;
        private System.Windows.Forms.TabControl tabManipulateMember;
        private System.Windows.Forms.TabPage tabPageListMember;
        private System.Windows.Forms.TabPage tabPageListBorrowedBooks;
        private System.Windows.Forms.DataGridView gridBooks;
        private System.Windows.Forms.TabPage tabPageListFine;
        private System.Windows.Forms.DataGridView gridFine;
        private System.Windows.Forms.Button btnActiveMember;
        private System.Windows.Forms.Button btnBack4;
        private System.Windows.Forms.TextBox tbxMoney;
        private System.Windows.Forms.Button btnFund;
        private System.Windows.Forms.Label lblLibrarianName;
    }
}