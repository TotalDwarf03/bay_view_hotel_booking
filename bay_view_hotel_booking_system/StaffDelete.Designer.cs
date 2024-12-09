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
            mnStaffDelete = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            pnlStaffDelete = new Panel();
            tbStaffType = new TextBox();
            tbStaffID = new TextBox();
            lblStaffID = new Label();
            btnDelete = new Button();
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
            lblStaffDelete = new Label();
            mnStaffDelete.SuspendLayout();
            pnlStaffDelete.SuspendLayout();
            SuspendLayout();
            // 
            // mnStaffDelete
            // 
            mnStaffDelete.ImageScalingSize = new Size(20, 20);
            mnStaffDelete.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, viewToolStripMenuItem });
            mnStaffDelete.Location = new Point(0, 0);
            mnStaffDelete.Name = "mnStaffDelete";
            mnStaffDelete.Size = new Size(547, 28);
            mnStaffDelete.TabIndex = 0;
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
            // pnlStaffDelete
            // 
            pnlStaffDelete.Controls.Add(tbStaffType);
            pnlStaffDelete.Controls.Add(tbStaffID);
            pnlStaffDelete.Controls.Add(lblStaffID);
            pnlStaffDelete.Controls.Add(btnDelete);
            pnlStaffDelete.Controls.Add(tbPassword);
            pnlStaffDelete.Controls.Add(tbEmail);
            pnlStaffDelete.Controls.Add(tbPhoneNumber);
            pnlStaffDelete.Controls.Add(tbSurname);
            pnlStaffDelete.Controls.Add(tbForename);
            pnlStaffDelete.Controls.Add(lblPassword);
            pnlStaffDelete.Controls.Add(lblEmail);
            pnlStaffDelete.Controls.Add(lblPhoneNumber);
            pnlStaffDelete.Controls.Add(lblSurname);
            pnlStaffDelete.Controls.Add(lblForename);
            pnlStaffDelete.Controls.Add(lblStaffType);
            pnlStaffDelete.Location = new Point(0, 96);
            pnlStaffDelete.Name = "pnlStaffDelete";
            pnlStaffDelete.Size = new Size(537, 327);
            pnlStaffDelete.TabIndex = 3;
            // 
            // tbStaffType
            // 
            tbStaffType.Enabled = false;
            tbStaffType.Location = new Point(122, 68);
            tbStaffType.Name = "tbStaffType";
            tbStaffType.Size = new Size(125, 27);
            tbStaffType.TabIndex = 26;
            // 
            // tbStaffID
            // 
            tbStaffID.Enabled = false;
            tbStaffID.Location = new Point(122, 19);
            tbStaffID.Name = "tbStaffID";
            tbStaffID.Size = new Size(125, 27);
            tbStaffID.TabIndex = 25;
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Location = new Point(27, 22);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(59, 20);
            lblStaffID.TabIndex = 24;
            lblStaffID.Text = "Staff ID";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(418, 291);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(116, 29);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // tbPassword
            // 
            tbPassword.Enabled = false;
            tbPassword.Location = new Point(122, 288);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(125, 27);
            tbPassword.TabIndex = 22;
            // 
            // tbEmail
            // 
            tbEmail.Enabled = false;
            tbEmail.Location = new Point(100, 244);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(125, 27);
            tbEmail.TabIndex = 21;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Enabled = false;
            tbPhoneNumber.Location = new Point(143, 198);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(125, 27);
            tbPhoneNumber.TabIndex = 20;
            // 
            // tbSurname
            // 
            tbSurname.Enabled = false;
            tbSurname.Location = new Point(122, 155);
            tbSurname.Name = "tbSurname";
            tbSurname.Size = new Size(125, 27);
            tbSurname.TabIndex = 19;
            // 
            // tbForename
            // 
            tbForename.Enabled = false;
            tbForename.Location = new Point(122, 112);
            tbForename.Name = "tbForename";
            tbForename.Size = new Size(125, 27);
            tbForename.TabIndex = 18;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(24, 291);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 17;
            lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(24, 247);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 16;
            lblEmail.Text = "Email";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(24, 201);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(108, 20);
            lblPhoneNumber.TabIndex = 15;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(24, 155);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(67, 20);
            lblSurname.TabIndex = 13;
            lblSurname.Text = "Surname";
            // 
            // lblForename
            // 
            lblForename.AutoSize = true;
            lblForename.Location = new Point(24, 113);
            lblForename.Name = "lblForename";
            lblForename.Size = new Size(75, 20);
            lblForename.TabIndex = 12;
            lblForename.Text = "Forename";
            // 
            // lblStaffType
            // 
            lblStaffType.AutoSize = true;
            lblStaffType.Location = new Point(24, 71);
            lblStaffType.Name = "lblStaffType";
            lblStaffType.Size = new Size(75, 20);
            lblStaffType.TabIndex = 11;
            lblStaffType.Text = "Staff Type";
            // 
            // lblStaffDelete
            // 
            lblStaffDelete.AutoSize = true;
            lblStaffDelete.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStaffDelete.Location = new Point(12, 40);
            lblStaffDelete.Name = "lblStaffDelete";
            lblStaffDelete.Size = new Size(170, 41);
            lblStaffDelete.TabIndex = 4;
            lblStaffDelete.Text = "Staff Delete";
            // 
            // StaffDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 429);
            Controls.Add(lblStaffDelete);
            Controls.Add(pnlStaffDelete);
            Controls.Add(mnStaffDelete);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mnStaffDelete;
            Name = "StaffDelete";
            Text = "StaffDelete";
            mnStaffDelete.ResumeLayout(false);
            mnStaffDelete.PerformLayout();
            pnlStaffDelete.ResumeLayout(false);
            pnlStaffDelete.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnStaffDelete;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private Panel pnlStaffDelete;
        private TextBox tbStaffType;
        private TextBox tbStaffID;
        private Label lblStaffID;
        private Button btnDelete;
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
        private Label lblStaffDelete;
    }
}