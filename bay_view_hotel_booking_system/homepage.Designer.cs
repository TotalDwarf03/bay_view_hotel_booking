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
            pbLogo = new PictureBox();
            lblTitle = new Label();
            btnUser = new Button();
            lblUser = new Label();
            pnlHeader = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.bay_view_logo;
            pbLogo.Location = new Point(3, 3);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(125, 62);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(134, 3);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(124, 62);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Home";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnUser
            // 
            btnUser.Location = new Point(672, 3);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(83, 62);
            btnUser.TabIndex = 2;
            btnUser.Text = "Logout";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // lblUser
            // 
            lblUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUser.Location = new Point(472, 3);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(194, 62);
            lblUser.TabIndex = 3;
            lblUser.Text = "Logged in as: \r\nUser Type: ";
            lblUser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = SystemColors.Info;
            pnlHeader.BorderStyle = BorderStyle.FixedSingle;
            pnlHeader.Controls.Add(pbLogo);
            pnlHeader.Controls.Add(btnUser);
            pnlHeader.Controls.Add(lblUser);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(9, 9);
            pnlHeader.Margin = new Padding(0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(760, 71);
            pnlHeader.TabIndex = 4;
            // 
            // homepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "homepage";
            Text = "Home";
            FormClosing += homepage_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogo;
        private Label lblTitle;
        private Button btnUser;
        private Label lblUser;
        private Panel pnlHeader;
    }
}