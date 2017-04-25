namespace LibraryLoanSystem
{
    partial class LibrarianOperationsForm
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
            this.btnManipulateBooks = new System.Windows.Forms.Button();
            this.btnManipulateMembers = new System.Windows.Forms.Button();
            this.lblLibrarianName = new System.Windows.Forms.Label();
            this.pictureBoxLibrarianBooks = new System.Windows.Forms.PictureBox();
            this.btnLogoutLibrarian = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLibrarianBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnManipulateBooks
            // 
            this.btnManipulateBooks.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManipulateBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnManipulateBooks.Location = new System.Drawing.Point(89, 217);
            this.btnManipulateBooks.Name = "btnManipulateBooks";
            this.btnManipulateBooks.Size = new System.Drawing.Size(176, 34);
            this.btnManipulateBooks.TabIndex = 0;
            this.btnManipulateBooks.Text = "Manipulate Books";
            this.btnManipulateBooks.UseVisualStyleBackColor = false;
            this.btnManipulateBooks.Click += new System.EventHandler(this.btnManipulateBooks_Click);
            // 
            // btnManipulateMembers
            // 
            this.btnManipulateMembers.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManipulateMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnManipulateMembers.Location = new System.Drawing.Point(293, 217);
            this.btnManipulateMembers.Name = "btnManipulateMembers";
            this.btnManipulateMembers.Size = new System.Drawing.Size(174, 34);
            this.btnManipulateMembers.TabIndex = 1;
            this.btnManipulateMembers.Text = "Manipulate Members";
            this.btnManipulateMembers.UseVisualStyleBackColor = false;
            this.btnManipulateMembers.Click += new System.EventHandler(this.btnManipulateMembers_Click);
            // 
            // lblLibrarianName
            // 
            this.lblLibrarianName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLibrarianName.Location = new System.Drawing.Point(162, 21);
            this.lblLibrarianName.Name = "lblLibrarianName";
            this.lblLibrarianName.Size = new System.Drawing.Size(316, 43);
            this.lblLibrarianName.TabIndex = 15;
            // 
            // pictureBoxLibrarianBooks
            // 
            this.pictureBoxLibrarianBooks.Image = global::LibraryLoanSystem.Properties.Resources.kutuphane__1_;
            this.pictureBoxLibrarianBooks.Location = new System.Drawing.Point(24, 55);
            this.pictureBoxLibrarianBooks.Name = "pictureBoxLibrarianBooks";
            this.pictureBoxLibrarianBooks.Size = new System.Drawing.Size(554, 139);
            this.pictureBoxLibrarianBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLibrarianBooks.TabIndex = 16;
            this.pictureBoxLibrarianBooks.TabStop = false;
            // 
            // btnLogoutLibrarian
            // 
            this.btnLogoutLibrarian.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogoutLibrarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogoutLibrarian.Image = global::LibraryLoanSystem.Properties.Resources.logoutt1;
            this.btnLogoutLibrarian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogoutLibrarian.Location = new System.Drawing.Point(471, 266);
            this.btnLogoutLibrarian.Name = "btnLogoutLibrarian";
            this.btnLogoutLibrarian.Size = new System.Drawing.Size(83, 38);
            this.btnLogoutLibrarian.TabIndex = 2;
            this.btnLogoutLibrarian.Text = "Logout";
            this.btnLogoutLibrarian.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogoutLibrarian.UseVisualStyleBackColor = false;
            this.btnLogoutLibrarian.Click += new System.EventHandler(this.btnLogoutLibrarian_Click);
            // 
            // LibrarianOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 316);
            this.Controls.Add(this.pictureBoxLibrarianBooks);
            this.Controls.Add(this.lblLibrarianName);
            this.Controls.Add(this.btnLogoutLibrarian);
            this.Controls.Add(this.btnManipulateMembers);
            this.Controls.Add(this.btnManipulateBooks);
            this.Name = "LibrarianOperationsForm";
            this.Text = "Librarian Operations";
            this.Load += new System.EventHandler(this.LibrarianOperationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLibrarianBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManipulateBooks;
        private System.Windows.Forms.Button btnManipulateMembers;
        private System.Windows.Forms.Button btnLogoutLibrarian;
        public System.Windows.Forms.Label lblLibrarianName;
        private System.Windows.Forms.PictureBox pictureBoxLibrarianBooks;
    }
}