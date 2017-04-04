namespace WindowsFormsApplication1
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnCommWLibry = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ReservedText
            // 
            this.ReservedText.Location = new System.Drawing.Point(93, 237);
            this.ReservedText.Name = "ReservedText";
            this.ReservedText.Size = new System.Drawing.Size(116, 58);
            this.ReservedText.TabIndex = 0;
            this.ReservedText.Text = "Self Check out\r\nSelf  Return\r\nReservation\r\n\r\n\r\n\r\n";
            this.ReservedText.UseVisualStyleBackColor = true;
            this.ReservedText.Click += new System.EventHandler(this.ReservedText_Click);
            // 
            // btnFine
            // 
            this.btnFine.Location = new System.Drawing.Point(240, 244);
            this.btnFine.Name = "btnFine";
            this.btnFine.Size = new System.Drawing.Size(116, 45);
            this.btnFine.TabIndex = 1;
            this.btnFine.Text = "Fine \r\nPay Fine";
            this.btnFine.UseVisualStyleBackColor = true;
            this.btnFine.Click += new System.EventHandler(this.btnFine_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(501, 297);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(159, 23);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(225, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(301, 34);
            this.lblUserName.TabIndex = 8;
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // btnCommWLibry
            // 
            this.btnCommWLibry.Location = new System.Drawing.Point(376, 244);
            this.btnCommWLibry.Name = "btnCommWLibry";
            this.btnCommWLibry.Size = new System.Drawing.Size(123, 45);
            this.btnCommWLibry.TabIndex = 2;
            this.btnCommWLibry.Text = "Communication with \r\n      the librarian";
            this.btnCommWLibry.UseVisualStyleBackColor = true;
            this.btnCommWLibry.Click += new System.EventHandler(this.btnCommWLibry_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.kutuphane__1_;
            this.pictureBox1.Location = new System.Drawing.Point(34, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(626, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // MemberOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 332);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCommWLibry);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnFine);
            this.Controls.Add(this.ReservedText);
            this.Name = "MemberOperationsForm";
            this.Text = "Member Operations";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReservedText;
        private System.Windows.Forms.Button btnFine;
        private System.Windows.Forms.Button btnLogOut;
        public System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnCommWLibry;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}