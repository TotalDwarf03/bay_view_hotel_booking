namespace bay_view_hotel_booking_system
{
    partial class StaffView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffView));
            mnStaffView = new MenuStrip();
            staffManagementToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            btnLoad = new Button();
            tbStaffName = new TextBox();
            lblStaffView = new Label();
            dgStaff = new DataGridView();
            mnStaffView.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgStaff).BeginInit();
            SuspendLayout();
            // 
            // mnStaffView
            // 
            mnStaffView.ImageScalingSize = new Size(20, 20);
            mnStaffView.Items.AddRange(new ToolStripItem[] { staffManagementToolStripMenuItem });
            mnStaffView.Location = new Point(0, 0);
            mnStaffView.Name = "mnStaffView";
            mnStaffView.Size = new Size(758, 28);
            mnStaffView.TabIndex = 0;
            mnStaffView.Text = "menuStrip1";
            // 
            // staffManagementToolStripMenuItem
            // 
            staffManagementToolStripMenuItem.Name = "staffManagementToolStripMenuItem";
            staffManagementToolStripMenuItem.Size = new Size(146, 24);
            staffManagementToolStripMenuItem.Text = "Staff Management";
            staffManagementToolStripMenuItem.Click += staffManagementToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLoad);
            panel1.Controls.Add(tbStaffName);
            panel1.Controls.Add(lblStaffView);
            panel1.Controls.Add(dgStaff);
            panel1.Location = new Point(0, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(758, 311);
            panel1.TabIndex = 2;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(652, 22);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 5;
            btnLoad.Text = "Search";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // tbStaffName
            // 
            tbStaffName.Location = new Point(521, 24);
            tbStaffName.Name = "tbStaffName";
            tbStaffName.Size = new Size(125, 27);
            tbStaffName.TabIndex = 4;
            // 
            // lblStaffView
            // 
            lblStaffView.AutoSize = true;
            lblStaffView.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStaffView.Location = new Point(12, 9);
            lblStaffView.Name = "lblStaffView";
            lblStaffView.Size = new Size(185, 50);
            lblStaffView.TabIndex = 3;
            lblStaffView.Text = "Staff View";
            // 
            // dgStaff
            // 
            dgStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStaff.Location = new Point(12, 75);
            dgStaff.Name = "dgStaff";
            dgStaff.RowHeadersWidth = 51;
            dgStaff.Size = new Size(734, 217);
            dgStaff.TabIndex = 2;
            // 
            // StaffView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 345);
            Controls.Add(panel1);
            Controls.Add(mnStaffView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mnStaffView;
            Name = "StaffView";
            Text = "StaffView";
            Load += StaffView_Load;
            mnStaffView.ResumeLayout(false);
            mnStaffView.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgStaff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnStaffView;
        private ToolStripMenuItem staffManagementToolStripMenuItem;
        private Panel panel1;
        private TextBox tbStaffName;
        private Label lblStaffView;
        private DataGridView dgStaff;
        private Button btnLoad;
    }
}