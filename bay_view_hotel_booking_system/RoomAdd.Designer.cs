namespace bay_view_hotel_booking_system
{
    partial class RoomAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomAdd));
            menuStrip1 = new MenuStrip();
            viewRoomsToolStripMenuItem = new ToolStripMenuItem();
            returnToHomepageToolStripMenuItem = new ToolStripMenuItem();
            pnlEditCustomer = new Panel();
            cbDisabled = new ComboBox();
            lblRoomType = new Label();
            btnSave = new Button();
            rType = new ComboBox();
            label7 = new Label();
            txtCapacity = new TextBox();
            cbStatus = new ComboBox();
            lblCapacity = new Label();
            lblStatus = new Label();
            txtPrice = new TextBox();
            lblPrice = new Label();
            menuStrip1.SuspendLayout();
            pnlEditCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { viewRoomsToolStripMenuItem, returnToHomepageToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(684, 24);
            menuStrip1.TabIndex = 15;
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
            // pnlEditCustomer
            // 
            pnlEditCustomer.BackColor = SystemColors.ControlLight;
            pnlEditCustomer.BorderStyle = BorderStyle.FixedSingle;
            pnlEditCustomer.Controls.Add(cbDisabled);
            pnlEditCustomer.Controls.Add(lblRoomType);
            pnlEditCustomer.Controls.Add(btnSave);
            pnlEditCustomer.Controls.Add(rType);
            pnlEditCustomer.Controls.Add(label7);
            pnlEditCustomer.Controls.Add(txtCapacity);
            pnlEditCustomer.Controls.Add(cbStatus);
            pnlEditCustomer.Controls.Add(lblCapacity);
            pnlEditCustomer.Controls.Add(lblStatus);
            pnlEditCustomer.Controls.Add(txtPrice);
            pnlEditCustomer.Controls.Add(lblPrice);
            pnlEditCustomer.Location = new Point(12, 26);
            pnlEditCustomer.Margin = new Padding(3, 2, 3, 2);
            pnlEditCustomer.Name = "pnlEditCustomer";
            pnlEditCustomer.Size = new Size(421, 133);
            pnlEditCustomer.TabIndex = 19;
            // 
            // cbDisabled
            // 
            cbDisabled.FormattingEnabled = true;
            cbDisabled.Items.AddRange(new object[] { "Yes", "No" });
            cbDisabled.Location = new Point(281, 24);
            cbDisabled.Name = "cbDisabled";
            cbDisabled.Size = new Size(133, 23);
            cbDisabled.TabIndex = 17;
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRoomType.Location = new Point(142, 6);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(72, 15);
            lblRoomType.TabIndex = 0;
            lblRoomType.Text = "Room Type:";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ControlLightLight;
            btnSave.Location = new Point(142, 97);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 23);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnAdd_Click;
            // 
            // rType
            // 
            rType.FormattingEnabled = true;
            rType.Items.AddRange(new object[] { "Single", "Double", "Family" });
            rType.Location = new Point(142, 24);
            rType.Name = "rType";
            rType.Size = new Size(133, 23);
            rType.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(281, 6);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 12;
            label7.Text = "Disabled Room:";
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(142, 68);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(133, 23);
            txtCapacity.TabIndex = 11;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Available", "Under Refurbishment", "Off Sale" });
            cbStatus.Location = new Point(3, 24);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(133, 23);
            cbStatus.TabIndex = 6;
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCapacity.Location = new Point(142, 50);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(56, 15);
            lblCapacity.TabIndex = 10;
            lblCapacity.Text = "Capacity:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.Location = new Point(3, 6);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(81, 15);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Room Status:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(3, 68);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(133, 23);
            txtPrice.TabIndex = 9;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPrice.Location = new Point(3, 50);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(94, 15);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price Per Night:";
            // 
            // RoomAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 340);
            Controls.Add(pnlEditCustomer);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "RoomAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Room";
            FormClosing += RoomAdd_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlEditCustomer.ResumeLayout(false);
            pnlEditCustomer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem viewRoomsToolStripMenuItem;
        private ToolStripMenuItem returnToHomepageToolStripMenuItem;
        private Panel pnlEditCustomer;
        private ComboBox cbDisabled;
        private Label lblRoomType;
        private Button btnSave;
        private ComboBox rType;
        private Label label7;
        private TextBox txtCapacity;
        private ComboBox cbStatus;
        private Label lblCapacity;
        private Label lblStatus;
        private TextBox txtPrice;
        private Label lblPrice;
    }
}