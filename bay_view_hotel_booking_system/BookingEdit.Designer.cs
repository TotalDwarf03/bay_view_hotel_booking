﻿namespace bay_view_hotel_booking_system
{
    partial class BookingEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingEdit));
            pnlBooking = new Panel();
            btnUpdateRoom = new Button();
            lblRoomAvailableCount = new Label();
            dgvAvailability = new DataGridView();
            cbRoomType = new ComboBox();
            tbRoomAvailable = new TextBox();
            lblRoomAvailable = new Label();
            tbCapacity = new TextBox();
            lblCapacity = new Label();
            tbPricePerNight = new TextBox();
            lblPricePerNight = new Label();
            tbDisabled = new TextBox();
            lblDisabled = new Label();
            lblRoomType = new Label();
            tbRoomID = new TextBox();
            lblRoomID = new Label();
            lblEndDate = new Label();
            lblBooking = new Label();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            lblStartDate = new Label();
            MenuStrip = new MenuStrip();
            tsmiAvailability = new ToolStripMenuItem();
            tsmiQuit = new ToolStripMenuItem();
            pnlGuest = new Panel();
            tbCustomerPhone = new TextBox();
            lblCustomerPhone = new Label();
            tbCustomerEmail = new TextBox();
            lblCustomerEmail = new Label();
            tbCustomerName = new TextBox();
            rbBreakfastNo = new RadioButton();
            lblCustomerName = new Label();
            rbBreakfastYes = new RadioButton();
            lblBreakfast = new Label();
            lblAdult = new Label();
            lblChild = new Label();
            nudAdult = new NumericUpDown();
            nudChild = new NumericUpDown();
            lblGuest = new Label();
            btnCancel = new Button();
            btnBook = new Button();
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
            pnlCurrentBooking = new Panel();
            lblBookingID = new Label();
            lblCurrentlyEditing = new Label();
            pnlBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailability).BeginInit();
            MenuStrip.SuspendLayout();
            pnlGuest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAdult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudChild).BeginInit();
            pnlSummary.SuspendLayout();
            pnlCurrentBooking.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBooking
            // 
            pnlBooking.BackColor = SystemColors.ControlLight;
            pnlBooking.BorderStyle = BorderStyle.FixedSingle;
            pnlBooking.Controls.Add(btnUpdateRoom);
            pnlBooking.Controls.Add(lblRoomAvailableCount);
            pnlBooking.Controls.Add(dgvAvailability);
            pnlBooking.Controls.Add(cbRoomType);
            pnlBooking.Controls.Add(tbRoomAvailable);
            pnlBooking.Controls.Add(lblRoomAvailable);
            pnlBooking.Controls.Add(tbCapacity);
            pnlBooking.Controls.Add(lblCapacity);
            pnlBooking.Controls.Add(tbPricePerNight);
            pnlBooking.Controls.Add(lblPricePerNight);
            pnlBooking.Controls.Add(tbDisabled);
            pnlBooking.Controls.Add(lblDisabled);
            pnlBooking.Controls.Add(lblRoomType);
            pnlBooking.Controls.Add(tbRoomID);
            pnlBooking.Controls.Add(lblRoomID);
            pnlBooking.Controls.Add(lblEndDate);
            pnlBooking.Controls.Add(lblBooking);
            pnlBooking.Controls.Add(dtpEndDate);
            pnlBooking.Controls.Add(dtpStartDate);
            pnlBooking.Controls.Add(lblStartDate);
            pnlBooking.Location = new Point(12, 27);
            pnlBooking.Name = "pnlBooking";
            pnlBooking.Size = new Size(356, 414);
            pnlBooking.TabIndex = 4;
            // 
            // btnUpdateRoom
            // 
            btnUpdateRoom.AutoSize = true;
            btnUpdateRoom.BackColor = SystemColors.ControlLightLight;
            btnUpdateRoom.Location = new Point(3, 381);
            btnUpdateRoom.Margin = new Padding(3, 2, 3, 2);
            btnUpdateRoom.Name = "btnUpdateRoom";
            btnUpdateRoom.Size = new Size(161, 30);
            btnUpdateRoom.TabIndex = 14;
            btnUpdateRoom.Text = "Update Room Choice";
            btnUpdateRoom.UseVisualStyleBackColor = false;
            btnUpdateRoom.Click += btnUpdateRoom_Click;
            // 
            // lblRoomAvailableCount
            // 
            lblRoomAvailableCount.AutoSize = true;
            lblRoomAvailableCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRoomAvailableCount.Location = new Point(177, 386);
            lblRoomAvailableCount.Name = "lblRoomAvailableCount";
            lblRoomAvailableCount.Size = new Size(174, 15);
            lblRoomAvailableCount.TabIndex = 17;
            lblRoomAvailableCount.Text = "x Alternative Rooms Available";
            lblRoomAvailableCount.TextAlign = ContentAlignment.MiddleRight;
            lblRoomAvailableCount.Visible = false;
            // 
            // dgvAvailability
            // 
            dgvAvailability.AllowUserToAddRows = false;
            dgvAvailability.AllowUserToDeleteRows = false;
            dgvAvailability.AllowUserToOrderColumns = true;
            dgvAvailability.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAvailability.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailability.Location = new Point(3, 215);
            dgvAvailability.Margin = new Padding(3, 2, 3, 2);
            dgvAvailability.MultiSelect = false;
            dgvAvailability.Name = "dgvAvailability";
            dgvAvailability.ReadOnly = true;
            dgvAvailability.RowHeadersWidth = 51;
            dgvAvailability.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAvailability.Size = new Size(348, 162);
            dgvAvailability.TabIndex = 27;
            // 
            // cbRoomType
            // 
            cbRoomType.FormattingEnabled = true;
            cbRoomType.Location = new Point(159, 99);
            cbRoomType.Name = "cbRoomType";
            cbRoomType.Size = new Size(150, 23);
            cbRoomType.TabIndex = 26;
            cbRoomType.SelectedIndexChanged += BookingInformationChanged;
            // 
            // tbRoomAvailable
            // 
            tbRoomAvailable.Enabled = false;
            tbRoomAvailable.Location = new Point(159, 187);
            tbRoomAvailable.Name = "tbRoomAvailable";
            tbRoomAvailable.Size = new Size(150, 23);
            tbRoomAvailable.TabIndex = 25;
            // 
            // lblRoomAvailable
            // 
            lblRoomAvailable.AutoSize = true;
            lblRoomAvailable.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRoomAvailable.Location = new Point(159, 169);
            lblRoomAvailable.Name = "lblRoomAvailable";
            lblRoomAvailable.Size = new Size(122, 15);
            lblRoomAvailable.TabIndex = 24;
            lblRoomAvailable.Text = "Room Still Available?";
            // 
            // tbCapacity
            // 
            tbCapacity.Enabled = false;
            tbCapacity.Location = new Point(159, 143);
            tbCapacity.Name = "tbCapacity";
            tbCapacity.Size = new Size(150, 23);
            tbCapacity.TabIndex = 23;
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCapacity.Location = new Point(159, 125);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(92, 15);
            lblCapacity.TabIndex = 22;
            lblCapacity.Text = "Room Capacity:";
            // 
            // tbPricePerNight
            // 
            tbPricePerNight.Enabled = false;
            tbPricePerNight.Location = new Point(3, 187);
            tbPricePerNight.Name = "tbPricePerNight";
            tbPricePerNight.Size = new Size(150, 23);
            tbPricePerNight.TabIndex = 21;
            // 
            // lblPricePerNight
            // 
            lblPricePerNight.AutoSize = true;
            lblPricePerNight.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPricePerNight.Location = new Point(3, 169);
            lblPricePerNight.Name = "lblPricePerNight";
            lblPricePerNight.Size = new Size(130, 15);
            lblPricePerNight.TabIndex = 20;
            lblPricePerNight.Text = "Room Price Per Night:";
            // 
            // tbDisabled
            // 
            tbDisabled.Enabled = false;
            tbDisabled.Location = new Point(3, 143);
            tbDisabled.Name = "tbDisabled";
            tbDisabled.Size = new Size(150, 23);
            tbDisabled.TabIndex = 19;
            // 
            // lblDisabled
            // 
            lblDisabled.AutoSize = true;
            lblDisabled.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDisabled.Location = new Point(3, 125);
            lblDisabled.Name = "lblDisabled";
            lblDisabled.Size = new Size(107, 15);
            lblDisabled.TabIndex = 18;
            lblDisabled.Text = "Is Disabled Room?";
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRoomType.Location = new Point(159, 81);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(72, 15);
            lblRoomType.TabIndex = 16;
            lblRoomType.Text = "Room Type:";
            // 
            // tbRoomID
            // 
            tbRoomID.Enabled = false;
            tbRoomID.Location = new Point(3, 99);
            tbRoomID.Name = "tbRoomID";
            tbRoomID.Size = new Size(150, 23);
            tbRoomID.TabIndex = 15;
            // 
            // lblRoomID
            // 
            lblRoomID.AutoSize = true;
            lblRoomID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRoomID.Location = new Point(3, 81);
            lblRoomID.Name = "lblRoomID";
            lblRoomID.Size = new Size(56, 15);
            lblRoomID.TabIndex = 12;
            lblRoomID.Text = "RoomID:";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEndDate.Location = new Point(159, 26);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(60, 15);
            lblEndDate.TabIndex = 11;
            lblEndDate.Text = "End Date:";
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
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(159, 43);
            dtpEndDate.Margin = new Padding(3, 2, 3, 2);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(150, 23);
            dtpEndDate.TabIndex = 10;
            dtpEndDate.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpEndDate.ValueChanged += BookingInformationChanged;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(3, 43);
            dtpStartDate.Margin = new Padding(3, 2, 3, 2);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(150, 23);
            dtpStartDate.TabIndex = 8;
            dtpStartDate.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpStartDate.ValueChanged += BookingInformationChanged;
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
            // MenuStrip
            // 
            MenuStrip.ImageScalingSize = new Size(20, 20);
            MenuStrip.Items.AddRange(new ToolStripItem[] { tsmiAvailability, tsmiQuit });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Padding = new Padding(5, 2, 0, 2);
            MenuStrip.Size = new Size(784, 24);
            MenuStrip.TabIndex = 5;
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
            // pnlGuest
            // 
            pnlGuest.BackColor = SystemColors.ControlLight;
            pnlGuest.BorderStyle = BorderStyle.FixedSingle;
            pnlGuest.Controls.Add(tbCustomerPhone);
            pnlGuest.Controls.Add(lblCustomerPhone);
            pnlGuest.Controls.Add(tbCustomerEmail);
            pnlGuest.Controls.Add(lblCustomerEmail);
            pnlGuest.Controls.Add(tbCustomerName);
            pnlGuest.Controls.Add(rbBreakfastNo);
            pnlGuest.Controls.Add(lblCustomerName);
            pnlGuest.Controls.Add(rbBreakfastYes);
            pnlGuest.Controls.Add(lblBreakfast);
            pnlGuest.Controls.Add(lblAdult);
            pnlGuest.Controls.Add(lblChild);
            pnlGuest.Controls.Add(nudAdult);
            pnlGuest.Controls.Add(nudChild);
            pnlGuest.Controls.Add(lblGuest);
            pnlGuest.Location = new Point(374, 127);
            pnlGuest.Name = "pnlGuest";
            pnlGuest.Size = new Size(162, 314);
            pnlGuest.TabIndex = 6;
            // 
            // tbCustomerPhone
            // 
            tbCustomerPhone.Enabled = false;
            tbCustomerPhone.Location = new Point(3, 131);
            tbCustomerPhone.Name = "tbCustomerPhone";
            tbCustomerPhone.Size = new Size(150, 23);
            tbCustomerPhone.TabIndex = 34;
            // 
            // lblCustomerPhone
            // 
            lblCustomerPhone.AutoSize = true;
            lblCustomerPhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCustomerPhone.Location = new Point(3, 113);
            lblCustomerPhone.Name = "lblCustomerPhone";
            lblCustomerPhone.Size = new Size(151, 15);
            lblCustomerPhone.TabIndex = 33;
            lblCustomerPhone.Text = "Customer Phone Number:";
            // 
            // tbCustomerEmail
            // 
            tbCustomerEmail.Enabled = false;
            tbCustomerEmail.Location = new Point(3, 87);
            tbCustomerEmail.Name = "tbCustomerEmail";
            tbCustomerEmail.Size = new Size(150, 23);
            tbCustomerEmail.TabIndex = 32;
            // 
            // lblCustomerEmail
            // 
            lblCustomerEmail.AutoSize = true;
            lblCustomerEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCustomerEmail.Location = new Point(3, 69);
            lblCustomerEmail.Name = "lblCustomerEmail";
            lblCustomerEmail.Size = new Size(96, 15);
            lblCustomerEmail.TabIndex = 31;
            lblCustomerEmail.Text = "Customer Email:";
            // 
            // tbCustomerName
            // 
            tbCustomerName.Enabled = false;
            tbCustomerName.Location = new Point(3, 43);
            tbCustomerName.Name = "tbCustomerName";
            tbCustomerName.Size = new Size(150, 23);
            tbCustomerName.TabIndex = 25;
            // 
            // rbBreakfastNo
            // 
            rbBreakfastNo.AutoSize = true;
            rbBreakfastNo.Checked = true;
            rbBreakfastNo.Location = new Point(51, 274);
            rbBreakfastNo.Name = "rbBreakfastNo";
            rbBreakfastNo.Size = new Size(41, 19);
            rbBreakfastNo.TabIndex = 30;
            rbBreakfastNo.TabStop = true;
            rbBreakfastNo.Text = "No";
            rbBreakfastNo.UseVisualStyleBackColor = true;
            rbBreakfastNo.Click += CostingChanged;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCustomerName.Location = new Point(3, 25);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(100, 15);
            lblCustomerName.TabIndex = 24;
            lblCustomerName.Text = "Customer Name:";
            // 
            // rbBreakfastYes
            // 
            rbBreakfastYes.AutoSize = true;
            rbBreakfastYes.Location = new Point(3, 274);
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
            lblBreakfast.Location = new Point(3, 256);
            lblBreakfast.Name = "lblBreakfast";
            lblBreakfast.Size = new Size(64, 15);
            lblBreakfast.TabIndex = 28;
            lblBreakfast.Text = "Breakfast:";
            // 
            // lblAdult
            // 
            lblAdult.AutoSize = true;
            lblAdult.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAdult.Location = new Point(3, 168);
            lblAdult.Name = "lblAdult";
            lblAdult.Size = new Size(67, 15);
            lblAdult.TabIndex = 27;
            lblAdult.Text = "No. Adults:";
            // 
            // lblChild
            // 
            lblChild.AutoSize = true;
            lblChild.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblChild.Location = new Point(3, 212);
            lblChild.Name = "lblChild";
            lblChild.Size = new Size(78, 15);
            lblChild.TabIndex = 26;
            lblChild.Text = "No. Children:";
            // 
            // nudAdult
            // 
            nudAdult.Location = new Point(3, 186);
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
            nudChild.Location = new Point(3, 230);
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
            // btnCancel
            // 
            btnCancel.Location = new Point(542, 418);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 23);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += tsmiAvailability_Click;
            // 
            // btnBook
            // 
            btnBook.Location = new Point(672, 418);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(100, 23);
            btnBook.TabIndex = 9;
            btnBook.Text = "Update Booking";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
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
            pnlSummary.Location = new Point(542, 28);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Size = new Size(230, 384);
            pnlSummary.TabIndex = 8;
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
            // pnlCurrentBooking
            // 
            pnlCurrentBooking.BackColor = SystemColors.ControlLight;
            pnlCurrentBooking.BorderStyle = BorderStyle.FixedSingle;
            pnlCurrentBooking.Controls.Add(lblBookingID);
            pnlCurrentBooking.Controls.Add(lblCurrentlyEditing);
            pnlCurrentBooking.Location = new Point(374, 28);
            pnlCurrentBooking.Name = "pnlCurrentBooking";
            pnlCurrentBooking.Size = new Size(162, 93);
            pnlCurrentBooking.TabIndex = 11;
            // 
            // lblBookingID
            // 
            lblBookingID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBookingID.Location = new Point(3, 49);
            lblBookingID.Name = "lblBookingID";
            lblBookingID.Size = new Size(151, 42);
            lblBookingID.TabIndex = 1;
            lblBookingID.Text = "1";
            lblBookingID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrentlyEditing
            // 
            lblCurrentlyEditing.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCurrentlyEditing.Location = new Point(3, 0);
            lblCurrentlyEditing.Name = "lblCurrentlyEditing";
            lblCurrentlyEditing.Size = new Size(151, 49);
            lblCurrentlyEditing.TabIndex = 0;
            lblCurrentlyEditing.Text = "Viewing / Editing Booking:";
            lblCurrentlyEditing.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EditBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(pnlCurrentBooking);
            Controls.Add(btnCancel);
            Controls.Add(btnBook);
            Controls.Add(pnlSummary);
            Controls.Add(pnlGuest);
            Controls.Add(MenuStrip);
            Controls.Add(pnlBooking);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditBooking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Booking";
            FormClosing += EditBooking_FormClosing;
            Load += EditBooking_Load;
            pnlBooking.ResumeLayout(false);
            pnlBooking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailability).EndInit();
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            pnlGuest.ResumeLayout(false);
            pnlGuest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAdult).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudChild).EndInit();
            pnlSummary.ResumeLayout(false);
            pnlSummary.PerformLayout();
            pnlCurrentBooking.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlBooking;
        private TextBox tbCapacity;
        private Label lblCapacity;
        private TextBox tbPricePerNight;
        private Label lblPricePerNight;
        private TextBox tbDisabled;
        private Label lblDisabled;
        private Label lblRoomType;
        private TextBox tbRoomID;
        private Label lblRoomID;
        private Label lblEndDate;
        private Label lblBooking;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private Label lblStartDate;
        private MenuStrip MenuStrip;
        private ToolStripMenuItem tsmiAvailability;
        private ToolStripMenuItem tsmiQuit;
        private Panel pnlGuest;
        private RadioButton rbBreakfastNo;
        private RadioButton rbBreakfastYes;
        private Label lblBreakfast;
        private Label lblAdult;
        private Label lblChild;
        private NumericUpDown nudAdult;
        private NumericUpDown nudChild;
        private Label lblGuest;
        private TextBox tbCustomerName;
        private Label lblCustomerName;
        private TextBox tbCustomerPhone;
        private Label lblCustomerPhone;
        private TextBox tbCustomerEmail;
        private Label lblCustomerEmail;
        private TextBox tbRoomAvailable;
        private Label lblRoomAvailable;
        private Button btnCancel;
        private Button btnBook;
        private Panel pnlSummary;
        private Label lblTotalValue;
        private Label lblTotal;
        private Label lblNoOfNightsValue;
        private Label lblNoOfNights;
        private CheckBox chbConfirm;
        private Label lblPPNValue;
        private Label lblPPN;
        private ListView lvPricing;
        private ColumnHeader chChargeType;
        private ColumnHeader chPrice;
        private Label lblSummary;
        private ComboBox cbRoomType;
        private DataGridView dgvAvailability;
        private Label lblRoomAvailableCount;
        private Button btnUpdateRoom;
        private Panel pnlCurrentBooking;
        private Label lblBookingID;
        private Label lblCurrentlyEditing;
    }
}