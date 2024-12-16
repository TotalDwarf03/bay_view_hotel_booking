namespace bay_view_hotel_booking_system
{
    partial class CustomerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerView));
            dgCustomer = new DataGridView();
            mnView = new MenuStrip();
            tsmiCustomerHome = new ToolStripMenuItem();
            tsmiQuit = new ToolStripMenuItem();
            lblCustomerHeader = new Label();
            btnCustomerSearch = new Button();
            tbCustomerName = new TextBox();
            panel1 = new Panel();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgCustomer).BeginInit();
            mnView.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgCustomer
            // 
            dgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCustomer.Location = new Point(10, 78);
            dgCustomer.Margin = new Padding(3, 2, 3, 2);
            dgCustomer.Name = "dgCustomer";
            dgCustomer.ReadOnly = true;
            dgCustomer.RowHeadersWidth = 51;
            dgCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCustomer.Size = new Size(663, 222);
            dgCustomer.TabIndex = 0;
            // 
            // mnView
            // 
            mnView.ImageScalingSize = new Size(20, 20);
            mnView.Items.AddRange(new ToolStripItem[] { tsmiCustomerHome, tsmiQuit });
            mnView.Location = new Point(0, 0);
            mnView.Name = "mnView";
            mnView.Padding = new Padding(5, 2, 0, 2);
            mnView.Size = new Size(684, 24);
            mnView.TabIndex = 1;
            mnView.Text = "menuStrip1";
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
            // lblCustomerHeader
            // 
            lblCustomerHeader.AutoSize = true;
            lblCustomerHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCustomerHeader.Location = new Point(3, 0);
            lblCustomerHeader.Name = "lblCustomerHeader";
            lblCustomerHeader.Size = new Size(100, 15);
            lblCustomerHeader.TabIndex = 36;
            lblCustomerHeader.Text = "Customer Name:";
            // 
            // btnCustomerSearch
            // 
            btnCustomerSearch.BackColor = SystemColors.ControlLightLight;
            btnCustomerSearch.Location = new Point(389, 15);
            btnCustomerSearch.Name = "btnCustomerSearch";
            btnCustomerSearch.Size = new Size(97, 23);
            btnCustomerSearch.TabIndex = 38;
            btnCustomerSearch.Text = "Search";
            btnCustomerSearch.UseVisualStyleBackColor = false;
            btnCustomerSearch.Click += CustomerView_Load;
            // 
            // tbCustomerName
            // 
            tbCustomerName.Location = new Point(3, 16);
            tbCustomerName.Name = "tbCustomerName";
            tbCustomerName.Size = new Size(382, 23);
            tbCustomerName.TabIndex = 37;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblCustomerHeader);
            panel1.Controls.Add(tbCustomerName);
            panel1.Controls.Add(btnCustomerSearch);
            panel1.Location = new Point(10, 23);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(664, 51);
            panel1.TabIndex = 39;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ControlLightLight;
            btnClear.Location = new Point(577, 305);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(97, 23);
            btnClear.TabIndex = 39;
            btnClear.Text = "Clear Search";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 340);
            Controls.Add(btnClear);
            Controls.Add(panel1);
            Controls.Add(dgCustomer);
            Controls.Add(mnView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mnView;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CustomerView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Customers";
            FormClosing += CustomerSearch_FormClosing;
            Load += CustomerView_Load;
            ((System.ComponentModel.ISupportInitialize)dgCustomer).EndInit();
            mnView.ResumeLayout(false);
            mnView.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgCustomer;
        private MenuStrip mnView;
        private ToolStripMenuItem tsmiCustomerHome;
        private ToolStripMenuItem tsmiQuit;
        private Label lblCustomerHeader;
        private Button btnCustomerSearch;
        private TextBox tbCustomerName;
        private Panel panel1;
        private Button btnClear;
    }
}