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
            tsmiAvailability = new ToolStripMenuItem();
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
            MenuStrip.Items.AddRange(new ToolStripItem[] { tsmiAvailability, tsmiEditBooking, tsmiQuit });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Padding = new Padding(6, 3, 0, 3);
            MenuStrip.Size = new Size(782, 30);
            MenuStrip.TabIndex = 1;
            MenuStrip.Text = "menuStrip1";
            // 
            // tsmiAvailability
            // 
            tsmiAvailability.Name = "tsmiAvailability";
            tsmiAvailability.Size = new Size(133, 24);
            tsmiAvailability.Text = "View Availability";
            // 
            // tsmiEditBooking
            // 
            tsmiEditBooking.Name = "tsmiEditBooking";
            tsmiEditBooking.Size = new Size(108, 24);
            tsmiEditBooking.Text = "Edit Booking";
            tsmiEditBooking.Click += tsmiEditBooking_Click;
            // 
            // tsmiQuit
            // 
            tsmiQuit.Name = "tsmiQuit";
            tsmiQuit.Size = new Size(163, 24);
            tsmiQuit.Text = "Return to Homepage";
            tsmiQuit.Click += tsmiQuit_Click;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(11, 51);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(171, 27);
            dtpStartDate.TabIndex = 3;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStartDate.Location = new Point(11, 28);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(88, 20);
            lblStartDate.TabIndex = 4;
            lblStartDate.Text = "Start Date: ";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEndDate.Location = new Point(190, 28);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(76, 20);
            lblEndDate.TabIndex = 6;
            lblEndDate.Text = "End Date:";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(190, 51);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(171, 27);
            dtpEndDate.TabIndex = 5;
            dtpEndDate.Value = new DateTime(2024, 11, 21, 11, 28, 36, 0);
            // 
            // lblAvailability
            // 
            lblAvailability.AutoSize = true;
            lblAvailability.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAvailability.Location = new Point(11, 133);
            lblAvailability.Name = "lblAvailability";
            lblAvailability.Size = new Size(62, 20);
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
            dgvAvailability.Location = new Point(11, 157);
            dgvAvailability.MultiSelect = false;
            dgvAvailability.Name = "dgvAvailability";
            dgvAvailability.ReadOnly = true;
            dgvAvailability.RowHeadersWidth = 51;
            dgvAvailability.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAvailability.Size = new Size(758, 245);
            dgvAvailability.TabIndex = 9;
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRoomType.Location = new Point(368, 28);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(92, 20);
            lblRoomType.TabIndex = 10;
            lblRoomType.Text = "Room Type:";
            // 
            // cbRoomType
            // 
            cbRoomType.FormattingEnabled = true;
            cbRoomType.Location = new Point(368, 51);
            cbRoomType.Name = "cbRoomType";
            cbRoomType.Size = new Size(171, 28);
            cbRoomType.TabIndex = 11;
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.Location = new Point(11, 93);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 33);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnBook
            // 
            btnBook.AutoSize = true;
            btnBook.Location = new Point(14, 409);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(168, 33);
            btnBook.TabIndex = 13;
            btnBook.Text = "Create Booking";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // cbDisabled
            // 
            cbDisabled.FormattingEnabled = true;
            cbDisabled.Items.AddRange(new object[] { "Any", "Yes", "No" });
            cbDisabled.Location = new Point(546, 51);
            cbDisabled.Name = "cbDisabled";
            cbDisabled.Size = new Size(171, 28);
            cbDisabled.TabIndex = 15;
            // 
            // lblDisabled
            // 
            lblDisabled.AutoSize = true;
            lblDisabled.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDisabled.Location = new Point(546, 28);
            lblDisabled.Name = "lblDisabled";
            lblDisabled.Size = new Size(122, 20);
            lblDisabled.TabIndex = 14;
            lblDisabled.Text = "Disabled Room?";
            // 
            // lblRoomsAvailable
            // 
            lblRoomsAvailable.AutoSize = true;
            lblRoomsAvailable.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRoomsAvailable.Location = new Point(645, 409);
            lblRoomsAvailable.Name = "lblRoomsAvailable";
            lblRoomsAvailable.Size = new Size(138, 20);
            lblRoomsAvailable.TabIndex = 16;
            lblRoomsAvailable.Text = "x Rooms Available";
            lblRoomsAvailable.TextAlign = ContentAlignment.MiddleRight;
            lblRoomsAvailable.Visible = false;
            // 
            // BookingAvailability
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
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
        private ToolStripMenuItem tsmiAvailability;
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
    }
}