namespace bay_view_hotel_booking_system
{
    partial class AddBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBooking));
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
            MenuStrip.Size = new Size(782, 28);
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
            // 
            // tsmiQuit
            // 
            tsmiQuit.Name = "tsmiQuit";
            tsmiQuit.Size = new Size(51, 24);
            tsmiQuit.Text = "Quit";
            tsmiQuit.Click += tsmiQuit_Click;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(12, 51);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(230, 27);
            dtpStartDate.TabIndex = 3;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStartDate.Location = new Point(12, 28);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(88, 20);
            lblStartDate.TabIndex = 4;
            lblStartDate.Text = "Start Date: ";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEndDate.Location = new Point(248, 28);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(76, 20);
            lblEndDate.TabIndex = 6;
            lblEndDate.Text = "End Date:";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(248, 51);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(230, 27);
            dtpEndDate.TabIndex = 5;
            dtpEndDate.Value = new DateTime(2024, 11, 21, 11, 28, 36, 0);
            // 
            // lblAvailability
            // 
            lblAvailability.AutoSize = true;
            lblAvailability.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAvailability.Location = new Point(12, 134);
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
            dgvAvailability.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailability.Location = new Point(12, 157);
            dgvAvailability.MultiSelect = false;
            dgvAvailability.Name = "dgvAvailability";
            dgvAvailability.ReadOnly = true;
            dgvAvailability.RowHeadersWidth = 51;
            dgvAvailability.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAvailability.Size = new Size(758, 284);
            dgvAvailability.TabIndex = 9;
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRoomType.Location = new Point(484, 28);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(92, 20);
            lblRoomType.TabIndex = 10;
            lblRoomType.Text = "Room Type:";
            // 
            // cbRoomType
            // 
            cbRoomType.FormattingEnabled = true;
            cbRoomType.Location = new Point(484, 50);
            cbRoomType.Name = "cbRoomType";
            cbRoomType.Size = new Size(230, 28);
            cbRoomType.TabIndex = 11;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(12, 93);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // AddBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
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
            Name = "AddBooking";
            Text = "Booking Management: Availability";
            FormClosing += AddBooking_FormClosing;
            Load += AddBooking_Load;
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
    }
}