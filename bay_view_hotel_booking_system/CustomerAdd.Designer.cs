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
            mnCustomerAdd.Size = new Size(974, 28);
            mnCustomerAdd.TabIndex = 0;
            mnCustomerAdd.Text = "menuStrip1";
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
            pnlEditCustomer.Location = new Point(12, 31);
            pnlEditCustomer.Name = "pnlEditCustomer";
            pnlEditCustomer.Size = new Size(442, 208);
            pnlEditCustomer.TabIndex = 4;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCustomer.Location = new Point(3, 6);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(133, 20);
            lblCustomer.TabIndex = 11;
            lblCustomer.Text = "Customer Details:";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ControlLightLight;
            btnSave.Location = new Point(139, 165);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(164, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Add Customer";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(244, 89);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 20);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email:";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPhoneNumber.Location = new Point(244, 36);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(120, 20);
            lblPhoneNumber.TabIndex = 8;
            lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSurname.Location = new Point(3, 89);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(75, 20);
            lblSurname.TabIndex = 7;
            lblSurname.Text = "Surname:";
            // 
            // lblForename
            // 
            lblForename.AutoSize = true;
            lblForename.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblForename.Location = new Point(3, 36);
            lblForename.Name = "lblForename";
            lblForename.Size = new Size(83, 20);
            lblForename.TabIndex = 6;
            lblForename.Text = "Forename:";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(244, 112);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(190, 27);
            tbEmail.TabIndex = 4;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Location = new Point(244, 59);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(190, 27);
            tbPhoneNumber.TabIndex = 3;
            // 
            // tbSurname
            // 
            tbSurname.Location = new Point(3, 112);
            tbSurname.Name = "tbSurname";
            tbSurname.Size = new Size(190, 27);
            tbSurname.TabIndex = 2;
            // 
            // tbForename
            // 
            tbForename.Location = new Point(3, 59);
            tbForename.Name = "tbForename";
            tbForename.Size = new Size(190, 27);
            tbForename.TabIndex = 0;
            // 
            // CustomerAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 377);
            Controls.Add(pnlEditCustomer);
            Controls.Add(mnCustomerAdd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mnCustomerAdd;
            Name = "CustomerAdd";
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