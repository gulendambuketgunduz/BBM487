using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*If the person does not fill the boxes*/
            if(tbxName.Text.Trim()=="" ||
                tbxSurname.Text.Trim() == "" ||
                tbxUserEmail.Text.Trim() == "" ||                 
                tbxUserName.Text.Trim() == "" ||
                tbxUserPasswordFirst.Text.Trim() == "" ||
                tbxUserPasswordSecond.Text.Trim() == "" ||
                tbxUserTC.Text.Trim()==""   || 
                rtbxUserAdress.Text.Trim()=="" ||
                cmbUserCaption.Text.Trim()=="" 
                )
            {
                MessageBox.Show("Please Fill The Blanks!");
            }
            else if (tbxUserEmail.Text.IndexOf("@") == -1 || tbxUserEmail.Text.IndexOf(".") == -1)/*It must be dot and @ at the mail address.*/
            {
                MessageBox.Show("Please Enter A Valid E-mail Adress!");
            }
            else if (tbxUserPasswordFirst.Text != tbxUserPasswordSecond.Text)/*The person will enter two passwords to verify the password and if the two passwords do not match*/
            {
                MessageBox.Show("Passwords does not match!");
            }
            else
            {
                DataTable user_control = DBOperations.Select("Select * from " +
                    " tblUser where UserName='" + tbxUserName.Text.Trim() + "'");

                if (user_control == null || user_control.Rows.Count == 0)
                {
                    string Name = tbxName.Text;
                    string Surname = tbxSurname.Text;
                    string userName = tbxUserName.Text;
                    string userPassword = tbxUserPasswordFirst.Text;
                    string userTc = tbxUserTC.Text;
                    string userEmail = tbxUserEmail.Text;
                    string userAdress = rtbxUserAdress.Text;
                    string userCaption = cmbUserCaption.Text;

                    /*The new member will be insert to the database.*/
                    string insertCmd = "INSERT INTO tblUser VALUES('" + tbxName.Text + "','" + tbxSurname.Text + "'," +

                        "'" + userName + "','" + userPassword + "','" + userTc + "','" + userEmail + "','" + userCaption + "','" + userAdress + "',0,1)";

                    if (DBOperations.insertUpdateDelete(insertCmd) > 0)/**/
                    {
                        MessageBox.Show("User Saved!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error Occured During User Saving!");
                    }
                }
                else
                    MessageBox.Show("User Name Already Exist");
            }
        }

        
    }
}
