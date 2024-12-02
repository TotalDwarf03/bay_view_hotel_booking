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

namespace bay_view_hotel_booking_system
{
    public partial class FindBooking : Form
    {
        SQLController controller = new SQLController();

        public FindBooking()
        {
            InitializeComponent();
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
                WHERE c.Forename || ' ' || c.Surname LIKE '%{CustomerName}%';
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
                    b.*
                FROM Booking AS b
                WHERE
                    b.CustomerID = {CustomerID}
                    AND (
                            b.StartDate >= date('now')
                            OR
                            b.EndDate >= date('now')
                        )
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
                    "You must select a Booking before you can edit it.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string BookingID = dgvBooking.SelectedRows[0].Cells[0].Value.ToString();

            EditBooking frm = new EditBooking(Convert.ToInt32(BookingID));
            frm.Owner = this;

            frm.Show();
            this.Hide();
        }
    }
}
