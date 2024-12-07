using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bay_view_hotel_booking_system
{
    public partial class CustomerDelete : Form
    {
        SQLController controller = new SQLController();

        public CustomerDelete(string CustomerID)
        {
            InitializeComponent();

            string query = $"SELECT * FROM Customer WHERE CustomerID = '{CustomerID}'";

            DataTable dtCustomer = controller.RunQuery(query);

            tbCustomerID.Text = CustomerID;
            tbForename.Text = dtCustomer.Rows[0]["Forename"].ToString();
            tbSurname.Text = dtCustomer.Rows[0]["Surname"].ToString();
            tbPhoneNumber.Text = dtCustomer.Rows[0]["PhoneNumber"].ToString();
            tbEmail.Text = dtCustomer.Rows[0]["Email"].ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string CustomerID = tbCustomerID.Text;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this customer?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if ( result == DialogResult.No)
            {
                this.Close();
                return;
            }

            // Remove Customer from Bookings
            string query = $"""
                UPDATE Booking
                SET
                    CustomerID = 1
                WHERE
                    CustomerID = '{CustomerID}'
                """;

            int RecordsChanged = controller.RunNonQuery(query);

            if (RecordsChanged == 0) {
                MessageBox.Show(
                    "Customer has no existing bookings. Skipping process.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    $"Customer had {RecordsChanged.ToString()} existing bookings. These have been ammended appropriately.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            query = $"DELETE FROM Customer WHERE CustomerID = '{CustomerID}'";

            RecordsChanged = controller.RunNonQuery(query);

            if (RecordsChanged > 0)
            {
                MessageBox.Show(
                    "Customer has been deleted.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "An error has occured when deleting the customer. Please try again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            this.Close();
        }

        private void tsmiCustomerHome_Click(object sender, EventArgs e)
        {
            this.Owner?.Close();
        }

        private void CustomerEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner?.Show();
        }

        private void tsmiQuit_Click(object sender, EventArgs e)
        {
            this.Owner?.Owner?.Close();
        }
    }
}
