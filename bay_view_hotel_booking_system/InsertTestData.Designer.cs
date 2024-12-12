namespace bay_view_hotel_booking_system
{
    partial class InsertTestData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertTestData));
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblTitle = new Label();
            lblCustomer = new Label();
            pbCustomer = new ProgressBar();
            lblCustomerComplete = new Label();
            lblStaff = new Label();
            pbStaff = new ProgressBar();
            lblStaffComplete = new Label();
            lblBooking = new Label();
            pbBooking = new ProgressBar();
            lblBookingComplete = new Label();
            lblPayment = new Label();
            pbPayment = new ProgressBar();
            lblPaymentsComplete = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.BackColor = SystemColors.ControlLight;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(lblTitle);
            flowLayoutPanel1.Controls.Add(lblCustomer);
            flowLayoutPanel1.Controls.Add(pbCustomer);
            flowLayoutPanel1.Controls.Add(lblCustomerComplete);
            flowLayoutPanel1.Controls.Add(lblStaff);
            flowLayoutPanel1.Controls.Add(pbStaff);
            flowLayoutPanel1.Controls.Add(lblStaffComplete);
            flowLayoutPanel1.Controls.Add(lblBooking);
            flowLayoutPanel1.Controls.Add(pbBooking);
            flowLayoutPanel1.Controls.Add(lblBookingComplete);
            flowLayoutPanel1.Controls.Add(lblPayment);
            flowLayoutPanel1.Controls.Add(pbPayment);
            flowLayoutPanel1.Controls.Add(lblPaymentsComplete);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(105, 12);
            flowLayoutPanel1.MinimumSize = new Size(200, 218);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(20);
            flowLayoutPanel1.Size = new Size(490, 349);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(23, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(0, 0, 0, 10);
            lblTitle.Size = new Size(442, 31);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "Inserting Test Data...";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblCustomer
            // 
            lblCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCustomer.Location = new Point(23, 51);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(442, 15);
            lblCustomer.TabIndex = 0;
            lblCustomer.Text = "Inserting Customers...";
            lblCustomer.TextAlign = ContentAlignment.MiddleCenter;
            lblCustomer.Visible = false;
            // 
            // pbCustomer
            // 
            pbCustomer.Anchor = AnchorStyles.Top;
            pbCustomer.Location = new Point(23, 69);
            pbCustomer.Name = "pbCustomer";
            pbCustomer.Size = new Size(442, 23);
            pbCustomer.Step = 1;
            pbCustomer.TabIndex = 3;
            pbCustomer.Visible = false;
            // 
            // lblCustomerComplete
            // 
            lblCustomerComplete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCustomerComplete.AutoSize = true;
            lblCustomerComplete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCustomerComplete.ForeColor = Color.ForestGreen;
            lblCustomerComplete.Location = new Point(23, 95);
            lblCustomerComplete.Name = "lblCustomerComplete";
            lblCustomerComplete.Padding = new Padding(0, 0, 0, 10);
            lblCustomerComplete.Size = new Size(442, 25);
            lblCustomerComplete.TabIndex = 8;
            lblCustomerComplete.Text = "Completed.";
            lblCustomerComplete.TextAlign = ContentAlignment.MiddleCenter;
            lblCustomerComplete.Visible = false;
            // 
            // lblStaff
            // 
            lblStaff.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblStaff.AutoSize = true;
            lblStaff.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStaff.Location = new Point(23, 120);
            lblStaff.Name = "lblStaff";
            lblStaff.Size = new Size(442, 15);
            lblStaff.TabIndex = 1;
            lblStaff.Text = "Inserting Staff...";
            lblStaff.TextAlign = ContentAlignment.MiddleCenter;
            lblStaff.Visible = false;
            // 
            // pbStaff
            // 
            pbStaff.Anchor = AnchorStyles.Top;
            pbStaff.Location = new Point(23, 138);
            pbStaff.Name = "pbStaff";
            pbStaff.Size = new Size(442, 23);
            pbStaff.Step = 1;
            pbStaff.TabIndex = 4;
            pbStaff.Visible = false;
            // 
            // lblStaffComplete
            // 
            lblStaffComplete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblStaffComplete.AutoSize = true;
            lblStaffComplete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStaffComplete.ForeColor = Color.ForestGreen;
            lblStaffComplete.Location = new Point(23, 164);
            lblStaffComplete.Name = "lblStaffComplete";
            lblStaffComplete.Padding = new Padding(0, 0, 0, 10);
            lblStaffComplete.Size = new Size(442, 25);
            lblStaffComplete.TabIndex = 9;
            lblStaffComplete.Text = "Completed.";
            lblStaffComplete.TextAlign = ContentAlignment.MiddleCenter;
            lblStaffComplete.Visible = false;
            // 
            // lblBooking
            // 
            lblBooking.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblBooking.AutoSize = true;
            lblBooking.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBooking.Location = new Point(23, 189);
            lblBooking.Name = "lblBooking";
            lblBooking.Size = new Size(442, 15);
            lblBooking.TabIndex = 2;
            lblBooking.Text = "Inserting Bookings...";
            lblBooking.TextAlign = ContentAlignment.MiddleCenter;
            lblBooking.Visible = false;
            // 
            // pbBooking
            // 
            pbBooking.Anchor = AnchorStyles.Top;
            pbBooking.Location = new Point(23, 207);
            pbBooking.Name = "pbBooking";
            pbBooking.Size = new Size(442, 23);
            pbBooking.Step = 1;
            pbBooking.TabIndex = 5;
            pbBooking.Visible = false;
            // 
            // lblBookingComplete
            // 
            lblBookingComplete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblBookingComplete.AutoSize = true;
            lblBookingComplete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBookingComplete.ForeColor = Color.ForestGreen;
            lblBookingComplete.Location = new Point(23, 233);
            lblBookingComplete.Name = "lblBookingComplete";
            lblBookingComplete.Padding = new Padding(0, 0, 0, 10);
            lblBookingComplete.Size = new Size(442, 25);
            lblBookingComplete.TabIndex = 10;
            lblBookingComplete.Text = "Completed.";
            lblBookingComplete.TextAlign = ContentAlignment.MiddleCenter;
            lblBookingComplete.Visible = false;
            // 
            // lblPayment
            // 
            lblPayment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPayment.AutoSize = true;
            lblPayment.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPayment.Location = new Point(23, 258);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(442, 15);
            lblPayment.TabIndex = 6;
            lblPayment.Text = "Inserting Payments...";
            lblPayment.TextAlign = ContentAlignment.MiddleCenter;
            lblPayment.Visible = false;
            // 
            // pbPayment
            // 
            pbPayment.Anchor = AnchorStyles.Top;
            pbPayment.Location = new Point(23, 276);
            pbPayment.Name = "pbPayment";
            pbPayment.Size = new Size(442, 23);
            pbPayment.Step = 1;
            pbPayment.TabIndex = 7;
            pbPayment.Visible = false;
            // 
            // lblPaymentsComplete
            // 
            lblPaymentsComplete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPaymentsComplete.AutoSize = true;
            lblPaymentsComplete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPaymentsComplete.ForeColor = Color.ForestGreen;
            lblPaymentsComplete.Location = new Point(23, 302);
            lblPaymentsComplete.Name = "lblPaymentsComplete";
            lblPaymentsComplete.Padding = new Padding(0, 0, 0, 10);
            lblPaymentsComplete.Size = new Size(442, 25);
            lblPaymentsComplete.TabIndex = 11;
            lblPaymentsComplete.Text = "Completed.";
            lblPaymentsComplete.TextAlign = ContentAlignment.MiddleCenter;
            lblPaymentsComplete.Visible = false;
            // 
            // InsertTestData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 375);
            Controls.Add(flowLayoutPanel1);
            Cursor = Cursors.WaitCursor;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InsertTestData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Insert Test Data";
            Shown += InsertTestData_Shown;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblCustomer;
        private ProgressBar pbCustomer;
        private Label lblCustomerComplete;
        private Label lblStaff;
        private ProgressBar pbStaff;
        private Label lblStaffComplete;
        private Label lblBooking;
        private ProgressBar pbBooking;
        private Label lblBookingComplete;
        private Label lblPayment;
        private ProgressBar pbPayment;
        private Label lblPaymentsComplete;
        private Label lblTitle;
    }
}