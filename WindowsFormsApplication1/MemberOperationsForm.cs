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
    public partial class MemberOperationsForm : Form
    {
        public MemberOperationsForm()
        {
            InitializeComponent();
        }

        

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Close();

        }

        private void ReservedText_Click(object sender, EventArgs e)
        {
            Reservation_WaitingListForm rl_form = new Reservation_WaitingListForm();
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

         

       
    }
}
