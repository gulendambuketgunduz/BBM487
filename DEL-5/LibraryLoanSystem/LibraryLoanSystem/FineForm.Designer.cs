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
            this.btnListViewActiveFine = new System.Windows.Forms.Button();
            this.gridMyFine = new System.Windows.Forms.DataGridView();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.btnListPayFine = new System.Windows.Forms.Button();
            this.btnPayFine = new System.Windows.Forms.Button();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridMyFine)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListViewActiveFine
            // 
            this.btnListViewActiveFine.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListViewActiveFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListViewActiveFine.Location = new System.Drawing.Point(22, 26);
            this.btnListViewActiveFine.Name = "btnListViewActiveFine";
            this.btnListViewActiveFine.Size = new System.Drawing.Size(145, 35);
            this.btnListViewActiveFine.TabIndex = 1;
            this.btnListViewActiveFine.Text = "List Active Fines";
            this.btnListViewActiveFine.UseVisualStyleBackColor = false;
            this.btnListViewActiveFine.Click += new System.EventHandler(this.btnListViewActiveFine_Click);
            // 
            // gridMyFine
            // 
            this.gridMyFine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMyFine.Location = new System.Drawing.Point(22, 79);
            this.gridMyFine.Name = "gridMyFine";
            this.gridMyFine.Size = new System.Drawing.Size(815, 245);
            this.gridMyFine.TabIndex = 2;
            // 
            // btnBack2
            // 
            this.btnBack2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack2.Image = global::LibraryLoanSystem.Properties.Resources.back;
            this.btnBack2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack2.Location = new System.Drawing.Point(716, 352);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(121, 35);
            this.btnBack2.TabIndex = 0;
            this.btnBack2.Text = "Back";
            this.btnBack2.UseVisualStyleBackColor = false;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
            // 
            // btnListPayFine
            // 
            this.btnListPayFine.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListPayFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListPayFine.Location = new System.Drawing.Point(193, 26);
            this.btnListPayFine.Name = "btnListPayFine";
            this.btnListPayFine.Size = new System.Drawing.Size(146, 37);
            this.btnListPayFine.TabIndex = 3;
            this.btnListPayFine.Text = "List Funded Fines";
            this.btnListPayFine.UseVisualStyleBackColor = false;
            this.btnListPayFine.Click += new System.EventHandler(this.btnListPayFine_Click);
            // 
            // btnPayFine
            // 
            this.btnPayFine.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPayFine.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPayFine.ForeColor = System.Drawing.Color.Maroon;
            this.btnPayFine.Location = new System.Drawing.Point(690, 26);
            this.btnPayFine.Name = "btnPayFine";
            this.btnPayFine.Size = new System.Drawing.Size(147, 37);
            this.btnPayFine.TabIndex = 4;
            this.btnPayFine.Text = "Pay Fine";
            this.btnPayFine.UseVisualStyleBackColor = false;
            this.btnPayFine.Click += new System.EventHandler(this.btnPayFine_Click);
            // 
            // lblMoney
            // 
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMoney.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMoney.Location = new System.Drawing.Point(573, 34);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(100, 23);
            this.lblMoney.TabIndex = 5;
            this.lblMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(281, 352);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(0, 13);
            this.lblMemberName.TabIndex = 6;
            // 
            // FineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 408);
            this.Controls.Add(this.lblMemberName);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.btnPayFine);
            this.Controls.Add(this.btnListPayFine);
            this.Controls.Add(this.btnBack2);
            this.Controls.Add(this.gridMyFine);
            this.Controls.Add(this.btnListViewActiveFine);
            this.Name = "FineForm";
            this.Text = "Fine";
            this.Load += new System.EventHandler(this.FineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMyFine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListViewActiveFine;
        private System.Windows.Forms.DataGridView gridMyFine;
        private System.Windows.Forms.Button btnBack2;
        private System.Windows.Forms.Button btnListPayFine;
        private System.Windows.Forms.Button btnPayFine;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblMemberName;
    }
}