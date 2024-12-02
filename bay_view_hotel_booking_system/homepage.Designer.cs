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
            fpnlBooking = new FlowLayoutPanel();
            lblBookingHeader = new Label();
            lblBookingDesc = new Label();
            fpnlCustomer = new FlowLayoutPanel();
            lblCustomerHeader = new Label();
            lblCustomerDesc = new Label();
            fpnlRoom = new FlowLayoutPanel();
            lblRoomHeading = new Label();
            lblRoomDesc = new Label();
            fpnlPayment = new FlowLayoutPanel();
            lblPaymentHeader = new Label();
            lblPaymentDesc = new Label();
            fpnlStaff = new FlowLayoutPanel();
            lblStaffHeader = new Label();
            lblStaffDesc = new Label();
            fpnlReporting = new FlowLayoutPanel();
            lblReportingHeader = new Label();
            lblReportingDesc = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlHeader.SuspendLayout();
            fpnlBooking.SuspendLayout();
            fpnlCustomer.SuspendLayout();
            fpnlRoom.SuspendLayout();
            fpnlPayment.SuspendLayout();
            fpnlStaff.SuspendLayout();
            fpnlReporting.SuspendLayout();
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
            // fpnlBooking
            // 
            fpnlBooking.BackColor = SystemColors.ControlLight;
            fpnlBooking.BorderStyle = BorderStyle.FixedSingle;
            fpnlBooking.Controls.Add(lblBookingHeader);
            fpnlBooking.Controls.Add(lblBookingDesc);
            fpnlBooking.ImeMode = ImeMode.NoControl;
            fpnlBooking.Location = new Point(9, 93);
            fpnlBooking.Name = "fpnlBooking";
            fpnlBooking.Size = new Size(350, 84);
            fpnlBooking.TabIndex = 5;
            fpnlBooking.Click += fpnlBooking_Click;
            // 
            // lblBookingHeader
            // 
            lblBookingHeader.AutoSize = true;
            lblBookingHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBookingHeader.ImageAlign = ContentAlignment.TopLeft;
            lblBookingHeader.Location = new Point(3, 0);
            lblBookingHeader.Name = "lblBookingHeader";
            lblBookingHeader.Size = new Size(221, 28);
            lblBookingHeader.TabIndex = 0;
            lblBookingHeader.Text = "Booking Management";
            lblBookingHeader.Click += fpnlBooking_Click;
            // 
            // lblBookingDesc
            // 
            lblBookingDesc.AutoSize = true;
            lblBookingDesc.Location = new Point(3, 28);
            lblBookingDesc.Name = "lblBookingDesc";
            lblBookingDesc.Size = new Size(319, 20);
            lblBookingDesc.TabIndex = 1;
            lblBookingDesc.Text = "View Availability, Create and Update Bookings.";
            lblBookingDesc.Click += fpnlBooking_Click;
            // 
            // fpnlCustomer
            // 
            fpnlCustomer.BackColor = SystemColors.ControlLight;
            fpnlCustomer.BorderStyle = BorderStyle.FixedSingle;
            fpnlCustomer.Controls.Add(lblCustomerHeader);
            fpnlCustomer.Controls.Add(lblCustomerDesc);
            fpnlCustomer.Location = new Point(9, 183);
            fpnlCustomer.Name = "fpnlCustomer";
            fpnlCustomer.Size = new Size(350, 84);
            fpnlCustomer.TabIndex = 6;
            // 
            // lblCustomerHeader
            // 
            lblCustomerHeader.AutoSize = true;
            lblCustomerHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCustomerHeader.ImageAlign = ContentAlignment.TopLeft;
            lblCustomerHeader.Location = new Point(3, 0);
            lblCustomerHeader.Name = "lblCustomerHeader";
            lblCustomerHeader.Size = new Size(233, 28);
            lblCustomerHeader.TabIndex = 0;
            lblCustomerHeader.Text = "Customer Management";
            // 
            // lblCustomerDesc
            // 
            lblCustomerDesc.AutoSize = true;
            lblCustomerDesc.Location = new Point(3, 28);
            lblCustomerDesc.Name = "lblCustomerDesc";
            lblCustomerDesc.Size = new Size(285, 20);
            lblCustomerDesc.TabIndex = 1;
            lblCustomerDesc.Text = "View, Add, Update and Delete Customers.";
            // 
            // fpnlRoom
            // 
            fpnlRoom.BackColor = SystemColors.ControlLight;
            fpnlRoom.BorderStyle = BorderStyle.FixedSingle;
            fpnlRoom.Controls.Add(lblRoomHeading);
            fpnlRoom.Controls.Add(lblRoomDesc);
            fpnlRoom.Location = new Point(420, 94);
            fpnlRoom.Name = "fpnlRoom";
            fpnlRoom.Size = new Size(350, 84);
            fpnlRoom.TabIndex = 7;
            fpnlRoom.Visible = false;
            // 
            // lblRoomHeading
            // 
            lblRoomHeading.AutoSize = true;
            lblRoomHeading.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRoomHeading.ImageAlign = ContentAlignment.TopLeft;
            lblRoomHeading.Location = new Point(3, 0);
            lblRoomHeading.Name = "lblRoomHeading";
            lblRoomHeading.Size = new Size(198, 28);
            lblRoomHeading.TabIndex = 0;
            lblRoomHeading.Text = "Room Management";
            // 
            // lblRoomDesc
            // 
            lblRoomDesc.AutoSize = true;
            lblRoomDesc.Location = new Point(3, 28);
            lblRoomDesc.Name = "lblRoomDesc";
            lblRoomDesc.Size = new Size(211, 20);
            lblRoomDesc.TabIndex = 1;
            lblRoomDesc.Text = "View, Add and Update Rooms.";
            // 
            // fpnlPayment
            // 
            fpnlPayment.BackColor = SystemColors.ControlLight;
            fpnlPayment.BorderStyle = BorderStyle.FixedSingle;
            fpnlPayment.Controls.Add(lblPaymentHeader);
            fpnlPayment.Controls.Add(lblPaymentDesc);
            fpnlPayment.Location = new Point(9, 273);
            fpnlPayment.Name = "fpnlPayment";
            fpnlPayment.Size = new Size(350, 84);
            fpnlPayment.TabIndex = 8;
            // 
            // lblPaymentHeader
            // 
            lblPaymentHeader.AutoSize = true;
            lblPaymentHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPaymentHeader.ImageAlign = ContentAlignment.TopLeft;
            lblPaymentHeader.Location = new Point(3, 0);
            lblPaymentHeader.Name = "lblPaymentHeader";
            lblPaymentHeader.Size = new Size(226, 28);
            lblPaymentHeader.TabIndex = 0;
            lblPaymentHeader.Text = "Payment Management";
            // 
            // lblPaymentDesc
            // 
            lblPaymentDesc.AutoSize = true;
            lblPaymentDesc.Location = new Point(3, 28);
            lblPaymentDesc.Name = "lblPaymentDesc";
            lblPaymentDesc.Size = new Size(291, 20);
            lblPaymentDesc.TabIndex = 1;
            lblPaymentDesc.Text = "Mark Bookings as Paid or Cancel Bookings.";
            // 
            // fpnlStaff
            // 
            fpnlStaff.BackColor = SystemColors.ControlLight;
            fpnlStaff.BorderStyle = BorderStyle.FixedSingle;
            fpnlStaff.Controls.Add(lblStaffHeader);
            fpnlStaff.Controls.Add(lblStaffDesc);
            fpnlStaff.Location = new Point(420, 185);
            fpnlStaff.Name = "fpnlStaff";
            fpnlStaff.Size = new Size(350, 84);
            fpnlStaff.TabIndex = 8;
            fpnlStaff.Visible = false;
            // 
            // lblStaffHeader
            // 
            lblStaffHeader.AutoSize = true;
            lblStaffHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblStaffHeader.ImageAlign = ContentAlignment.TopLeft;
            lblStaffHeader.Location = new Point(3, 0);
            lblStaffHeader.Name = "lblStaffHeader";
            lblStaffHeader.Size = new Size(189, 28);
            lblStaffHeader.TabIndex = 0;
            lblStaffHeader.Text = "Staff Management";
            // 
            // lblStaffDesc
            // 
            lblStaffDesc.AutoSize = true;
            lblStaffDesc.Location = new Point(3, 28);
            lblStaffDesc.Name = "lblStaffDesc";
            lblStaffDesc.Size = new Size(247, 20);
            lblStaffDesc.TabIndex = 1;
            lblStaffDesc.Text = "View, Add, Update and Delete Staff.";
            // 
            // fpnlReporting
            // 
            fpnlReporting.BackColor = SystemColors.ControlLight;
            fpnlReporting.BorderStyle = BorderStyle.FixedSingle;
            fpnlReporting.Controls.Add(lblReportingHeader);
            fpnlReporting.Controls.Add(lblReportingDesc);
            fpnlReporting.Location = new Point(420, 275);
            fpnlReporting.Name = "fpnlReporting";
            fpnlReporting.Size = new Size(350, 84);
            fpnlReporting.TabIndex = 9;
            fpnlReporting.Visible = false;
            // 
            // lblReportingHeader
            // 
            lblReportingHeader.AutoSize = true;
            lblReportingHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblReportingHeader.ImageAlign = ContentAlignment.TopLeft;
            lblReportingHeader.Location = new Point(3, 0);
            lblReportingHeader.Name = "lblReportingHeader";
            lblReportingHeader.Size = new Size(191, 28);
            lblReportingHeader.TabIndex = 0;
            lblReportingHeader.Text = "Reporting Services";
            // 
            // lblReportingDesc
            // 
            lblReportingDesc.AutoSize = true;
            lblReportingDesc.Location = new Point(3, 28);
            lblReportingDesc.Name = "lblReportingDesc";
            lblReportingDesc.Size = new Size(287, 40);
            lblReportingDesc.TabIndex = 1;
            lblReportingDesc.Text = "View Income, Time Occupancy and Room Occupancy Reports.";
            // 
            // homepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(fpnlBooking);
            Controls.Add(pnlHeader);
            Controls.Add(fpnlReporting);
            Controls.Add(fpnlStaff);
            Controls.Add(fpnlPayment);
            Controls.Add(fpnlRoom);
            Controls.Add(fpnlCustomer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "homepage";
            Text = "Home";
            FormClosing += homepage_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlHeader.ResumeLayout(false);
            fpnlBooking.ResumeLayout(false);
            fpnlBooking.PerformLayout();
            fpnlCustomer.ResumeLayout(false);
            fpnlCustomer.PerformLayout();
            fpnlRoom.ResumeLayout(false);
            fpnlRoom.PerformLayout();
            fpnlPayment.ResumeLayout(false);
            fpnlPayment.PerformLayout();
            fpnlStaff.ResumeLayout(false);
            fpnlStaff.PerformLayout();
            fpnlReporting.ResumeLayout(false);
            fpnlReporting.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogo;
        private Label lblTitle;
        private Button btnUser;
        private Label lblUser;
        private Panel pnlHeader;
        private FlowLayoutPanel fpnlBooking;
        private Label lblBookingHeader;
        private Label lblBookingDesc;
        private FlowLayoutPanel fpnlCustomer;
        private Label lblCustomerHeader;
        private Label lblCustomerDesc;
        private FlowLayoutPanel fpnlRoom;
        private Label lblRoomHeading;
        private Label lblRoomDesc;
        private FlowLayoutPanel fpnlPayment;
        private Label lblPaymentHeader;
        private Label lblPaymentDesc;
        private FlowLayoutPanel fpnlStaff;
        private Label lblStaffHeader;
        private Label lblStaffDesc;
        private FlowLayoutPanel fpnlReporting;
        private Label lblReportingHeader;
        private Label lblReportingDesc;
    }
}