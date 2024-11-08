
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
            email_lbl = new Label();
            password_lbl = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            bay_logo_picture = new PictureBox();
            introduction_lbl = new Label();
            email_textbox = new TextBox();
            password_textbox = new TextBox();
            login_btn = new Button();
            error_message_lbl = new Label();
            label1 = new Label();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bay_logo_picture).BeginInit();
            SuspendLayout();
            // 
            // email_lbl
            // 
            email_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            email_lbl.AutoSize = true;
            email_lbl.Location = new Point(23, 146);
            email_lbl.Name = "email_lbl";
            email_lbl.Size = new Size(220, 15);
            email_lbl.TabIndex = 0;
            email_lbl.Text = "Email:";
            email_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // password_lbl
            // 
            password_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            password_lbl.AutoSize = true;
            password_lbl.Location = new Point(23, 190);
            password_lbl.Name = "password_lbl";
            password_lbl.Size = new Size(220, 15);
            password_lbl.TabIndex = 1;
            password_lbl.Text = "Password:";
            password_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(bay_logo_picture);
            flowLayoutPanel1.Controls.Add(introduction_lbl);
            flowLayoutPanel1.Controls.Add(email_lbl);
            flowLayoutPanel1.Controls.Add(email_textbox);
            flowLayoutPanel1.Controls.Add(password_lbl);
            flowLayoutPanel1.Controls.Add(password_textbox);
            flowLayoutPanel1.Controls.Add(login_btn);
            flowLayoutPanel1.Controls.Add(error_message_lbl);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(267, 12);
            flowLayoutPanel1.MinimumSize = new Size(200, 218);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(20);
            flowLayoutPanel1.Size = new Size(266, 405);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // bay_logo_picture
            // 
            bay_logo_picture.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bay_logo_picture.Image = Properties.Resources.bay_view_logo;
            bay_logo_picture.Location = new Point(23, 23);
            bay_logo_picture.Name = "bay_logo_picture";
            bay_logo_picture.Size = new Size(220, 50);
            bay_logo_picture.SizeMode = PictureBoxSizeMode.Zoom;
            bay_logo_picture.TabIndex = 3;
            bay_logo_picture.TabStop = false;
            // 
            // introduction_lbl
            // 
            introduction_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            introduction_lbl.AutoSize = true;
            introduction_lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            introduction_lbl.Location = new Point(23, 76);
            introduction_lbl.Name = "introduction_lbl";
            introduction_lbl.Padding = new Padding(0, 20, 0, 20);
            introduction_lbl.Size = new Size(220, 70);
            introduction_lbl.TabIndex = 4;
            introduction_lbl.Text = "Welcome to Bay View Hotel's Booking System. To get started, please log in.";
            introduction_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // email_textbox
            // 
            email_textbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            email_textbox.Location = new Point(23, 164);
            email_textbox.Name = "email_textbox";
            email_textbox.Size = new Size(220, 23);
            email_textbox.TabIndex = 1;
            email_textbox.TextAlign = HorizontalAlignment.Center;
            // 
            // password_textbox
            // 
            password_textbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            password_textbox.Location = new Point(23, 208);
            password_textbox.Name = "password_textbox";
            password_textbox.Size = new Size(220, 23);
            password_textbox.TabIndex = 2;
            password_textbox.TextAlign = HorizontalAlignment.Center;
            password_textbox.UseSystemPasswordChar = true;
            // 
            // login_btn
            // 
            login_btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            login_btn.Location = new Point(23, 244);
            login_btn.Margin = new Padding(3, 10, 3, 3);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(220, 23);
            login_btn.TabIndex = 5;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_btn_Click;
            // 
            // error_message_lbl
            // 
            error_message_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            error_message_lbl.AutoSize = true;
            error_message_lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            error_message_lbl.ForeColor = Color.IndianRed;
            error_message_lbl.Location = new Point(23, 270);
            error_message_lbl.Name = "error_message_lbl";
            error_message_lbl.Padding = new Padding(0, 20, 0, 20);
            error_message_lbl.Size = new Size(220, 55);
            error_message_lbl.TabIndex = 6;
            error_message_lbl.Text = "Login Error: Credentials Invalid";
            error_message_lbl.TextAlign = ContentAlignment.MiddleCenter;
            error_message_lbl.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(23, 325);
            label1.Name = "label1";
            label1.Size = new Size(220, 60);
            label1.TabIndex = 3;
            label1.Text = "Default Login:\r\n\r\nadmin@bayview.com\r\npassword";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "login";
            Text = "Login";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bay_logo_picture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label email_lbl;
        private Label password_lbl;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox email_textbox;
        private TextBox password_textbox;
        private PictureBox bay_logo_picture;
        private Label introduction_lbl;
        private Button login_btn;
        private Label error_message_lbl;
        private Label label1;
    }
}

