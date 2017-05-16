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
    public partial class ManipulateBooksForm : Form
    {
        public ManipulateBooksForm()
        {
            InitializeComponent();
        }

        /*Book informations*/
        private void ManipulateBooksForm_Load(object sender, EventArgs e)
        {
            DataTable _dt = DBOperations.Select("Select BookTypeCode,BookType " +
                " FROM tblBookType ");

            cmbBookCategory.DataSource = _dt;
            cmbBookCategory.ValueMember = "BookTypeCode";
            cmbBookCategory.DisplayMember = "BookType";
            cmbBookCategory_SelectedIndexChanged(sender, e);

            RefreshBookGrid();
        }

        /*The librarian will insert books*/
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string bookCode = tbxBookCodePrefix.Text.Trim() + tbxBookCodePostFix.Text.Trim();
            string bookName = tbxBookName.Text.Trim();
            string bookAuthor = tbxBookAuthor.Text.Trim();

            if (bookCode == "" || bookName == "" || bookAuthor == "")
            {
                MessageBox.Show("Please Fill All Informations !");
                return;
            }


            string cmd = "INSERT INTO tblBook VALUES('" + bookCode + "','" + tbxBookName.Text + "'," +
                "'" + bookAuthor + "',1," + cmbBookCategory.SelectedValue.ToString() + ")";

            try
            {

                if (DBOperations.insertUpdateDelete(cmd) > 0)
                {
                    MessageBox.Show("Book Inserted");
                    RefreshBookGrid();
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.StartsWith("Violation of PRIMARY KEY"))
                    MessageBox.Show("Can not insert dublicate Book Code !");/*If trying to insert books in the same code*/
            }
        }


        private void RefreshBookGrid()
        {

            DataTable _dt = DBOperations.Select("Select b.BookCode as Code,b.BookName as Name," +
                " b.BookAuthor as Author, CASE WHEN b.BookState=1 Then 'Avaible' ELSE 'Not Avaible' END as Avaibility," +
                " t.BookType as Type from tblBook b, tblBookType t " +
                " WHERE b.BookTypeCode=t.BookTypeCode");
            gridBooks.DataSource = _dt;

        }


        private void btnBack3_Click(object sender, EventArgs e)
        {
            LibrarianOperationsForm of = new LibrarianOperationsForm();
            of.lblLibrarianName.Text = this.lblLibrarianName.Text;
            of.Show();/*When we click on Button we make it go to  LibrarianOperationsForm*/
            this.Close();/*After opens LibrarianOperationsForm, we hide ManipulateMembersForm*/
        }


        /*Books have a book type*/
        private void cmbBookCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBookCategory.Text == "Science")
                tbxBookCodePrefix.Text = "S";
            else if (cmbBookCategory.Text == "Computer")
                tbxBookCodePrefix.Text = "C";
            else if (cmbBookCategory.Text == "Novel")
                tbxBookCodePrefix.Text = "N";
            else if (cmbBookCategory.Text == "Poem")
                tbxBookCodePrefix.Text = "P";
        }

        /*If the librarian updates a book's knowledge*/
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gridBooks.SelectedRows.Count == 1)
            {
                string bookCode = tbxBookCodePrefix.Text + tbxBookCodePostFix.Text;
                string bookName = tbxBookName.Text;
                string bookAuthor = tbxBookAuthor.Text;
                string cmd = "UPDATE tblBook SET BookCode ='" + bookCode + "'," +
                    " BookName='" + tbxBookName.Text + "'," +
                    " BookAuthor='" + bookAuthor + "'," +
                    " BookTypeCode=" + cmbBookCategory.SelectedValue.ToString() + " " +
                    " WHERE BookCode='" + gridBooks.SelectedRows[0].Cells[0].Value.ToString() + "'";

                if (DBOperations.insertUpdateDelete(cmd) > 0)
                {
                    MessageBox.Show("Book Updated!");
                    RefreshBookGrid();
                }
            }
            else
                MessageBox.Show("Please Select A Row!!");
        }

        /*If the librarian is going to select a book and delete it*/
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridBooks.SelectedRows.Count == 1)
            {
                string cmd = "DELETE FROM tblBook " +
                    " WHERE BookCode='" + gridBooks.SelectedRows[0].Cells[0].Value.ToString() + "'";

                if (DBOperations.insertUpdateDelete(cmd) > 0)
                {
                    MessageBox.Show("Book Deleted!");
                    RefreshBookGrid();
                }
            }
            else
                MessageBox.Show("Please Select A Row!!");/*Librarin must select a row*/
        }


   

     




      


     
    }
}
