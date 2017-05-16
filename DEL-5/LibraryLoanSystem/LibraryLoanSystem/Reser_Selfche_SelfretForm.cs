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
    public partial class ReservetionSelfcheckoutSelfreturnForm : Form
    {
        public ReservetionSelfcheckoutSelfreturnForm()
        {
            InitializeComponent();
        }

        private void Reservation_WaitingListForm_Load(object sender, EventArgs e)
        {
            RefreshGridBooks();
        }

        /*Updating list of information at GridBooks*/
        private void RefreshGridBooks()
        {
            gridBooks.DataSource = DBOperations.Select("Select b.BookCode as Code,b.BookName as Name," +
              " b.BookAuthor as Author, CASE WHEN b.BookState=1 Then 'Avaible' ELSE 'Not Avaible' END as Avaibility," +
              " t.BookType as Type from tblBook b, tblBookType t " +
              " WHERE b.BookTypeCode=t.BookTypeCode");

        }

        /*Updating list of information at GridWaitingList*/
        private void RefreshGridWaitingList()
        {
            DataTable _dt = DBOperations.Select("Select u.Name, u.SurName, w.RequestDate Date " +
                " from tblWaitingList w, tblUser u " +
                " WHERE w.UserTc=u.UserTc " +
                " And BookCode='" + tbxWaitingBookCode.Text + "' And w.RequestState=0" +
                " ORDER BY w.RequestDate");
            gridWaitingList.DataSource = _dt;

        }
        /*Updating list of information at GridMyBooks*/
        private void RefreshGridMyBooks()
        {
            DataTable _dt = DBOperations.Select(" Select b.BookCode,b.BookName,b.BookAuthor,bb.StartDate,bb.EndDate " +
                " from tblBorrowedBooks bb, tblBook b " +
                " Where bb.BookCode=b.BookCode " +
                " And bb.UserTC='" + UserInfo.UserTC + "' " +
                " And ReturnDate is null");
            gridMyBooks.DataSource = _dt;

        }

        /*Updating list of information at GridMyReservation*/
        private void RefreshGridMyReservations()
        {
            DataTable _dt = DBOperations.Select("Select b.BookCode,b.BookName,b.BookAuthor,wl.RequestDate  " +
            " from tblWaitingList wl, tblBook b " +
            " Where wl.BookCode=b.BookCode " +
            " And wl.UserTC='" + UserInfo.UserTC + "'");
            gridMyReservations.DataSource = _dt;


        }

        /*We enter the book information and search the time we click the SearchBook button*/
        private void btnSearchBook_Click(object sender, EventArgs e)
        {
         
            RefreshGridBooks();

            if (tbxSearchByName.Text.Trim() == "" &&
                    tbxSearchByAuthor.Text.Trim() == "" &&
                    tbxSearchByCode.Text.Trim() == "")
                {
                    MessageBox.Show("Please fill at least one blank!");
                }
            else
            {
                DataTable dt = (DataTable)gridBooks.DataSource;
                DataView dv = new DataView(dt);
                /*Checking the accuracy of data*/
                String filter = "";
                if (tbxSearchByName.Text.Trim() != "")
                    filter =  " Name LIKE '%" + tbxSearchByName.Text + "%' AND " ;
                if (tbxSearchByAuthor.Text.Trim() != "")
                    filter +=  " Author LIKE '%" + tbxSearchByAuthor.Text + "%' AND " ;
                if (tbxSearchByCode.Text.Trim() != "")
                    filter +=  " Code ='" + tbxSearchByCode.Text + "' AND " ;
               
                
                if (filter != "")
                {
                    filter = filter.Remove(filter.LastIndexOf("AND"));
                    dv.RowFilter = filter;
                   
                }
                gridBooks.DataSource = dv;
                DataTable dts = dv.ToTable();
                int count = dts.Rows.Count;
                if (count == 0)/*if the data does not match*/
                {
                    MessageBox.Show("There is no such record!");
                }
           }
        }

        /*Selecting between SelfCheckIn buton and GoToWaitingList buton*/
        private void gridBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (gridBooks.SelectedRows.Count == 1)
            {
                if (gridBooks.SelectedRows[0].Cells["Avaibility"].Value.ToString() == "Avaible")/*if book is avaliable*/
                {
                    btnSelfCheckout.Enabled = true;/*Self Check out button active*/
                    btnGoToWaitingList.Enabled = false;/*Go to waiting list button deactive*/
                }
                else if (gridBooks.SelectedRows[0].Cells["Avaibility"].Value.ToString() == "Not Avaible")/*if book is not avaliable*/
                {

                    btnSelfCheckout.Enabled = false;/*Self Check out button deactive*/
                    btnGoToWaitingList.Enabled = true;/*Go to waiting list button active*/
                }
            }

        }

        /*If the book is not available and we want to make a reservation, click on the GoToWaitingList buton*/
        private void btnGoToWaitingList_Click(object sender, EventArgs e)
        {
            if (gridBooks.SelectedRows.Count == 1)
            {
                tbxWaitingBookCode.Text = gridBooks.SelectedRows[0].Cells["Code"].Value.ToString();
                tabReservationForm.SelectedTab = tabPageWaitingList;/*go to waiting list form*/
            }
            else
                MessageBox.Show("Select a row! ");

        }

        /*List of reservations*/
        private void btnShowWaitList_Click(object sender, EventArgs e)
        {
            if(tbxWaitingBookCode.Text.Trim()=="")
            {
                MessageBox.Show("Please fill the blank!");
            }
            else
              RefreshGridWaitingList();
        }

        /*If we want to make a reservation*/
        private void btnMakeReservation_Click(object sender, EventArgs e)
        {
            if (tbxWaitingBookCode.Text.Trim() != "")
            {
                if (MessageBox.Show("Are You Sure?", "Question", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    if (DBOperations.insertUpdateDelete("INSERT INTO tblWaitingList VALUES('" +
                        UserInfo.UserTC + "','" + tbxWaitingBookCode.Text + "','" +
                        DateTime.Now.Date.ToString("yyyy-MM-dd") + "',0)") > 0)/*Adding user info and date to the Waiting List*/
                    {
                        MessageBox.Show("Added to waiting list!");
                        RefreshGridWaitingList();

                    }


                }
            }
            else
                MessageBox.Show("select a book!");
        }

        /*list myt books*/
        private void btnViewMyBooks_Click(object sender, EventArgs e)
        {

            RefreshGridMyBooks();

        }
        /*list my reservation*/
        private void btnViewMyReservations_Click(object sender, EventArgs e)
        {
            RefreshGridMyReservations();
            
        }

        /*If we want to cancel the reservation we made*/
        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            if (gridMyReservations.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Are You Sure?", "Question", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    string BookCode = gridMyReservations.SelectedRows[0].Cells["BookCode"].Value.ToString();


                    if (DBOperations.insertUpdateDelete("DELETE FROM tblWaitingList WHERE BookCode ='" + BookCode + "' AND " +
                        " UserTC='" + UserInfo.UserTC + "'") > 0)/*Canceling that reservation from the list*/
                    {
                        MessageBox.Show("Reservation cancelled !");
                        RefreshGridMyReservations();
                    }
                }
            }
            else
                MessageBox.Show("Select a row!");

        }

        /*back to MemberOperationsForm*/
        private void btnBack5_Click(object sender, EventArgs e)
        {
            MemberOperationsForm of = new MemberOperationsForm();
            of.lblMemberName.Text = this.lblMemberName.Text;
            of.Show();/*When we click on Button we make it go to  MemberOperationsForm*/
            this.Close();/*After opens MemberOperationsForm, we hide Reser_Selfche_SelfretForm*/
        }

        /*If we want to deliver the borrowed book*/
        private void btnSelfReturn_Click(object sender, EventArgs e)
        {
            if (gridMyBooks.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Are You Sure?", "Question", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)/*if self return is yes*/
                {
                    string BookCode = gridMyBooks.SelectedRows[0].Cells["BookCode"].Value.ToString();
                    DateTime EndDate = Convert.ToDateTime(gridMyBooks.SelectedRows[0].Cells["EndDate"].Value.ToString());

                    DateTime ReturnDate = DateTime.Now.Date;
                    double Fine = 0.0;
                    if (ReturnDate > EndDate) Fine = 0.5 * ((ReturnDate - EndDate).TotalDays);/*Fine:0.5*/

                    string returnDate = ReturnDate.ToString("yyyy-MM-dd");

                    if (DBOperations.insertUpdateDelete("UPDATE tblBorrowedBooks SET ReturnDate='" + returnDate + "', " +
                        "Fine=" + Fine.ToString().Replace(",",".") + " WHERE BookCode='" + BookCode + "' And UserTC='" + UserInfo.UserTC + "'") > 0)/*If there is a book in the member*/
                    {

                        if (DBOperations.insertUpdateDelete(" UPDATE tblBook Set BookState=1 WHERE BookCode='" + BookCode + "'") > 0)/*BookState=1 is availiable*/
                        {
                            MessageBox.Show("Self Return successed!");
                            RefreshGridBooks();
                            RefreshGridMyBooks();
                        }

                    }
                }
            }
            else
                MessageBox.Show("Select a row!");

        }

        /*Borrowing book*/
        private void btnSelfCheckOut_Click(object sender, EventArgs e)
        {
            DataTable _dt = DBOperations.Select(" select COUNT(BookCode) BookCount from tblBorrowedBooks " +
                " Where UserTc = '" + UserInfo.UserTC + "' And ReturnDate is null");

            if (_dt != null && _dt.Rows.Count > 0 && Convert.ToInt32(_dt.Rows[0]["BookCount"].ToString()) < 5)/*Can not get more than five books*/
            {
                if (gridBooks.SelectedRows.Count == 1)
                {
                    if (MessageBox.Show("Are You Sure?", "Question", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                    {
                        string BookCode = gridBooks.SelectedRows[0].Cells["Code"].Value.ToString();

                        string StartDate = DateTime.Now.Date.ToString("yyyy-MM-dd");
                        string EndDate = DateTime.Now.Date.AddDays(30).ToString("yyyy-MM-dd");/*User's use of the book 30 days*/

                        if (DBOperations.insertUpdateDelete("INSERT INTO tblBorrowedBooks (BookCode,UserTC,StartDate,EndDate) " +
                            " VALUES('" + BookCode + "', '" + UserInfo.UserTC + "','" + StartDate + "','" + EndDate + "')") > 0)
                        {
                            if (DBOperations.insertUpdateDelete(" UPDATE tblBook Set BookState=0 WHERE BookCode='" + BookCode + "'") > 0)
                            {
                                MessageBox.Show("Self check out successed!");
                                RefreshGridBooks();
                                RefreshGridMyBooks();
                            }

                        }
                    }
                }
                else
                    MessageBox.Show("Select a row!");
            }
            else

                MessageBox.Show("Can not take more than 5 books! Please check my books !");/*Can not get more than 5 books*/

        }

     


    
  
      
    }
}