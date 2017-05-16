namespace LibraryLoanSystem
{
    partial class MemberOperationsForm
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
            this.ReservedText = new System.Windows.Forms.Button();
            this.btnFine = new System.Windows.Forms.Button();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.btnCommWLibry = new System.Windows.Forms.Button();
            this.pictureBoxMemberBooks = new System.Windows.Forms.PictureBox();
            this.btnLogoutMember = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMemberBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // ReservedText
            // 
            this.ReservedText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReservedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ReservedText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ReservedText.Location = new System.Drawing.Point(129, 274);
            this.ReservedText.Name = "ReservedText";
            this.ReservedText.Size = new System.Drawing.Size(116, 58);
            this.ReservedText.TabIndex = 0;
            this.ReservedText.Text = "Self Check out\r\nSelf  Return\r\nReservation\r\n\r\n\r\n\r\n";
            this.ReservedText.UseVisualStyleBackColor = false;
            this.ReservedText.Click += new System.EventHandler(this.ReservedText_Click);
            // 
            // btnFine
            // 
            this.btnFine.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFine.Location = new System.Drawing.Point(310, 281);
            this.btnFine.Name = "btnFine";
            this.btnFine.Size = new System.Drawing.Size(116, 45);
            this.btnFine.TabIndex = 1;
            this.btnFine.Text = "Fine \r\nPay Fine";
            this.btnFine.UseVisualStyleBackColor = false;
            this.btnFine.Click += new System.EventHandler(this.btnFine_Click);
            // 
            // lblMemberName
            // 
            this.lblMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMemberName.Location = new System.Drawing.Point(225, 9);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(301, 34);
            this.lblMemberName.TabIndex = 8;
            // 
            // btnCommWLibry
            // 
            this.btnCommWLibry.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCommWLibry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCommWLibry.Location = new System.Drawing.Point(487, 281);
            this.btnCommWLibry.Name = "btnCommWLibry";
            this.btnCommWLibry.Size = new System.Drawing.Size(150, 45);
            this.btnCommWLibry.TabIndex = 2;
            this.btnCommWLibry.Text = "Communication with \r\n      the librarian";
            this.btnCommWLibry.UseVisualStyleBackColor = false;
            this.btnCommWLibry.Click += new System.EventHandler(this.btnCommWLibry_Click);
            // 
            // pictureBoxMemberBooks
            // 
            this.pictureBoxMemberBooks.Image = global::LibraryLoanSystem.Properties.Resources.kutuphane__1_;
            this.pictureBoxMemberBooks.Location = new System.Drawing.Point(34, 46);
            this.pictureBoxMemberBooks.Name = "pictureBoxMemberBooks";
            this.pictureBoxMemberBooks.Size = new System.Drawing.Size(751, 172);
            this.pictureBoxMemberBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMemberBooks.TabIndex = 11;
            this.pictureBoxMemberBooks.TabStop = false;
            // 
            // btnLogoutMember
            // 
            this.btnLogoutMember.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogoutMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogoutMember.Image = global::LibraryLoanSystem.Properties.Resources.logoutt1;
            this.btnLogoutMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogoutMember.Location = new System.Drawing.Point(702, 348);
            this.btnLogoutMember.Name = "btnLogoutMember";
            this.btnLogoutMember.Size = new System.Drawing.Size(83, 38);
            this.btnLogoutMember.TabIndex = 12;
            this.btnLogoutMember.Text = "Logout";
            this.btnLogoutMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogoutMember.UseVisualStyleBackColor = false;
            this.btnLogoutMember.Click += new System.EventHandler(this.btnLogoutMember_Click);
            // 
            // MemberOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 420);
            this.Controls.Add(this.btnLogoutMember);
            this.Controls.Add(this.pictureBoxMemberBooks);
            this.Controls.Add(this.btnCommWLibry);
            this.Controls.Add(this.lblMemberName);
            this.Controls.Add(this.btnFine);
            this.Controls.Add(this.ReservedText);
            this.Name = "MemberOperationsForm";
            this.Text = "Member Operations";
            this.Load += new System.EventHandler(this.MemberOperationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMemberBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReservedText;
        private System.Windows.Forms.Button btnFine;
        public System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Button btnCommWLibry;
        private System.Windows.Forms.PictureBox pictureBoxMemberBooks;
        private System.Windows.Forms.Button btnLogoutMember;
    }
}