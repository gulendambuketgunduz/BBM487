namespace WindowsFormsApplication1
{
    partial class LoginForm
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxUserNamee = new System.Windows.Forms.TextBox();
            this.tbxPasswordd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignupp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.resim_01;
            this.pictureBox2.Location = new System.Drawing.Point(40, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(620, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "UserName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // tbxUserNamee
            // 
            this.tbxUserNamee.Location = new System.Drawing.Point(206, 189);
            this.tbxUserNamee.Name = "tbxUserNamee";
            this.tbxUserNamee.Size = new System.Drawing.Size(100, 20);
            this.tbxUserNamee.TabIndex = 3;
            // 
            // tbxPasswordd
            // 
            this.tbxPasswordd.Location = new System.Drawing.Point(206, 229);
            this.tbxPasswordd.Name = "tbxPasswordd";
            this.tbxPasswordd.PasswordChar = '*';
            this.tbxPasswordd.Size = new System.Drawing.Size(100, 20);
            this.tbxPasswordd.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(362, 206);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSignupp
            // 
            this.btnSignupp.Location = new System.Drawing.Point(550, 267);
            this.btnSignupp.Name = "btnSignupp";
            this.btnSignupp.Size = new System.Drawing.Size(75, 23);
            this.btnSignupp.TabIndex = 6;
            this.btnSignupp.Text = "Sign up";
            this.btnSignupp.UseVisualStyleBackColor = true;
            this.btnSignupp.Click += new System.EventHandler(this.btnSignupp_Click);
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(725, 329);
            this.Controls.Add(this.btnSignupp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxPasswordd);
            this.Controls.Add(this.tbxUserNamee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "LoginForm";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label UserPass;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSignup;
        protected System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxUserNamee;
        private System.Windows.Forms.TextBox tbxPasswordd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignupp;
    }
}

