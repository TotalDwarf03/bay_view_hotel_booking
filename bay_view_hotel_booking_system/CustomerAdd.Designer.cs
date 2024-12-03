namespace bay_view_hotel_booking_system
{
    partial class CustomerAdd
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
            mnCustomerAdd = new MenuStrip();
            customerHomeToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            pnlCustomerAddTitle = new Panel();
            lblCustomerAdd = new Label();
            pnlAddCustomer = new Panel();
            btnSave = new Button();
            lblEmail = new Label();
            lblPhoneNumber = new Label();
            lblSurname = new Label();
            lblForename = new Label();
            tbEmail = new TextBox();
            tbPhoneNumber = new TextBox();
            tbSurname = new TextBox();
            tbForename = new TextBox();
            viewToolStripMenuItem = new ToolStripMenuItem();
            mnCustomerAdd.SuspendLayout();
            pnlCustomerAddTitle.SuspendLayout();
            pnlAddCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // mnCustomerAdd
            // 
            mnCustomerAdd.ImageScalingSize = new Size(20, 20);
            mnCustomerAdd.Items.AddRange(new ToolStripItem[] { customerHomeToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, viewToolStripMenuItem });
            mnCustomerAdd.Location = new Point(0, 0);
            mnCustomerAdd.Name = "mnCustomerAdd";
            mnCustomerAdd.Size = new Size(467, 28);
            mnCustomerAdd.TabIndex = 0;
            mnCustomerAdd.Text = "menuStrip1";
            // 
            // customerHomeToolStripMenuItem
            // 
            customerHomeToolStripMenuItem.Name = "customerHomeToolStripMenuItem";
            customerHomeToolStripMenuItem.Size = new Size(64, 24);
            customerHomeToolStripMenuItem.Text = "Home";
            customerHomeToolStripMenuItem.Click += customerHomeToolStripMenuItem_Click;
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
            // pnlCustomerAddTitle
            // 
            pnlCustomerAddTitle.Controls.Add(lblCustomerAdd);
            pnlCustomerAddTitle.Location = new Point(12, 31);
            pnlCustomerAddTitle.Name = "pnlCustomerAddTitle";
            pnlCustomerAddTitle.Size = new Size(448, 79);
            pnlCustomerAddTitle.TabIndex = 1;
            // 
            // lblCustomerAdd
            // 
            lblCustomerAdd.AutoSize = true;
            lblCustomerAdd.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerAdd.Location = new Point(124, 24);
            lblCustomerAdd.Name = "lblCustomerAdd";
            lblCustomerAdd.Size = new Size(194, 38);
            lblCustomerAdd.TabIndex = 0;
            lblCustomerAdd.Text = "Customer Add";
            // 
            // pnlAddCustomer
            // 
            pnlAddCustomer.Controls.Add(btnSave);
            pnlAddCustomer.Controls.Add(lblEmail);
            pnlAddCustomer.Controls.Add(lblPhoneNumber);
            pnlAddCustomer.Controls.Add(lblSurname);
            pnlAddCustomer.Controls.Add(lblForename);
            pnlAddCustomer.Controls.Add(tbEmail);
            pnlAddCustomer.Controls.Add(tbPhoneNumber);
            pnlAddCustomer.Controls.Add(tbSurname);
            pnlAddCustomer.Controls.Add(tbForename);
            pnlAddCustomer.Location = new Point(12, 128);
            pnlAddCustomer.Name = "pnlAddCustomer";
            pnlAddCustomer.Size = new Size(448, 238);
            pnlAddCustomer.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(335, 192);
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
            lblEmail.Location = new Point(18, 192);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(18, 140);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(108, 20);
            lblPhoneNumber.TabIndex = 8;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(18, 83);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(67, 20);
            lblSurname.TabIndex = 7;
            lblSurname.Text = "Surname";
            // 
            // lblForename
            // 
            lblForename.AutoSize = true;
            lblForename.Location = new Point(18, 31);
            lblForename.Name = "lblForename";
            lblForename.Size = new Size(75, 20);
            lblForename.TabIndex = 6;
            lblForename.Text = "Forename";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(124, 189);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(169, 27);
            tbEmail.TabIndex = 4;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Location = new Point(147, 137);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(146, 27);
            tbPhoneNumber.TabIndex = 3;
            // 
            // tbSurname
            // 
            tbSurname.Location = new Point(124, 80);
            tbSurname.Name = "tbSurname";
            tbSurname.Size = new Size(107, 27);
            tbSurname.TabIndex = 2;
            // 
            // tbForename
            // 
            tbForename.Location = new Point(124, 28);
            tbForename.Name = "tbForename";
            tbForename.Size = new Size(107, 27);
            tbForename.TabIndex = 0;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            viewToolStripMenuItem.Click += viewToolStripMenuItem_Click;
            // 
            // CustomerAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 377);
            Controls.Add(pnlAddCustomer);
            Controls.Add(pnlCustomerAddTitle);
            Controls.Add(mnCustomerAdd);
            MainMenuStrip = mnCustomerAdd;
            Name = "CustomerAdd";
            Text = "CustomerAdd";
            mnCustomerAdd.ResumeLayout(false);
            mnCustomerAdd.PerformLayout();
            pnlCustomerAddTitle.ResumeLayout(false);
            pnlCustomerAddTitle.PerformLayout();
            pnlAddCustomer.ResumeLayout(false);
            pnlAddCustomer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnCustomerAdd;
        private ToolStripMenuItem customerHomeToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Panel pnlCustomerAddTitle;
        private Panel pnlAddCustomer;
        private TextBox tbForename;
        private Label lblCustomerAdd;
        private TextBox tbEmail;
        private TextBox tbPhoneNumber;
        private TextBox tbSurname;
        private Button btnSave;
        private Label lblEmail;
        private Label lblPhoneNumber;
        private Label lblSurname;
        private Label lblForename;
        private ToolStripMenuItem viewToolStripMenuItem;
    }
}