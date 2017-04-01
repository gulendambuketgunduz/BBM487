namespace WindowsFormsApplication1
{
    partial class SignUpForm
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserTC = new System.Windows.Forms.Label();
            this.lblUserMail = new System.Windows.Forms.Label();
            this.lblUserAdress = new System.Windows.Forms.Label();
            this.lblUserPasswordFirst = new System.Windows.Forms.Label();
            this.lblUserPasswordSecond = new System.Windows.Forms.Label();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.tbxUserEmail = new System.Windows.Forms.TextBox();
            this.tbxUserPasswordFirst = new System.Windows.Forms.TextBox();
            this.tbxUserPasswordSecond = new System.Windows.Forms.TextBox();
            this.rtbxUserAdress = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxUserTC = new System.Windows.Forms.MaskedTextBox();
            this.cmbUserCaption = new System.Windows.Forms.ComboBox();
            this.lblUserCaption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(40, 84);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(67, 23);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name:";
            // 
            // lblUserTC
            // 
            this.lblUserTC.Location = new System.Drawing.Point(40, 115);
            this.lblUserTC.Name = "lblUserTC";
            this.lblUserTC.Size = new System.Drawing.Size(67, 15);
            this.lblUserTC.TabIndex = 1;
            this.lblUserTC.Text = "User TC:";
            // 
            // lblUserMail
            // 
            this.lblUserMail.Location = new System.Drawing.Point(40, 143);
            this.lblUserMail.Name = "lblUserMail";
            this.lblUserMail.Size = new System.Drawing.Size(67, 20);
            this.lblUserMail.TabIndex = 2;
            this.lblUserMail.Text = "E-mail:";
            // 
            // lblUserAdress
            // 
            this.lblUserAdress.Location = new System.Drawing.Point(40, 174);
            this.lblUserAdress.Name = "lblUserAdress";
            this.lblUserAdress.Size = new System.Drawing.Size(67, 20);
            this.lblUserAdress.TabIndex = 3;
            this.lblUserAdress.Text = "Adress:";
            // 
            // lblUserPasswordFirst
            // 
            this.lblUserPasswordFirst.Location = new System.Drawing.Point(41, 250);
            this.lblUserPasswordFirst.Name = "lblUserPasswordFirst";
            this.lblUserPasswordFirst.Size = new System.Drawing.Size(67, 20);
            this.lblUserPasswordFirst.TabIndex = 4;
            this.lblUserPasswordFirst.Text = "Password:";
            // 
            // lblUserPasswordSecond
            // 
            this.lblUserPasswordSecond.Location = new System.Drawing.Point(41, 281);
            this.lblUserPasswordSecond.Name = "lblUserPasswordSecond";
            this.lblUserPasswordSecond.Size = new System.Drawing.Size(109, 20);
            this.lblUserPasswordSecond.TabIndex = 5;
            this.lblUserPasswordSecond.Text = "Confirm Password:";
            // 
            // tbxUserName
            // 
            this.tbxUserName.Location = new System.Drawing.Point(156, 81);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(100, 20);
            this.tbxUserName.TabIndex = 2;
            // 
            // tbxUserEmail
            // 
            this.tbxUserEmail.Location = new System.Drawing.Point(156, 133);
            this.tbxUserEmail.Name = "tbxUserEmail";
            this.tbxUserEmail.Size = new System.Drawing.Size(100, 20);
            this.tbxUserEmail.TabIndex = 4;
            // 
            // tbxUserPasswordFirst
            // 
            this.tbxUserPasswordFirst.Location = new System.Drawing.Point(157, 247);
            this.tbxUserPasswordFirst.Name = "tbxUserPasswordFirst";
            this.tbxUserPasswordFirst.PasswordChar = '*';
            this.tbxUserPasswordFirst.Size = new System.Drawing.Size(100, 20);
            this.tbxUserPasswordFirst.TabIndex = 7;
            // 
            // tbxUserPasswordSecond
            // 
            this.tbxUserPasswordSecond.Location = new System.Drawing.Point(156, 281);
            this.tbxUserPasswordSecond.Name = "tbxUserPasswordSecond";
            this.tbxUserPasswordSecond.PasswordChar = '*';
            this.tbxUserPasswordSecond.Size = new System.Drawing.Size(100, 20);
            this.tbxUserPasswordSecond.TabIndex = 8;
            // 
            // rtbxUserAdress
            // 
            this.rtbxUserAdress.Location = new System.Drawing.Point(155, 160);
            this.rtbxUserAdress.Name = "rtbxUserAdress";
            this.rtbxUserAdress.Size = new System.Drawing.Size(274, 41);
            this.rtbxUserAdress.TabIndex = 5;
            this.rtbxUserAdress.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(305, 338);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(154, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(156, 52);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(100, 20);
            this.tbxSurname.TabIndex = 1;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(156, 21);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 0;
            // 
            // lblSurname
            // 
            this.lblSurname.Location = new System.Drawing.Point(40, 55);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(67, 15);
            this.lblSurname.TabIndex = 14;
            this.lblSurname.Text = "Surname :";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(40, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 23);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Name:";
            // 
            // tbxUserTC
            // 
            this.tbxUserTC.Location = new System.Drawing.Point(156, 110);
            this.tbxUserTC.Mask = "00000000000";
            this.tbxUserTC.Name = "tbxUserTC";
            this.tbxUserTC.Size = new System.Drawing.Size(100, 20);
            this.tbxUserTC.TabIndex = 3;
            // 
            // cmbUserCaption
            // 
            this.cmbUserCaption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserCaption.FormattingEnabled = true;
            this.cmbUserCaption.Items.AddRange(new object[] {
            "Student",
            "Academician"});
            this.cmbUserCaption.Location = new System.Drawing.Point(157, 208);
            this.cmbUserCaption.Name = "cmbUserCaption";
            this.cmbUserCaption.Size = new System.Drawing.Size(121, 21);
            this.cmbUserCaption.TabIndex = 6;
            // 
            // lblUserCaption
            // 
            this.lblUserCaption.Location = new System.Drawing.Point(41, 208);
            this.lblUserCaption.Name = "lblUserCaption";
            this.lblUserCaption.Size = new System.Drawing.Size(100, 21);
            this.lblUserCaption.TabIndex = 18;
            this.lblUserCaption.Text = "UserCaption :";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 373);
            this.Controls.Add(this.lblUserCaption);
            this.Controls.Add(this.cmbUserCaption);
            this.Controls.Add(this.tbxUserTC);
            this.Controls.Add(this.tbxSurname);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtbxUserAdress);
            this.Controls.Add(this.tbxUserPasswordSecond);
            this.Controls.Add(this.tbxUserPasswordFirst);
            this.Controls.Add(this.tbxUserEmail);
            this.Controls.Add(this.tbxUserName);
            this.Controls.Add(this.lblUserPasswordSecond);
            this.Controls.Add(this.lblUserPasswordFirst);
            this.Controls.Add(this.lblUserAdress);
            this.Controls.Add(this.lblUserMail);
            this.Controls.Add(this.lblUserTC);
            this.Controls.Add(this.lblUserName);
            this.MinimizeBox = false;
            this.Name = "SignUpForm";
            this.Text = "Sign up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserTC;
        private System.Windows.Forms.Label lblUserMail;
        private System.Windows.Forms.Label lblUserAdress;
        private System.Windows.Forms.Label lblUserPasswordFirst;
        private System.Windows.Forms.Label lblUserPasswordSecond;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.TextBox tbxUserEmail;
        private System.Windows.Forms.TextBox tbxUserPasswordFirst;
        private System.Windows.Forms.TextBox tbxUserPasswordSecond;
        private System.Windows.Forms.RichTextBox rtbxUserAdress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.MaskedTextBox tbxUserTC;
        private System.Windows.Forms.ComboBox cmbUserCaption;
        private System.Windows.Forms.Label lblUserCaption;
    }
}