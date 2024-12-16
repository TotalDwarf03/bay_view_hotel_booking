namespace bay_view_hotel_booking_system
{
    partial class RoomView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomView));
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
            btnRefresh = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgRoom).BeginInit();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgRoom
            // 
            dgRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgRoom.Location = new Point(12, 126);
            dgRoom.Margin = new Padding(3, 2, 3, 2);
            dgRoom.MultiSelect = false;
            dgRoom.Name = "dgRoom";
            dgRoom.ReadOnly = true;
            dgRoom.RowHeadersWidth = 51;
            dgRoom.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgRoom.Size = new Size(663, 176);
            dgRoom.TabIndex = 0;
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
            returnToHomepageToolStripMenuItem.Click += returnToHomepageToolStripMenuItem_Click;
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRoomType.Location = new Point(3, 3);
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
            rType.Location = new Point(3, 20);
            rType.Margin = new Padding(3, 2, 3, 2);
            rType.Name = "rType";
            rType.Size = new Size(150, 23);
            rType.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ControlLightLight;
            btnSearch.Location = new Point(3, 52);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 22);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblDisabled
            // 
            lblDisabled.AutoSize = true;
            lblDisabled.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDisabled.Location = new Point(315, 3);
            lblDisabled.Name = "lblDisabled";
            lblDisabled.Size = new Size(95, 15);
            lblDisabled.TabIndex = 5;
            lblDisabled.Text = "Disabled Room?";
            // 
            // lblRooms
            // 
            lblRooms.AutoSize = true;
            lblRooms.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRooms.Location = new Point(12, 109);
            lblRooms.Name = "lblRooms";
            lblRooms.Size = new Size(48, 15);
            lblRooms.TabIndex = 6;
            lblRooms.Text = "Rooms:";
            // 
            // lblEdit
            // 
            lblEdit.Location = new Point(529, 306);
            lblEdit.Margin = new Padding(3, 2, 3, 2);
            lblEdit.Name = "lblEdit";
            lblEdit.Size = new Size(147, 25);
            lblEdit.TabIndex = 7;
            lblEdit.Text = "Edit Room";
            lblEdit.UseVisualStyleBackColor = true;
            lblEdit.Click += lblEdit_Click;
            // 
            // cbDisabled
            // 
            cbDisabled.FormattingEnabled = true;
            cbDisabled.Items.AddRange(new object[] { "Any", "Yes", "No" });
            cbDisabled.Location = new Point(315, 20);
            cbDisabled.Margin = new Padding(3, 2, 3, 2);
            cbDisabled.Name = "cbDisabled";
            cbDisabled.Size = new Size(150, 23);
            cbDisabled.TabIndex = 8;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.Location = new Point(159, 3);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(81, 15);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Room Status:";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Any", "Available", "Under Refurbishment", "Off Sale" });
            cbStatus.Location = new Point(159, 20);
            cbStatus.Margin = new Padding(3, 2, 3, 2);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(150, 23);
            cbStatus.TabIndex = 10;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.ControlLightLight;
            btnRefresh.Location = new Point(91, 52);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(82, 22);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "Set Default";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += ResetDefaultValues;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(rType);
            panel1.Controls.Add(cbStatus);
            panel1.Controls.Add(lblRoomType);
            panel1.Controls.Add(cbDisabled);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(lblDisabled);
            panel1.Location = new Point(12, 26);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(664, 81);
            panel1.TabIndex = 40;
            // 
            // RoomView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 340);
            Controls.Add(lblEdit);
            Controls.Add(dgRoom);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            Controls.Add(lblRooms);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "RoomView";
            Text = "View Rooms";
            FormClosing += RoomView_FormClosing;
            Load += viewrooms_Load;
            VisibleChanged += ResetDefaultValues;
            ((System.ComponentModel.ISupportInitialize)dgRoom).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Button btnRefresh;
        private Panel panel1;
    }
}