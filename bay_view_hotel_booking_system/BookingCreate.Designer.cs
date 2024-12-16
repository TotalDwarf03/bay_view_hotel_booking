namespace bay_view_hotel_booking_system
{
    partial class BookingCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingCreate));
            lblBooking = new Label();
            MenuStrip = new MenuStrip();
            tsmiAvailability = new ToolStripMenuItem();
            tsmiQuit = new ToolStripMenuItem();
            pnlBooking = new Panel();
            tbCapacity = new TextBox();
            lblCapacity = new Label();
            tbPricePerNight = new TextBox();
            lblPricePerNight = new Label();
            tbDisabled = new TextBox();
            lblDisabled = new Label();
            tbRoomType = new TextBox();
            lblRoomType = new Label();
            tbRoomID = new TextBox();
            lblRoomID = new Label();
            lblEndDate = new Label();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            lblStartDate = new Label();
            lblCustomerHeader = new Label();
            pnlGuest = new Panel();
            dgvCustomer = new DataGridView();
            btnCustomerSearch = new Button();
            tbCustomerName = new TextBox();
            rbBreakfastNo = new RadioButton();
            rbBreakfastYes = new RadioButton();
            lblBreakfast = new Label();
            lblAdult = new Label();
            lblChild = new Label();
            nudAdult = new NumericUpDown();
            nudChild = new NumericUpDown();
            lblGuest = new Label();
            pnlSummary = new Panel();
            lblTotalValue = new Label();
            lblTotal = new Label();
            lblNoOfNightsValue = new Label();
            lblNoOfNights = new Label();
            chbConfirm = new CheckBox();
            lblPPNValue = new Label();
            lblPPN = new Label();
            lvPricing = new ListView();
            chChargeType = new ColumnHeader();
            chPrice = new ColumnHeader();
            lblSummary = new Label();
            btnBook = new Button();
            btnCancel = new Button();
            MenuStrip.SuspendLayout();
            pnlBooking.SuspendLayout();
            pnlGuest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAdult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudChild).BeginInit();
            pnlSummary.SuspendLayout();
            SuspendLayout();
            // 
            // lblBooking
            // 
            lblBooking.AutoSize = true;
            lblBooking.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBooking.Location = new Point(3, 0);
            lblBooking.Name = "lblBooking";
            lblBooking.Size = new Size(126, 15);
            lblBooking.TabIndex = 0;
            lblBooking.Text = "Booking Information:";
            // 
            // MenuStrip
            // 
            MenuStrip.ImageScalingSize = new Size(20, 20);
            MenuStrip.Items.AddRange(new ToolStripItem[] { tsmiAvailability, tsmiQuit });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Padding = new Padding(5, 2, 0, 2);
            MenuStrip.Size = new Size(784, 24);
            MenuStrip.TabIndex = 2;
            MenuStrip.Text = "menuStrip1";
            // 
            // tsmiAvailability
            // 
            tsmiAvailability.Name = "tsmiAvailability";
            tsmiAvailability.Size = new Size(105, 20);
            tsmiAvailability.Text = "View Availability";
            tsmiAvailability.Click += tsmiAvailability_Click;
            // 
            // tsmiQuit
            // 
            tsmiQuit.Name = "tsmiQuit";
            tsmiQuit.Size = new Size(130, 20);
            tsmiQuit.Text = "Return to Homepage";
            tsmiQuit.Click += tsmiQuit_Click;
            // 
            // pnlBooking
            // 
            pnlBooking.BackColor = SystemColors.ControlLight;
            pnlBooking.BorderStyle = BorderStyle.FixedSingle;
            pnlBooking.Controls.Add(tbCapacity);
            pnlBooking.Controls.Add(lblCapacity);
            pnlBooking.Controls.Add(tbPricePerNight);
            pnlBooking.Controls.Add(lblPricePerNight);
            pnlBooking.Controls.Add(tbDisabled);
            pnlBooking.Controls.Add(lblDisabled);
            pnlBooking.Controls.Add(tbRoomType);
            pnlBooking.Controls.Add(lblRoomType);
            pnlBooking.Controls.Add(tbRoomID);
            pnlBooking.Controls.Add(lblRoomID);
            pnlBooking.Controls.Add(lblEndDate);
            pnlBooking.Controls.Add(lblBooking);
            pnlBooking.Controls.Add(dtpEndDate);
            pnlBooking.Controls.Add(dtpStartDate);
            pnlBooking.Controls.Add(lblStartDate);
            pnlBooking.Location = new Point(12, 36);
            pnlBooking.Name = "pnlBooking";
            pnlBooking.Size = new Size(162, 384);
            pnlBooking.TabIndex = 3;
            // 
            // tbCapacity
            // 
            tbCapacity.Enabled = false;
            tbCapacity.Location = new Point(3, 319);
            tbCapacity.Name = "tbCapacity";
            tbCapacity.Size = new Size(150, 23);
            tbCapacity.TabIndex = 23;
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCapacity.Location = new Point(3, 301);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(92, 15);
            lblCapacity.TabIndex = 22;
            lblCapacity.Text = "Room Capacity:";
            // 
            // tbPricePerNight
            // 
            tbPricePerNight.Enabled = false;
            tbPricePerNight.Location = new Point(3, 275);
            tbPricePerNight.Name = "tbPricePerNight";
            tbPricePerNight.Size = new Size(150, 23);
            tbPricePerNight.TabIndex = 21;
            // 
            // lblPricePerNight
            // 
            lblPricePerNight.AutoSize = true;
            lblPricePerNight.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPricePerNight.Location = new Point(3, 257);
            lblPricePerNight.Name = "lblPricePerNight";
            lblPricePerNight.Size = new Size(130, 15);
            lblPricePerNight.TabIndex = 20;
            lblPricePerNight.Text = "Room Price Per Night:";
            // 
            // tbDisabled
            // 
            tbDisabled.Enabled = false;
            tbDisabled.Location = new Point(3, 231);
            tbDisabled.Name = "tbDisabled";
            tbDisabled.Size = new Size(150, 23);
            tbDisabled.TabIndex = 19;
            // 
            // lblDisabled
            // 
            lblDisabled.AutoSize = true;
            lblDisabled.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDisabled.Location = new Point(3, 213);
            lblDisabled.Name = "lblDisabled";
            lblDisabled.Size = new Size(107, 15);
            lblDisabled.TabIndex = 18;
            lblDisabled.Text = "Is Disabled Room?";
            // 
            // tbRoomType
            // 
            tbRoomType.Enabled = false;
            tbRoomType.Location = new Point(3, 187);
            tbRoomType.Name = "tbRoomType";
            tbRoomType.Size = new Size(150, 23);
            tbRoomType.TabIndex = 17;
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRoomType.Location = new Point(3, 169);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(72, 15);
            lblRoomType.TabIndex = 16;
            lblRoomType.Text = "Room Type:";
            // 
            // tbRoomID
            // 
            tbRoomID.Enabled = false;
            tbRoomID.Location = new Point(3, 143);
            tbRoomID.Name = "tbRoomID";
            tbRoomID.Size = new Size(150, 23);
            tbRoomID.TabIndex = 15;
            // 
            // lblRoomID
            // 
            lblRoomID.AutoSize = true;
            lblRoomID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRoomID.Location = new Point(3, 125);
            lblRoomID.Name = "lblRoomID";
            lblRoomID.Size = new Size(56, 15);
            lblRoomID.TabIndex = 12;
            lblRoomID.Text = "RoomID:";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEndDate.Location = new Point(3, 68);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(60, 15);
            lblEndDate.TabIndex = 11;
            lblEndDate.Text = "End Date:";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Enabled = false;
            dtpEndDate.Location = new Point(3, 85);
            dtpEndDate.Margin = new Padding(3, 2, 3, 2);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(150, 23);
            dtpEndDate.TabIndex = 10;
            dtpEndDate.Value = new DateTime(2024, 11, 21, 11, 28, 36, 0);
            // 
            // dtpStartDate
            // 
            dtpStartDate.Enabled = false;
            dtpStartDate.Location = new Point(3, 43);
            dtpStartDate.Margin = new Padding(3, 2, 3, 2);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(150, 23);
            dtpStartDate.TabIndex = 8;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStartDate.Location = new Point(3, 26);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(71, 15);
            lblStartDate.TabIndex = 9;
            lblStartDate.Text = "Start Date: ";
            // 
            // lblCustomerHeader
            // 
            lblCustomerHeader.AutoSize = true;
            lblCustomerHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCustomerHeader.Location = new Point(3, 26);
            lblCustomerHeader.Name = "lblCustomerHeader";
            lblCustomerHeader.Size = new Size(64, 15);
            lblCustomerHeader.TabIndex = 20;
            lblCustomerHeader.Text = "Customer:";
            // 
            // pnlGuest
            // 
            pnlGuest.BackColor = SystemColors.ControlLight;
            pnlGuest.BorderStyle = BorderStyle.FixedSingle;
            pnlGuest.Controls.Add(dgvCustomer);
            pnlGuest.Controls.Add(btnCustomerSearch);
            pnlGuest.Controls.Add(tbCustomerName);
            pnlGuest.Controls.Add(rbBreakfastNo);
            pnlGuest.Controls.Add(rbBreakfastYes);
            pnlGuest.Controls.Add(lblBreakfast);
            pnlGuest.Controls.Add(lblAdult);
            pnlGuest.Controls.Add(lblChild);
            pnlGuest.Controls.Add(lblCustomerHeader);
            pnlGuest.Controls.Add(nudAdult);
            pnlGuest.Controls.Add(nudChild);
            pnlGuest.Controls.Add(lblGuest);
            pnlGuest.Location = new Point(180, 36);
            pnlGuest.Name = "pnlGuest";
            pnlGuest.Size = new Size(356, 384);
            pnlGuest.TabIndex = 4;
            // 
            // dgvCustomer
            // 
            dgvCustomer.AllowUserToAddRows = false;
            dgvCustomer.AllowUserToDeleteRows = false;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Location = new Point(3, 72);
            dgvCustomer.MultiSelect = false;
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.ReadOnly = true;
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomer.ShowEditingIcon = false;
            dgvCustomer.Size = new Size(348, 215);
            dgvCustomer.TabIndex = 33;
            // 
            // btnCustomerSearch
            // 
            btnCustomerSearch.BackColor = SystemColors.ControlLightLight;
            btnCustomerSearch.Location = new Point(286, 42);
            btnCustomerSearch.Name = "btnCustomerSearch";
            btnCustomerSearch.Size = new Size(65, 23);
            btnCustomerSearch.TabIndex = 32;
            btnCustomerSearch.Text = "Search";
            btnCustomerSearch.UseVisualStyleBackColor = false;
            btnCustomerSearch.Click += btnCustomerSearch_Click;
            // 
            // tbCustomerName
            // 
            tbCustomerName.Location = new Point(3, 43);
            tbCustomerName.Name = "tbCustomerName";
            tbCustomerName.Size = new Size(277, 23);
            tbCustomerName.TabIndex = 31;
            tbCustomerName.KeyPress += tbCustomerName_KeyPress;
            // 
            // rbBreakfastNo
            // 
            rbBreakfastNo.AutoSize = true;
            rbBreakfastNo.Checked = true;
            rbBreakfastNo.Location = new Point(298, 319);
            rbBreakfastNo.Name = "rbBreakfastNo";
            rbBreakfastNo.Size = new Size(41, 19);
            rbBreakfastNo.TabIndex = 30;
            rbBreakfastNo.TabStop = true;
            rbBreakfastNo.Text = "No";
            rbBreakfastNo.UseVisualStyleBackColor = true;
            rbBreakfastNo.Click += CostingChanged;
            // 
            // rbBreakfastYes
            // 
            rbBreakfastYes.AutoSize = true;
            rbBreakfastYes.Location = new Point(250, 319);
            rbBreakfastYes.Name = "rbBreakfastYes";
            rbBreakfastYes.Size = new Size(42, 19);
            rbBreakfastYes.TabIndex = 29;
            rbBreakfastYes.Text = "Yes";
            rbBreakfastYes.UseVisualStyleBackColor = true;
            rbBreakfastYes.Click += CostingChanged;
            // 
            // lblBreakfast
            // 
            lblBreakfast.AutoSize = true;
            lblBreakfast.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBreakfast.Location = new Point(250, 301);
            lblBreakfast.Name = "lblBreakfast";
            lblBreakfast.Size = new Size(64, 15);
            lblBreakfast.TabIndex = 28;
            lblBreakfast.Text = "Breakfast:";
            // 
            // lblAdult
            // 
            lblAdult.AutoSize = true;
            lblAdult.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAdult.Location = new Point(3, 301);
            lblAdult.Name = "lblAdult";
            lblAdult.Size = new Size(67, 15);
            lblAdult.TabIndex = 27;
            lblAdult.Text = "No. Adults:";
            // 
            // lblChild
            // 
            lblChild.AutoSize = true;
            lblChild.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblChild.Location = new Point(109, 301);
            lblChild.Name = "lblChild";
            lblChild.Size = new Size(78, 15);
            lblChild.TabIndex = 26;
            lblChild.Text = "No. Children:";
            // 
            // nudAdult
            // 
            nudAdult.Location = new Point(3, 319);
            nudAdult.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            nudAdult.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAdult.Name = "nudAdult";
            nudAdult.Size = new Size(100, 23);
            nudAdult.TabIndex = 2;
            nudAdult.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudAdult.ValueChanged += NumberOfGuestsChanged;
            // 
            // nudChild
            // 
            nudChild.Location = new Point(109, 319);
            nudChild.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            nudChild.Name = "nudChild";
            nudChild.Size = new Size(100, 23);
            nudChild.TabIndex = 1;
            nudChild.ValueChanged += NumberOfGuestsChanged;
            // 
            // lblGuest
            // 
            lblGuest.AutoSize = true;
            lblGuest.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGuest.Location = new Point(3, 0);
            lblGuest.Name = "lblGuest";
            lblGuest.Size = new Size(113, 15);
            lblGuest.TabIndex = 0;
            lblGuest.Text = "Guest Information:";
            // 
            // pnlSummary
            // 
            pnlSummary.BackColor = SystemColors.Info;
            pnlSummary.BorderStyle = BorderStyle.FixedSingle;
            pnlSummary.Controls.Add(lblTotalValue);
            pnlSummary.Controls.Add(lblTotal);
            pnlSummary.Controls.Add(lblNoOfNightsValue);
            pnlSummary.Controls.Add(lblNoOfNights);
            pnlSummary.Controls.Add(chbConfirm);
            pnlSummary.Controls.Add(lblPPNValue);
            pnlSummary.Controls.Add(lblPPN);
            pnlSummary.Controls.Add(lvPricing);
            pnlSummary.Controls.Add(lblSummary);
            pnlSummary.Location = new Point(542, 36);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Size = new Size(230, 384);
            pnlSummary.TabIndex = 5;
            // 
            // lblTotalValue
            // 
            lblTotalValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotalValue.Location = new Point(154, 257);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(71, 20);
            lblTotalValue.TabIndex = 38;
            lblTotalValue.Text = "£00.00";
            lblTotalValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotal.Location = new Point(3, 257);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(145, 20);
            lblTotal.TabIndex = 37;
            lblTotal.Text = "Total Booking Cost:";
            // 
            // lblNoOfNightsValue
            // 
            lblNoOfNightsValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNoOfNightsValue.Location = new Point(161, 228);
            lblNoOfNightsValue.Name = "lblNoOfNightsValue";
            lblNoOfNightsValue.Size = new Size(64, 15);
            lblNoOfNightsValue.TabIndex = 36;
            lblNoOfNightsValue.Text = "7";
            lblNoOfNightsValue.TextAlign = ContentAlignment.TopRight;
            // 
            // lblNoOfNights
            // 
            lblNoOfNights.AutoSize = true;
            lblNoOfNights.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNoOfNights.Location = new Point(3, 228);
            lblNoOfNights.Name = "lblNoOfNights";
            lblNoOfNights.Size = new Size(110, 15);
            lblNoOfNights.TabIndex = 35;
            lblNoOfNights.Text = "Number of Nights:";
            // 
            // chbConfirm
            // 
            chbConfirm.CheckAlign = ContentAlignment.MiddleRight;
            chbConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chbConfirm.Location = new Point(3, 291);
            chbConfirm.Name = "chbConfirm";
            chbConfirm.Size = new Size(222, 85);
            chbConfirm.TabIndex = 34;
            chbConfirm.Text = "I have read the above information and can confidently confirm that all booking information is correct and has been confirmed by the customer.";
            chbConfirm.UseVisualStyleBackColor = true;
            // 
            // lblPPNValue
            // 
            lblPPNValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPPNValue.Location = new Point(161, 213);
            lblPPNValue.Name = "lblPPNValue";
            lblPPNValue.Size = new Size(64, 15);
            lblPPNValue.TabIndex = 32;
            lblPPNValue.Text = "£00.00";
            lblPPNValue.TextAlign = ContentAlignment.TopRight;
            // 
            // lblPPN
            // 
            lblPPN.AutoSize = true;
            lblPPN.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPPN.Location = new Point(3, 213);
            lblPPN.Name = "lblPPN";
            lblPPN.Size = new Size(94, 15);
            lblPPN.TabIndex = 31;
            lblPPN.Text = "Price Per Night:";
            // 
            // lvPricing
            // 
            lvPricing.BackColor = SystemColors.Info;
            lvPricing.Columns.AddRange(new ColumnHeader[] { chChargeType, chPrice });
            lvPricing.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvPricing.Location = new Point(3, 18);
            lvPricing.Name = "lvPricing";
            lvPricing.Size = new Size(222, 192);
            lvPricing.TabIndex = 1;
            lvPricing.UseCompatibleStateImageBehavior = false;
            lvPricing.View = View.Details;
            // 
            // chChargeType
            // 
            chChargeType.Text = "Charge Type";
            chChargeType.Width = 130;
            // 
            // chPrice
            // 
            chPrice.Text = "Price";
            chPrice.TextAlign = HorizontalAlignment.Right;
            chPrice.Width = 85;
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSummary.Location = new Point(3, 0);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(112, 15);
            lblSummary.TabIndex = 0;
            lblSummary.Text = "Booking Summary:";
            // 
            // btnBook
            // 
            btnBook.Location = new Point(672, 426);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(100, 23);
            btnBook.TabIndex = 6;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(542, 426);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += tsmiAvailability_Click;
            // 
            // CreateBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(btnCancel);
            Controls.Add(btnBook);
            Controls.Add(pnlSummary);
            Controls.Add(pnlGuest);
            Controls.Add(pnlBooking);
            Controls.Add(MenuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateBooking";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Create Booking";
            FormClosing += CreateBooking_FormClosing;
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            pnlBooking.ResumeLayout(false);
            pnlBooking.PerformLayout();
            pnlGuest.ResumeLayout(false);
            pnlGuest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAdult).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudChild).EndInit();
            pnlSummary.ResumeLayout(false);
            pnlSummary.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBooking;
        private MenuStrip MenuStrip;
        private ToolStripMenuItem tsmiAvailability;
        private ToolStripMenuItem tsmiQuit;
        private Panel pnlBooking;
        private Panel pnlGuest;
        private Label lblGuest;
        private Panel pnlSummary;
        private Label lblSummary;
        private Button btnBook;
        private Button btnCancel;
        private DateTimePicker dtpStartDate;
        private Label lblStartDate;
        private Label lblEndDate;
        private DateTimePicker dtpEndDate;
        private Label lblCustomerHeader;
        private TextBox tbDisabled;
        private Label lblDisabled;
        private TextBox tbRoomType;
        private Label lblRoomType;
        private TextBox tbRoomID;
        private Label lblRoomID;
        private Label lblAdult;
        private Label lblChild;
        private NumericUpDown nudAdult;
        private NumericUpDown nudChild;
        private Label lblBreakfast;
        private RadioButton rbBreakfastYes;
        private RadioButton rbBreakfastNo;
        private ListView lvPricing;
        private ColumnHeader chChargeType;
        private ColumnHeader chPrice;
        private Label lblPPNValue;
        private Label lblPPN;
        private CheckBox chbConfirm;
        private TextBox tbPricePerNight;
        private Label lblPricePerNight;
        private TextBox tbCapacity;
        private Label lblCapacity;
        private Label lblNoOfNightsValue;
        private Label lblNoOfNights;
        private Label lblTotalValue;
        private Label lblTotal;
        private TextBox tbCustomerName;
        private Button btnCustomerSearch;
        private DataGridView dgvCustomer;
    }
}