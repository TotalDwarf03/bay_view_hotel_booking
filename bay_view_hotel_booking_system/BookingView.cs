using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bay_view_hotel_booking_system
{
    public partial class BookingView : Form
    {
        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
        SQLController controller = new SQLController();

        public BookingView()
        {
            InitializeComponent();

            // Populate Room Type Combo Box
            string query = $"""
                SELECT DISTINCT
                    RoomType
                FROM Room
                """;

            DataTable dt = controller.RunQuery(query);

            cbRoomType.Items.Clear();
            cbRoomType.Items.Add("Any");

            foreach (DataRow row in dt.Rows)
            {
                cbRoomType.Items.Add(ti.ToTitleCase(row["RoomType"].ToString()));
            }

            SetDefaultValues();
        }

        private void ViewBookings_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner?.Show();
        }

        private void tsmiAvailability_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiQuit_Click(object sender, EventArgs e)
        {
            this.Owner?.Close();
        }

        private void PopulateRoomComboBox(string RoomType)
        {
            string query = $"""
                SELECT
                    RoomID
                FROM Room
                WHERE '{RoomType.ToLower()}' IN (RoomType, 'any')
                """;

            DataTable dt = controller.RunQuery(query);

            cbRoom.Items.Clear();

            cbRoom.Items.Add("Any");

            foreach (DataRow row in dt.Rows)
            {
                cbRoom.Items.Add(row["RoomID"].ToString());
            }
        }

        private void SetDefaultValues()
        {
            dgvCustomer.DataSource = null;
            dgvStaff.DataSource = null;
            dgvBooking.DataSource = null;

            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today.AddDays(21);

            cbPaid.SelectedIndex = 0;
            cbCancelled.SelectedIndex = 0;
            cbRoomType.SelectedIndex = 0;
            cbRoom.SelectedIndex = 0;
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

        private void btnStaffSearch_Click(object sender, EventArgs e)
        {
            string StaffName = tbCustomerName.Text;

            string query = $"""
                SELECT 
                    s.StaffID,
                    s.StaffType,
                    s.Forename || ' ' || s.Surname AS Name,
                    s.PhoneNumber,
                    s.Email
                FROM Staff AS s 
                WHERE s.Forename || ' ' || s.Surname LIKE '%{StaffName}%'
                """;

            DataTable dt = controller.RunQuery(query);

            dgvStaff.DataSource = dt;

            // Hide StaffID Column
            dgvStaff.Columns[0].Visible = false;

            // Resize columns to fit content or header (whichever is larger)
            for (int i = 0; i < dgvStaff.Columns.Count; i++)
            {
                dgvStaff.AutoResizeColumn(i, DataGridViewAutoSizeColumnMode.AllCells);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            SetDefaultValues();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Get Parameters from UI
            int CustomerID = -1;
            int StaffID = -1;

            if (dgvCustomer.SelectedRows.Count > 0)
            {
                CustomerID = Convert.ToInt32(dgvCustomer.SelectedRows[0].Cells[0].Value);
            }

            if (dgvStaff.SelectedRows.Count > 0)
            {
                StaffID = Convert.ToInt32(dgvStaff.SelectedRows[0].Cells[0].Value);
            }

            DateTime StartDate = dtpStartDate.Value.Date;
            DateTime EndDate = dtpEndDate.Value.Date;

            string Cancelled = cbCancelled.Text;
            string Paid = cbPaid.Text;

            string RoomType = cbRoomType.Text;
            string Room = cbRoom.Text;

            string query = $"""
                SELECT
                    b.BookingID,
                    c.Forename || ' ' || c.Surname AS Customer,
                    b.RoomID,
                    r.RoomType,
                    b.StartDate,
                    b.EndDate,
                    b.NoAdults,
                    b.NoChildren,
                    CASE
                        WHEN b.Breakfast = 1
                            THEN 'Yes'
                        ELSE
                            'No'
                    END AS Breakfast,
                    b.Price,
                    CASE
                        WHEN b.IsPaid = 1
                            THEN 'Yes'
                        ELSE
                            'No'
                    END AS Paid,
                    created.Forename || ' ' || created.Surname AS CreatedBy,
                    b.CreationDate,
                    updated.Forename || ' ' || updated.Surname AS LastUpdatedBy,
                    b.LastUpdatedDate,
                    CASE
                        WHEN b.IsCancelled = 1
                            THEN 'Yes'
                        ELSE
                            'No'
                    END AS Cancelled,
                    cancelled.Forename || ' ' || cancelled.Surname AS CancelledBy,
                    b.CancellationDate
                FROM Booking AS b
                JOIN Customer AS c
                    ON b.CustomerID = c.CustomerID
                JOIN Room AS r
                    ON b.RoomID = r.RoomID
                JOIN Staff AS created
                    ON b.CreatedBy = created.StaffID
                LEFT JOIN Staff AS updated
                    ON b.LastUpdatedBy = updated.StaffID
                LEFT JOIN Staff AS cancelled
                    ON b.CancelledBy = cancelled.StaffID
                WHERE
                    -- Booking within selected date range
                    (
                        b.StartDate BETWEEN '{StartDate.ToString("yyyy-MM-dd")}' AND '{EndDate.ToString("yyyy-MM-dd")}'
                        OR
                        b.EndDate BETWEEN '{StartDate.ToString("yyyy-MM-dd")}' AND '{EndDate.ToString("yyyy-MM-dd")}'
                    )

                    -- Booking is for selected customer
                    AND {CustomerID} IN (b.CustomerID, -1)

                    -- Booking has been Created, Updated or Cancelled by Selected Staff
                    AND {StaffID} IN (b.CreatedBy, b.LastUpdatedBy, b.CancelledBy, -1)

                    -- Booking is Cancelled or Not
                    AND '{Cancelled}' IN  (
                                            CASE
                                                WHEN b.IsCancelled = 1
                                                    THEN 'Yes'
                                                ELSE
                                                    'No'
                                            END,
                                            'Any'
                                        )

                    -- Booking is Paid or not
                    AND '{Paid}' IN   (
                                        CASE
                                            WHEN b.IsPaid = 1
                                                THEN 'Yes'
                                            ELSE
                                                'No'
                                        END,
                                        'Any'
                                    )
                    AND '{Room}' IN (CAST(b.RoomID AS TEXT), 'Any')
                    AND '{RoomType.ToLower()}' IN (r.RoomType, 'any')
                """;

            DataTable dtBooking = controller.RunQuery(query);

            if (dtBooking.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No Bookings found with those parameters. Please try again.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                dgvBooking.DataSource = null;

                return;
            }

            dgvBooking.DataSource = dtBooking;

            // Resize columns to fit content or header (whichever is larger)
            for (int i = 0; i < dgvBooking.Columns.Count; i++)
            {
                dgvBooking.AutoResizeColumn(i, DataGridViewAutoSizeColumnMode.AllCells);
            }
        }

        private void cbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateRoomComboBox(cbRoomType.Text);
        }

        private void dgvBooking_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgvBooking.Rows.Count > 0)
            {
                lblTotalBookings.Visible = true;
                lblTotalBookings.Text = $"{dgvBooking.Rows.Count} Bookings Found.";
            }
            else
            {
                lblTotalBookings.Visible = false;
            }
        }
    }
}
