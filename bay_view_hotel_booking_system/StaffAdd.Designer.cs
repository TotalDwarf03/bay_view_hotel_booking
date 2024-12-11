namespace bay_view_hotel_booking_system
{
    partial class StaffAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffAdd));
            mnStaffAdd = new MenuStrip();
            tsmiStaffHome = new ToolStripMenuItem();
            tsmiQuit = new ToolStripMenuItem();
            pnlAddStaff = new Panel();
            cbStaffType = new ComboBox();
            lblStaff = new Label();
            lblStaffType = new Label();
            lblPhoneNumber = new Label();
            lblSurname = new Label();
            lblForename = new Label();
            tbPhoneNumber = new TextBox();
            tbSurname = new TextBox();
            tbForename = new TextBox();
            btnSave = new Button();
            panel1 = new Panel();
            lblLogin = new Label();
            lblPassword = new Label();
            lblEmail = new Label();
            tbPassword = new TextBox();
            tbEmail = new TextBox();
            mnStaffAdd.SuspendLayout();
            pnlAddStaff.SuspendLayout();
            panel1.SuspendLayout();
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
            mnStaffAdd.TabIndex = 1;
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
            // pnlAddStaff
            // 
            pnlAddStaff.BackColor = SystemColors.ControlLight;
            pnlAddStaff.BorderStyle = BorderStyle.FixedSingle;
            pnlAddStaff.Controls.Add(cbStaffType);
            pnlAddStaff.Controls.Add(lblStaff);
            pnlAddStaff.Controls.Add(lblStaffType);
            pnlAddStaff.Controls.Add(lblPhoneNumber);
            pnlAddStaff.Controls.Add(lblSurname);
            pnlAddStaff.Controls.Add(lblForename);
            pnlAddStaff.Controls.Add(tbPhoneNumber);
            pnlAddStaff.Controls.Add(tbSurname);
            pnlAddStaff.Controls.Add(tbForename);
            pnlAddStaff.Location = new Point(12, 26);
            pnlAddStaff.Margin = new Padding(3, 2, 3, 2);
            pnlAddStaff.Name = "pnlAddStaff";
            pnlAddStaff.Size = new Size(387, 124);
            pnlAddStaff.TabIndex = 5;
            // 
            // cbStaffType
            // 
            cbStaffType.FormattingEnabled = true;
            cbStaffType.Location = new Point(214, 85);
            cbStaffType.Name = "cbStaffType";
            cbStaffType.Size = new Size(167, 23);
            cbStaffType.TabIndex = 28;
            // 
            // lblStaff
            // 
            lblStaff.AutoSize = true;
            lblStaff.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStaff.Location = new Point(3, 4);
            lblStaff.Name = "lblStaff";
            lblStaff.Size = new Size(79, 15);
            lblStaff.TabIndex = 11;
            lblStaff.Text = "Staff Details:";
            // 
            // lblStaffType
            // 
            lblStaffType.AutoSize = true;
            lblStaffType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStaffType.Location = new Point(214, 67);
            lblStaffType.Name = "lblStaffType";
            lblStaffType.Size = new Size(67, 15);
            lblStaffType.TabIndex = 27;
            lblStaffType.Text = "Staff Type:";
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
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ControlLightLight;
            btnSave.Location = new Point(122, 240);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(144, 22);
            btnSave.TabIndex = 10;
            btnSave.Text = "Add Staff";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblLogin);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(tbEmail);
            panel1.Location = new Point(12, 154);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(387, 82);
            panel1.TabIndex = 29;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLogin.Location = new Point(3, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(81, 15);
            lblLogin.TabIndex = 29;
            lblLogin.Text = "Login Details:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPassword.Location = new Point(214, 27);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(59, 15);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(3, 27);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(214, 44);
            tbPassword.Margin = new Padding(3, 2, 3, 2);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(167, 23);
            tbPassword.TabIndex = 3;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(3, 44);
            tbEmail.Margin = new Padding(3, 2, 3, 2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(167, 23);
            tbEmail.TabIndex = 0;
            // 
            // StaffAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 340);
            Controls.Add(panel1);
            Controls.Add(pnlAddStaff);
            Controls.Add(mnStaffAdd);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mnStaffAdd;
            Margin = new Padding(3, 2, 3, 2);
            Name = "StaffAdd";
            Text = "Add Staff";
            FormClosing += StaffFormClosing;
            mnStaffAdd.ResumeLayout(false);
            mnStaffAdd.PerformLayout();
            pnlAddStaff.ResumeLayout(false);
            pnlAddStaff.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip mnStaffAdd;
        private ToolStripMenuItem tsmiStaffHome;
        private ToolStripMenuItem tsmiQuit;
        private Panel pnlAddStaff;
        private Label lblStaff;
        private Button btnSave;
        private Label lblPhoneNumber;
        private Label lblSurname;
        private Label lblForename;
        private TextBox tbPhoneNumber;
        private TextBox tbSurname;
        private TextBox tbForename;
        private ComboBox cbStaffType;
        private Label lblStaffType;
        private Panel panel1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label lblPassword;
        private Label label4;
        private Label lblEmail;
        private TextBox tbPassword;
        private TextBox textBox2;
        private TextBox tbEmail;
        private Label lblLogin;
    }
}