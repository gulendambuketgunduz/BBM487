namespace LibraryLoanSystem
{
    partial class CommunicationLibrarianForm
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
            this.gridLibrarian = new System.Windows.Forms.DataGridView();
            this.btnBack1 = new System.Windows.Forms.Button();
            this.lblMemberName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridLibrarian)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLibrarian
            // 
            this.gridLibrarian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLibrarian.Location = new System.Drawing.Point(13, 20);
            this.gridLibrarian.Name = "gridLibrarian";
            this.gridLibrarian.Size = new System.Drawing.Size(729, 285);
            this.gridLibrarian.TabIndex = 1;
           
            // 
            // btnBack1
            // 
            this.btnBack1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack1.Image = global::LibraryLoanSystem.Properties.Resources.back;
            this.btnBack1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack1.Location = new System.Drawing.Point(630, 331);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(112, 39);
            this.btnBack1.TabIndex = 0;
            this.btnBack1.Text = "Back";
            this.btnBack1.UseVisualStyleBackColor = false;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click);
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(291, 331);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(0, 13);
            this.lblMemberName.TabIndex = 2;
            // 
            // CommunicationLibrarianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 392);
            this.Controls.Add(this.lblMemberName);
            this.Controls.Add(this.btnBack1);
            this.Controls.Add(this.gridLibrarian);
            this.Name = "CommunicationLibrarianForm";
            this.Text = "Communication with the Librarian";
            this.Load += new System.EventHandler(this.CommunicationLibraryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLibrarian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridLibrarian;
        private System.Windows.Forms.Button btnBack1;
        private System.Windows.Forms.Label lblMemberName;
    }
}