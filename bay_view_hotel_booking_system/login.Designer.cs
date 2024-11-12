
namespace bay_view_hotel_booking_system
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            lblEmail = new Label();
            lblPassword = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pbLogo = new PictureBox();
            lblIntroduction = new Label();
            tbEmail = new TextBox();
            tbPassword = new TextBox();
            btnLogin = new Button();
            lblDefaultCredentials = new Label();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(26, 216);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(239, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(26, 271);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(239, 20);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password:";
            lblPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(pbLogo);
            flowLayoutPanel1.Controls.Add(lblIntroduction);
            flowLayoutPanel1.Controls.Add(lblEmail);
            flowLayoutPanel1.Controls.Add(tbEmail);
            flowLayoutPanel1.Controls.Add(lblPassword);
            flowLayoutPanel1.Controls.Add(tbPassword);
            flowLayoutPanel1.Controls.Add(btnLogin);
            flowLayoutPanel1.Controls.Add(lblDefaultCredentials);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(305, 16);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.MinimumSize = new Size(229, 291);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(23, 27, 23, 27);
            flowLayoutPanel1.Size = new Size(291, 661);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // pbLogo
            // 
            pbLogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbLogo.Image = Properties.Resources.bay_view_logo;
            pbLogo.Location = new Point(26, 31);
            pbLogo.Margin = new Padding(3, 4, 3, 4);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(239, 67);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 3;
            pbLogo.TabStop = false;
            // 
            // lblIntroduction
            // 
            lblIntroduction.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblIntroduction.AutoSize = true;
            lblIntroduction.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblIntroduction.Location = new Point(26, 102);
            lblIntroduction.Name = "lblIntroduction";
            lblIntroduction.Padding = new Padding(0, 27, 0, 27);
            lblIntroduction.Size = new Size(239, 114);
            lblIntroduction.TabIndex = 4;
            lblIntroduction.Text = "Welcome to Bay View Hotel's Booking System. To get started, please log in.";
            lblIntroduction.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbEmail
            // 
            tbEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbEmail.Location = new Point(26, 240);
            tbEmail.Margin = new Padding(3, 4, 3, 4);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(239, 27);
            tbEmail.TabIndex = 1;
            tbEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbPassword.Location = new Point(26, 295);
            tbPassword.Margin = new Padding(3, 4, 3, 4);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(239, 27);
            tbPassword.TabIndex = 2;
            tbPassword.TextAlign = HorizontalAlignment.Center;
            tbPassword.UseSystemPasswordChar = true;
            tbPassword.KeyPress += tbPassword_KeyPress;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.Location = new Point(26, 339);
            btnLogin.Margin = new Padding(3, 13, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(239, 31);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += login_btn_Click;
            // 
            // lblDefaultCredentials
            // 
            lblDefaultCredentials.AutoSize = true;
            lblDefaultCredentials.Dock = DockStyle.Fill;
            lblDefaultCredentials.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDefaultCredentials.Location = new Point(26, 374);
            lblDefaultCredentials.Name = "lblDefaultCredentials";
            lblDefaultCredentials.Size = new Size(239, 260);
            lblDefaultCredentials.TabIndex = 3;
            lblDefaultCredentials.Text = resources.GetString("lblDefaultCredentials.Text");
            lblDefaultCredentials.TextAlign = ContentAlignment.TopCenter;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 681);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "login";
            Text = "Login";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private Label lblPassword;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox tbEmail;
        private TextBox tbPassword;
        private PictureBox pbLogo;
        private Label lblIntroduction;
        private Button btnLogin;
        private Label lblDefaultCredentials;
    }
}

