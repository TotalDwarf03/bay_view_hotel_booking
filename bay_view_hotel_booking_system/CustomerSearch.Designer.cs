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
            lblCustomerSearch = new Label();
            tbForenameSearch = new TextBox();
            tbSurnameSearch = new TextBox();
            pnlSearch = new Panel();
            btnSearch = new Button();
            lblSurnameSearch = new Label();
            lblForenameSearch = new Label();
            mnCustomerSearch = new MenuStrip();
            backToolStripMenuItem = new ToolStripMenuItem();
            lblNextPage = new Label();
            dgCustomer = new DataGridView();
            btnLoad = new Button();
            pnlSearch.SuspendLayout();
            mnCustomerSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCustomer).BeginInit();
            SuspendLayout();
            // 
            // lblCustomerSearch
            // 
            lblCustomerSearch.AutoSize = true;
            lblCustomerSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerSearch.Location = new Point(256, 47);
            lblCustomerSearch.Name = "lblCustomerSearch";
            lblCustomerSearch.Size = new Size(243, 41);
            lblCustomerSearch.TabIndex = 0;
            lblCustomerSearch.Text = "Customer Search";
            // 
            // tbForenameSearch
            // 
            tbForenameSearch.Location = new Point(152, 40);
            tbForenameSearch.Name = "tbForenameSearch";
            tbForenameSearch.Size = new Size(125, 27);
            tbForenameSearch.TabIndex = 1;
            // 
            // tbSurnameSearch
            // 
            tbSurnameSearch.Location = new Point(152, 103);
            tbSurnameSearch.Name = "tbSurnameSearch";
            tbSurnameSearch.Size = new Size(125, 27);
            tbSurnameSearch.TabIndex = 2;
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(btnSearch);
            pnlSearch.Controls.Add(lblSurnameSearch);
            pnlSearch.Controls.Add(tbSurnameSearch);
            pnlSearch.Controls.Add(lblForenameSearch);
            pnlSearch.Controls.Add(tbForenameSearch);
            pnlSearch.Location = new Point(12, 121);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(346, 241);
            pnlSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(99, 178);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblSurnameSearch
            // 
            lblSurnameSearch.AutoSize = true;
            lblSurnameSearch.Location = new Point(33, 106);
            lblSurnameSearch.Name = "lblSurnameSearch";
            lblSurnameSearch.Size = new Size(67, 20);
            lblSurnameSearch.TabIndex = 4;
            lblSurnameSearch.Text = "Surname";
            // 
            // lblForenameSearch
            // 
            lblForenameSearch.AutoSize = true;
            lblForenameSearch.Location = new Point(33, 40);
            lblForenameSearch.Name = "lblForenameSearch";
            lblForenameSearch.Size = new Size(75, 20);
            lblForenameSearch.TabIndex = 5;
            lblForenameSearch.Text = "Forename";
            // 
            // mnCustomerSearch
            // 
            mnCustomerSearch.ImageScalingSize = new Size(20, 20);
            mnCustomerSearch.Items.AddRange(new ToolStripItem[] { backToolStripMenuItem });
            mnCustomerSearch.Location = new Point(0, 0);
            mnCustomerSearch.Name = "mnCustomerSearch";
            mnCustomerSearch.Size = new Size(782, 28);
            mnCustomerSearch.TabIndex = 4;
            mnCustomerSearch.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(54, 24);
            backToolStripMenuItem.Text = "Back";
            backToolStripMenuItem.Click += backToolStripMenuItem_Click;
            // 
            // lblNextPage
            // 
            lblNextPage.AutoSize = true;
            lblNextPage.Location = new Point(12, 47);
            lblNextPage.Name = "lblNextPage";
            lblNextPage.Size = new Size(0, 20);
            lblNextPage.TabIndex = 5;
            lblNextPage.Visible = false;
            // 
            // dgCustomer
            // 
            dgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCustomer.Location = new Point(379, 121);
            dgCustomer.Name = "dgCustomer";
            dgCustomer.RowHeadersWidth = 51;
            dgCustomer.Size = new Size(391, 207);
            dgCustomer.TabIndex = 6;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(534, 334);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 7;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // CustomerSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 375);
            Controls.Add(btnLoad);
            Controls.Add(dgCustomer);
            Controls.Add(lblNextPage);
            Controls.Add(pnlSearch);
            Controls.Add(lblCustomerSearch);
            Controls.Add(mnCustomerSearch);
            MainMenuStrip = mnCustomerSearch;
            Name = "CustomerSearch";
            Text = "CustomerSearch";
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            mnCustomerSearch.ResumeLayout(false);
            mnCustomerSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomerSearch;
        private TextBox tbForenameSearch;
        private TextBox tbSurnameSearch;
        private Panel pnlSearch;
        private Button btnSearch;
        private Label lblSurnameSearch;
        private Label lblForenameSearch;
        private MenuStrip mnCustomerSearch;
        private ToolStripMenuItem backToolStripMenuItem;
        private Label lblNextPage;
        private DataGridView dgCustomer;
        private Button btnLoad;
    }
}