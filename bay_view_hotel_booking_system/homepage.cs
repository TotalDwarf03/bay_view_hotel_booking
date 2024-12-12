using System;
using System.Globalization;

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

        private void fpnlStaff_Click(object sender, EventArgs e)
        {
            StaffForm frm = new StaffForm();
            frm.Owner = this;

            frm.Show();
            this.Hide();
        }

        private void btnInsertTestData_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "You are about to insert test data into the database. This will overwrite any existing data and should only be used for testing purposes. Do you want to continue?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                TestDataGenerator TestData = new TestDataGenerator();

                // Insert Customers
                int CustomersInserted = TestData.InsertExampleCustomers();

                if (CustomersInserted == 0)
                {
                    MessageBox.Show(
                        "Error inserting example customers. Please try again.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }

                MessageBox.Show(
                    "Example customers inserted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Insert Staff
                int StaffInserted = TestData.InsertExampleStaff();

                if (StaffInserted == 0)
                {
                    MessageBox.Show(
                        "Error inserting example staff. Please try again.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }

                MessageBox.Show(
                    "Example staff inserted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Insert Bookings
                int BookingsInserted = TestData.InsertExampleBookings();

                if (BookingsInserted == 0)
                {
                    MessageBox.Show(
                        "Error inserting example bookings. Please try again.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }

                MessageBox.Show(
                    "Example bookings inserted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Insert Payments
                int PaymentsInserted = TestData.InsertPaymentsForBookings();

                if (PaymentsInserted == 0)
                {
                    MessageBox.Show(
                        "Error inserting example payments. Please try again.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }

                MessageBox.Show(
                    "Example payments inserted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Success Message

                MessageBox.Show(
                    "Test data inserted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}
