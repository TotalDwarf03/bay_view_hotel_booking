namespace bay_view_hotel_booking_system
{
    partial class StaffEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffEdit));
            mnStaffEdit = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            pnlStaffEditTitle = new Panel();
            label1 = new Label();
            pnlStaffEdit = new Panel();
            tbStaffID = new TextBox();
            lblStaffID = new Label();
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
            mnStaffEdit.SuspendLayout();
            pnlStaffEditTitle.SuspendLayout();
            pnlStaffEdit.SuspendLayout();
            SuspendLayout();
            // 
            // mnStaffEdit
            // 
            mnStaffEdit.ImageScalingSize = new Size(20, 20);
            mnStaffEdit.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, viewToolStripMenuItem });
            mnStaffEdit.Location = new Point(0, 0);
            mnStaffEdit.Name = "mnStaffEdit";
            mnStaffEdit.Size = new Size(576, 28);
            mnStaffEdit.TabIndex = 0;
            mnStaffEdit.Text = "menuStrip1";
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
            // pnlStaffEditTitle
            // 
            pnlStaffEditTitle.Controls.Add(label1);
            pnlStaffEditTitle.Location = new Point(12, 31);
            pnlStaffEditTitle.Name = "pnlStaffEditTitle";
            pnlStaffEditTitle.Size = new Size(545, 83);
            pnlStaffEditTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 19);
            label1.Name = "label1";
            label1.Size = new Size(154, 46);
            label1.TabIndex = 2;
            label1.Text = "Staff Edit";
            // 
            // pnlStaffEdit
            // 
            pnlStaffEdit.Controls.Add(tbStaffType);
            pnlStaffEdit.Controls.Add(tbStaffID);
            pnlStaffEdit.Controls.Add(lblStaffID);
            pnlStaffEdit.Controls.Add(btnSave);
            pnlStaffEdit.Controls.Add(tbPassword);
            pnlStaffEdit.Controls.Add(tbEmail);
            pnlStaffEdit.Controls.Add(tbPhoneNumber);
            pnlStaffEdit.Controls.Add(tbSurname);
            pnlStaffEdit.Controls.Add(tbForename);
            pnlStaffEdit.Controls.Add(lblPassword);
            pnlStaffEdit.Controls.Add(lblEmail);
            pnlStaffEdit.Controls.Add(lblPhoneNumber);
            pnlStaffEdit.Controls.Add(lblSurname);
            pnlStaffEdit.Controls.Add(lblForename);
            pnlStaffEdit.Controls.Add(lblStaffType);
            pnlStaffEdit.Location = new Point(12, 120);
            pnlStaffEdit.Name = "pnlStaffEdit";
            pnlStaffEdit.Size = new Size(545, 327);
            pnlStaffEdit.TabIndex = 2;
            // 
            // tbStaffID
            // 
            tbStaffID.Enabled = false;
            tbStaffID.Location = new Point(122, 19);
            tbStaffID.Name = "tbStaffID";
            tbStaffID.ReadOnly = true;
            tbStaffID.Size = new Size(103, 27);
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
            // btnSave
            // 
            btnSave.Location = new Point(401, 290);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 29);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(122, 288);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(125, 27);
            tbPassword.TabIndex = 22;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(100, 244);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(125, 27);
            tbEmail.TabIndex = 21;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Location = new Point(143, 198);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(125, 27);
            tbPhoneNumber.TabIndex = 20;
            // 
            // tbSurname
            // 
            tbSurname.Location = new Point(122, 155);
            tbSurname.Name = "tbSurname";
            tbSurname.Size = new Size(125, 27);
            tbSurname.TabIndex = 19;
            // 
            // tbForename
            // 
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
            // tbStaffType
            // 
            tbStaffType.Location = new Point(126, 67);
            tbStaffType.Name = "tbStaffType";
            tbStaffType.Size = new Size(125, 27);
            tbStaffType.TabIndex = 26;
            // 
            // StaffEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 451);
            Controls.Add(pnlStaffEdit);
            Controls.Add(pnlStaffEditTitle);
            Controls.Add(mnStaffEdit);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mnStaffEdit;
            Name = "StaffEdit";
            Text = "StaffEdit";
            mnStaffEdit.ResumeLayout(false);
            mnStaffEdit.PerformLayout();
            pnlStaffEditTitle.ResumeLayout(false);
            pnlStaffEditTitle.PerformLayout();
            pnlStaffEdit.ResumeLayout(false);
            pnlStaffEdit.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnStaffEdit;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private Panel pnlStaffEditTitle;
        private Label label1;
        private Panel pnlStaffEdit;
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
        private TextBox tbStaffID;
        private Label lblStaffID;
        private TextBox tbStaffType;
    }
}