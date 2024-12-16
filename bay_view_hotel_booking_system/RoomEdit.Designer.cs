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
            lblRoomType = new Label();
            cbType = new ComboBox();
            lblEditRoom = new Label();
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
            btnCancel = new Button();
            cbDisabled = new ComboBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Location = new Point(79, 131);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(69, 15);
            lblRoomType.TabIndex = 0;
            lblRoomType.Text = "Room Type:";
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "Single", "Double", "Family" });
            cbType.Location = new Point(160, 128);
            cbType.Name = "cbType";
            cbType.Size = new Size(133, 23);
            cbType.TabIndex = 1;
            // 
            // lblEditRoom
            // 
            lblEditRoom.AutoSize = true;
            lblEditRoom.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditRoom.Location = new Point(207, 45);
            lblEditRoom.Name = "lblEditRoom";
            lblEditRoom.Size = new Size(104, 25);
            lblEditRoom.TabIndex = 2;
            lblEditRoom.Text = "Edit Room";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { viewRoomsToolStripMenuItem, returnToHomepageToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(546, 24);
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
            // 
            // lblRoomID
            // 
            lblRoomID.AutoSize = true;
            lblRoomID.Location = new Point(92, 97);
            lblRoomID.Name = "lblRoomID";
            lblRoomID.Size = new Size(56, 15);
            lblRoomID.TabIndex = 4;
            lblRoomID.Text = "Room ID:";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(160, 94);
            txtID.Name = "txtID";
            txtID.Size = new Size(133, 23);
            txtID.TabIndex = 5;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Available", "Under Refurbishment", "Off Sale" });
            cbStatus.Location = new Point(160, 163);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(133, 23);
            cbStatus.TabIndex = 6;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(71, 166);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(77, 15);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Room Status:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(112, 200);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(36, 15);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(160, 197);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(133, 23);
            txtPrice.TabIndex = 9;
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Location = new Point(92, 232);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(56, 15);
            lblCapacity.TabIndex = 10;
            lblCapacity.Text = "Capacity:";
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(160, 229);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(133, 23);
            txtCapacity.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 266);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 12;
            label1.Text = "Disabled Room:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(395, 133);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(395, 180);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += button2_Click;
            // 
            // cbDisabled
            // 
            cbDisabled.FormattingEnabled = true;
            cbDisabled.Items.AddRange(new object[] { "Yes", "No" });
            cbDisabled.Location = new Point(160, 266);
            cbDisabled.Name = "cbDisabled";
            cbDisabled.Size = new Size(133, 23);
            cbDisabled.TabIndex = 17;
            // 
            // editroom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 338);
            Controls.Add(cbDisabled);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(txtCapacity);
            Controls.Add(lblCapacity);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(lblStatus);
            Controls.Add(cbStatus);
            Controls.Add(txtID);
            Controls.Add(lblRoomID);
            Controls.Add(lblEditRoom);
            Controls.Add(cbType);
            Controls.Add(lblRoomType);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "editroom";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRoomType;
        private ComboBox cbType;
        private Label lblEditRoom;
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
        private Button btnCancel;
        private ComboBox cbDisabled;
    }
}