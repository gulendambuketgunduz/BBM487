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
    public partial class CommunicationLibrarianForm : Form
    {
        public CommunicationLibrarianForm()
        {
            InitializeComponent();
        }

        private void CommunicationLibraryForm_Load(object sender, EventArgs e)
        {
            DataTable _dt = DBOperations.Select("Select Name,SurName,UserMail from tblUser " +
            " where UserStatus=1 And UserType=1");/*select the librarian information from database*/
            gridLibrarian.DataSource = _dt;
        }


        private void btnBack1_Click(object sender, EventArgs e)
        {
            MemberOperationsForm of = new MemberOperationsForm();
            of.lblMemberName.Text = this.lblMemberName.Text;
            of.Show();/*When we click on Button we make it go to  MemberOperationsForm*/
            this.Close();/*After opens MemberOperationsForm, we hide CommunicationLibrarianForm*/
        }

   
  
      

    }
}
