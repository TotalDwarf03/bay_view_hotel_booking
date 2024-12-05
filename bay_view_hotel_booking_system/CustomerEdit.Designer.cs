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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerEdit));
            mnCustomerEdit = new MenuStrip();
            tsmiCustomerHome = new ToolStripMenuItem();
            tsmiQuit = new ToolStripMenuItem();
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
            mnCustomerEdit.SuspendLayout();
            pnlEditCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // mnCustomerEdit
            // 
            mnCustomerEdit.ImageScalingSize = new Size(20, 20);
            mnCustomerEdit.Items.AddRange(new ToolStripItem[] { tsmiCustomerHome, tsmiQuit });
            mnCustomerEdit.Location = new Point(0, 0);
            mnCustomerEdit.Name = "mnCustomerEdit";
            mnCustomerEdit.Size = new Size(782, 28);
            mnCustomerEdit.TabIndex = 0;
            mnCustomerEdit.Text = "menuStrip1";
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
            // pnlEditCustomer
            // 
            pnlEditCustomer.BackColor = SystemColors.ControlLight;
            pnlEditCustomer.BorderStyle = BorderStyle.FixedSingle;
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
            pnlEditCustomer.Location = new Point(12, 31);
            pnlEditCustomer.Name = "pnlEditCustomer";
            pnlEditCustomer.Size = new Size(442, 248);
            pnlEditCustomer.TabIndex = 3;
            // 
            // tbCustomerID
            // 
            tbCustomerID.Enabled = false;
            tbCustomerID.Location = new Point(3, 30);
            tbCustomerID.Name = "tbCustomerID";
            tbCustomerID.Size = new Size(190, 27);
            tbCustomerID.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ControlLightLight;
            btnSave.Location = new Point(139, 205);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(164, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Update Customer";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(244, 129);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 20);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email:";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPhoneNumber.Location = new Point(244, 76);
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
            // tbEmail
            // 
            tbEmail.Location = new Point(244, 152);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(190, 27);
            tbEmail.TabIndex = 4;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Location = new Point(244, 99);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(190, 27);
            tbPhoneNumber.TabIndex = 3;
            // 
            // tbSurname
            // 
            tbSurname.Location = new Point(3, 152);
            tbSurname.Name = "tbSurname";
            tbSurname.Size = new Size(190, 27);
            tbSurname.TabIndex = 2;
            // 
            // tbForename
            // 
            tbForename.Location = new Point(3, 99);
            tbForename.Name = "tbForename";
            tbForename.Size = new Size(190, 27);
            tbForename.TabIndex = 0;
            // 
            // CustomerEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(pnlEditCustomer);
            Controls.Add(mnCustomerEdit);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mnCustomerEdit;
            Name = "CustomerEdit";
            Text = "Edit Customer";
            FormClosing += CustomerEdit_FormClosing;
            mnCustomerEdit.ResumeLayout(false);
            mnCustomerEdit.PerformLayout();
            pnlEditCustomer.ResumeLayout(false);
            pnlEditCustomer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnCustomerEdit;
        private ToolStripMenuItem tsmiCustomerHome;
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
        private TextBox tbCustomerID;
        private ToolStripMenuItem tsmiQuit;
    }
}