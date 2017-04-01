namespace WindowsFormsApplication1
{
    partial class Reservation_WaitingListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabForm = new System.Windows.Forms.TabControl();
            this.tabPageCheckIN = new System.Windows.Forms.TabPage();
            this.btnSelfCheckIn = new System.Windows.Forms.Button();
            this.btnGoToWaitingList = new System.Windows.Forms.Button();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.lblSearchByBookCode = new System.Windows.Forms.Label();
            this.lblSearchByAuthor = new System.Windows.Forms.Label();
            this.lblSeachByName = new System.Windows.Forms.Label();
            this.tbxSearchByCode = new System.Windows.Forms.TextBox();
            this.tbxSearchByAuthor = new System.Windows.Forms.TextBox();
            this.tbxSearchByName = new System.Windows.Forms.TextBox();
            this.gridBooks = new System.Windows.Forms.DataGridView();
            this.tabPageWaitingList = new System.Windows.Forms.TabPage();
            this.btnShowWaitList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxWaitingBookCode = new System.Windows.Forms.TextBox();
            this.btnMakeReservation = new System.Windows.Forms.Button();
            this.gridWaitingList = new System.Windows.Forms.DataGridView();
            this.tabPageMyBooks = new System.Windows.Forms.TabPage();
            this.btnSelfReturn = new System.Windows.Forms.Button();
            this.gridMyBooks = new System.Windows.Forms.DataGridView();
            this.btnViewMyBooks = new System.Windows.Forms.Button();
            this.tabPageMyReservation = new System.Windows.Forms.TabPage();
            this.btnCancelReservation = new System.Windows.Forms.Button();
            this.gridMyReservations = new System.Windows.Forms.DataGridView();
            this.btnViewMyReservations = new System.Windows.Forms.Button();
            this.btnBack5 = new System.Windows.Forms.Button();
            this.tabForm.SuspendLayout();
            this.tabPageCheckIN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).BeginInit();
            this.tabPageWaitingList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridWaitingList)).BeginInit();
            this.tabPageMyBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMyBooks)).BeginInit();
            this.tabPageMyReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMyReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // tabForm
            // 
            this.tabForm.Controls.Add(this.tabPageCheckIN);
            this.tabForm.Controls.Add(this.tabPageWaitingList);
            this.tabForm.Controls.Add(this.tabPageMyBooks);
            this.tabForm.Controls.Add(this.tabPageMyReservation);
            this.tabForm.Location = new System.Drawing.Point(12, 12);
            this.tabForm.Name = "tabForm";
            this.tabForm.SelectedIndex = 0;
            this.tabForm.Size = new System.Drawing.Size(666, 339);
            this.tabForm.TabIndex = 0;
            // 
            // tabPageCheckIN
            // 
            this.tabPageCheckIN.Controls.Add(this.btnSelfCheckIn);
            this.tabPageCheckIN.Controls.Add(this.btnGoToWaitingList);
            this.tabPageCheckIN.Controls.Add(this.btnSearchBook);
            this.tabPageCheckIN.Controls.Add(this.lblSearchByBookCode);
            this.tabPageCheckIN.Controls.Add(this.lblSearchByAuthor);
            this.tabPageCheckIN.Controls.Add(this.lblSeachByName);
            this.tabPageCheckIN.Controls.Add(this.tbxSearchByCode);
            this.tabPageCheckIN.Controls.Add(this.tbxSearchByAuthor);
            this.tabPageCheckIN.Controls.Add(this.tbxSearchByName);
            this.tabPageCheckIN.Controls.Add(this.gridBooks);
            this.tabPageCheckIN.Location = new System.Drawing.Point(4, 22);
            this.tabPageCheckIN.Name = "tabPageCheckIN";
            this.tabPageCheckIN.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCheckIN.Size = new System.Drawing.Size(658, 313);
            this.tabPageCheckIN.TabIndex = 0;
            this.tabPageCheckIN.Text = "Self Check out";
            this.tabPageCheckIN.UseVisualStyleBackColor = true;
            // 
            // btnSelfCheckIn
            // 
            this.btnSelfCheckIn.Location = new System.Drawing.Point(18, 265);
            this.btnSelfCheckIn.Name = "btnSelfCheckIn";
            this.btnSelfCheckIn.Size = new System.Drawing.Size(118, 23);
            this.btnSelfCheckIn.TabIndex = 4;
            this.btnSelfCheckIn.Text = "Self Check out";
            this.btnSelfCheckIn.UseVisualStyleBackColor = true;
            this.btnSelfCheckIn.Click += new System.EventHandler(this.btnSelfCheckOut_Click);
            // 
            // btnGoToWaitingList
            // 
            this.btnGoToWaitingList.Location = new System.Drawing.Point(158, 265);
            this.btnGoToWaitingList.Name = "btnGoToWaitingList";
            this.btnGoToWaitingList.Size = new System.Drawing.Size(124, 23);
            this.btnGoToWaitingList.TabIndex = 5;
            this.btnGoToWaitingList.Text = "Go To Waiting List";
            this.btnGoToWaitingList.UseVisualStyleBackColor = true;
            this.btnGoToWaitingList.Click += new System.EventHandler(this.btnGoToWaitingList_Click);
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(583, 23);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(75, 23);
            this.btnSearchBook.TabIndex = 3;
            this.btnSearchBook.Text = "Search";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // lblSearchByBookCode
            // 
            this.lblSearchByBookCode.Location = new System.Drawing.Point(394, 26);
            this.lblSearchByBookCode.Name = "lblSearchByBookCode";
            this.lblSearchByBookCode.Size = new System.Drawing.Size(76, 18);
            this.lblSearchByBookCode.TabIndex = 16;
            this.lblSearchByBookCode.Text = "Book Code:";
            // 
            // lblSearchByAuthor
            // 
            this.lblSearchByAuthor.Location = new System.Drawing.Point(197, 24);
            this.lblSearchByAuthor.Name = "lblSearchByAuthor";
            this.lblSearchByAuthor.Size = new System.Drawing.Size(76, 18);
            this.lblSearchByAuthor.TabIndex = 15;
            this.lblSearchByAuthor.Text = "Author Name:";
            // 
            // lblSeachByName
            // 
            this.lblSeachByName.Location = new System.Drawing.Point(1, 26);
            this.lblSeachByName.Name = "lblSeachByName";
            this.lblSeachByName.Size = new System.Drawing.Size(76, 18);
            this.lblSeachByName.TabIndex = 14;
            this.lblSeachByName.Text = "Book Name:";
            // 
            // tbxSearchByCode
            // 
            this.tbxSearchByCode.Location = new System.Drawing.Point(476, 25);
            this.tbxSearchByCode.Name = "tbxSearchByCode";
            this.tbxSearchByCode.Size = new System.Drawing.Size(100, 20);
            this.tbxSearchByCode.TabIndex = 2;
            // 
            // tbxSearchByAuthor
            // 
            this.tbxSearchByAuthor.Location = new System.Drawing.Point(281, 23);
            this.tbxSearchByAuthor.Name = "tbxSearchByAuthor";
            this.tbxSearchByAuthor.Size = new System.Drawing.Size(100, 20);
            this.tbxSearchByAuthor.TabIndex = 1;
            // 
            // tbxSearchByName
            // 
            this.tbxSearchByName.Location = new System.Drawing.Point(83, 24);
            this.tbxSearchByName.Name = "tbxSearchByName";
            this.tbxSearchByName.Size = new System.Drawing.Size(100, 20);
            this.tbxSearchByName.TabIndex = 0;
            // 
            // gridBooks
            // 
            this.gridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBooks.Location = new System.Drawing.Point(18, 58);
            this.gridBooks.MultiSelect = false;
            this.gridBooks.Name = "gridBooks";
            this.gridBooks.ReadOnly = true;
            this.gridBooks.Size = new System.Drawing.Size(625, 189);
            this.gridBooks.TabIndex = 10;
            this.gridBooks.SelectionChanged += new System.EventHandler(this.gridBooks_SelectionChanged);
            // 
            // tabPageWaitingList
            // 
            this.tabPageWaitingList.Controls.Add(this.btnShowWaitList);
            this.tabPageWaitingList.Controls.Add(this.label1);
            this.tabPageWaitingList.Controls.Add(this.tbxWaitingBookCode);
            this.tabPageWaitingList.Controls.Add(this.btnMakeReservation);
            this.tabPageWaitingList.Controls.Add(this.gridWaitingList);
            this.tabPageWaitingList.Location = new System.Drawing.Point(4, 22);
            this.tabPageWaitingList.Name = "tabPageWaitingList";
            this.tabPageWaitingList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWaitingList.Size = new System.Drawing.Size(658, 313);
            this.tabPageWaitingList.TabIndex = 1;
            this.tabPageWaitingList.Text = "Waiting List";
            this.tabPageWaitingList.UseVisualStyleBackColor = true;
            // 
            // btnShowWaitList
            // 
            this.btnShowWaitList.Location = new System.Drawing.Point(233, 16);
            this.btnShowWaitList.Name = "btnShowWaitList";
            this.btnShowWaitList.Size = new System.Drawing.Size(129, 23);
            this.btnShowWaitList.TabIndex = 18;
            this.btnShowWaitList.Text = "Show Waiting List";
            this.btnShowWaitList.UseVisualStyleBackColor = true;
            this.btnShowWaitList.Click += new System.EventHandler(this.btnShowWaitList_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Book Code:";
            // 
            // tbxWaitingBookCode
            // 
            this.tbxWaitingBookCode.Location = new System.Drawing.Point(96, 16);
            this.tbxWaitingBookCode.Name = "tbxWaitingBookCode";
            this.tbxWaitingBookCode.Size = new System.Drawing.Size(100, 20);
            this.tbxWaitingBookCode.TabIndex = 13;
            // 
            // btnMakeReservation
            // 
            this.btnMakeReservation.Location = new System.Drawing.Point(17, 268);
            this.btnMakeReservation.Name = "btnMakeReservation";
            this.btnMakeReservation.Size = new System.Drawing.Size(153, 23);
            this.btnMakeReservation.TabIndex = 12;
            this.btnMakeReservation.Text = "Make Reservation";
            this.btnMakeReservation.UseVisualStyleBackColor = true;
            this.btnMakeReservation.Click += new System.EventHandler(this.btnMakeReservation_Click);
            // 
            // gridWaitingList
            // 
            this.gridWaitingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridWaitingList.Location = new System.Drawing.Point(17, 45);
            this.gridWaitingList.MultiSelect = false;
            this.gridWaitingList.Name = "gridWaitingList";
            this.gridWaitingList.ReadOnly = true;
            this.gridWaitingList.Size = new System.Drawing.Size(625, 217);
            this.gridWaitingList.TabIndex = 11;
            // 
            // tabPageMyBooks
            // 
            this.tabPageMyBooks.Controls.Add(this.btnSelfReturn);
            this.tabPageMyBooks.Controls.Add(this.gridMyBooks);
            this.tabPageMyBooks.Controls.Add(this.btnViewMyBooks);
            this.tabPageMyBooks.Location = new System.Drawing.Point(4, 22);
            this.tabPageMyBooks.Name = "tabPageMyBooks";
            this.tabPageMyBooks.Size = new System.Drawing.Size(658, 313);
            this.tabPageMyBooks.TabIndex = 3;
            this.tabPageMyBooks.Text = "My Books";
            this.tabPageMyBooks.UseVisualStyleBackColor = true;
            // 
            // btnSelfReturn
            // 
            this.btnSelfReturn.Location = new System.Drawing.Point(515, 276);
            this.btnSelfReturn.Name = "btnSelfReturn";
            this.btnSelfReturn.Size = new System.Drawing.Size(112, 23);
            this.btnSelfReturn.TabIndex = 2;
            this.btnSelfReturn.Text = "Self Return";
            this.btnSelfReturn.UseVisualStyleBackColor = true;
            this.btnSelfReturn.Click += new System.EventHandler(this.btnSelfReturn_Click);
            // 
            // gridMyBooks
            // 
            this.gridMyBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMyBooks.Location = new System.Drawing.Point(22, 46);
            this.gridMyBooks.Name = "gridMyBooks";
            this.gridMyBooks.Size = new System.Drawing.Size(605, 215);
            this.gridMyBooks.TabIndex = 1;
            // 
            // btnViewMyBooks
            // 
            this.btnViewMyBooks.Location = new System.Drawing.Point(22, 17);
            this.btnViewMyBooks.Name = "btnViewMyBooks";
            this.btnViewMyBooks.Size = new System.Drawing.Size(128, 23);
            this.btnViewMyBooks.TabIndex = 0;
            this.btnViewMyBooks.Text = "View My Books";
            this.btnViewMyBooks.UseVisualStyleBackColor = true;
            this.btnViewMyBooks.Click += new System.EventHandler(this.btnViewMyBooks_Click);
            // 
            // tabPageMyReservation
            // 
            this.tabPageMyReservation.Controls.Add(this.btnCancelReservation);
            this.tabPageMyReservation.Controls.Add(this.gridMyReservations);
            this.tabPageMyReservation.Controls.Add(this.btnViewMyReservations);
            this.tabPageMyReservation.Location = new System.Drawing.Point(4, 22);
            this.tabPageMyReservation.Name = "tabPageMyReservation";
            this.tabPageMyReservation.Size = new System.Drawing.Size(658, 313);
            this.tabPageMyReservation.TabIndex = 2;
            this.tabPageMyReservation.Text = "My Reservations";
            this.tabPageMyReservation.UseVisualStyleBackColor = true;
            // 
            // btnCancelReservation
            // 
            this.btnCancelReservation.Location = new System.Drawing.Point(515, 274);
            this.btnCancelReservation.Name = "btnCancelReservation";
            this.btnCancelReservation.Size = new System.Drawing.Size(115, 23);
            this.btnCancelReservation.TabIndex = 2;
            this.btnCancelReservation.Text = "Cancel Reservation";
            this.btnCancelReservation.UseVisualStyleBackColor = true;
            this.btnCancelReservation.Click += new System.EventHandler(this.btnCancelReservation_Click);
            // 
            // gridMyReservations
            // 
            this.gridMyReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMyReservations.Location = new System.Drawing.Point(22, 46);
            this.gridMyReservations.Name = "gridMyReservations";
            this.gridMyReservations.Size = new System.Drawing.Size(608, 221);
            this.gridMyReservations.TabIndex = 1;
            // 
            // btnViewMyReservations
            // 
            this.btnViewMyReservations.Location = new System.Drawing.Point(22, 17);
            this.btnViewMyReservations.Name = "btnViewMyReservations";
            this.btnViewMyReservations.Size = new System.Drawing.Size(128, 23);
            this.btnViewMyReservations.TabIndex = 0;
            this.btnViewMyReservations.Text = "View My Reservations";
            this.btnViewMyReservations.UseVisualStyleBackColor = true;
            this.btnViewMyReservations.Click += new System.EventHandler(this.btnViewMyReservations_Click);
            // 
            // btnBack5
            // 
            this.btnBack5.Location = new System.Drawing.Point(531, 353);
            this.btnBack5.Name = "btnBack5";
            this.btnBack5.Size = new System.Drawing.Size(143, 23);
            this.btnBack5.TabIndex = 0;
            this.btnBack5.Text = "Back";
            this.btnBack5.UseVisualStyleBackColor = true;
            this.btnBack5.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Reservation_WaitingListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 384);
            this.Controls.Add(this.tabForm);
            this.Controls.Add(this.btnBack5);
            this.MaximizeBox = false;
            this.Name = "Reservation_WaitingListForm";
            this.Text = "Self Check out/Self Return/Reservation/Waiting List/My Reservations/My Books";
            this.Load += new System.EventHandler(this.Reservation_WaitingListForm_Load);
            this.tabForm.ResumeLayout(false);
            this.tabPageCheckIN.ResumeLayout(false);
            this.tabPageCheckIN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).EndInit();
            this.tabPageWaitingList.ResumeLayout(false);
            this.tabPageWaitingList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridWaitingList)).EndInit();
            this.tabPageMyBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMyBooks)).EndInit();
            this.tabPageMyReservation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMyReservations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabForm;
        private System.Windows.Forms.TabPage tabPageCheckIN;
        private System.Windows.Forms.TabPage tabPageWaitingList;
        private System.Windows.Forms.Button btnBack5;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Label lblSearchByBookCode;
        private System.Windows.Forms.Label lblSearchByAuthor;
        private System.Windows.Forms.Label lblSeachByName;
        private System.Windows.Forms.TextBox tbxSearchByCode;
        private System.Windows.Forms.TextBox tbxSearchByAuthor;
        private System.Windows.Forms.TextBox tbxSearchByName;
        private System.Windows.Forms.DataGridView gridBooks;
        private System.Windows.Forms.Button btnGoToWaitingList;
        private System.Windows.Forms.DataGridView gridWaitingList;
        private System.Windows.Forms.Button btnMakeReservation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxWaitingBookCode;
        private System.Windows.Forms.Button btnShowWaitList;
        private System.Windows.Forms.Button btnSelfCheckIn;
        private System.Windows.Forms.TabPage tabPageMyBooks;
        private System.Windows.Forms.TabPage tabPageMyReservation;
        private System.Windows.Forms.DataGridView gridMyBooks;
        private System.Windows.Forms.Button btnViewMyBooks;
        private System.Windows.Forms.DataGridView gridMyReservations;
        private System.Windows.Forms.Button btnViewMyReservations;
        private System.Windows.Forms.Button btnSelfReturn;
        private System.Windows.Forms.Button btnCancelReservation;
    }
}