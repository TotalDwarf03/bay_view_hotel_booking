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
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgRoom).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgRoom
            // 
            dgRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgRoom.Location = new Point(11, 157);
            dgRoom.Name = "dgRoom";
            dgRoom.RowHeadersWidth = 51;
            dgRoom.Size = new Size(758, 245);
            dgRoom.TabIndex = 0;
            dgRoom.CellContentClick += dataGridView1_CellContentClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addRoomToolStripMenuItem, returnToHomepageToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(782, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // addRoomToolStripMenuItem
            // 
            addRoomToolStripMenuItem.Name = "addRoomToolStripMenuItem";
            addRoomToolStripMenuItem.Size = new Size(95, 24);
            addRoomToolStripMenuItem.Text = "Add Room";
            addRoomToolStripMenuItem.Click += addRoomToolStripMenuItem_Click;
            // 
            // returnToHomepageToolStripMenuItem
            // 
            returnToHomepageToolStripMenuItem.Name = "returnToHomepageToolStripMenuItem";
            returnToHomepageToolStripMenuItem.Size = new Size(163, 24);
            returnToHomepageToolStripMenuItem.Text = "Return to Homepage";
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRoomType.Location = new Point(11, 28);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(92, 20);
            lblRoomType.TabIndex = 2;
            lblRoomType.Text = "Room Type:";
            // 
            // rType
            // 
            rType.AllowDrop = true;
            rType.FormattingEnabled = true;
            rType.Items.AddRange(new object[] { "single", "double", "family" });
            rType.Location = new Point(11, 51);
            rType.Name = "rType";
            rType.Size = new Size(171, 28);
            rType.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(11, 93);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblDisabled
            // 
            lblDisabled.AutoSize = true;
            lblDisabled.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDisabled.Location = new Point(190, 28);
            lblDisabled.Name = "lblDisabled";
            lblDisabled.Size = new Size(122, 20);
            lblDisabled.TabIndex = 5;
            lblDisabled.Text = "Disabled Room?";
            // 
            // lblRooms
            // 
            lblRooms.AutoSize = true;
            lblRooms.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRooms.Location = new Point(11, 133);
            lblRooms.Name = "lblRooms";
            lblRooms.Size = new Size(62, 20);
            lblRooms.TabIndex = 6;
            lblRooms.Text = "Rooms:";
            // 
            // lblEdit
            // 
            lblEdit.Location = new Point(14, 409);
            lblEdit.Name = "lblEdit";
            lblEdit.Size = new Size(168, 33);
            lblEdit.TabIndex = 7;
            lblEdit.Text = "View/Edit Room";
            lblEdit.UseVisualStyleBackColor = true;
            // 
            // cbDisabled
            // 
            cbDisabled.FormattingEnabled = true;
            cbDisabled.Location = new Point(190, 51);
            cbDisabled.Name = "cbDisabled";
            cbDisabled.Size = new Size(171, 28);
            cbDisabled.TabIndex = 8;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.Location = new Point(368, 28);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(103, 20);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Room Status:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(368, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(171, 28);
            comboBox1.TabIndex = 10;
            // 
            // viewrooms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(comboBox1);
            Controls.Add(lblStatus);
            Controls.Add(cbDisabled);
            Controls.Add(lblEdit);
            Controls.Add(lblRooms);
            Controls.Add(lblDisabled);
            Controls.Add(btnSearch);
            Controls.Add(rType);
            Controls.Add(lblRoomType);
            Controls.Add(dgRoom);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
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
        private ComboBox comboBox1;
    }
}