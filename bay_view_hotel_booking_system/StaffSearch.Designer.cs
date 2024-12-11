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
            lblNextPage = new Label();
            mnStaffAdd = new MenuStrip();
            tsmiStaffHome = new ToolStripMenuItem();
            tsmiQuit = new ToolStripMenuItem();
            pnlSearch = new Panel();
            lblStaffHeader = new Label();
            btnStaffSearch = new Button();
            dgvStaff = new DataGridView();
            tbStaffName = new TextBox();
            btnLoad = new Button();
            mnStaffAdd.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).BeginInit();
            SuspendLayout();
            // 
            // lblNextPage
            // 
            lblNextPage.AutoSize = true;
            lblNextPage.Location = new Point(480, 284);
            lblNextPage.Name = "lblNextPage";
            lblNextPage.Size = new Size(58, 15);
            lblNextPage.TabIndex = 5;
            lblNextPage.Text = "NextPage";
            lblNextPage.Visible = false;
            // 
            // mnStaffAdd
            // 
            mnStaffAdd.ImageScalingSize = new Size(20, 20);
            mnStaffAdd.Items.AddRange(new ToolStripItem[] { tsmiStaffHome, tsmiQuit });
            mnStaffAdd.Location = new Point(0, 0);
            mnStaffAdd.Name = "mnStaffAdd";
            mnStaffAdd.Padding = new Padding(5, 2, 0, 2);
            mnStaffAdd.Size = new Size(684, 24);
            mnStaffAdd.TabIndex = 6;
            mnStaffAdd.Text = "menuStrip1";
            // 
            // tsmiStaffHome
            // 
            tsmiStaffHome.Name = "tsmiStaffHome";
            tsmiStaffHome.Size = new Size(117, 20);
            tsmiStaffHome.Text = "Staff Management";
            tsmiStaffHome.Click += tsmiStaffHome_Click;
            // 
            // tsmiQuit
            // 
            tsmiQuit.Name = "tsmiQuit";
            tsmiQuit.Size = new Size(130, 20);
            tsmiQuit.Text = "Return to Homepage";
            tsmiQuit.Click += tsmiQuit_Click;
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = SystemColors.ControlLight;
            pnlSearch.BorderStyle = BorderStyle.FixedSingle;
            pnlSearch.Controls.Add(lblStaffHeader);
            pnlSearch.Controls.Add(btnStaffSearch);
            pnlSearch.Controls.Add(dgvStaff);
            pnlSearch.Controls.Add(tbStaffName);
            pnlSearch.Controls.Add(btnLoad);
            pnlSearch.Location = new Point(12, 26);
            pnlSearch.Margin = new Padding(3, 2, 3, 2);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(492, 232);
            pnlSearch.TabIndex = 37;
            // 
            // lblStaffHeader
            // 
            lblStaffHeader.AutoSize = true;
            lblStaffHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStaffHeader.Location = new Point(3, 0);
            lblStaffHeader.Name = "lblStaffHeader";
            lblStaffHeader.Size = new Size(74, 15);
            lblStaffHeader.TabIndex = 33;
            lblStaffHeader.Text = "Staff Name:";
            // 
            // btnStaffSearch
            // 
            btnStaffSearch.BackColor = SystemColors.ControlLightLight;
            btnStaffSearch.Location = new Point(389, 15);
            btnStaffSearch.Name = "btnStaffSearch";
            btnStaffSearch.Size = new Size(97, 23);
            btnStaffSearch.TabIndex = 35;
            btnStaffSearch.Text = "Search";
            btnStaffSearch.UseVisualStyleBackColor = false;
            btnStaffSearch.Click += btnSearch_Click;
            // 
            // dgvStaff
            // 
            dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaff.Location = new Point(3, 44);
            dgvStaff.Margin = new Padding(3, 2, 3, 2);
            dgvStaff.Name = "dgvStaff";
            dgvStaff.ReadOnly = true;
            dgvStaff.RowHeadersWidth = 51;
            dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStaff.Size = new Size(484, 155);
            dgvStaff.TabIndex = 6;
            // 
            // tbStaffName
            // 
            tbStaffName.Location = new Point(3, 16);
            tbStaffName.Name = "tbStaffName";
            tbStaffName.Size = new Size(382, 23);
            tbStaffName.TabIndex = 34;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = SystemColors.ControlLightLight;
            btnLoad.Location = new Point(205, 204);
            btnLoad.Margin = new Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(82, 22);
            btnLoad.TabIndex = 7;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // StaffSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 340);
            Controls.Add(pnlSearch);
            Controls.Add(mnStaffAdd);
            Controls.Add(lblNextPage);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "StaffSearch";
            Text = "Search Staff";
            FormClosing += StaffFormClosing;
            VisibleChanged += StaffSearch_VisibleChanged;
            mnStaffAdd.ResumeLayout(false);
            mnStaffAdd.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNextPage;
        private MenuStrip mnStaffAdd;
        private ToolStripMenuItem tsmiStaffHome;
        private ToolStripMenuItem tsmiQuit;
        private Panel pnlSearch;
        private Label lblStaffHeader;
        private Button btnStaffSearch;
        private DataGridView dgvStaff;
        private TextBox tbStaffName;
        private Button btnLoad;
    }
}