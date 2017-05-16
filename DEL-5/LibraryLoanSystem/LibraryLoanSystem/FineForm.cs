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
    public partial class FineForm : Form
    {
        public FineForm()
        {
            InitializeComponent();
        }
        /*If the member has not paid yet*/
        private void btnListViewActiveFine_Click(object sender, EventArgs e)
        {
            ListActiveFine();
        }
        /**/
        private void btnPayFine_Click(object sender, EventArgs e)
        {

            if (gridMyFine.SelectedRows.Count != 1)/*the member must select a row*/
            {
                MessageBox.Show("Select A Row !");
                return;
            }
            else if (Convert.ToDouble(UserInfo.UserMoney.Replace(",", ".")) < Convert.ToDouble(gridMyFine.SelectedRows[0].Cells["Fine"].Value.ToString()))/*If the balance is not enough to pay the debt*/
            {
                MessageBox.Show("You Do Not Have Enough Money !");
                return;
            }

            else if (gridMyFine.SelectedRows[0].Cells["FineStatus"].Value.ToString() != "UnFunded")/*member must select a row*/
            {
                MessageBox.Show("Select A UnFunded Fine !");
                return;
            }
            else
            {
                if (DBOperations.insertUpdateDelete("UPDATE tblBorrowedBooks  Set FineStatus=1 where UserTC='" + UserInfo.UserTC + "' " +
                    " And BookCode='" + gridMyFine.SelectedRows[0].Cells["BookCode"].Value.ToString() + "' ") >= 1)
                {

                    if (DBOperations.insertUpdateDelete("UPDATE tblUser Set UserMoney=UserMoney-"+gridMyFine.SelectedRows[0].Cells["Fine"].Value.ToString().Replace(",",".")+
                        " Where UserTC='" + UserInfo.UserTC + "' ") >= 1)/*If the chosen book is paid*/
                    {
                        UpdateUserMoney();
                        MessageBox.Show("Pay Fined Successfully !");
                        ListPayFine();
                    }

                }


            }
        }

        /*If the member has not paid yet*/
        public void ListActiveFine()
        {

            DataTable _dt = DBOperations.Select(" select b.BookCode,b.BookName,b.BookAuthor,  u.Name,u.Surname,bb.StartDate,bb.EndDate,  " +
                        " bb.ReturnDate AS ReturnDate  " +
                        " ,DATEDIFF(day,bb.EndDate,CONVERT(DATE,GETDATE())) as PunismentDay, " +
                        " DATEDIFF(day,bb.EndDate,CONVERT(DATE,GETDATE()))*0.5 Fine, 'UnFunded' FineStatus " +
                        " from tblBorrowedBooks bb, tblBook b, tblUser u " +
                        " where bb.BookCode = b.BookCode " +
                        " And bb.UserTc=u.UserTc " +
                        " And bb.ReturnDate is null " +
                        " And DATEDIFF(day,bb.EndDate,CONVERT(DATE,GETDATE()))>=1 " +
                        " And u.UserTc='" + UserInfo.UserTC + "' ");
            
            gridMyFine.DataSource = _dt;
            lblMoney.Text = UserInfo.UserMoney + " TL";

        }

        /*If the member self return the book and makes a payment*/
        public void ListPayFine()
        {

            DataTable _dt = DBOperations.Select(" select	b.BookCode,b.BookName,b.BookAuthor,  u.Name,u.Surname,bb.StartDate,bb.EndDate,   " +
                 "  bb.ReturnDate AS ReturnDate   , " +
                 "	DATEDIFF(day,bb.EndDate,bb.ReturnDate) as PunismentDay,   " +
                 "	bb.Fine ,CASE WHEN bb.FineStatus is null THEN 'UnFunded' ELSE 'Funded' END FineStatus " +
                 "	from tblBorrowedBooks bb, tblBook b, tblUser u  " +
                 "	where bb.BookCode = b.BookCode  And " +
                 "		  bb.UserTc=u.UserTc  And " +
                 "	      bb.ReturnDate is not null  " +
                 "		  And u.UserTc=" + UserInfo.UserTC);

            gridMyFine.DataSource = _dt;
            lblMoney.Text = UserInfo.UserMoney + " TL";
        }

        /*Balance updated as debt is paid*/
        public void UpdateUserMoney()
        {

            string userControl = "Select * from tblUser where UserTC='" +UserInfo.UserTC+ "' ";/*if UserStatus=1,member active*/

            DataTable _dt = DBOperations.Select(userControl);/*Putting all the user's information on the DataTable*/

            if (_dt.Rows[0]["UserMoney"] != null)
            {
                UserInfo.UserMoney = _dt.Rows[0]["UserMoney"].ToString();
            }
            else
            {
                UserInfo.UserMoney = "0.00";
            }

        }
        /*If the member self return the book and makes a payment*/
        private void btnListPayFine_Click(object sender, EventArgs e)
        {
            ListPayFine();            
        }
        /*Show remaining money*/
        private void FineForm_Load(object sender, EventArgs e)
        {
            lblMoney.Text = UserInfo.UserMoney + " TL" ;
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            MemberOperationsForm of = new MemberOperationsForm();
            of.lblMemberName.Text = this.lblMemberName.Text;
            of.Show();/*When we click on Button we make it go to  MemberOperationsForm*/
            this.Close();/*After opens MemberOperationsForm, we hide FineForm*/
        }
    
    }
}
