using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace LibraryLoanSystem
{



    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        /*If the librarian or member wants to log in to the library system*/
        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*Is it the same as the information in the database?*/
            string userControl = "Select * from tblUser where UserName='" + tbxUserName.Text + "' And UserPassword='" + tbxPassword.Text + "' And UserStatus=1";/*if UserStatus=1,member active*/

            DataTable _dt = DBOperations.Select(userControl);/*Putting all the user's information on the DataTable*/
            if (_dt != null && _dt.Rows.Count > 0)
            {

                UserInfo.Name = _dt.Rows[0]["Name"].ToString();
                UserInfo.SurName = _dt.Rows[0]["Surname"].ToString();
                UserInfo.UserAddress = _dt.Rows[0]["UserAddress"].ToString();
                UserInfo.UserCaption = _dt.Rows[0]["UserCaption"].ToString();
                UserInfo.UserMail = _dt.Rows[0]["UserMail"].ToString();
                UserInfo.UserName = _dt.Rows[0]["UserName"].ToString();
                UserInfo.UserTC = _dt.Rows[0]["UserTC"].ToString();


                if (_dt.Rows[0]["UserMoney"] != null)
                {
                    UserInfo.UserMoney = _dt.Rows[0]["UserMoney"].ToString();
                }
                else
                {
                    UserInfo.UserMoney = "0.00";
                }

                if (_dt.Rows[0]["UserType"].ToString() == "0")/*If the user is a member,it is UserType=0 in database*/
                {
                    UserInfo.Librarian = 0;
                    MemberOperationsForm form = new MemberOperationsForm();
                   
                    form.Show(); /*When we click on Button we make it go to MemberOperationsForm*/

                    this.Hide(); /*After OperationForm opens, we hide LoginForm*/
                }
                else if (_dt.Rows[0]["UserType"].ToString() == "1")/*If the user is a librarian,it is UserType=1 in database*/
                {
                    UserInfo.Librarian = 1;
                    LibrarianOperationsForm form = new LibrarianOperationsForm();
                    
                    form.Show();/*When we click on Button we make it go to LibrarianOperationsForm*/

                    this.Hide();/*After OperationForm opens, we hide LoginForm*/
                }
            }
            else
                MessageBox.Show("Incorrect username or password!");

        }

        /*If the user wants to become a member,click the Sign up button*/
        private void btnSignup_Click(object sender, EventArgs e)
        {
            
            SignUpForm signForm = new SignUpForm();
            signForm.Show();/*Go to the Sign up Form*/    

        }

        
        

      

       

        

     
    }
}
