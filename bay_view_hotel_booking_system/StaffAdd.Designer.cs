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
            lblStaffAdd = new Label();
            mnStaffAdd = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            pnlStaffAdd = new Panel();
            btnSave = new Button();
            tbPassword = new TextBox();
            tbEmail = new TextBox();
            tbPhoneNumber = new TextBox();
            tbSurname = new TextBox();
            tbForename = new TextBox();
            lblPassword = new Label();
            lblEmail = new Label();
            lblPhoneNumber = new Label();
            lblSurname = new Label();
            lblForename = new Label();
            lblStaffType = new Label();
            tbStaffType = new TextBox();
            mnStaffAdd.SuspendLayout();
            pnlStaffAdd.SuspendLayout();
            SuspendLayout();
            // 
            // lblStaffAdd
            // 
            lblStaffAdd.AutoSize = true;
            lblStaffAdd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStaffAdd.Location = new Point(180, 50);
            lblStaffAdd.Name = "lblStaffAdd";
            lblStaffAdd.Size = new Size(139, 41);
            lblStaffAdd.TabIndex = 0;
            lblStaffAdd.Text = "Staff Add";
            // 
            // mnStaffAdd
            // 
            mnStaffAdd.ImageScalingSize = new Size(20, 20);
            mnStaffAdd.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, viewToolStripMenuItem });
            mnStaffAdd.Location = new Point(0, 0);
            mnStaffAdd.Name = "mnStaffAdd";
            mnStaffAdd.Size = new Size(498, 28);
            mnStaffAdd.TabIndex = 1;
            mnStaffAdd.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(146, 24);
            homeToolStripMenuItem.Text = "Staff Management";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(90, 24);
            viewToolStripMenuItem.Text = "Staff View";
            viewToolStripMenuItem.Click += viewToolStripMenuItem_Click;
            // 
            // pnlStaffAdd
            // 
            pnlStaffAdd.Controls.Add(tbStaffType);
            pnlStaffAdd.Controls.Add(btnSave);
            pnlStaffAdd.Controls.Add(tbPassword);
            pnlStaffAdd.Controls.Add(tbEmail);
            pnlStaffAdd.Controls.Add(tbPhoneNumber);
            pnlStaffAdd.Controls.Add(tbSurname);
            pnlStaffAdd.Controls.Add(tbForename);
            pnlStaffAdd.Controls.Add(lblPassword);
            pnlStaffAdd.Controls.Add(lblEmail);
            pnlStaffAdd.Controls.Add(lblPhoneNumber);
            pnlStaffAdd.Controls.Add(lblSurname);
            pnlStaffAdd.Controls.Add(lblForename);
            pnlStaffAdd.Controls.Add(lblStaffType);
            pnlStaffAdd.Location = new Point(12, 109);
            pnlStaffAdd.Name = "pnlStaffAdd";
            pnlStaffAdd.Size = new Size(474, 278);
            pnlStaffAdd.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(353, 236);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(113, 233);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(125, 27);
            tbPassword.TabIndex = 10;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(91, 189);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(125, 27);
            tbEmail.TabIndex = 9;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Location = new Point(134, 143);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(125, 27);
            tbPhoneNumber.TabIndex = 8;
            // 
            // tbSurname
            // 
            tbSurname.Location = new Point(113, 100);
            tbSurname.Name = "tbSurname";
            tbSurname.Size = new Size(125, 27);
            tbSurname.TabIndex = 7;
            // 
            // tbForename
            // 
            tbForename.Location = new Point(113, 57);
            tbForename.Name = "tbForename";
            tbForename.Size = new Size(125, 27);
            tbForename.TabIndex = 6;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(15, 236);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(15, 192);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(15, 146);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(104, 20);
            lblPhoneNumber.TabIndex = 3;
            lblPhoneNumber.Text = "PhoneNumber";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(15, 100);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(67, 20);
            lblSurname.TabIndex = 2;
            lblSurname.Text = "Surname";
            // 
            // lblForename
            // 
            lblForename.AutoSize = true;
            lblForename.Location = new Point(15, 58);
            lblForename.Name = "lblForename";
            lblForename.Size = new Size(75, 20);
            lblForename.TabIndex = 1;
            lblForename.Text = "Forename";
            // 
            // lblStaffType
            // 
            lblStaffType.AutoSize = true;
            lblStaffType.Location = new Point(15, 16);
            lblStaffType.Name = "lblStaffType";
            lblStaffType.Size = new Size(75, 20);
            lblStaffType.TabIndex = 0;
            lblStaffType.Text = "Staff Type";
            // 
            // tbStaffType
            // 
            tbStaffType.Location = new Point(114, 12);
            tbStaffType.Name = "tbStaffType";
            tbStaffType.Size = new Size(125, 27);
            tbStaffType.TabIndex = 12;
            // 
            // StaffAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 397);
            Controls.Add(pnlStaffAdd);
            Controls.Add(lblStaffAdd);
            Controls.Add(mnStaffAdd);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mnStaffAdd;
            Name = "StaffAdd";
            Text = "StaffAdd";
            mnStaffAdd.ResumeLayout(false);
            mnStaffAdd.PerformLayout();
            pnlStaffAdd.ResumeLayout(false);
            pnlStaffAdd.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStaffAdd;
        private MenuStrip mnStaffAdd;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private Panel pnlStaffAdd;
        private TextBox tbPassword;
        private TextBox tbEmail;
        private TextBox tbPhoneNumber;
        private TextBox tbSurname;
        private TextBox tbForename;
        private Label lblPassword;
        private Label lblEmail;
        private Label lblPhoneNumber;
        private Label lblSurname;
        private Label lblForename;
        private Label lblStaffType;
        private Button btnSave;
        private TextBox tbStaffType;
    }
}