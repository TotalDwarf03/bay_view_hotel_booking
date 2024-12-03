namespace bay_view_hotel_booking_system
{
    partial class CustomerDelete
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
            menuStrip1 = new MenuStrip();
            customerHomeToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            pnlEditCustomer = new Panel();
            tbCustomerID = new TextBox();
            btnDelete = new Button();
            lblEmail = new Label();
            lblPhoneNumber = new Label();
            lblSurname = new Label();
            lblForename = new Label();
            lblCustomerID = new Label();
            tbEmail = new TextBox();
            tbPhoneNumber = new TextBox();
            tbSurname = new TextBox();
            tbForename = new TextBox();
            pnlCustomerDelete = new Panel();
            lblCustomerDelete = new Label();
            viewToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            pnlEditCustomer.SuspendLayout();
            pnlCustomerDelete.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { customerHomeToolStripMenuItem, addToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(490, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "mnCustomerDelete";
            // 
            // customerHomeToolStripMenuItem
            // 
            customerHomeToolStripMenuItem.Name = "customerHomeToolStripMenuItem";
            customerHomeToolStripMenuItem.Size = new Size(64, 24);
            customerHomeToolStripMenuItem.Text = "Home";
            customerHomeToolStripMenuItem.Click += customerHomeToolStripMenuItem_Click;
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
            // pnlEditCustomer
            // 
            pnlEditCustomer.Controls.Add(tbCustomerID);
            pnlEditCustomer.Controls.Add(btnDelete);
            pnlEditCustomer.Controls.Add(lblEmail);
            pnlEditCustomer.Controls.Add(lblPhoneNumber);
            pnlEditCustomer.Controls.Add(lblSurname);
            pnlEditCustomer.Controls.Add(lblForename);
            pnlEditCustomer.Controls.Add(lblCustomerID);
            pnlEditCustomer.Controls.Add(tbEmail);
            pnlEditCustomer.Controls.Add(tbPhoneNumber);
            pnlEditCustomer.Controls.Add(tbSurname);
            pnlEditCustomer.Controls.Add(tbForename);
            pnlEditCustomer.Location = new Point(12, 113);
            pnlEditCustomer.Name = "pnlEditCustomer";
            pnlEditCustomer.Size = new Size(469, 258);
            pnlEditCustomer.TabIndex = 4;
            // 
            // tbCustomerID
            // 
            tbCustomerID.Enabled = false;
            tbCustomerID.Location = new Point(124, 30);
            tbCustomerID.Name = "tbCustomerID";
            tbCustomerID.Size = new Size(107, 27);
            tbCustomerID.TabIndex = 11;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(335, 214);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(18, 214);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(18, 165);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(108, 20);
            lblPhoneNumber.TabIndex = 8;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(18, 118);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(67, 20);
            lblSurname.TabIndex = 7;
            lblSurname.Text = "Surname";
            // 
            // lblForename
            // 
            lblForename.AutoSize = true;
            lblForename.Location = new Point(18, 76);
            lblForename.Name = "lblForename";
            lblForename.Size = new Size(75, 20);
            lblForename.TabIndex = 6;
            lblForename.Text = "Forename";
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Location = new Point(18, 33);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(91, 20);
            lblCustomerID.TabIndex = 5;
            lblCustomerID.Text = "Customer ID";
            // 
            // tbEmail
            // 
            tbEmail.Enabled = false;
            tbEmail.Location = new Point(124, 211);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(169, 27);
            tbEmail.TabIndex = 4;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Enabled = false;
            tbPhoneNumber.Location = new Point(147, 162);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(146, 27);
            tbPhoneNumber.TabIndex = 3;
            // 
            // tbSurname
            // 
            tbSurname.Enabled = false;
            tbSurname.Location = new Point(124, 115);
            tbSurname.Name = "tbSurname";
            tbSurname.Size = new Size(107, 27);
            tbSurname.TabIndex = 2;
            // 
            // tbForename
            // 
            tbForename.Enabled = false;
            tbForename.Location = new Point(124, 73);
            tbForename.Name = "tbForename";
            tbForename.Size = new Size(107, 27);
            tbForename.TabIndex = 0;
            // 
            // pnlCustomerDelete
            // 
            pnlCustomerDelete.Controls.Add(lblCustomerDelete);
            pnlCustomerDelete.Location = new Point(12, 41);
            pnlCustomerDelete.Name = "pnlCustomerDelete";
            pnlCustomerDelete.Size = new Size(469, 66);
            pnlCustomerDelete.TabIndex = 5;
            // 
            // lblCustomerDelete
            // 
            lblCustomerDelete.AutoSize = true;
            lblCustomerDelete.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerDelete.Location = new Point(110, 12);
            lblCustomerDelete.Name = "lblCustomerDelete";
            lblCustomerDelete.Size = new Size(241, 41);
            lblCustomerDelete.TabIndex = 0;
            lblCustomerDelete.Text = "Customer Delete";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            viewToolStripMenuItem.Click += viewToolStripMenuItem_Click;
            // 
            // CustomerDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 384);
            Controls.Add(pnlCustomerDelete);
            Controls.Add(pnlEditCustomer);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CustomerDelete";
            Text = "CustomerDelete";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlEditCustomer.ResumeLayout(false);
            pnlEditCustomer.PerformLayout();
            pnlCustomerDelete.ResumeLayout(false);
            pnlCustomerDelete.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem customerHomeToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private Panel pnlEditCustomer;
        private Button btnDelete;
        private Label lblEmail;
        private Label lblPhoneNumber;
        private Label lblSurname;
        private Label lblForename;
        private Label lblCustomerID;
        private TextBox tbEmail;
        private TextBox tbPhoneNumber;
        private TextBox tbSurname;
        private TextBox tbForename;
        private Panel pnlCustomerDelete;
        private Label lblCustomerDelete;
        private TextBox tbCustomerID;
        private ToolStripMenuItem viewToolStripMenuItem;
    }
}