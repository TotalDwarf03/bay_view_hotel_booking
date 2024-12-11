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
            mnStaffAdd = new MenuStrip();
            tsmiStaffHome = new ToolStripMenuItem();
            tsmiQuit = new ToolStripMenuItem();
            btnClear = new Button();
            panel1 = new Panel();
            lblStaffHeader = new Label();
            tbStaffName = new TextBox();
            btnStaffSearch = new Button();
            dgvStaff = new DataGridView();
            cbStaffType = new ComboBox();
            lblStaffType = new Label();
            mnStaffAdd.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).BeginInit();
            SuspendLayout();
            // 
            // mnStaffAdd
            // 
            mnStaffAdd.ImageScalingSize = new Size(20, 20);
            mnStaffAdd.Items.AddRange(new ToolStripItem[] { tsmiStaffHome, tsmiQuit });
            mnStaffAdd.Location = new Point(0, 0);
            mnStaffAdd.Name = "mnStaffAdd";
            mnStaffAdd.Padding = new Padding(5, 2, 0, 2);
            mnStaffAdd.Size = new Size(684, 24);
            mnStaffAdd.TabIndex = 3;
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
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ControlLightLight;
            btnClear.Location = new Point(579, 308);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(97, 23);
            btnClear.TabIndex = 42;
            btnClear.Text = "Clear Search";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cbStaffType);
            panel1.Controls.Add(lblStaffType);
            panel1.Controls.Add(lblStaffHeader);
            panel1.Controls.Add(tbStaffName);
            panel1.Controls.Add(btnStaffSearch);
            panel1.Location = new Point(12, 26);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(664, 51);
            panel1.TabIndex = 41;
            // 
            // lblStaffHeader
            // 
            lblStaffHeader.AutoSize = true;
            lblStaffHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStaffHeader.Location = new Point(3, 0);
            lblStaffHeader.Name = "lblStaffHeader";
            lblStaffHeader.Size = new Size(77, 15);
            lblStaffHeader.TabIndex = 36;
            lblStaffHeader.Text = "Staff Name: ";
            // 
            // tbStaffName
            // 
            tbStaffName.Location = new Point(3, 16);
            tbStaffName.Name = "tbStaffName";
            tbStaffName.Size = new Size(250, 23);
            tbStaffName.TabIndex = 37;
            // 
            // btnStaffSearch
            // 
            btnStaffSearch.BackColor = SystemColors.ControlLightLight;
            btnStaffSearch.Location = new Point(562, 15);
            btnStaffSearch.Name = "btnStaffSearch";
            btnStaffSearch.Size = new Size(97, 23);
            btnStaffSearch.TabIndex = 38;
            btnStaffSearch.Text = "Search";
            btnStaffSearch.UseVisualStyleBackColor = false;
            btnStaffSearch.Click += btnLoad_Click;
            // 
            // dgvStaff
            // 
            dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaff.Location = new Point(12, 81);
            dgvStaff.Margin = new Padding(3, 2, 3, 2);
            dgvStaff.Name = "dgvStaff";
            dgvStaff.ReadOnly = true;
            dgvStaff.RowHeadersWidth = 51;
            dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStaff.Size = new Size(663, 222);
            dgvStaff.TabIndex = 40;
            // 
            // cbStaffType
            // 
            cbStaffType.FormattingEnabled = true;
            cbStaffType.Location = new Point(259, 16);
            cbStaffType.Name = "cbStaffType";
            cbStaffType.Size = new Size(200, 23);
            cbStaffType.TabIndex = 40;
            // 
            // lblStaffType
            // 
            lblStaffType.AutoSize = true;
            lblStaffType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStaffType.Location = new Point(259, 0);
            lblStaffType.Name = "lblStaffType";
            lblStaffType.Size = new Size(67, 15);
            lblStaffType.TabIndex = 39;
            lblStaffType.Text = "Staff Type:";
            // 
            // StaffView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 340);
            Controls.Add(btnClear);
            Controls.Add(panel1);
            Controls.Add(dgvStaff);
            Controls.Add(mnStaffAdd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "StaffView";
            Text = "View Staff";
            FormClosing += StaffFormClosing;
            Load += btnLoad_Click;
            mnStaffAdd.ResumeLayout(false);
            mnStaffAdd.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip mnStaffAdd;
        private ToolStripMenuItem tsmiStaffHome;
        private ToolStripMenuItem tsmiQuit;
        private Button btnClear;
        private Panel panel1;
        private Label lblStaffHeader;
        private TextBox tbStaffName;
        private Button btnStaffSearch;
        private DataGridView dgvStaff;
        private ComboBox cbStaffType;
        private Label lblStaffType;
    }
}