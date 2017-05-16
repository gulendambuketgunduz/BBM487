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
    public partial class ManipulateMembersForm : Form
    {
        public ManipulateMembersForm()
        {
            InitializeComponent();
        }



        private void btnListMembers_Click(object sender, EventArgs e)
        {
            RefreshGridMembers();
        }


        private void RefreshGridMembers()
        {
            DataTable _dt = DBOperations.Select("Select Name, Surname,UserName," +
                " UserTC, UserMail,UserAddress,CASE WHEN UserStatus=1 THEN 'Active' ELSE 'Deactive' END UserStatus, COALESCE(UserMoney,0) UserMoney " +
                " from tblUser Where UserType=0 ");
            gridMembers.DataSource = _dt;

        }


        /*Librarian can make member inactive*/
        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            if (gridMembers.SelectedRows.Count == 1)
            {

                string userTC = gridMembers.SelectedRows[0].Cells["UserTC"].Value.ToString();

                if (DBOperations.insertUpdateDelete("UPDATE tblUser SET UserStatus=0 " +
                    " Where UserTC='" + userTC + "'") > 0)
                {
                    MessageBox.Show("User Inactive !");
                    RefreshGridMembers();
                }
                else
                    MessageBox.Show("Error Occured During User Deleting !");
            }
            else
            {
                MessageBox.Show("Select A Member!");
            }
        }



        /*Librarian can make member active again*/
        private void btnActiveMember_Click(object sender, EventArgs e)
        {
            if (gridMembers.SelectedRows.Count == 1)
            {
                string userTC = gridMembers.SelectedRows[0].Cells["UserTC"].Value.ToString();

                if (DBOperations.insertUpdateDelete("UPDATE tblUser SET UserStatus=1 " +
                    " Where UserTC='" + userTC + "'") > 0)
                {
                    MessageBox.Show("User Activated !");
                    RefreshGridMembers();
                }
                else
                    MessageBox.Show("Error Occured During User Activating !");
            }
            else
            {
                MessageBox.Show("Select A Member!");
            }
        }



        /*The librarian can view the self check out books*/
        private void btnListBooksBorrowed_Click(object sender, EventArgs e)
        {
            DataTable _dt = DBOperations.Select(" Select b.BookCode , b.BookName,u.Name, u.SurName, " +
                " u.userName,bb.StartDate,bb.EndDate,bb.ReturnDate from " +
                " tblBorrowedBooks bb, tblUser u , tblBook b " +
                " Where bb.BookCode = b.BookCode " +
                " And bb.UserTC=u.UserTC " +
                " And bb.ReturnDate is null ");

            gridBooks.DataSource = _dt;
        }


        /*The librarian can view the fines*/
       private void btnListFine_Click(object sender, EventArgs e)
        {
            DataTable _dt = DBOperations.Select("select BookCode, BookName,BookAuthor,Name,Surname,StartDate,EndDate,ReturnDate,PunismentDay,Fine "+
                " from  "+
                " (select b.BookCode,b.BookName,b.BookAuthor,  u.Name,u.Surname,bb.StartDate,bb.EndDate,  "+
                " COALESCE(bb.ReturnDate,'-') AS ReturnDate  "+
                " ,DATEDIFF(day,bb.EndDate,CONVERT(DATE,GETDATE())) as PunismentDay, "+
                " DATEDIFF(day,bb.EndDate,CONVERT(DATE,GETDATE()))*0.5 Fine "+
                " from tblBorrowedBooks bb, tblBook b, tblUser u "+
                " where bb.BookCode = b.BookCode "+
                " And bb.UserTc=u.UserTc "+
                " And bb.ReturnDate is null "+
                " And DATEDIFF(day,bb.EndDate,CONVERT(DATE,GETDATE()))>30 "+
                " UNION  "+
                " select b.BookCode,b.BookName,b.BookAuthor,  u.Name,u.Surname,bb.StartDate,bb.EndDate, "+
                " bb.ReturnDate AS ReturnDate  "+
                " ,CASE WHEN DATEDIFF(day,bb.EndDate,bb.ReturnDate)<=30 THEN  0 ELSE "+
				" DATEDIFF(day,bb.EndDate,bb.ReturnDate) END  as PunismentDay,Fine "+
                " from tblBorrowedBooks bb, tblBook b, tblUser u "+
                " where bb.BookCode = b.BookCode "+
                " And bb.UserTc=u.UserTc "+
                " And bb.ReturnDate is not null  ) A "+
                " where PunismentDay<>0 ");

            gridFine.DataSource = _dt;

        }


        

       private void gridMembers_SelectionChanged(object sender, EventArgs e)
        {
            if (gridMembers.SelectedRows.Count == 1)
            {
                if (gridMembers.SelectedRows[0].Cells["UserStatus"].Value.ToString() == "Active")/*Member can be active if inactive*/

                {
                    btnActiveMember.Enabled=false;
                    btnInactiveMember.Enabled=true;
                }
                else if (gridMembers.SelectedRows[0].Cells["UserStatus"].Value.ToString() == "Deactive") /*Member can be inactive if active*/
                {
                    btnActiveMember.Enabled=true;
                    btnInactiveMember.Enabled=false;
                }

            }
        }


        
        /*fund money*/
        private void btnFund_Click(object sender, EventArgs e)
        {

            if (Convert.ToDecimal(tbxMoney.Text) <= 0)
            {
                MessageBox.Show("Incorrect Money !");
                return;
            }
            if (gridMembers.SelectedRows.Count != 1)
            {
                MessageBox.Show("Select A Member!");
                return;
            }
            if (gridMembers.SelectedRows[0].Cells["UserStatus"].Value.ToString() != "Active")
            {
                MessageBox.Show("Money Can Not Be Fund To Deactive Member!");
                return;
            }
            else
            {
                if (MessageBox.Show("Are You Sure?", "Question", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    string userTC = gridMembers.SelectedRows[0].Cells["UserTC"].Value.ToString();

                    if (DBOperations.insertUpdateDelete("UPDATE tblUser SET UserMoney=Coalesce(UserMoney,0)+" + tbxMoney.Text.Replace(",", ".") + " " +
                                " Where UserTC='" + userTC + "'") > 0)
                    {
                        MessageBox.Show("Money Funded !");
                        tbxMoney.Text = "0,0";
                        RefreshGridMembers();
                    }
                    else
                        MessageBox.Show("Error Occured During Money Funding !");
                }
            }
            
        }

        /*There may be specific character input*/
        private void tbxMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != ',' && e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != '2' && e.KeyChar != '3' && e.KeyChar != '4'
                && e.KeyChar != '5' && e.KeyChar != '6' && e.KeyChar != '7' && e.KeyChar != '8' && e.KeyChar != '9' && e.KeyChar!=(char)8)
            {

                e.Handled = true;
            }
        }

        private void btnBack4_Click(object sender, EventArgs e)
        {
            LibrarianOperationsForm of = new LibrarianOperationsForm();
            of.lblLibrarianName.Text = this.lblLibrarianName.Text;
            of.Show();/*When we click on Button we make it go to  LibrarianOperationsForm*/
            this.Close();/*After opens LibrarianOperationsForm, we hide ManipulateMembersForm*/
        }

        

       
     
        

         
        
    }
}
