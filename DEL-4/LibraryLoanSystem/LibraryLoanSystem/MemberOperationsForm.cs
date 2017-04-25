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
    public partial class MemberOperationsForm : Form
    {
        public MemberOperationsForm()
        {
            InitializeComponent();
        }



        /*Go to ReservetionSelfcheckoutSelfreturnForm*/
        private void ReservedText_Click(object sender, EventArgs e)
        {
            ReservetionSelfcheckoutSelfreturnForm rl_form = new ReservetionSelfcheckoutSelfreturnForm();
            rl_form.Show();
            this.Close();
        }

        private void btnFine_Click(object sender, EventArgs e)
        {
            FineForm fine_form = new FineForm();
            fine_form.Show();
            this.Close();
        }

        private void btnCommWLibry_Click(object sender, EventArgs e)
        {
            CommunicationLibraryForm cl_form = new CommunicationLibraryForm();
            cl_form.Show();
            this.Close();

        }
        /*The name of the person who appears is on the screen*/
        private void MemberOperationsForm_Load(object sender, EventArgs e)
        {
            lblMemberName.Text = UserInfo.Name + " " + UserInfo.SurName + " WELCOME!";
        }
        /*loogout from the system*/
        private void btnLogoutMember_Click(object sender, EventArgs e)
        {

            LoginForm lf = new LoginForm();
                lf.Show();
                this.Close();
                

        }

    
         

       
    }
}
