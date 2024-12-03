namespace bay_view_hotel_booking_system
{
    partial class CustomerEdit
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
            mnCustomerEdit = new MenuStrip();
            customerHomeToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            lblCustomerID = new Label();
            pnlEditCustomer = new Panel();
            tbCustomerID = new TextBox();
            btnSave = new Button();
            lblEmail = new Label();
            lblPhoneNumber = new Label();
            lblSurname = new Label();
            lblForename = new Label();
            tbEmail = new TextBox();
            tbPhoneNumber = new TextBox();
            tbSurname = new TextBox();
            tbForename = new TextBox();
            pnlCustomerEdit = new Panel();
            lblCustomerEdit = new Label();
            mnCustomerEdit.SuspendLayout();
            pnlEditCustomer.SuspendLayout();
            pnlCustomerEdit.SuspendLayout();
            SuspendLayout();
            // 
            // mnCustomerEdit
            // 
            mnCustomerEdit.ImageScalingSize = new Size(20, 20);
            mnCustomerEdit.Items.AddRange(new ToolStripItem[] { customerHomeToolStripMenuItem, addToolStripMenuItem, deleteToolStripMenuItem });
            mnCustomerEdit.Location = new Point(0, 0);
            mnCustomerEdit.Name = "mnCustomerEdit";
            mnCustomerEdit.Size = new Size(490, 28);
            mnCustomerEdit.TabIndex = 0;
            mnCustomerEdit.Text = "menuStrip1";
            // 
            // customerHomeToolStripMenuItem
            // 
            customerHomeToolStripMenuItem.Name = "customerHomeToolStripMenuItem";
            customerHomeToolStripMenuItem.Size = new Size(131, 24);
            customerHomeToolStripMenuItem.Text = "Customer Home";
            customerHomeToolStripMenuItem.Click += customerHomeToolStripMenuItem_Click;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(51, 24);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(67, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
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
            // pnlEditCustomer
            // 
            pnlEditCustomer.Controls.Add(tbCustomerID);
            pnlEditCustomer.Controls.Add(btnSave);
            pnlEditCustomer.Controls.Add(lblEmail);
            pnlEditCustomer.Controls.Add(lblPhoneNumber);
            pnlEditCustomer.Controls.Add(lblSurname);
            pnlEditCustomer.Controls.Add(lblForename);
            pnlEditCustomer.Controls.Add(lblCustomerID);
            pnlEditCustomer.Controls.Add(tbEmail);
            pnlEditCustomer.Controls.Add(tbPhoneNumber);
            pnlEditCustomer.Controls.Add(tbSurname);
            pnlEditCustomer.Controls.Add(tbForename);
            pnlEditCustomer.Location = new Point(12, 106);
            pnlEditCustomer.Name = "pnlEditCustomer";
            pnlEditCustomer.Size = new Size(461, 258);
            pnlEditCustomer.TabIndex = 3;
            // 
            // tbCustomerID
            // 
            tbCustomerID.Location = new Point(124, 30);
            tbCustomerID.Name = "tbCustomerID";
            tbCustomerID.Size = new Size(125, 27);
            tbCustomerID.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(335, 214);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
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
            // tbEmail
            // 
            tbEmail.Location = new Point(124, 211);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(169, 27);
            tbEmail.TabIndex = 4;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Location = new Point(147, 162);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(146, 27);
            tbPhoneNumber.TabIndex = 3;
            // 
            // tbSurname
            // 
            tbSurname.Location = new Point(124, 115);
            tbSurname.Name = "tbSurname";
            tbSurname.Size = new Size(107, 27);
            tbSurname.TabIndex = 2;
            // 
            // tbForename
            // 
            tbForename.Location = new Point(124, 73);
            tbForename.Name = "tbForename";
            tbForename.Size = new Size(107, 27);
            tbForename.TabIndex = 0;
            // 
            // pnlCustomerEdit
            // 
            pnlCustomerEdit.Controls.Add(lblCustomerEdit);
            pnlCustomerEdit.Location = new Point(12, 31);
            pnlCustomerEdit.Name = "pnlCustomerEdit";
            pnlCustomerEdit.Size = new Size(461, 69);
            pnlCustomerEdit.TabIndex = 4;
            // 
            // lblCustomerEdit
            // 
            lblCustomerEdit.AutoSize = true;
            lblCustomerEdit.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerEdit.Location = new Point(124, 14);
            lblCustomerEdit.Name = "lblCustomerEdit";
            lblCustomerEdit.Size = new Size(205, 41);
            lblCustomerEdit.TabIndex = 0;
            lblCustomerEdit.Text = "Customer Edit";
            // 
            // CustomerEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 390);
            Controls.Add(pnlCustomerEdit);
            Controls.Add(pnlEditCustomer);
            Controls.Add(mnCustomerEdit);
            MainMenuStrip = mnCustomerEdit;
            Name = "CustomerEdit";
            Text = "CustomerEdit";
            Load += CustomerEdit_Load;
            mnCustomerEdit.ResumeLayout(false);
            mnCustomerEdit.PerformLayout();
            pnlEditCustomer.ResumeLayout(false);
            pnlEditCustomer.PerformLayout();
            pnlCustomerEdit.ResumeLayout(false);
            pnlCustomerEdit.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnCustomerEdit;
        private ToolStripMenuItem customerHomeToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Label lblCustomerID;
        private Panel pnlEditCustomer;
        private Button btnSave;
        private Label lblEmail;
        private Label lblPhoneNumber;
        private Label lblSurname;
        private Label lblForename;
        private TextBox tbEmail;
        private TextBox tbPhoneNumber;
        private TextBox tbSurname;
        private TextBox tbForename;
        private Panel pnlCustomerEdit;
        private Label lblCustomerEdit;
        private TextBox tbCustomerID;
    }
}