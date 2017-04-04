namespace WindowsFormsApplication1
{
    partial class CommunicationLibraryForm
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
            ((System.ComponentModel.ISupportInitialize)(this.gridLibrarian)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLibrarian
            // 
            this.gridLibrarian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLibrarian.Location = new System.Drawing.Point(13, 20);
            this.gridLibrarian.Name = "gridLibrarian";
            this.gridLibrarian.Size = new System.Drawing.Size(611, 217);
            this.gridLibrarian.TabIndex = 1;
            // 
            // btnBack1
            // 
            this.btnBack1.Location = new System.Drawing.Point(549, 256);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(75, 23);
            this.btnBack1.TabIndex = 0;
            this.btnBack1.Text = "Back";
            this.btnBack1.UseVisualStyleBackColor = true;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click);
            // 
            // CommunicationLibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 291);
            this.Controls.Add(this.btnBack1);
            this.Controls.Add(this.gridLibrarian);
            this.Name = "CommunicationLibraryForm";
            this.Text = "Communication with Library";
            this.Load += new System.EventHandler(this.CommunicationLibraryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLibrarian)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridLibrarian;
        private System.Windows.Forms.Button btnBack1;
    }
}