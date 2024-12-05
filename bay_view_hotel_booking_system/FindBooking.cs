using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace bay_view_hotel_booking_system
{
    public partial class FindBooking : Form
    {
        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
        SQLController controller = new SQLController();

        public FindBooking(string NextPage)
        {
            InitializeComponent();

            lblNextPage.Text = NextPage;

            // If the next page is Payment Management, the availability button goes back to the homepage
            // Therefore we need to rename this button to "Back to Homepage"
            // And hide the quit button
            if (NextPage == "PaymentManagement")
            {
                tsmiQuit.Visible = false;
                tsmiAvailability.Text = "Back to Homepage";
            }
        }

        private void EditBooking_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner?.Show();
        }

        private void tsmiAvailability_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiQuit_Click(object sender, EventArgs e)
        {
            this.Owner?.Owner?.Show();
            this.Owner?.Close();
        }

        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            string CustomerName = tbCustomerName.Text;

            string query = $"""
                SELECT 
                    c.CustomerID, 
                    c.Forename || ' ' || c.Surname AS Name, 
                    c.Email, 
                    c.PhoneNumber 
                FROM Customer AS c 
                WHERE c.Forename || ' ' || c.Surname LIKE '%{CustomerName}%'
                    AND c.CustomerID != 1;
                """;

            DataTable dt = controller.RunQuery(query);

            dgvCustomer.DataSource = dt;

            // Hide CustomerID Column
            dgvCustomer.Columns[0].Visible = false;

            // Resize columns to fit content or header (whichever is larger)
            for (int i = 0; i < dgvCustomer.Columns.Count; i++)
            {
                dgvCustomer.AutoResizeColumn(i, DataGridViewAutoSizeColumnMode.AllCells);
            }

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No customers found with that name. Please try again.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void tbCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If enter pressed, search for customer
            if (e.KeyChar == 13)
            {
                btnCustomerSearch_Click(this, e);
            }
        }

        private void btnLoadCustomerBooking_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "You must select a Customer before loading their bookings.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string CustomerID = dgvCustomer.SelectedRows[0].Cells[0].Value.ToString();

            dgvBooking.DataSource = null;

            string query = $"""
                SELECT
                    b.BookingID,
                    b.StartDate,
                    b.EndDate,
                    b.RoomID,
                    CASE
                        WHEN b.Breakfast = 1 THEN 'Yes'
                        ELSE 'No'
                    END AS Breakfast,
                    b.NoAdults,
                    b.NoChildren,
                    b.Price
                FROM Booking AS b
                WHERE
                    b.CustomerID = {CustomerID}
                    AND (
                            b.StartDate >= date('now')
                            OR
                            b.EndDate >= date('now')
                        )
                    AND b.IsCancelled = 0

                    -- Only return bookings that are not paid unless going to EditBooking
                    AND (b.IsPaid = 0 OR '{lblNextPage.Text}' = 'EditBooking') 
                """;

            DataTable dt = controller.RunQuery(query);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No bookings for that customer. Please try again.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }

            dgvBooking.DataSource = dt;
        }

        private void btnEditBooking_Click(object sender, EventArgs e)
        {
            if (dgvBooking.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "You must select a Booking before you can load it.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            string BookingID = dgvBooking.SelectedRows[0].Cells[0].Value.ToString();

            string NextPage = lblNextPage.Text;

            if (NextPage == "EditBooking")
            {
                EditBooking frm = new EditBooking(Convert.ToInt32(BookingID));
                frm.Owner = this;

                frm.Show();
                this.Hide();
            }
            else if (NextPage == "PaymentManagement")
            {
                // Go to Payment Management
                PaymentManagement frm = new PaymentManagement(Convert.ToInt32(BookingID));
                frm.Owner = this;

                frm.Show();
                this.Hide();
            }
        }

        private void FindBooking_VisibleChanged(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = null;
            dgvBooking.DataSource = null;
        }
    }
}
