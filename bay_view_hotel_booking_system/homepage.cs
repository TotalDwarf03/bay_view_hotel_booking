﻿using System.Globalization;

namespace bay_view_hotel_booking_system
{
    public partial class homepage : Form
    {
        public homepage(string username, string usertype)
        {
            InitializeComponent();

            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;

            lblUser.Text = $"Logged in as: {ti.ToTitleCase(username)}.\n User Type: {ti.ToTitleCase(usertype)}.";

            if (usertype == "manager")
            {
                fpnlRoom.Visible = true;
                fpnlStaff.Visible = true;
                fpnlReporting.Visible = true;
            }
        }

        SQLController controller = new SQLController();

        private void homepage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.SetEnvironmentVariable("username", null);
            this.Owner?.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fpnlBooking_Click(object sender, EventArgs e)
        {
            BookingAvailability frm = new BookingAvailability();
            frm.Owner = this;

            frm.Show();
            this.Hide();
        }

        private void fpnlPayment_Click(object sender, EventArgs e)
        {
            FindBooking frm = new FindBooking("PaymentManagement");
            frm.Owner = this;

            frm.Show();
            this.Hide();
        }

        private void fpnlCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm frm = new CustomerForm();
            frm.Owner = this;

            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffForm CHome = new StaffForm();
            CHome.Show();
            this.Hide();
        }
    }
}
