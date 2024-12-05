namespace bay_view_hotel_booking_system
{
    partial class BookingAvailability
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingAvailability));
            MenuStrip = new MenuStrip();
            tsmiViewBookings = new ToolStripMenuItem();
            tsmiEditBooking = new ToolStripMenuItem();
            tsmiQuit = new ToolStripMenuItem();
            dtpStartDate = new DateTimePicker();
            lblStartDate = new Label();
            lblEndDate = new Label();
            dtpEndDate = new DateTimePicker();
            lblAvailability = new Label();
            dgvAvailability = new DataGridView();
            lblRoomType = new Label();
            cbRoomType = new ComboBox();
            btnSearch = new Button();
            btnBook = new Button();
            cbDisabled = new ComboBox();
            lblDisabled = new Label();
            lblRoomsAvailable = new Label();
            MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailability).BeginInit();
            SuspendLayout();
            // 
            // MenuStrip
            // 
            MenuStrip.ImageScalingSize = new Size(20, 20);
            MenuStrip.Items.AddRange(new ToolStripItem[] { tsmiViewBookings, tsmiEditBooking, tsmiQuit });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Padding = new Padding(5, 2, 0, 2);
            MenuStrip.Size = new Size(684, 24);
            MenuStrip.TabIndex = 1;
            MenuStrip.Text = "menuStrip1";
            // 
            // tsmiViewBookings
            // 
            tsmiViewBookings.Name = "tsmiViewBookings";
            tsmiViewBookings.Size = new Size(96, 20);
            tsmiViewBookings.Text = "View Bookings";
            tsmiViewBookings.Click += tsmiViewBookings_Click;
            // 
            // tsmiEditBooking
            // 
            tsmiEditBooking.Name = "tsmiEditBooking";
            tsmiEditBooking.Size = new Size(89, 20);
            tsmiEditBooking.Text = "Find Booking";
            tsmiEditBooking.Click += tsmiEditBooking_Click;
            // 
            // tsmiQuit
            // 
            tsmiQuit.Name = "tsmiQuit";
            tsmiQuit.Size = new Size(130, 20);
            tsmiQuit.Text = "Return to Homepage";
            tsmiQuit.Click += tsmiQuit_Click;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(10, 38);
            dtpStartDate.Margin = new Padding(3, 2, 3, 2);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(150, 23);
            dtpStartDate.TabIndex = 3;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStartDate.Location = new Point(10, 21);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(71, 15);
            lblStartDate.TabIndex = 4;
            lblStartDate.Text = "Start Date: ";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEndDate.Location = new Point(166, 21);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(60, 15);
            lblEndDate.TabIndex = 6;
            lblEndDate.Text = "End Date:";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(166, 38);
            dtpEndDate.Margin = new Padding(3, 2, 3, 2);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(150, 23);
            dtpEndDate.TabIndex = 5;
            dtpEndDate.Value = new DateTime(2024, 11, 21, 11, 28, 36, 0);
            // 
            // lblAvailability
            // 
            lblAvailability.AutoSize = true;
            lblAvailability.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAvailability.Location = new Point(10, 100);
            lblAvailability.Name = "lblAvailability";
            lblAvailability.Size = new Size(48, 15);
            lblAvailability.TabIndex = 8;
            lblAvailability.Text = "Rooms:";
            // 
            // dgvAvailability
            // 
            dgvAvailability.AllowUserToAddRows = false;
            dgvAvailability.AllowUserToDeleteRows = false;
            dgvAvailability.AllowUserToOrderColumns = true;
            dgvAvailability.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAvailability.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailability.Location = new Point(10, 118);
            dgvAvailability.Margin = new Padding(3, 2, 3, 2);
            dgvAvailability.MultiSelect = false;
            dgvAvailability.Name = "dgvAvailability";
            dgvAvailability.ReadOnly = true;
            dgvAvailability.RowHeadersWidth = 51;
            dgvAvailability.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAvailability.Size = new Size(663, 184);
            dgvAvailability.TabIndex = 9;
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRoomType.Location = new Point(322, 21);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(72, 15);
            lblRoomType.TabIndex = 10;
            lblRoomType.Text = "Room Type:";
            // 
            // cbRoomType
            // 
            cbRoomType.FormattingEnabled = true;
            cbRoomType.Location = new Point(322, 38);
            cbRoomType.Margin = new Padding(3, 2, 3, 2);
            cbRoomType.Name = "cbRoomType";
            cbRoomType.Size = new Size(150, 23);
            cbRoomType.TabIndex = 11;
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.Location = new Point(10, 70);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 25);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnBook
            // 
            btnBook.AutoSize = true;
            btnBook.Location = new Point(12, 307);
            btnBook.Margin = new Padding(3, 2, 3, 2);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(147, 25);
            btnBook.TabIndex = 13;
            btnBook.Text = "Create Booking";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // cbDisabled
            // 
            cbDisabled.FormattingEnabled = true;
            cbDisabled.Items.AddRange(new object[] { "Any", "Yes", "No" });
            cbDisabled.Location = new Point(478, 38);
            cbDisabled.Margin = new Padding(3, 2, 3, 2);
            cbDisabled.Name = "cbDisabled";
            cbDisabled.Size = new Size(150, 23);
            cbDisabled.TabIndex = 15;
            // 
            // lblDisabled
            // 
            lblDisabled.AutoSize = true;
            lblDisabled.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDisabled.Location = new Point(478, 21);
            lblDisabled.Name = "lblDisabled";
            lblDisabled.Size = new Size(95, 15);
            lblDisabled.TabIndex = 14;
            lblDisabled.Text = "Disabled Room?";
            // 
            // lblRoomsAvailable
            // 
            lblRoomsAvailable.AutoSize = true;
            lblRoomsAvailable.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRoomsAvailable.Location = new Point(564, 307);
            lblRoomsAvailable.Name = "lblRoomsAvailable";
            lblRoomsAvailable.Size = new Size(108, 15);
            lblRoomsAvailable.TabIndex = 16;
            lblRoomsAvailable.Text = "x Rooms Available";
            lblRoomsAvailable.TextAlign = ContentAlignment.MiddleRight;
            lblRoomsAvailable.Visible = false;
            // 
            // BookingAvailability
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 340);
            Controls.Add(lblRoomsAvailable);
            Controls.Add(cbDisabled);
            Controls.Add(lblDisabled);
            Controls.Add(btnBook);
            Controls.Add(btnSearch);
            Controls.Add(cbRoomType);
            Controls.Add(lblRoomType);
            Controls.Add(dgvAvailability);
            Controls.Add(lblAvailability);
            Controls.Add(lblEndDate);
            Controls.Add(dtpEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(dtpStartDate);
            Controls.Add(MenuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = MenuStrip;
            Margin = new Padding(3, 2, 3, 2);
            Name = "BookingAvailability";
            Text = "Booking Management: Availability";
            FormClosing += AddBooking_FormClosing;
            VisibleChanged += BookingAvailability_VisibleChanged;
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailability).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuStrip;
        private ToolStripMenuItem tsmiEditBooking;
        private ToolStripMenuItem tsmiQuit;
        private DateTimePicker dtpStartDate;
        private Label lblStartDate;
        private Label lblEndDate;
        private DateTimePicker dtpEndDate;
        private Label lblAvailability;
        private DataGridView dgvAvailability;
        private Label lblRoomType;
        private ComboBox cbRoomType;
        private Button btnSearch;
        private Button btnBook;
        private ComboBox cbDisabled;
        private Label lblDisabled;
        private Label lblRoomsAvailable;
        private ToolStripMenuItem tsmiViewBookings;
    }
}