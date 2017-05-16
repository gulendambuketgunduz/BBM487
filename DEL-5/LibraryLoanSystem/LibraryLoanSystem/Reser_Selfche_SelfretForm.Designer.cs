namespace LibraryLoanSystem
{
    partial class ReservetionSelfcheckoutSelfreturnForm
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
            this.tabReservationForm = new System.Windows.Forms.TabControl();
            this.tabPageCheck = new System.Windows.Forms.TabPage();
            this.btnSelfCheckout = new System.Windows.Forms.Button();
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
            this.lblBooksCodes = new System.Windows.Forms.Label();
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
            this.lblMemberName = new System.Windows.Forms.Label();
            this.btnBack5 = new System.Windows.Forms.Button();
            this.tabReservationForm.SuspendLayout();
            this.tabPageCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).BeginInit();
            this.tabPageWaitingList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridWaitingList)).BeginInit();
            this.tabPageMyBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMyBooks)).BeginInit();
            this.tabPageMyReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMyReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // tabReservationForm
            // 
            this.tabReservationForm.Controls.Add(this.tabPageCheck);
            this.tabReservationForm.Controls.Add(this.tabPageWaitingList);
            this.tabReservationForm.Controls.Add(this.tabPageMyBooks);
            this.tabReservationForm.Controls.Add(this.tabPageMyReservation);
            this.tabReservationForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabReservationForm.Location = new System.Drawing.Point(12, 12);
            this.tabReservationForm.Name = "tabReservationForm";
            this.tabReservationForm.SelectedIndex = 0;
            this.tabReservationForm.Size = new System.Drawing.Size(868, 420);
            this.tabReservationForm.TabIndex = 0;
            // 
            // tabPageCheck
            // 
            this.tabPageCheck.Controls.Add(this.btnSelfCheckout);
            this.tabPageCheck.Controls.Add(this.btnGoToWaitingList);
            this.tabPageCheck.Controls.Add(this.btnSearchBook);
            this.tabPageCheck.Controls.Add(this.lblSearchByBookCode);
            this.tabPageCheck.Controls.Add(this.lblSearchByAuthor);
            this.tabPageCheck.Controls.Add(this.lblSeachByName);
            this.tabPageCheck.Controls.Add(this.tbxSearchByCode);
            this.tabPageCheck.Controls.Add(this.tbxSearchByAuthor);
            this.tabPageCheck.Controls.Add(this.tbxSearchByName);
            this.tabPageCheck.Controls.Add(this.gridBooks);
            this.tabPageCheck.Location = new System.Drawing.Point(4, 24);
            this.tabPageCheck.Name = "tabPageCheck";
            this.tabPageCheck.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCheck.Size = new System.Drawing.Size(860, 392);
            this.tabPageCheck.TabIndex = 0;
            this.tabPageCheck.Text = "Self Check out";
            this.tabPageCheck.UseVisualStyleBackColor = true;
            // 
            // btnSelfCheckout
            // 
            this.btnSelfCheckout.BackColor = System.Drawing.Color.White;
            this.btnSelfCheckout.Location = new System.Drawing.Point(6, 356);
            this.btnSelfCheckout.Name = "btnSelfCheckout";
            this.btnSelfCheckout.Size = new System.Drawing.Size(132, 30);
            this.btnSelfCheckout.TabIndex = 4;
            this.btnSelfCheckout.Text = "Self Check out";
            this.btnSelfCheckout.UseVisualStyleBackColor = false;
            this.btnSelfCheckout.Click += new System.EventHandler(this.btnSelfCheckOut_Click);
            // 
            // btnGoToWaitingList
            // 
            this.btnGoToWaitingList.BackColor = System.Drawing.Color.White;
            this.btnGoToWaitingList.Image = global::LibraryLoanSystem.Properties.Resources.ileri;
            this.btnGoToWaitingList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGoToWaitingList.Location = new System.Drawing.Point(144, 356);
            this.btnGoToWaitingList.Name = "btnGoToWaitingList";
            this.btnGoToWaitingList.Size = new System.Drawing.Size(138, 30);
            this.btnGoToWaitingList.TabIndex = 5;
            this.btnGoToWaitingList.Text = "Go To Waiting List";
            this.btnGoToWaitingList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoToWaitingList.UseVisualStyleBackColor = false;
            this.btnGoToWaitingList.Click += new System.EventHandler(this.btnGoToWaitingList_Click);
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.BackColor = System.Drawing.Color.White;
            this.btnSearchBook.Image = global::LibraryLoanSystem.Properties.Resources.bütütec;
            this.btnSearchBook.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnSearchBook.Location = new System.Drawing.Point(607, 14);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(91, 39);
            this.btnSearchBook.TabIndex = 3;
            this.btnSearchBook.Text = "Search";
            this.btnSearchBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchBook.UseVisualStyleBackColor = false;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // lblSearchByBookCode
            // 
            this.lblSearchByBookCode.Location = new System.Drawing.Point(408, 25);
            this.lblSearchByBookCode.Name = "lblSearchByBookCode";
            this.lblSearchByBookCode.Size = new System.Drawing.Size(76, 18);
            this.lblSearchByBookCode.TabIndex = 16;
            this.lblSearchByBookCode.Text = "Book Code:";
            // 
            // lblSearchByAuthor
            // 
            this.lblSearchByAuthor.Location = new System.Drawing.Point(211, 23);
            this.lblSearchByAuthor.Name = "lblSearchByAuthor";
            this.lblSearchByAuthor.Size = new System.Drawing.Size(76, 18);
            this.lblSearchByAuthor.TabIndex = 15;
            this.lblSearchByAuthor.Text = "Author Name:";
            // 
            // lblSeachByName
            // 
            this.lblSeachByName.Location = new System.Drawing.Point(15, 25);
            this.lblSeachByName.Name = "lblSeachByName";
            this.lblSeachByName.Size = new System.Drawing.Size(76, 18);
            this.lblSeachByName.TabIndex = 14;
            this.lblSeachByName.Text = "Book Name:";
            // 
            // tbxSearchByCode
            // 
            this.tbxSearchByCode.Location = new System.Drawing.Point(490, 24);
            this.tbxSearchByCode.Name = "tbxSearchByCode";
            this.tbxSearchByCode.Size = new System.Drawing.Size(100, 21);
            this.tbxSearchByCode.TabIndex = 2;
            // 
            // tbxSearchByAuthor
            // 
            this.tbxSearchByAuthor.Location = new System.Drawing.Point(295, 22);
            this.tbxSearchByAuthor.Name = "tbxSearchByAuthor";
            this.tbxSearchByAuthor.Size = new System.Drawing.Size(100, 21);
            this.tbxSearchByAuthor.TabIndex = 1;
            // 
            // tbxSearchByName
            // 
            this.tbxSearchByName.Location = new System.Drawing.Point(97, 23);
            this.tbxSearchByName.Name = "tbxSearchByName";
            this.tbxSearchByName.Size = new System.Drawing.Size(100, 21);
            this.tbxSearchByName.TabIndex = 0;
            // 
            // gridBooks
            // 
            this.gridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBooks.Location = new System.Drawing.Point(18, 58);
            this.gridBooks.MultiSelect = false;
            this.gridBooks.Name = "gridBooks";
            this.gridBooks.ReadOnly = true;
            this.gridBooks.Size = new System.Drawing.Size(826, 292);
            this.gridBooks.TabIndex = 10;
            this.gridBooks.SelectionChanged += new System.EventHandler(this.gridBooks_SelectionChanged);
            // 
            // tabPageWaitingList
            // 
            this.tabPageWaitingList.Controls.Add(this.btnShowWaitList);
            this.tabPageWaitingList.Controls.Add(this.lblBooksCodes);
            this.tabPageWaitingList.Controls.Add(this.tbxWaitingBookCode);
            this.tabPageWaitingList.Controls.Add(this.btnMakeReservation);
            this.tabPageWaitingList.Controls.Add(this.gridWaitingList);
            this.tabPageWaitingList.Location = new System.Drawing.Point(4, 24);
            this.tabPageWaitingList.Name = "tabPageWaitingList";
            this.tabPageWaitingList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWaitingList.Size = new System.Drawing.Size(744, 327);
            this.tabPageWaitingList.TabIndex = 1;
            this.tabPageWaitingList.Text = "Waiting List";
            this.tabPageWaitingList.UseVisualStyleBackColor = true;
            // 
            // btnShowWaitList
            // 
            this.btnShowWaitList.BackColor = System.Drawing.Color.White;
            this.btnShowWaitList.Location = new System.Drawing.Point(222, 10);
            this.btnShowWaitList.Name = "btnShowWaitList";
            this.btnShowWaitList.Size = new System.Drawing.Size(128, 29);
            this.btnShowWaitList.TabIndex = 18;
            this.btnShowWaitList.Text = "Show Waiting List";
            this.btnShowWaitList.UseVisualStyleBackColor = false;
            this.btnShowWaitList.Click += new System.EventHandler(this.btnShowWaitList_Click);
            // 
            // lblBooksCodes
            // 
            this.lblBooksCodes.Location = new System.Drawing.Point(14, 16);
            this.lblBooksCodes.Name = "lblBooksCodes";
            this.lblBooksCodes.Size = new System.Drawing.Size(76, 18);
            this.lblBooksCodes.TabIndex = 17;
            this.lblBooksCodes.Text = "Book Code:";
            // 
            // tbxWaitingBookCode
            // 
            this.tbxWaitingBookCode.Enabled = false;
            this.tbxWaitingBookCode.Location = new System.Drawing.Point(96, 16);
            this.tbxWaitingBookCode.Name = "tbxWaitingBookCode";
            this.tbxWaitingBookCode.Size = new System.Drawing.Size(100, 21);
            this.tbxWaitingBookCode.TabIndex = 13;
            // 
            // btnMakeReservation
            // 
            this.btnMakeReservation.BackColor = System.Drawing.Color.White;
            this.btnMakeReservation.Location = new System.Drawing.Point(17, 268);
            this.btnMakeReservation.Name = "btnMakeReservation";
            this.btnMakeReservation.Size = new System.Drawing.Size(152, 29);
            this.btnMakeReservation.TabIndex = 12;
            this.btnMakeReservation.Text = "Make Reservation";
            this.btnMakeReservation.UseVisualStyleBackColor = false;
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
            this.tabPageMyBooks.Location = new System.Drawing.Point(4, 24);
            this.tabPageMyBooks.Name = "tabPageMyBooks";
            this.tabPageMyBooks.Size = new System.Drawing.Size(744, 327);
            this.tabPageMyBooks.TabIndex = 3;
            this.tabPageMyBooks.Text = "My Books";
            this.tabPageMyBooks.UseVisualStyleBackColor = true;
            // 
            // btnSelfReturn
            // 
            this.btnSelfReturn.BackColor = System.Drawing.Color.White;
            this.btnSelfReturn.Location = new System.Drawing.Point(597, 283);
            this.btnSelfReturn.Name = "btnSelfReturn";
            this.btnSelfReturn.Size = new System.Drawing.Size(112, 23);
            this.btnSelfReturn.TabIndex = 2;
            this.btnSelfReturn.Text = "Self Return";
            this.btnSelfReturn.UseVisualStyleBackColor = false;
            this.btnSelfReturn.Click += new System.EventHandler(this.btnSelfReturn_Click);
            // 
            // gridMyBooks
            // 
            this.gridMyBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMyBooks.Location = new System.Drawing.Point(22, 46);
            this.gridMyBooks.Name = "gridMyBooks";
            this.gridMyBooks.Size = new System.Drawing.Size(687, 215);
            this.gridMyBooks.TabIndex = 1;
            // 
            // btnViewMyBooks
            // 
            this.btnViewMyBooks.BackColor = System.Drawing.Color.White;
            this.btnViewMyBooks.Location = new System.Drawing.Point(22, 14);
            this.btnViewMyBooks.Name = "btnViewMyBooks";
            this.btnViewMyBooks.Size = new System.Drawing.Size(136, 26);
            this.btnViewMyBooks.TabIndex = 0;
            this.btnViewMyBooks.Text = "View My Books";
            this.btnViewMyBooks.UseVisualStyleBackColor = false;
            this.btnViewMyBooks.Click += new System.EventHandler(this.btnViewMyBooks_Click);
            // 
            // tabPageMyReservation
            // 
            this.tabPageMyReservation.Controls.Add(this.btnCancelReservation);
            this.tabPageMyReservation.Controls.Add(this.gridMyReservations);
            this.tabPageMyReservation.Controls.Add(this.btnViewMyReservations);
            this.tabPageMyReservation.Location = new System.Drawing.Point(4, 24);
            this.tabPageMyReservation.Name = "tabPageMyReservation";
            this.tabPageMyReservation.Size = new System.Drawing.Size(744, 327);
            this.tabPageMyReservation.TabIndex = 2;
            this.tabPageMyReservation.Text = "My Reservations";
            this.tabPageMyReservation.UseVisualStyleBackColor = true;
            // 
            // btnCancelReservation
            // 
            this.btnCancelReservation.BackColor = System.Drawing.Color.White;
            this.btnCancelReservation.Location = new System.Drawing.Point(580, 288);
            this.btnCancelReservation.Name = "btnCancelReservation";
            this.btnCancelReservation.Size = new System.Drawing.Size(129, 26);
            this.btnCancelReservation.TabIndex = 2;
            this.btnCancelReservation.Text = "Cancel Reservation";
            this.btnCancelReservation.UseVisualStyleBackColor = false;
            this.btnCancelReservation.Click += new System.EventHandler(this.btnCancelReservation_Click);
            // 
            // gridMyReservations
            // 
            this.gridMyReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMyReservations.Location = new System.Drawing.Point(22, 61);
            this.gridMyReservations.Name = "gridMyReservations";
            this.gridMyReservations.Size = new System.Drawing.Size(687, 221);
            this.gridMyReservations.TabIndex = 1;
            // 
            // btnViewMyReservations
            // 
            this.btnViewMyReservations.BackColor = System.Drawing.Color.White;
            this.btnViewMyReservations.Location = new System.Drawing.Point(22, 17);
            this.btnViewMyReservations.Name = "btnViewMyReservations";
            this.btnViewMyReservations.Size = new System.Drawing.Size(140, 29);
            this.btnViewMyReservations.TabIndex = 0;
            this.btnViewMyReservations.Text = "View My Reservations";
            this.btnViewMyReservations.UseVisualStyleBackColor = false;
            this.btnViewMyReservations.Click += new System.EventHandler(this.btnViewMyReservations_Click);
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(273, 7);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(0, 13);
            this.lblMemberName.TabIndex = 1;
            // 
            // btnBack5
            // 
            this.btnBack5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack5.Image = global::LibraryLoanSystem.Properties.Resources.back;
            this.btnBack5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack5.Location = new System.Drawing.Point(780, 438);
            this.btnBack5.Name = "btnBack5";
            this.btnBack5.Size = new System.Drawing.Size(100, 28);
            this.btnBack5.TabIndex = 0;
            this.btnBack5.Text = "Back";
            this.btnBack5.UseVisualStyleBackColor = false;
            this.btnBack5.Click += new System.EventHandler(this.btnBack5_Click);
            // 
            // ReservetionSelfcheckoutSelfreturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 478);
            this.Controls.Add(this.lblMemberName);
            this.Controls.Add(this.tabReservationForm);
            this.Controls.Add(this.btnBack5);
            this.MaximizeBox = false;
            this.Name = "ReservetionSelfcheckoutSelfreturnForm";
            this.Text = "Self Check out/Self Return/Reservation/Waiting List/My Reservations/My Books";
            this.Load += new System.EventHandler(this.Reservation_WaitingListForm_Load);
            this.tabReservationForm.ResumeLayout(false);
            this.tabPageCheck.ResumeLayout(false);
            this.tabPageCheck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).EndInit();
            this.tabPageWaitingList.ResumeLayout(false);
            this.tabPageWaitingList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridWaitingList)).EndInit();
            this.tabPageMyBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMyBooks)).EndInit();
            this.tabPageMyReservation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMyReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabReservationForm;
        private System.Windows.Forms.TabPage tabPageCheck;
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
        private System.Windows.Forms.Label lblBooksCodes;
        private System.Windows.Forms.TextBox tbxWaitingBookCode;
        private System.Windows.Forms.Button btnShowWaitList;
        private System.Windows.Forms.Button btnSelfCheckout;
        private System.Windows.Forms.TabPage tabPageMyBooks;
        private System.Windows.Forms.TabPage tabPageMyReservation;
        private System.Windows.Forms.DataGridView gridMyBooks;
        private System.Windows.Forms.Button btnViewMyBooks;
        private System.Windows.Forms.DataGridView gridMyReservations;
        private System.Windows.Forms.Button btnViewMyReservations;
        private System.Windows.Forms.Button btnSelfReturn;
        private System.Windows.Forms.Button btnCancelReservation;
        private System.Windows.Forms.Label lblMemberName;
    }
}