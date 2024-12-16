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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDelete));
            menuStrip1 = new MenuStrip();
            tsmiCustomerHome = new ToolStripMenuItem();
            tsmiQuit = new ToolStripMenuItem();
            pnlEditCustomer = new Panel();
            tbCustomerID = new TextBox();
            lblEmail = new Label();
            lblPhoneNumber = new Label();
            lblSurname = new Label();
            lblForename = new Label();
            lblCustomerID = new Label();
            tbEmail = new TextBox();
            tbPhoneNumber = new TextBox();
            tbSurname = new TextBox();
            tbForename = new TextBox();
            btnDelete = new Button();
            menuStrip1.SuspendLayout();
            pnlEditCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiCustomerHome, tsmiQuit });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(782, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "mnCustomerDelete";
            // 
            // tsmiCustomerHome
            // 
            tsmiCustomerHome.Name = "tsmiCustomerHome";
            tsmiCustomerHome.Size = new Size(178, 24);
            tsmiCustomerHome.Text = "Customer Management";
            tsmiCustomerHome.Click += tsmiCustomerHome_Click;
            // 
            // tsmiQuit
            // 
            tsmiQuit.Name = "tsmiQuit";
            tsmiQuit.Size = new Size(163, 24);
            tsmiQuit.Text = "Return to Homepage";
            tsmiQuit.Click += tsmiQuit_Click;
            // 
            // pnlEditCustomer
            // 
            pnlEditCustomer.BackColor = SystemColors.Info;
            pnlEditCustomer.BorderStyle = BorderStyle.FixedSingle;
            pnlEditCustomer.Controls.Add(tbCustomerID);
            pnlEditCustomer.Controls.Add(lblEmail);
            pnlEditCustomer.Controls.Add(lblPhoneNumber);
            pnlEditCustomer.Controls.Add(lblSurname);
            pnlEditCustomer.Controls.Add(lblForename);
            pnlEditCustomer.Controls.Add(lblCustomerID);
            pnlEditCustomer.Controls.Add(tbEmail);
            pnlEditCustomer.Controls.Add(tbPhoneNumber);
            pnlEditCustomer.Controls.Add(tbSurname);
            pnlEditCustomer.Controls.Add(tbForename);
            pnlEditCustomer.Location = new Point(11, 31);
            pnlEditCustomer.Name = "pnlEditCustomer";
            pnlEditCustomer.Size = new Size(442, 199);
            pnlEditCustomer.TabIndex = 4;
            // 
            // tbCustomerID
            // 
            tbCustomerID.Enabled = false;
            tbCustomerID.Location = new Point(3, 29);
            tbCustomerID.Name = "tbCustomerID";
            tbCustomerID.Size = new Size(190, 27);
            tbCustomerID.TabIndex = 11;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(245, 129);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 20);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email:";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPhoneNumber.Location = new Point(245, 76);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(120, 20);
            lblPhoneNumber.TabIndex = 8;
            lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSurname.Location = new Point(3, 129);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(75, 20);
            lblSurname.TabIndex = 7;
            lblSurname.Text = "Surname:";
            // 
            // lblForename
            // 
            lblForename.AutoSize = true;
            lblForename.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblForename.Location = new Point(3, 76);
            lblForename.Name = "lblForename";
            lblForename.Size = new Size(83, 20);
            lblForename.TabIndex = 6;
            lblForename.Text = "Forename:";
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCustomerID.Location = new Point(3, 7);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(97, 20);
            lblCustomerID.TabIndex = 5;
            lblCustomerID.Text = "CustomerID:";
            // 
            // tbEmail
            // 
            tbEmail.Enabled = false;
            tbEmail.Location = new Point(245, 152);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(190, 27);
            tbEmail.TabIndex = 4;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Enabled = false;
            tbPhoneNumber.Location = new Point(245, 99);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(190, 27);
            tbPhoneNumber.TabIndex = 3;
            // 
            // tbSurname
            // 
            tbSurname.Enabled = false;
            tbSurname.Location = new Point(3, 152);
            tbSurname.Name = "tbSurname";
            tbSurname.Size = new Size(190, 27);
            tbSurname.TabIndex = 2;
            // 
            // tbForename
            // 
            tbForename.Enabled = false;
            tbForename.Location = new Point(3, 99);
            tbForename.Name = "tbForename";
            tbForename.Size = new Size(190, 27);
            tbForename.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(152, 237);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(165, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete Customer";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // CustomerDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(btnDelete);
            Controls.Add(pnlEditCustomer);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "CustomerDelete";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delete Customer";
            FormClosing += CustomerEdit_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlEditCustomer.ResumeLayout(false);
            pnlEditCustomer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Panel pnlCustomerDelete;
        private Label lblCustomerDelete;
        private ToolStripMenuItem tsmiCustomerHome;
        private ToolStripMenuItem tsmiQuit;
        private Panel pnlEditCustomer;
        private TextBox tbCustomerID;
        private Button btnSave;
        private Label lblEmail;
        private Label lblPhoneNumber;
        private Label lblSurname;
        private Label lblForename;
        private Label lblCustomerID;
        private TextBox tbEmail;
        private TextBox tbPhoneNumber;
        private TextBox tbSurname;
        private TextBox tbForename;
        private Button btnDelete;
    }
}