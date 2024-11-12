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
            panel1 = new Panel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label7 = new Label();
            label8 = new Label();
            flowLayoutPanel5 = new FlowLayoutPanel();
            label9 = new Label();
            label10 = new Label();
            flowLayoutPanel6 = new FlowLayoutPanel();
            label11 = new Label();
            label12 = new Label();
            flowLayoutPanel7 = new FlowLayoutPanel();
            label13 = new Label();
            label14 = new Label();
            flowLayoutPanel8 = new FlowLayoutPanel();
            label15 = new Label();
            label16 = new Label();
            flowLayoutPanel9 = new FlowLayoutPanel();
            label17 = new Label();
            label18 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            flowLayoutPanel8.SuspendLayout();
            flowLayoutPanel9.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bay_view_logo;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnUser);
            panel1.Controls.Add(lblUser);
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(9, 9);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 71);
            panel1.TabIndex = 4;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackColor = SystemColors.ControlLight;
            flowLayoutPanel4.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel4.Controls.Add(label7);
            flowLayoutPanel4.Controls.Add(label8);
            flowLayoutPanel4.Location = new Point(331, 94);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(316, 100);
            flowLayoutPanel4.TabIndex = 11;
            flowLayoutPanel4.Paint += this.flowLayoutPanel4_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(177, 25);
            label7.TabIndex = 6;
            label7.Text = "Staff Management";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 25);
            label8.Name = "label8";
            label8.Size = new Size(262, 20);
            label8.TabIndex = 7;
            label8.Text = "View, Create, Update and Delete Staff.";
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.BackColor = SystemColors.ControlLight;
            flowLayoutPanel5.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel5.Controls.Add(label9);
            flowLayoutPanel5.Controls.Add(label10);
            flowLayoutPanel5.Location = new Point(331, 201);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(316, 100);
            flowLayoutPanel5.TabIndex = 13;
            flowLayoutPanel5.Paint += flowLayoutPanel5_Paint;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(188, 25);
            label9.TabIndex = 6;
            label9.Text = "Room Management";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 25);
            label10.Name = "label10";
            label10.Size = new Size(226, 20);
            label10.TabIndex = 7;
            label10.Text = "View, Create and Update Rooms.";
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.BackColor = SystemColors.ControlLight;
            flowLayoutPanel6.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel6.Controls.Add(label11);
            flowLayoutPanel6.Controls.Add(label12);
            flowLayoutPanel6.Location = new Point(331, 307);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(316, 100);
            flowLayoutPanel6.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(180, 25);
            label11.TabIndex = 6;
            label11.Text = "Reporting Services";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 25);
            label12.Name = "label12";
            label12.Size = new Size(307, 60);
            label12.TabIndex = 7;
            label12.Text = "View Reports based on the system, including Income, Time Occupancy and Room Occupancy.\r\n";
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.BackColor = SystemColors.ControlLight;
            flowLayoutPanel7.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel7.Controls.Add(label13);
            flowLayoutPanel7.Controls.Add(label14);
            flowLayoutPanel7.Location = new Point(9, 94);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(316, 100);
            flowLayoutPanel7.TabIndex = 11;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label13.Location = new Point(3, 0);
            label13.Name = "label13";
            label13.Size = new Size(211, 25);
            label13.TabIndex = 6;
            label13.Text = "Booking Management";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(3, 25);
            label14.Name = "label14";
            label14.Size = new Size(304, 40);
            label14.TabIndex = 7;
            label14.Text = "View room availability and current bookings.\r\nCreate, Update and Cancel bookings.";
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.BackColor = SystemColors.ControlLight;
            flowLayoutPanel8.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel8.Controls.Add(label15);
            flowLayoutPanel8.Controls.Add(label16);
            flowLayoutPanel8.Location = new Point(9, 200);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(316, 100);
            flowLayoutPanel8.TabIndex = 13;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label15.Location = new Point(3, 0);
            label15.Name = "label15";
            label15.Size = new Size(221, 25);
            label15.TabIndex = 6;
            label15.Text = "Customer Management";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(3, 25);
            label16.Name = "label16";
            label16.Size = new Size(300, 20);
            label16.TabIndex = 7;
            label16.Text = "View, Create, Update and Delete Customers.";
            // 
            // flowLayoutPanel9
            // 
            flowLayoutPanel9.BackColor = SystemColors.ControlLight;
            flowLayoutPanel9.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel9.Controls.Add(label17);
            flowLayoutPanel9.Controls.Add(label18);
            flowLayoutPanel9.Location = new Point(9, 306);
            flowLayoutPanel9.Name = "flowLayoutPanel9";
            flowLayoutPanel9.Size = new Size(316, 100);
            flowLayoutPanel9.TabIndex = 12;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label17.Location = new Point(3, 0);
            label17.Name = "label17";
            label17.Size = new Size(159, 25);
            label17.TabIndex = 6;
            label17.Text = "Payment Service";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(3, 25);
            label18.Name = "label18";
            label18.Size = new Size(263, 40);
            label18.TabIndex = 7;
            label18.Text = "Log Payments made for Bookings and Cancellations.";
            // 
            // homepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel7);
            Controls.Add(flowLayoutPanel8);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(flowLayoutPanel9);
            Controls.Add(flowLayoutPanel5);
            Controls.Add(flowLayoutPanel6);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "homepage";
            Text = "Home";
            FormClosing += homepage_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            flowLayoutPanel8.ResumeLayout(false);
            flowLayoutPanel8.PerformLayout();
            flowLayoutPanel9.ResumeLayout(false);
            flowLayoutPanel9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTitle;
        private Button btnUser;
        private Label lblUser;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label7;
        private Label label8;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label label9;
        private Label label10;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label label11;
        private Label label12;
        private FlowLayoutPanel flowLayoutPanel7;
        private Label label13;
        private Label label14;
        private FlowLayoutPanel flowLayoutPanel8;
        private Label label15;
        private Label label16;
        private FlowLayoutPanel flowLayoutPanel9;
        private Label label17;
        private Label label18;
    }
}