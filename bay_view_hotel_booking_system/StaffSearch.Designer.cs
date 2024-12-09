namespace bay_view_hotel_booking_system
{
    partial class StaffSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffSearch));
            mnSearch = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            staffViewToolStripMenuItem = new ToolStripMenuItem();
            pnlSearch = new Panel();
            lblStaffSearch = new Label();
            btnLoad = new Button();
            dgStaff = new DataGridView();
            tbName = new TextBox();
            btnSearch = new Button();
            lblNextPage = new Label();
            mnSearch.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgStaff).BeginInit();
            SuspendLayout();
            // 
            // mnSearch
            // 
            mnSearch.ImageScalingSize = new Size(20, 20);
            mnSearch.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, staffViewToolStripMenuItem });
            mnSearch.Location = new Point(0, 0);
            mnSearch.Name = "mnSearch";
            mnSearch.Size = new Size(527, 28);
            mnSearch.TabIndex = 0;
            mnSearch.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(146, 24);
            homeToolStripMenuItem.Text = "Staff Management";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // staffViewToolStripMenuItem
            // 
            staffViewToolStripMenuItem.Name = "staffViewToolStripMenuItem";
            staffViewToolStripMenuItem.Size = new Size(90, 24);
            staffViewToolStripMenuItem.Text = "Staff View";
            staffViewToolStripMenuItem.Click += staffViewToolStripMenuItem_Click;
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(lblStaffSearch);
            pnlSearch.Controls.Add(btnLoad);
            pnlSearch.Controls.Add(dgStaff);
            pnlSearch.Controls.Add(tbName);
            pnlSearch.Controls.Add(btnSearch);
            pnlSearch.Location = new Point(12, 31);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(505, 347);
            pnlSearch.TabIndex = 1;
            // 
            // lblStaffSearch
            // 
            lblStaffSearch.AutoSize = true;
            lblStaffSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStaffSearch.Location = new Point(18, 13);
            lblStaffSearch.Name = "lblStaffSearch";
            lblStaffSearch.Size = new Size(172, 41);
            lblStaffSearch.TabIndex = 4;
            lblStaffSearch.Text = "Staff Search";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(203, 308);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // dgStaff
            // 
            dgStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStaff.Location = new Point(12, 83);
            dgStaff.Name = "dgStaff";
            dgStaff.RowHeadersWidth = 51;
            dgStaff.Size = new Size(473, 205);
            dgStaff.TabIndex = 2;
            // 
            // tbName
            // 
            tbName.Location = new Point(260, 26);
            tbName.Name = "tbName";
            tbName.Size = new Size(125, 27);
            tbName.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(391, 25);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblNextPage
            // 
            lblNextPage.AutoSize = true;
            lblNextPage.Location = new Point(548, 379);
            lblNextPage.Name = "lblNextPage";
            lblNextPage.Size = new Size(0, 20);
            lblNextPage.TabIndex = 5;
            // 
            // StaffSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 387);
            Controls.Add(lblNextPage);
            Controls.Add(pnlSearch);
            Controls.Add(mnSearch);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mnSearch;
            Name = "StaffSearch";
            Text = "StaffSearch";
            mnSearch.ResumeLayout(false);
            mnSearch.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgStaff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnSearch;
        private ToolStripMenuItem homeToolStripMenuItem;
        private Panel pnlSearch;
        private TextBox tbName;
        private Button btnSearch;
        private Button btnLoad;
        private ToolStripMenuItem staffViewToolStripMenuItem;
        private Label lblStaffSearch;
        private DataGridView dgStaff;
        private Label lblNextPage;
    }
}