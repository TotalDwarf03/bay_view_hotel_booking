namespace bay_view_hotel_booking_system
{
    partial class BookingView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingView));
            MenuStrip = new MenuStrip();
            tsmiAvailability = new ToolStripMenuItem();
            tsmiQuit = new ToolStripMenuItem();
            pnlSearch = new Panel();
            cbRoomType = new ComboBox();
            lblRoomType = new Label();
            cbRoom = new ComboBox();
            lblRoom = new Label();
            btnStaffSearch = new Button();
            lblStaff = new Label();
            tbStaff = new TextBox();
            dgvStaff = new DataGridView();
            btnClear = new Button();
            cbPaid = new ComboBox();
            lblPaid = new Label();
            cbCancelled = new ComboBox();
            lblCancelled = new Label();
            lblEndDate = new Label();
            dgvCustomer = new DataGridView();
            lblBooking = new Label();
            dtpEndDate = new DateTimePicker();
            btnSearch = new Button();
            dtpStartDate = new DateTimePicker();
            btnCustomerSearch = new Button();
            lblStartDate = new Label();
            lblCustomerHeader = new Label();
            tbCustomerName = new TextBox();
            dgvBooking = new DataGridView();
            lblTotalBookings = new Label();
            MenuStrip.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooking).BeginInit();
            SuspendLayout();
            // 
            // MenuStrip
            // 
            MenuStrip.ImageScalingSize = new Size(20, 20);
            MenuStrip.Items.AddRange(new ToolStripItem[] { tsmiAvailability, tsmiQuit });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Padding = new Padding(5, 2, 0, 2);
            MenuStrip.Size = new Size(915, 24);
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
            // pnlSearch
            // 
            pnlSearch.BackColor = SystemColors.ControlLight;
            pnlSearch.BorderStyle = BorderStyle.FixedSingle;
            pnlSearch.Controls.Add(cbRoomType);
            pnlSearch.Controls.Add(lblRoomType);
            pnlSearch.Controls.Add(cbRoom);
            pnlSearch.Controls.Add(lblRoom);
            pnlSearch.Controls.Add(btnStaffSearch);
            pnlSearch.Controls.Add(lblStaff);
            pnlSearch.Controls.Add(tbStaff);
            pnlSearch.Controls.Add(dgvStaff);
            pnlSearch.Controls.Add(btnClear);
            pnlSearch.Controls.Add(cbPaid);
            pnlSearch.Controls.Add(lblPaid);
            pnlSearch.Controls.Add(cbCancelled);
            pnlSearch.Controls.Add(lblCancelled);
            pnlSearch.Controls.Add(lblEndDate);
            pnlSearch.Controls.Add(dgvCustomer);
            pnlSearch.Controls.Add(lblBooking);
            pnlSearch.Controls.Add(dtpEndDate);
            pnlSearch.Controls.Add(btnSearch);
            pnlSearch.Controls.Add(dtpStartDate);
            pnlSearch.Controls.Add(btnCustomerSearch);
            pnlSearch.Controls.Add(lblStartDate);
            pnlSearch.Controls.Add(lblCustomerHeader);
            pnlSearch.Controls.Add(tbCustomerName);
            pnlSearch.Location = new Point(12, 27);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(893, 163);
            pnlSearch.TabIndex = 3;
            // 
            // cbRoomType
            // 
            cbRoomType.FormattingEnabled = true;
            cbRoomType.Location = new Point(761, 88);
            cbRoomType.Name = "cbRoomType";
            cbRoomType.Size = new Size(126, 23);
            cbRoomType.TabIndex = 49;
            cbRoomType.SelectedIndexChanged += cbRoomType_SelectedIndexChanged;
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRoomType.Location = new Point(761, 71);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(72, 15);
            lblRoomType.TabIndex = 48;
            lblRoomType.Text = "Room Type:";
            // 
            // cbRoom
            // 
            cbRoom.FormattingEnabled = true;
            cbRoom.Location = new Point(761, 46);
            cbRoom.Name = "cbRoom";
            cbRoom.Size = new Size(126, 23);
            cbRoom.TabIndex = 47;
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRoom.Location = new Point(761, 29);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(56, 15);
            lblRoom.TabIndex = 46;
            lblRoom.Text = "RoomID:";
            // 
            // btnStaffSearch
            // 
            btnStaffSearch.BackColor = SystemColors.ControlLightLight;
            btnStaffSearch.Location = new Point(433, 17);
            btnStaffSearch.Name = "btnStaffSearch";
            btnStaffSearch.Size = new Size(58, 23);
            btnStaffSearch.TabIndex = 45;
            btnStaffSearch.Text = "Search";
            btnStaffSearch.UseVisualStyleBackColor = false;
            btnStaffSearch.Click += btnStaffSearch_Click;
            // 
            // lblStaff
            // 
            lblStaff.AutoSize = true;
            lblStaff.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStaff.Location = new Point(251, 0);
            lblStaff.Name = "lblStaff";
            lblStaff.Size = new Size(167, 15);
            lblStaff.TabIndex = 43;
            lblStaff.Text = "Actioned By: (Staff Member)";
            // 
            // tbStaff
            // 
            tbStaff.Location = new Point(251, 17);
            tbStaff.Name = "tbStaff";
            tbStaff.Size = new Size(176, 23);
            tbStaff.TabIndex = 44;
            // 
            // dgvStaff
            // 
            dgvStaff.AllowUserToAddRows = false;
            dgvStaff.AllowUserToDeleteRows = false;
            dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaff.Location = new Point(251, 46);
            dgvStaff.MultiSelect = false;
            dgvStaff.Name = "dgvStaff";
            dgvStaff.ReadOnly = true;
            dgvStaff.RowHeadersWidth = 51;
            dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStaff.ShowEditingIcon = false;
            dgvStaff.Size = new Size(240, 107);
            dgvStaff.TabIndex = 42;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ControlLightLight;
            btnClear.Location = new Point(764, 130);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(123, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear Search";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // cbPaid
            // 
            cbPaid.FormattingEnabled = true;
            cbPaid.Items.AddRange(new object[] { "Any", "Yes", "No" });
            cbPaid.Location = new Point(629, 88);
            cbPaid.Name = "cbPaid";
            cbPaid.Size = new Size(126, 23);
            cbPaid.TabIndex = 41;
            // 
            // lblPaid
            // 
            lblPaid.AutoSize = true;
            lblPaid.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPaid.Location = new Point(629, 71);
            lblPaid.Name = "lblPaid";
            lblPaid.Size = new Size(47, 15);
            lblPaid.TabIndex = 40;
            lblPaid.Text = "Is Paid?";
            // 
            // cbCancelled
            // 
            cbCancelled.FormattingEnabled = true;
            cbCancelled.Items.AddRange(new object[] { "Any", "Yes", "No" });
            cbCancelled.Location = new Point(629, 46);
            cbCancelled.Name = "cbCancelled";
            cbCancelled.Size = new Size(126, 23);
            cbCancelled.TabIndex = 39;
            // 
            // lblCancelled
            // 
            lblCancelled.AutoSize = true;
            lblCancelled.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCancelled.Location = new Point(629, 29);
            lblCancelled.Name = "lblCancelled";
            lblCancelled.Size = new Size(77, 15);
            lblCancelled.TabIndex = 38;
            lblCancelled.Text = "Is Cancelled?";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEndDate.Location = new Point(497, 71);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(60, 15);
            lblEndDate.TabIndex = 16;
            lblEndDate.Text = "End Date:";
            // 
            // dgvCustomer
            // 
            dgvCustomer.AllowUserToAddRows = false;
            dgvCustomer.AllowUserToDeleteRows = false;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Location = new Point(3, 46);
            dgvCustomer.MultiSelect = false;
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.ReadOnly = true;
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomer.ShowEditingIcon = false;
            dgvCustomer.Size = new Size(240, 107);
            dgvCustomer.TabIndex = 37;
            // 
            // lblBooking
            // 
            lblBooking.AutoSize = true;
            lblBooking.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBooking.Location = new Point(497, 3);
            lblBooking.Name = "lblBooking";
            lblBooking.Size = new Size(126, 15);
            lblBooking.TabIndex = 12;
            lblBooking.Text = "Booking Information:";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(497, 88);
            dtpEndDate.Margin = new Padding(3, 2, 3, 2);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(126, 23);
            dtpEndDate.TabIndex = 15;
            dtpEndDate.Value = new DateTime(2024, 11, 21, 11, 28, 36, 0);
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ControlLightLight;
            btnSearch.Location = new Point(629, 130);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(126, 23);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search Bookings";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(497, 46);
            dtpStartDate.Margin = new Padding(3, 2, 3, 2);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(126, 23);
            dtpStartDate.TabIndex = 13;
            // 
            // btnCustomerSearch
            // 
            btnCustomerSearch.BackColor = SystemColors.ControlLightLight;
            btnCustomerSearch.Location = new Point(185, 17);
            btnCustomerSearch.Name = "btnCustomerSearch";
            btnCustomerSearch.Size = new Size(58, 23);
            btnCustomerSearch.TabIndex = 36;
            btnCustomerSearch.Text = "Search";
            btnCustomerSearch.UseVisualStyleBackColor = false;
            btnCustomerSearch.Click += btnCustomerSearch_Click;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStartDate.Location = new Point(497, 29);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(71, 15);
            lblStartDate.TabIndex = 14;
            lblStartDate.Text = "Start Date: ";
            // 
            // lblCustomerHeader
            // 
            lblCustomerHeader.AutoSize = true;
            lblCustomerHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCustomerHeader.Location = new Point(3, 0);
            lblCustomerHeader.Name = "lblCustomerHeader";
            lblCustomerHeader.Size = new Size(64, 15);
            lblCustomerHeader.TabIndex = 34;
            lblCustomerHeader.Text = "Customer:";
            // 
            // tbCustomerName
            // 
            tbCustomerName.Location = new Point(3, 17);
            tbCustomerName.Name = "tbCustomerName";
            tbCustomerName.Size = new Size(176, 23);
            tbCustomerName.TabIndex = 35;
            // 
            // dgvBooking
            // 
            dgvBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooking.Location = new Point(12, 196);
            dgvBooking.Name = "dgvBooking";
            dgvBooking.ReadOnly = true;
            dgvBooking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooking.Size = new Size(893, 253);
            dgvBooking.TabIndex = 4;
            dgvBooking.DataSourceChanged += dgvBooking_DataSourceChanged;
            // 
            // lblTotalBookings
            // 
            lblTotalBookings.AutoSize = true;
            lblTotalBookings.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalBookings.Location = new Point(797, 454);
            lblTotalBookings.Name = "lblTotalBookings";
            lblTotalBookings.Size = new Size(105, 15);
            lblTotalBookings.TabIndex = 17;
            lblTotalBookings.Text = "x Bookings Found";
            lblTotalBookings.TextAlign = ContentAlignment.MiddleRight;
            lblTotalBookings.Visible = false;
            // 
            // ViewBookings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 478);
            Controls.Add(lblTotalBookings);
            Controls.Add(dgvBooking);
            Controls.Add(pnlSearch);
            Controls.Add(MenuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewBookings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Bookings";
            FormClosing += ViewBookings_FormClosing;
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooking).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuStrip;
        private ToolStripMenuItem tsmiAvailability;
        private ToolStripMenuItem tsmiQuit;
        private Panel pnlSearch;
        private Button btnSearch;
        private DataGridView dgvBooking;
        private Button btnClear;
        private DataGridView dgvCustomer;
        private Button btnCustomerSearch;
        private Label lblCustomerHeader;
        private TextBox tbCustomerName;
        private Label lblEndDate;
        private Label lblBooking;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private Label lblStartDate;
        private ComboBox cbPaid;
        private Label lblPaid;
        private ComboBox cbCancelled;
        private Label lblCancelled;
        private Button btnStaffSearch;
        private Label lblStaff;
        private TextBox tbStaff;
        private DataGridView dgvStaff;
        private ComboBox cbRoomType;
        private Label lblRoomType;
        private ComboBox cbRoom;
        private Label lblRoom;
        private Label lblTotalBookings;
    }
}