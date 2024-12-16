namespace bay_view_hotel_booking_system
{
    partial class CustomerSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerSearch));
            mnCustomerSearch = new MenuStrip();
            tsmiCustomerHome = new ToolStripMenuItem();
            tsmiQuit = new ToolStripMenuItem();
            lblNextPage = new Label();
            dgCustomer = new DataGridView();
            btnLoad = new Button();
            btnCustomerSearch = new Button();
            tbCustomerName = new TextBox();
            lblCustomerHeader = new Label();
            pnlSearch = new Panel();
            mnCustomerSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCustomer).BeginInit();
            pnlSearch.SuspendLayout();
            SuspendLayout();
            // 
            // mnCustomerSearch
            // 
            mnCustomerSearch.ImageScalingSize = new Size(20, 20);
            mnCustomerSearch.Items.AddRange(new ToolStripItem[] { tsmiCustomerHome, tsmiQuit });
            mnCustomerSearch.Location = new Point(0, 0);
            mnCustomerSearch.Name = "mnCustomerSearch";
            mnCustomerSearch.Padding = new Padding(5, 2, 0, 2);
            mnCustomerSearch.Size = new Size(684, 24);
            mnCustomerSearch.TabIndex = 4;
            mnCustomerSearch.Text = "menuStrip1";
            // 
            // tsmiCustomerHome
            // 
            tsmiCustomerHome.Name = "tsmiCustomerHome";
            tsmiCustomerHome.Size = new Size(145, 20);
            tsmiCustomerHome.Text = "Customer Management";
            tsmiCustomerHome.Click += tsmiCustomerHome_Click;
            // 
            // tsmiQuit
            // 
            tsmiQuit.Name = "tsmiQuit";
            tsmiQuit.Size = new Size(130, 20);
            tsmiQuit.Text = "Return to Homepage";
            tsmiQuit.Click += tsmiQuit_Click;
            // 
            // lblNextPage
            // 
            lblNextPage.AutoSize = true;
            lblNextPage.Location = new Point(355, 292);
            lblNextPage.Name = "lblNextPage";
            lblNextPage.Size = new Size(61, 15);
            lblNextPage.TabIndex = 5;
            lblNextPage.Text = "Next Page";
            lblNextPage.Visible = false;
            // 
            // dgCustomer
            // 
            dgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCustomer.Location = new Point(3, 44);
            dgCustomer.Margin = new Padding(3, 2, 3, 2);
            dgCustomer.Name = "dgCustomer";
            dgCustomer.ReadOnly = true;
            dgCustomer.RowHeadersWidth = 51;
            dgCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCustomer.Size = new Size(484, 155);
            dgCustomer.TabIndex = 6;
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
            // btnCustomerSearch
            // 
            btnCustomerSearch.BackColor = SystemColors.ControlLightLight;
            btnCustomerSearch.Location = new Point(389, 15);
            btnCustomerSearch.Name = "btnCustomerSearch";
            btnCustomerSearch.Size = new Size(97, 23);
            btnCustomerSearch.TabIndex = 35;
            btnCustomerSearch.Text = "Search";
            btnCustomerSearch.UseVisualStyleBackColor = false;
            btnCustomerSearch.Click += btnSearch_Click;
            // 
            // tbCustomerName
            // 
            tbCustomerName.Location = new Point(3, 16);
            tbCustomerName.Name = "tbCustomerName";
            tbCustomerName.Size = new Size(382, 23);
            tbCustomerName.TabIndex = 34;
            // 
            // lblCustomerHeader
            // 
            lblCustomerHeader.AutoSize = true;
            lblCustomerHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCustomerHeader.Location = new Point(3, 0);
            lblCustomerHeader.Name = "lblCustomerHeader";
            lblCustomerHeader.Size = new Size(100, 15);
            lblCustomerHeader.TabIndex = 33;
            lblCustomerHeader.Text = "Customer Name:";
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = SystemColors.ControlLight;
            pnlSearch.BorderStyle = BorderStyle.FixedSingle;
            pnlSearch.Controls.Add(lblCustomerHeader);
            pnlSearch.Controls.Add(btnCustomerSearch);
            pnlSearch.Controls.Add(dgCustomer);
            pnlSearch.Controls.Add(tbCustomerName);
            pnlSearch.Controls.Add(btnLoad);
            pnlSearch.Location = new Point(16, 23);
            pnlSearch.Margin = new Padding(3, 2, 3, 2);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(492, 232);
            pnlSearch.TabIndex = 36;
            // 
            // CustomerSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 340);
            Controls.Add(pnlSearch);
            Controls.Add(lblNextPage);
            Controls.Add(mnCustomerSearch);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mnCustomerSearch;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CustomerSearch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Find Customer";
            FormClosing += CustomerSearch_FormClosing;
            VisibleChanged += CustomerSearch_VisibleChanged;
            mnCustomerSearch.ResumeLayout(false);
            mnCustomerSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgCustomer).EndInit();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip mnCustomerSearch;
        private Label lblNextPage;
        private DataGridView dgCustomer;
        private Button btnLoad;
        private ToolStripMenuItem tsmiCustomerHome;
        private ToolStripMenuItem tsmiQuit;
        private Button btnCustomerSearch;
        private TextBox tbCustomerName;
        private Label lblCustomerHeader;
        private Panel pnlSearch;
    }
}