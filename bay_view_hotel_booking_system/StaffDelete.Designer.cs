namespace bay_view_hotel_booking_system
{
    partial class StaffDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffDelete));
            mnStaffAdd = new MenuStrip();
            tsmiStaffHome = new ToolStripMenuItem();
            tsmiQuit = new ToolStripMenuItem();
            btnDelete = new Button();
            pnlEditCustomer = new Panel();
            tbStaffType = new TextBox();
            lblStaffType = new Label();
            tbStaffID = new TextBox();
            lblEmail = new Label();
            lblPhoneNumber = new Label();
            lblSurname = new Label();
            lblForename = new Label();
            lblStaffID = new Label();
            tbEmail = new TextBox();
            tbPhoneNumber = new TextBox();
            tbSurname = new TextBox();
            tbForename = new TextBox();
            mnStaffAdd.SuspendLayout();
            pnlEditCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // mnStaffAdd
            // 
            mnStaffAdd.ImageScalingSize = new Size(20, 20);
            mnStaffAdd.Items.AddRange(new ToolStripItem[] { tsmiStaffHome, tsmiQuit });
            mnStaffAdd.Location = new Point(0, 0);
            mnStaffAdd.Name = "mnStaffAdd";
            mnStaffAdd.Padding = new Padding(5, 2, 0, 2);
            mnStaffAdd.Size = new Size(684, 24);
            mnStaffAdd.TabIndex = 5;
            mnStaffAdd.Text = "menuStrip1";
            // 
            // tsmiStaffHome
            // 
            tsmiStaffHome.Name = "tsmiStaffHome";
            tsmiStaffHome.Size = new Size(117, 20);
            tsmiStaffHome.Text = "Staff Management";
            tsmiStaffHome.Click += tsmiStaffHome_Click;
            // 
            // tsmiQuit
            // 
            tsmiQuit.Name = "tsmiQuit";
            tsmiQuit.Size = new Size(130, 20);
            tsmiQuit.Text = "Return to Homepage";
            tsmiQuit.Click += tsmiQuit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(135, 181);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(144, 22);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete Staff";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // pnlEditCustomer
            // 
            pnlEditCustomer.BackColor = SystemColors.Info;
            pnlEditCustomer.BorderStyle = BorderStyle.FixedSingle;
            pnlEditCustomer.Controls.Add(tbStaffType);
            pnlEditCustomer.Controls.Add(lblStaffType);
            pnlEditCustomer.Controls.Add(tbStaffID);
            pnlEditCustomer.Controls.Add(lblEmail);
            pnlEditCustomer.Controls.Add(lblPhoneNumber);
            pnlEditCustomer.Controls.Add(lblSurname);
            pnlEditCustomer.Controls.Add(lblForename);
            pnlEditCustomer.Controls.Add(lblStaffID);
            pnlEditCustomer.Controls.Add(tbEmail);
            pnlEditCustomer.Controls.Add(tbPhoneNumber);
            pnlEditCustomer.Controls.Add(tbSurname);
            pnlEditCustomer.Controls.Add(tbForename);
            pnlEditCustomer.Location = new Point(12, 26);
            pnlEditCustomer.Margin = new Padding(3, 2, 3, 2);
            pnlEditCustomer.Name = "pnlEditCustomer";
            pnlEditCustomer.Size = new Size(387, 150);
            pnlEditCustomer.TabIndex = 13;
            // 
            // tbStaffType
            // 
            tbStaffType.Enabled = false;
            tbStaffType.Location = new Point(214, 22);
            tbStaffType.Margin = new Padding(3, 2, 3, 2);
            tbStaffType.Name = "tbStaffType";
            tbStaffType.Size = new Size(167, 23);
            tbStaffType.TabIndex = 13;
            // 
            // lblStaffType
            // 
            lblStaffType.AutoSize = true;
            lblStaffType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStaffType.Location = new Point(214, 5);
            lblStaffType.Name = "lblStaffType";
            lblStaffType.Size = new Size(67, 15);
            lblStaffType.TabIndex = 12;
            lblStaffType.Text = "Staff Type:";
            // 
            // tbStaffID
            // 
            tbStaffID.Enabled = false;
            tbStaffID.Location = new Point(3, 22);
            tbStaffID.Margin = new Padding(3, 2, 3, 2);
            tbStaffID.Name = "tbStaffID";
            tbStaffID.Size = new Size(167, 23);
            tbStaffID.TabIndex = 11;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(214, 97);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email:";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPhoneNumber.Location = new Point(214, 57);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(94, 15);
            lblPhoneNumber.TabIndex = 8;
            lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSurname.Location = new Point(3, 97);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(60, 15);
            lblSurname.TabIndex = 7;
            lblSurname.Text = "Surname:";
            // 
            // lblForename
            // 
            lblForename.AutoSize = true;
            lblForename.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblForename.Location = new Point(3, 57);
            lblForename.Name = "lblForename";
            lblForename.Size = new Size(66, 15);
            lblForename.TabIndex = 6;
            lblForename.Text = "Forename:";
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStaffID.Location = new Point(3, 5);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(51, 15);
            lblStaffID.TabIndex = 5;
            lblStaffID.Text = "StaffID:";
            // 
            // tbEmail
            // 
            tbEmail.Enabled = false;
            tbEmail.Location = new Point(214, 114);
            tbEmail.Margin = new Padding(3, 2, 3, 2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(167, 23);
            tbEmail.TabIndex = 4;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Enabled = false;
            tbPhoneNumber.Location = new Point(214, 74);
            tbPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(167, 23);
            tbPhoneNumber.TabIndex = 3;
            // 
            // tbSurname
            // 
            tbSurname.Enabled = false;
            tbSurname.Location = new Point(3, 114);
            tbSurname.Margin = new Padding(3, 2, 3, 2);
            tbSurname.Name = "tbSurname";
            tbSurname.Size = new Size(167, 23);
            tbSurname.TabIndex = 2;
            // 
            // tbForename
            // 
            tbForename.Enabled = false;
            tbForename.Location = new Point(3, 74);
            tbForename.Margin = new Padding(3, 2, 3, 2);
            tbForename.Name = "tbForename";
            tbForename.Size = new Size(167, 23);
            tbForename.TabIndex = 0;
            // 
            // StaffDelete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 340);
            Controls.Add(btnDelete);
            Controls.Add(pnlEditCustomer);
            Controls.Add(mnStaffAdd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "StaffDelete";
            Text = "Delete Staff";
            FormClosing += StaffFormClosing;
            mnStaffAdd.ResumeLayout(false);
            mnStaffAdd.PerformLayout();
            pnlEditCustomer.ResumeLayout(false);
            pnlEditCustomer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip mnStaffAdd;
        private ToolStripMenuItem tsmiStaffHome;
        private ToolStripMenuItem tsmiQuit;
        private Button btnDelete;
        private Panel pnlEditCustomer;
        private TextBox tbStaffType;
        private Label lblStaffType;
        private TextBox tbStaffID;
        private Label lblEmail;
        private Label lblPhoneNumber;
        private Label lblSurname;
        private Label lblForename;
        private Label lblStaffID;
        private TextBox tbEmail;
        private TextBox tbPhoneNumber;
        private TextBox tbSurname;
        private TextBox tbForename;
    }
}