namespace WindowsFormsApplication1
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
            this.btnLogout1 = new System.Windows.Forms.Button();
            this.lblLibrarianName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnManipulateBooks
            // 
            this.btnManipulateBooks.Location = new System.Drawing.Point(89, 228);
            this.btnManipulateBooks.Name = "btnManipulateBooks";
            this.btnManipulateBooks.Size = new System.Drawing.Size(173, 23);
            this.btnManipulateBooks.TabIndex = 0;
            this.btnManipulateBooks.Text = "Manipulate Books";
            this.btnManipulateBooks.UseVisualStyleBackColor = true;
            this.btnManipulateBooks.Click += new System.EventHandler(this.btnManipulateBooks_Click);
            // 
            // btnManipulateMembers
            // 
            this.btnManipulateMembers.Location = new System.Drawing.Point(293, 228);
            this.btnManipulateMembers.Name = "btnManipulateMembers";
            this.btnManipulateMembers.Size = new System.Drawing.Size(173, 23);
            this.btnManipulateMembers.TabIndex = 1;
            this.btnManipulateMembers.Text = "Manipulate Members";
            this.btnManipulateMembers.UseVisualStyleBackColor = true;
            this.btnManipulateMembers.Click += new System.EventHandler(this.btnManipulateMembers_Click);
            // 
            // btnLogout1
            // 
            this.btnLogout1.Location = new System.Drawing.Point(464, 272);
            this.btnLogout1.Name = "btnLogout1";
            this.btnLogout1.Size = new System.Drawing.Size(75, 23);
            this.btnLogout1.TabIndex = 2;
            this.btnLogout1.Text = "Logout";
            this.btnLogout1.UseVisualStyleBackColor = true;
            this.btnLogout1.Click += new System.EventHandler(this.btnLogout1_Click);
            // 
            // lblLibrarianName
            // 
            this.lblLibrarianName.Location = new System.Drawing.Point(162, 21);
            this.lblLibrarianName.Name = "lblLibrarianName";
            this.lblLibrarianName.Size = new System.Drawing.Size(316, 43);
            this.lblLibrarianName.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.kutuphane__1_;
            this.pictureBox1.Location = new System.Drawing.Point(43, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // LibrarianOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 316);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLibrarianName);
            this.Controls.Add(this.btnLogout1);
            this.Controls.Add(this.btnManipulateMembers);
            this.Controls.Add(this.btnManipulateBooks);
            this.Name = "LibrarianOperationsForm";
            this.Text = "Librarian Operations";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManipulateBooks;
        private System.Windows.Forms.Button btnManipulateMembers;
        private System.Windows.Forms.Button btnLogout1;
        public System.Windows.Forms.Label lblLibrarianName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}