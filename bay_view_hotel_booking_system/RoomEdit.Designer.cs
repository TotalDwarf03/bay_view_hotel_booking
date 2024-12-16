namespace bay_view_hotel_booking_system
{
    partial class RoomEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomEdit));
            lblRoomType = new Label();
            cbType = new ComboBox();
            menuStrip1 = new MenuStrip();
            viewRoomsToolStripMenuItem = new ToolStripMenuItem();
            returnToHomepageToolStripMenuItem = new ToolStripMenuItem();
            lblRoomID = new Label();
            txtID = new TextBox();
            cbStatus = new ComboBox();
            lblStatus = new Label();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblCapacity = new Label();
            txtCapacity = new TextBox();
            label1 = new Label();
            btnSave = new Button();
            cbDisabled = new ComboBox();
            pnlEditCustomer = new Panel();
            menuStrip1.SuspendLayout();
            pnlEditCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRoomType.Location = new Point(142, 71);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(72, 15);
            lblRoomType.TabIndex = 0;
            lblRoomType.Text = "Room Type:";
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "Single", "Double", "Family" });
            cbType.Location = new Point(142, 89);
            cbType.Name = "cbType";
            cbType.Size = new Size(133, 23);
            cbType.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { viewRoomsToolStripMenuItem, returnToHomepageToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(684, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // viewRoomsToolStripMenuItem
            // 
            viewRoomsToolStripMenuItem.Name = "viewRoomsToolStripMenuItem";
            viewRoomsToolStripMenuItem.Size = new Size(84, 20);
            viewRoomsToolStripMenuItem.Text = "View Rooms";
            viewRoomsToolStripMenuItem.Click += viewRoomsToolStripMenuItem_Click;
            // 
            // returnToHomepageToolStripMenuItem
            // 
            returnToHomepageToolStripMenuItem.Name = "returnToHomepageToolStripMenuItem";
            returnToHomepageToolStripMenuItem.Size = new Size(130, 20);
            returnToHomepageToolStripMenuItem.Text = "Return to Homepage";
            returnToHomepageToolStripMenuItem.Click += returnToHomepageToolStripMenuItem_Click;
            // 
            // lblRoomID
            // 
            lblRoomID.AutoSize = true;
            lblRoomID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRoomID.Location = new Point(3, 9);
            lblRoomID.Name = "lblRoomID";
            lblRoomID.Size = new Size(59, 15);
            lblRoomID.TabIndex = 4;
            lblRoomID.Text = "Room ID:";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(3, 27);
            txtID.Name = "txtID";
            txtID.Size = new Size(133, 23);
            txtID.TabIndex = 5;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Available", "Under Refurbishment", "Off Sale" });
            cbStatus.Location = new Point(3, 89);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(133, 23);
            cbStatus.TabIndex = 6;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.Location = new Point(3, 71);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(81, 15);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Room Status:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPrice.Location = new Point(3, 115);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(94, 15);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price Per Night:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(3, 133);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(133, 23);
            txtPrice.TabIndex = 9;
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCapacity.Location = new Point(142, 115);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(56, 15);
            lblCapacity.TabIndex = 10;
            lblCapacity.Text = "Capacity:";
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(142, 133);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(133, 23);
            txtCapacity.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(281, 71);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 12;
            label1.Text = "Disabled Room:";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ControlLightLight;
            btnSave.Location = new Point(142, 162);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 23);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // cbDisabled
            // 
            cbDisabled.FormattingEnabled = true;
            cbDisabled.Items.AddRange(new object[] { "Yes", "No" });
            cbDisabled.Location = new Point(281, 89);
            cbDisabled.Name = "cbDisabled";
            cbDisabled.Size = new Size(133, 23);
            cbDisabled.TabIndex = 17;
            // 
            // pnlEditCustomer
            // 
            pnlEditCustomer.BackColor = SystemColors.ControlLight;
            pnlEditCustomer.BorderStyle = BorderStyle.FixedSingle;
            pnlEditCustomer.Controls.Add(cbDisabled);
            pnlEditCustomer.Controls.Add(txtID);
            pnlEditCustomer.Controls.Add(lblRoomType);
            pnlEditCustomer.Controls.Add(btnSave);
            pnlEditCustomer.Controls.Add(cbType);
            pnlEditCustomer.Controls.Add(label1);
            pnlEditCustomer.Controls.Add(lblRoomID);
            pnlEditCustomer.Controls.Add(txtCapacity);
            pnlEditCustomer.Controls.Add(cbStatus);
            pnlEditCustomer.Controls.Add(lblCapacity);
            pnlEditCustomer.Controls.Add(lblStatus);
            pnlEditCustomer.Controls.Add(txtPrice);
            pnlEditCustomer.Controls.Add(lblPrice);
            pnlEditCustomer.Location = new Point(12, 26);
            pnlEditCustomer.Margin = new Padding(3, 2, 3, 2);
            pnlEditCustomer.Name = "pnlEditCustomer";
            pnlEditCustomer.Size = new Size(421, 194);
            pnlEditCustomer.TabIndex = 18;
            // 
            // RoomEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 340);
            Controls.Add(menuStrip1);
            Controls.Add(pnlEditCustomer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "RoomEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Room";
            FormClosing += editroom_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlEditCustomer.ResumeLayout(false);
            pnlEditCustomer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRoomType;
        private ComboBox cbType;
        private MenuStrip menuStrip1;
        private Label lblRoomID;
        private TextBox txtID;
        private ComboBox cbStatus;
        private Label lblStatus;
        private ToolStripMenuItem viewRoomsToolStripMenuItem;
        private ToolStripMenuItem returnToHomepageToolStripMenuItem;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblCapacity;
        private TextBox txtCapacity;
        private Label label1;
        private Button btnSave;
        private ComboBox cbDisabled;
        private Panel pnlEditCustomer;
    }
}