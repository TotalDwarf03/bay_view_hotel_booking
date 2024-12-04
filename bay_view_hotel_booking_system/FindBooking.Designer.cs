namespace bay_view_hotel_booking_system
{
    partial class FindBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindBooking));
            MenuStrip = new MenuStrip();
            tsmiAvailability = new ToolStripMenuItem();
            tsmiQuit = new ToolStripMenuItem();
            dgvCustomer = new DataGridView();
            btnCustomerSearch = new Button();
            tbCustomerName = new TextBox();
            lblCustomerHeader = new Label();
            pnlCustomer = new Panel();
            btnLoadCustomerBooking = new Button();
            pnlBooking = new Panel();
            btnEditBooking = new Button();
            lblBooking = new Label();
            dgvBooking = new DataGridView();
            lblNextPage = new Label();
            MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            pnlCustomer.SuspendLayout();
            pnlBooking.SuspendLayout();
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
            MenuStrip.Size = new Size(684, 24);
            MenuStrip.TabIndex = 3;
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
            dgvCustomer.Size = new Size(282, 158);
            dgvCustomer.TabIndex = 37;
            // 
            // btnCustomerSearch
            // 
            btnCustomerSearch.BackColor = SystemColors.ControlLightLight;
            btnCustomerSearch.Location = new Point(220, 15);
            btnCustomerSearch.Name = "btnCustomerSearch";
            btnCustomerSearch.Size = new Size(65, 23);
            btnCustomerSearch.TabIndex = 36;
            btnCustomerSearch.Text = "Search";
            btnCustomerSearch.UseVisualStyleBackColor = false;
            btnCustomerSearch.Click += btnCustomerSearch_Click;
            // 
            // tbCustomerName
            // 
            tbCustomerName.Location = new Point(3, 16);
            tbCustomerName.Name = "tbCustomerName";
            tbCustomerName.Size = new Size(212, 23);
            tbCustomerName.TabIndex = 35;
            tbCustomerName.KeyPress += tbCustomerName_KeyPress;
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
            // pnlCustomer
            // 
            pnlCustomer.BackColor = SystemColors.ControlLight;
            pnlCustomer.BorderStyle = BorderStyle.FixedSingle;
            pnlCustomer.Controls.Add(btnLoadCustomerBooking);
            pnlCustomer.Controls.Add(lblCustomerHeader);
            pnlCustomer.Controls.Add(dgvCustomer);
            pnlCustomer.Controls.Add(tbCustomerName);
            pnlCustomer.Controls.Add(btnCustomerSearch);
            pnlCustomer.Location = new Point(10, 25);
            pnlCustomer.Margin = new Padding(3, 2, 3, 2);
            pnlCustomer.Name = "pnlCustomer";
            pnlCustomer.Size = new Size(289, 240);
            pnlCustomer.TabIndex = 38;
            // 
            // btnLoadCustomerBooking
            // 
            btnLoadCustomerBooking.BackColor = SystemColors.ControlLightLight;
            btnLoadCustomerBooking.Location = new Point(54, 209);
            btnLoadCustomerBooking.Name = "btnLoadCustomerBooking";
            btnLoadCustomerBooking.Size = new Size(180, 23);
            btnLoadCustomerBooking.TabIndex = 38;
            btnLoadCustomerBooking.Text = "Load Customer's Bookings";
            btnLoadCustomerBooking.UseVisualStyleBackColor = false;
            btnLoadCustomerBooking.Click += btnLoadCustomerBooking_Click;
            // 
            // pnlBooking
            // 
            pnlBooking.BackColor = SystemColors.ControlLight;
            pnlBooking.BorderStyle = BorderStyle.FixedSingle;
            pnlBooking.Controls.Add(btnEditBooking);
            pnlBooking.Controls.Add(lblBooking);
            pnlBooking.Controls.Add(dgvBooking);
            pnlBooking.Location = new Point(318, 25);
            pnlBooking.Margin = new Padding(3, 2, 3, 2);
            pnlBooking.Name = "pnlBooking";
            pnlBooking.Size = new Size(354, 240);
            pnlBooking.TabIndex = 39;
            // 
            // btnEditBooking
            // 
            btnEditBooking.BackColor = SystemColors.ControlLightLight;
            btnEditBooking.Location = new Point(87, 209);
            btnEditBooking.Name = "btnEditBooking";
            btnEditBooking.Size = new Size(180, 23);
            btnEditBooking.TabIndex = 38;
            btnEditBooking.Text = "Load Booking";
            btnEditBooking.UseVisualStyleBackColor = false;
            btnEditBooking.Click += btnEditBooking_Click;
            // 
            // lblBooking
            // 
            lblBooking.AutoSize = true;
            lblBooking.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBooking.Location = new Point(3, 0);
            lblBooking.Name = "lblBooking";
            lblBooking.Size = new Size(61, 15);
            lblBooking.TabIndex = 34;
            lblBooking.Text = "Bookings:";
            // 
            // dgvBooking
            // 
            dgvBooking.AllowUserToAddRows = false;
            dgvBooking.AllowUserToDeleteRows = false;
            dgvBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooking.Location = new Point(3, 18);
            dgvBooking.MultiSelect = false;
            dgvBooking.Name = "dgvBooking";
            dgvBooking.ReadOnly = true;
            dgvBooking.RowHeadersWidth = 51;
            dgvBooking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooking.ShowEditingIcon = false;
            dgvBooking.Size = new Size(346, 185);
            dgvBooking.TabIndex = 37;
            // 
            // lblNextPage
            // 
            lblNextPage.AutoSize = true;
            lblNextPage.Location = new Point(277, 294);
            lblNextPage.Name = "lblNextPage";
            lblNextPage.Size = new Size(38, 15);
            lblNextPage.TabIndex = 40;
            lblNextPage.Text = "label1";
            lblNextPage.Visible = false;
            // 
            // FindBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 340);
            Controls.Add(lblNextPage);
            Controls.Add(pnlBooking);
            Controls.Add(pnlCustomer);
            Controls.Add(MenuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FindBooking";
            Text = "Find Booking";
            FormClosing += EditBooking_FormClosing;
            VisibleChanged += FindBooking_VisibleChanged;
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            pnlCustomer.ResumeLayout(false);
            pnlCustomer.PerformLayout();
            pnlBooking.ResumeLayout(false);
            pnlBooking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooking).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuStrip;
        private ToolStripMenuItem tsmiAvailability;
        private ToolStripMenuItem tsmiQuit;
        private DataGridView dgvCustomer;
        private Button btnCustomerSearch;
        private TextBox tbCustomerName;
        private Label lblCustomerHeader;
        private Panel pnlCustomer;
        private Button btnLoadCustomerBooking;
        private Panel pnlBooking;
        private Button btnEditBooking;
        private Label lblBooking;
        private DataGridView dgvBooking;
        private Label lblNextPage;
    }
}