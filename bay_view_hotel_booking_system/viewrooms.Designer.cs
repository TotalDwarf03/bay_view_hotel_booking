namespace bay_view_hotel_booking_system
{
    partial class viewrooms
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
            dgRoom = new DataGridView();
            menuStrip1 = new MenuStrip();
            addRoomToolStripMenuItem = new ToolStripMenuItem();
            returnToHomepageToolStripMenuItem = new ToolStripMenuItem();
            lblRoomType = new Label();
            rType = new ComboBox();
            btnSearch = new Button();
            lblDisabled = new Label();
            lblRooms = new Label();
            lblEdit = new Button();
            cbDisabled = new ComboBox();
            lblStatus = new Label();
            cbStatus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgRoom).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgRoom
            // 
            dgRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgRoom.Location = new Point(10, 118);
            dgRoom.Margin = new Padding(3, 2, 3, 2);
            dgRoom.Name = "dgRoom";
            dgRoom.RowHeadersWidth = 51;
            dgRoom.Size = new Size(663, 184);
            dgRoom.TabIndex = 0;
            dgRoom.CellContentClick += dataGridView1_CellContentClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addRoomToolStripMenuItem, returnToHomepageToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(684, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // addRoomToolStripMenuItem
            // 
            addRoomToolStripMenuItem.Name = "addRoomToolStripMenuItem";
            addRoomToolStripMenuItem.Size = new Size(76, 20);
            addRoomToolStripMenuItem.Text = "Add Room";
            addRoomToolStripMenuItem.Click += addRoomToolStripMenuItem_Click;
            // 
            // returnToHomepageToolStripMenuItem
            // 
            returnToHomepageToolStripMenuItem.Name = "returnToHomepageToolStripMenuItem";
            returnToHomepageToolStripMenuItem.Size = new Size(130, 20);
            returnToHomepageToolStripMenuItem.Text = "Return to Homepage";
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRoomType.Location = new Point(10, 21);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(72, 15);
            lblRoomType.TabIndex = 2;
            lblRoomType.Text = "Room Type:";
            // 
            // rType
            // 
            rType.AllowDrop = true;
            rType.FormattingEnabled = true;
            rType.Items.AddRange(new object[] { "All", "Single", "Double", "Family" });
            rType.Location = new Point(10, 38);
            rType.Margin = new Padding(3, 2, 3, 2);
            rType.Name = "rType";
            rType.Size = new Size(150, 23);
            rType.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(10, 70);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 22);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblDisabled
            // 
            lblDisabled.AutoSize = true;
            lblDisabled.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDisabled.Location = new Point(322, 21);
            lblDisabled.Name = "lblDisabled";
            lblDisabled.Size = new Size(95, 15);
            lblDisabled.TabIndex = 5;
            lblDisabled.Text = "Disabled Room?";
            // 
            // lblRooms
            // 
            lblRooms.AutoSize = true;
            lblRooms.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRooms.Location = new Point(10, 100);
            lblRooms.Name = "lblRooms";
            lblRooms.Size = new Size(48, 15);
            lblRooms.TabIndex = 6;
            lblRooms.Text = "Rooms:";
            // 
            // lblEdit
            // 
            lblEdit.Location = new Point(12, 307);
            lblEdit.Margin = new Padding(3, 2, 3, 2);
            lblEdit.Name = "lblEdit";
            lblEdit.Size = new Size(147, 25);
            lblEdit.TabIndex = 7;
            lblEdit.Text = "View/Edit Room";
            lblEdit.UseVisualStyleBackColor = true;
            lblEdit.Click += lblEdit_Click;
            // 
            // cbDisabled
            // 
            cbDisabled.FormattingEnabled = true;
            cbDisabled.Items.AddRange(new object[] { "Any", "Yes", "No" });
            cbDisabled.Location = new Point(322, 38);
            cbDisabled.Margin = new Padding(3, 2, 3, 2);
            cbDisabled.Name = "cbDisabled";
            cbDisabled.Size = new Size(150, 23);
            cbDisabled.TabIndex = 8;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.Location = new Point(166, 21);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(81, 15);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Room Status:";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Any", "Available", "Under Refurbishment", "Off Sale" });
            cbStatus.Location = new Point(166, 38);
            cbStatus.Margin = new Padding(3, 2, 3, 2);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(150, 23);
            cbStatus.TabIndex = 10;
            // 
            // viewrooms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 340);
            Controls.Add(cbStatus);
            Controls.Add(cbDisabled);
            Controls.Add(lblEdit);
            Controls.Add(lblRooms);
            Controls.Add(lblDisabled);
            Controls.Add(btnSearch);
            Controls.Add(rType);
            Controls.Add(dgRoom);
            Controls.Add(menuStrip1);
            Controls.Add(lblStatus);
            Controls.Add(lblRoomType);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "viewrooms";
            Text = "viewrooms";
            Load += viewrooms_Load;
            ((System.ComponentModel.ISupportInitialize)dgRoom).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgRoom;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addRoomToolStripMenuItem;
        private ToolStripMenuItem returnToHomepageToolStripMenuItem;
        private Label lblRoomType;
        private ComboBox rType;
        private Button btnSearch;
        private Label lblDisabled;
        private Label lblRooms;
        private Button lblEdit;
        private ComboBox cbDisabled;
        private Label lblStatus;
        private ComboBox cbStatus;
    }
}