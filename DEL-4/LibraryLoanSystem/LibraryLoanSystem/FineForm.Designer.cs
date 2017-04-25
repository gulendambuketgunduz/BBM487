namespace LibraryLoanSystem
{
    partial class FineForm
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
            this.btnViewmyFine = new System.Windows.Forms.Button();
            this.gridMyFine = new System.Windows.Forms.DataGridView();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.btnPayFine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridMyFine)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewmyFine
            // 
            this.btnViewmyFine.Location = new System.Drawing.Point(34, 13);
            this.btnViewmyFine.Name = "btnViewmyFine";
            this.btnViewmyFine.Size = new System.Drawing.Size(94, 23);
            this.btnViewmyFine.TabIndex = 1;
            this.btnViewmyFine.Text = "View my Fine";
            this.btnViewmyFine.UseVisualStyleBackColor = true;
            this.btnViewmyFine.Click += new System.EventHandler(this.btnViewmyFine_Click);
            // 
            // gridMyFine
            // 
            this.gridMyFine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMyFine.Location = new System.Drawing.Point(34, 55);
            this.gridMyFine.Name = "gridMyFine";
            this.gridMyFine.Size = new System.Drawing.Size(602, 173);
            this.gridMyFine.TabIndex = 2;
            // 
            // btnBack2
            // 
            this.btnBack2.Location = new System.Drawing.Point(561, 254);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(75, 23);
            this.btnBack2.TabIndex = 0;
            this.btnBack2.Text = "Back";
            this.btnBack2.UseVisualStyleBackColor = true;
            // 
            // btnPayFine
            // 
            this.btnPayFine.Location = new System.Drawing.Point(155, 13);
            this.btnPayFine.Name = "btnPayFine";
            this.btnPayFine.Size = new System.Drawing.Size(82, 23);
            this.btnPayFine.TabIndex = 3;
            this.btnPayFine.Text = "Pay Fine";
            this.btnPayFine.UseVisualStyleBackColor = true;
            this.btnPayFine.Click += new System.EventHandler(this.btnPayFine_Click);
            // 
            // FineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 289);
            this.Controls.Add(this.btnPayFine);
            this.Controls.Add(this.btnBack2);
            this.Controls.Add(this.gridMyFine);
            this.Controls.Add(this.btnViewmyFine);
            this.Name = "FineForm";
            this.Text = "Fine";
            ((System.ComponentModel.ISupportInitialize)(this.gridMyFine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewmyFine;
        private System.Windows.Forms.DataGridView gridMyFine;
        private System.Windows.Forms.Button btnBack2;
        private System.Windows.Forms.Button btnPayFine;
    }
}