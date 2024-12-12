using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bay_view_hotel_booking_system
{
    public partial class InsertTestData : Form
    {
        public InsertTestData()
        {
            InitializeComponent();
        }

        private async void InsertTestData_Shown(object sender, EventArgs e)
        {
            TestDataGenerator TestData = new TestDataGenerator();

            // Insert Customers

            lblCustomer.Visible = true;
            pbCustomer.Visible = true;

            int CustomersInserted = TestData.InsertExampleCustomers(pbCustomer);

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

            lblCustomerComplete.Visible = true;

            // Insert Staff

            lblStaff.Visible = true;
            pbStaff.Visible = true;

            await Task.Delay(1000);

            int StaffInserted = TestData.InsertExampleStaff(pbStaff);

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

            lblStaffComplete.Visible = true;

            // Insert Bookings

            lblBooking.Visible = true;
            pbBooking.Visible = true;

            await Task.Delay(1000);

            int BookingsInserted = TestData.InsertExampleBookings(pbBooking);

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

            lblBookingComplete.Visible = true;

            // Insert Payments

            lblPayment.Visible = true;
            pbPayment.Visible = true;

            await Task.Delay(1500);

            int PaymentsInserted = TestData.InsertPaymentsForBookings(pbPayment);

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

            lblPaymentsComplete.Visible = true;

            await Task.Delay(1000);

            // Success Message

            MessageBox.Show(
                "Test data inserted successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Close();
        }
    }
}
