namespace bay_view_hotel_booking_system
{
    partial class homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homepage));
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnUser = new Button();
            lblUser = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bay_view_logo;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(143, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(358, 62);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Home";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnUser
            // 
            btnUser.Location = new Point(681, 12);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(89, 62);
            btnUser.TabIndex = 2;
            btnUser.Text = "Logout";
            btnUser.UseVisualStyleBackColor = true;
            // 
            // lblUser
            // 
            lblUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUser.Location = new Point(507, 12);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(168, 62);
            lblUser.TabIndex = 3;
            lblUser.Text = "Logged in as: \r\nUser Type: ";
            lblUser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // homepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(lblUser);
            Controls.Add(btnUser);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "homepage";
            Text = "Home";
            FormClosing += homepage_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTitle;
        private Button btnUser;
        private Label lblUser;
    }
}