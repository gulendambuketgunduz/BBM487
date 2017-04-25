using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryLoanSystem
{
    public partial class LibrarianOperationsForm : Form
    {
        public LibrarianOperationsForm()
        {
            InitializeComponent();
        }

        private void btnManipulateBooks_Click(object sender, EventArgs e)
        {
            ManipulateBooksForm form = new ManipulateBooksForm();
            form.Show();

            this.Hide();

        }

   

        private void btnManipulateMembers_Click(object sender, EventArgs e)
        {
            ManipulateMembersForm mf = new ManipulateMembersForm();
            mf.Show();
            this.Close();

            
        }

        private void LibrarianOperationsForm_Load(object sender, EventArgs e)
        {
            lblLibrarianName.Text = UserInfo.Name + " " + UserInfo.SurName + " WELCOME!";
        }

        private void btnLogoutLibrarian_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Close();
        }

     
    
    }
}
