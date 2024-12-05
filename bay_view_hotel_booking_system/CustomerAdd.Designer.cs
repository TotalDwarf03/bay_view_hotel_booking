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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerAdd));
            mnCustomerAdd = new MenuStrip();
            tsmiCustomerHome = new ToolStripMenuItem();
            tsmiQuit = new ToolStripMenuItem();
            pnlEditCustomer = new Panel();
            lblCustomer = new Label();
            btnSave = new Button();
            lblEmail = new Label();
            lblPhoneNumber = new Label();
            lblSurname = new Label();
            lblForename = new Label();
            tbEmail = new TextBox();
            tbPhoneNumber = new TextBox();
            tbSurname = new TextBox();
            tbForename = new TextBox();
            mnCustomerAdd.SuspendLayout();
            pnlEditCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // mnCustomerAdd
            // 
            mnCustomerAdd.ImageScalingSize = new Size(20, 20);
            mnCustomerAdd.Items.AddRange(new ToolStripItem[] { tsmiCustomerHome, tsmiQuit });
            mnCustomerAdd.Location = new Point(0, 0);
            mnCustomerAdd.Name = "mnCustomerAdd";
            mnCustomerAdd.Padding = new Padding(5, 2, 0, 2);
            mnCustomerAdd.Size = new Size(852, 24);
            mnCustomerAdd.TabIndex = 0;
            mnCustomerAdd.Text = "menuStrip1";
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
            // pnlEditCustomer
            // 
            pnlEditCustomer.BackColor = SystemColors.ControlLight;
            pnlEditCustomer.BorderStyle = BorderStyle.FixedSingle;
            pnlEditCustomer.Controls.Add(lblCustomer);
            pnlEditCustomer.Controls.Add(btnSave);
            pnlEditCustomer.Controls.Add(lblEmail);
            pnlEditCustomer.Controls.Add(lblPhoneNumber);
            pnlEditCustomer.Controls.Add(lblSurname);
            pnlEditCustomer.Controls.Add(lblForename);
            pnlEditCustomer.Controls.Add(tbEmail);
            pnlEditCustomer.Controls.Add(tbPhoneNumber);
            pnlEditCustomer.Controls.Add(tbSurname);
            pnlEditCustomer.Controls.Add(tbForename);
            pnlEditCustomer.Location = new Point(10, 23);
            pnlEditCustomer.Margin = new Padding(3, 2, 3, 2);
            pnlEditCustomer.Name = "pnlEditCustomer";
            pnlEditCustomer.Size = new Size(387, 156);
            pnlEditCustomer.TabIndex = 4;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCustomer.Location = new Point(3, 4);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(105, 15);
            lblCustomer.TabIndex = 11;
            lblCustomer.Text = "Customer Details:";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ControlLightLight;
            btnSave.Location = new Point(122, 124);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(144, 22);
            btnSave.TabIndex = 10;
            btnSave.Text = "Add Customer";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(214, 67);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email:";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPhoneNumber.Location = new Point(214, 27);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(94, 15);
            lblPhoneNumber.TabIndex = 8;
            lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSurname.Location = new Point(3, 67);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(60, 15);
            lblSurname.TabIndex = 7;
            lblSurname.Text = "Surname:";
            // 
            // lblForename
            // 
            lblForename.AutoSize = true;
            lblForename.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblForename.Location = new Point(3, 27);
            lblForename.Name = "lblForename";
            lblForename.Size = new Size(66, 15);
            lblForename.TabIndex = 6;
            lblForename.Text = "Forename:";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(214, 84);
            tbEmail.Margin = new Padding(3, 2, 3, 2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(167, 23);
            tbEmail.TabIndex = 4;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Location = new Point(214, 44);
            tbPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(167, 23);
            tbPhoneNumber.TabIndex = 3;
            // 
            // tbSurname
            // 
            tbSurname.Location = new Point(3, 84);
            tbSurname.Margin = new Padding(3, 2, 3, 2);
            tbSurname.Name = "tbSurname";
            tbSurname.Size = new Size(167, 23);
            tbSurname.TabIndex = 2;
            // 
            // tbForename
            // 
            tbForename.Location = new Point(3, 44);
            tbForename.Margin = new Padding(3, 2, 3, 2);
            tbForename.Name = "tbForename";
            tbForename.Size = new Size(167, 23);
            tbForename.TabIndex = 0;
            // 
            // CustomerAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 283);
            Controls.Add(pnlEditCustomer);
            Controls.Add(mnCustomerAdd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mnCustomerAdd;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CustomerAdd";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Customer";
            FormClosing += CustomerEdit_FormClosing;
            mnCustomerAdd.ResumeLayout(false);
            mnCustomerAdd.PerformLayout();
            pnlEditCustomer.ResumeLayout(false);
            pnlEditCustomer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnCustomerAdd;
        private Panel pnlEditCustomer;
        private Label lblCustomer;
        private Button btnSave;
        private Label lblEmail;
        private Label lblPhoneNumber;
        private Label lblSurname;
        private Label lblForename;
        private TextBox tbEmail;
        private TextBox tbPhoneNumber;
        private TextBox tbSurname;
        private TextBox tbForename;
        private ToolStripMenuItem tsmiCustomerHome;
        private ToolStripMenuItem tsmiQuit;
    }
}