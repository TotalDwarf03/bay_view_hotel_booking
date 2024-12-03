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
            dgCustomer = new DataGridView();
            mnView = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            pnlSearch = new Panel();
            lblCustomerView = new Label();
            ((System.ComponentModel.ISupportInitialize)dgCustomer).BeginInit();
            mnView.SuspendLayout();
            pnlSearch.SuspendLayout();
            SuspendLayout();
            // 
            // dgCustomer
            // 
            dgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCustomer.Location = new Point(12, 127);
            dgCustomer.Name = "dgCustomer";
            dgCustomer.RowHeadersWidth = 51;
            dgCustomer.Size = new Size(762, 311);
            dgCustomer.TabIndex = 0;
            // 
            // mnView
            // 
            mnView.ImageScalingSize = new Size(20, 20);
            mnView.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, addToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem });
            mnView.Location = new Point(0, 0);
            mnView.Name = "mnView";
            mnView.Size = new Size(794, 28);
            mnView.TabIndex = 1;
            mnView.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(51, 24);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(67, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(lblCustomerView);
            pnlSearch.Location = new Point(12, 36);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(762, 72);
            pnlSearch.TabIndex = 2;
            // 
            // lblCustomerView
            // 
            lblCustomerView.AutoSize = true;
            lblCustomerView.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerView.Location = new Point(21, 14);
            lblCustomerView.Name = "lblCustomerView";
            lblCustomerView.Size = new Size(246, 46);
            lblCustomerView.TabIndex = 0;
            lblCustomerView.Text = "Customer View";
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 450);
            Controls.Add(pnlSearch);
            Controls.Add(dgCustomer);
            Controls.Add(mnView);
            MainMenuStrip = mnView;
            Name = "CustomerView";
            Text = "CustomerView";
            Load += CustomerView_Load;
            ((System.ComponentModel.ISupportInitialize)dgCustomer).EndInit();
            mnView.ResumeLayout(false);
            mnView.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgCustomer;
        private MenuStrip mnView;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Panel pnlSearch;
        private Label lblCustomerView;
    }
}