using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;

namespace bay_view_hotel_booking_system
{
    public partial class EditBooking : Form
    {
        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
        SQLController controller = new SQLController();

        public EditBooking(int BookingID)
        {
            InitializeComponent();

            lblBookingID.Text = BookingID.ToString();

            // Get the booking details
            string query = $"""
                SELECT
                    *
                FROM Booking
                WHERE BookingID = {BookingID}
                """;

            DataTable booking = controller.RunQuery(query);

            DateTime StartDate = Convert.ToDateTime(booking.Rows[0]["StartDate"]);
            DateTime EndDate = Convert.ToDateTime(booking.Rows[0]["EndDate"]);

            // Fill in the form
            tbRoomID.Text = booking.Rows[0]["RoomID"].ToString();
            dtpStartDate.Value = StartDate;
            dtpEndDate.Value = EndDate;

            nudAdult.Value = Convert.ToInt32(booking.Rows[0]["NoAdults"]);
            nudChild.Value = Convert.ToInt32(booking.Rows[0]["NoChildren"]);

            rbBreakfastYes.Checked = booking.Rows[0]["Breakfast"].ToString() == "1" ? true : false;
            rbBreakfastNo.Checked = booking.Rows[0]["Breakfast"].ToString() == "0" ? true : false;

            // Populate Room Type Combo Box
            query = $"""
                SELECT DISTINCT
                    RoomType
                FROM Room
                """;

            DataTable roomTypes = controller.RunQuery(query);

            cbRoomType.Items.Clear();

            foreach (DataRow row in roomTypes.Rows)
            {
                cbRoomType.Items.Add(ti.ToTitleCase(row["RoomType"].ToString()));
            }

            // Update Selected Room
            UpdateSelectedRoom();

            // Get the customer details
            query = $"""
                SELECT
                    c.Forename || ' ' || c.Surname AS CustomerName,
                    c.Email,
                    c.PhoneNumber
                FROM Customer AS c
                WHERE CustomerID = {booking.Rows[0]["CustomerID"]}
                """;

            DataTable customer = controller.RunQuery(query);

            tbCustomerName.Text = customer.Rows[0]["CustomerName"].ToString();
            tbCustomerEmail.Text = customer.Rows[0]["Email"].ToString();
            tbCustomerPhone.Text = customer.Rows[0]["PhoneNumber"].ToString();
        }

        public DataTable GetAvailableRooms()
        {
            DateTime StartDate = dtpStartDate.Value.Date;
            DateTime EndDate = dtpEndDate.Value.Date;
            String RoomType = cbRoomType.Text;

            string query = $"""
                SELECT
                	r.RoomID,
                	r.RoomType,
                	r.Price,
                	r.Capacity,

                	CASE
                		WHEN r.IsDisabled = 1
                			THEN 'Yes'
                		ELSE
                			'No'
                	END AS IsDisabled,

                	CASE
                		-- If there is only one booking between the dates
                		-- And that booking is the one being edited
                		-- Ok to book
                		WHEN 1 = 	(
                						SELECT
                							COUNT(b.BookingID)
                						FROM Booking AS b
                						WHERE
                								(
                									'{StartDate.ToString("yyyy-MM-dd")}' BETWEEN b.StartDate AND b.EndDate
                									OR
                									'{EndDate.ToString("yyyy-MM-dd")}' BETWEEN b.StartDate AND b.EndDate
                								)
                								AND b.RoomID = r.RoomID
                					)
                		AND '{lblBookingID.Text}' IN	(
                								            SELECT
                									            b.BookingID
                								            FROM Booking AS b
                								            WHERE
                										(
                											'{StartDate.ToString("yyyy-MM-dd")}' BETWEEN b.StartDate AND b.EndDate
                											OR
                											'{EndDate.ToString("yyyy-MM-dd")}' BETWEEN b.StartDate AND b.EndDate
                										)
                										AND b.RoomID = r.RoomID
                							)
                			THEN 'Current Room'

                		-- If there is another booking in the date range for the Room
                		-- Cannot Book
                		WHEN 0 < 	(
                							SELECT
                								COUNT(b.BookingID)
                							FROM Booking AS b
                							WHERE
                								(
                									'{StartDate.ToString("yyyy-MM-dd")}' BETWEEN b.StartDate AND b.EndDate
                									OR
                									'{EndDate.ToString("yyyy-MM-dd")}' BETWEEN b.StartDate AND b.EndDate
                								)
                								AND b.RoomID = r.RoomID
                					)
                			THEN 'Unavailable'

                		-- If the Room Status is not available (ID = 1)
                		-- Cannot Book as it's being refurbished or is off sale
                		WHEN r.RoomStatusID != 1
                			THEN 'Unavailable'

                		ELSE 'Available'
                	END AS Availability
                FROM Room AS r
                WHERE (r.RoomType = '{RoomType.ToLower()}' OR '{RoomType}' = 'All')
                ORDER BY r.Availability;
                """;

            DataTable dtAvailableRooms = controller.RunQuery(query);

            return dtAvailableRooms;
        }

        public void UpdateRoomAvailability()
        {
            DataTable dtAvailableRooms = GetAvailableRooms();

            dgvAvailability.DataSource = dtAvailableRooms;

            int AvailableRooms = 0;

            // If not available, change cell colour to Red
            for (int i = 0; i < dgvAvailability.Rows.Count; i++)
            {
                if (dgvAvailability.Rows[i].Cells[5].Value.ToString() == "Not Available")
                {
                    dgvAvailability.Rows[i].Cells[5].Style.BackColor = Color.DarkRed;
                    dgvAvailability.Rows[i].Cells[5].Style.ForeColor = Color.White;
                    dgvAvailability.Rows[i].Cells[5].Style.Font = new Font(this.Font, FontStyle.Bold);
                }
                else if (dgvAvailability.Rows[i].Cells[5].Value.ToString() == "Current Room")
                {
                    dgvAvailability.Rows[i].Cells[5].Style.BackColor = Color.Orange;
                    dgvAvailability.Rows[i].Cells[5].Style.ForeColor = Color.White;
                    dgvAvailability.Rows[i].Cells[5].Style.Font = new Font(this.Font, FontStyle.Bold);
                }
                else
                {
                    dgvAvailability.Rows[i].Cells[5].Style.BackColor = Color.DarkGreen;
                    dgvAvailability.Rows[i].Cells[5].Style.ForeColor = Color.White;

                    AvailableRooms++;
                }
            }

            lblRoomAvailableCount.Text = $"{AvailableRooms.ToString()} Alternative Rooms Available.";
        }

        public void UpdateSelectedRoomAvailability(DataTable dtAvailableRooms)
        {
            DataRow RoomRow;

            try
            {
                RoomRow = dtAvailableRooms.Select($"RoomID = {tbRoomID.Text}")[0];
            }
            catch (IndexOutOfRangeException)
            {
                tbRoomAvailable.Text = "Invalid Room Type";
                tbRoomAvailable.BackColor = Color.DarkRed;
                tbRoomAvailable.ForeColor = Color.White;

                return;
            }

            if (RoomRow["Availability"].ToString() == "Available")
            {
                tbRoomAvailable.Text = "Available";
                tbRoomAvailable.BackColor = Color.DarkGreen;
                tbRoomAvailable.ForeColor = Color.White;
            }
            else if (RoomRow["Availability"].ToString() == "Current Room")
            {
                tbRoomAvailable.Text = "Room Unchanged";
                tbRoomAvailable.BackColor = Color.Orange;
                tbRoomAvailable.ForeColor = Color.White;
            }
            else
            {
                tbRoomAvailable.Text = "Not Available";
                tbRoomAvailable.BackColor = Color.DarkRed;
                tbRoomAvailable.ForeColor = Color.White;
            }
        }

        public void UpdateSelectedRoom()
        {
            // Get Room details
            string query = $"""
                SELECT
                    *
                FROM Room
                WHERE RoomID = {tbRoomID.Text}
                """;

            DataTable room = controller.RunQuery(query);

            cbRoomType.SelectedItem = ti.ToTitleCase(room.Rows[0]["RoomType"].ToString());
            tbDisabled.Text = room.Rows[0]["IsDisabled"].ToString() == "1" ? "Yes" : "No";
            tbCapacity.Text = room.Rows[0]["Capacity"].ToString();
            tbPricePerNight.Text = Convert.ToDecimal(room.Rows[0]["Price"]).ToString("C");
        }

        private void EditBooking_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner?.Show();
        }

        private void tsmiAvailability_Click(object sender, EventArgs e)
        {
            this.Owner?.Close();
        }

        private void tsmiQuit_Click(object sender, EventArgs e)
        {
            this.Owner?.Owner?.Owner?.Show();
            this.Owner?.Owner?.Close();
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            tbRoomID.Text = dgvAvailability.SelectedRows[0].Cells[0].Value.ToString();

            UpdateSelectedRoom();
            UpdateSelectedRoomAvailability(GetAvailableRooms());
        }

        private int CalculateBreakfastRateID(int NumberOfGuests)
        {
            int BreakfastRateID;

            if (NumberOfGuests == 1)
            {
                BreakfastRateID = 1;
            }
            else if (NumberOfGuests == 2)
            {
                BreakfastRateID = 2;
            }
            else
            {
                BreakfastRateID = 3;
            }

            // Always use BreakfastRateID 3 for Family Rooms
            if (cbRoomType.Text == "Family")
            {
                BreakfastRateID = 3;
            }

            return BreakfastRateID;
        }

        private void calculateSummary()
        {
            lvPricing.Items.Clear();

            // Calculate Number of Guests
            int NumberOfGuests = Convert.ToInt32(nudAdult.Value + nudChild.Value);

            // Get the Number of Nights
            int NumberOfNights = Convert.ToInt32((dtpEndDate.Value - dtpStartDate.Value).TotalDays);

            // Add Room Charge
            decimal PricePerNight = Convert.ToDecimal(tbPricePerNight.Text.Substring(1));

            ListViewItem lviRoomPrice = new ListViewItem($"Base Room Charge");
            lviRoomPrice.SubItems.Add(PricePerNight.ToString("C"));

            lvPricing.Items.Add(lviRoomPrice);

            // Add Breakfast Charge
            if (rbBreakfastYes.Checked)
            {
                ListViewItem lviBreakfast = new ListViewItem($"Breakfast Charge - {NumberOfGuests} Guest(s)");

                int BreakfastRateID = CalculateBreakfastRateID(NumberOfGuests);

                string query = $"""
                    SELECT 
                        br.Price 
                    FROM BreakfastRate AS br 
                    WHERE br.BreakfastRateID = {BreakfastRateID};
                    """;

                DataTable dt = controller.RunQuery(query);

                decimal BreakfastPrice = Convert.ToDecimal(dt.Rows[0][0]);

                lviBreakfast.SubItems.Add(BreakfastPrice.ToString("C"));

                lvPricing.Items.Add(lviBreakfast);
            }

            // Add discount if booking is for one person in a double room
            if (NumberOfGuests == 1 & cbRoomType.Text == "Double")
            {
                ListViewItem lviDiscount = new ListViewItem("Single Person Discount");
                lviDiscount.SubItems.Add("-£20.00");

                lvPricing.Items.Add(lviDiscount);
            }

            // Resize columns to fit content or header (whichever is larger)
            for (int i = 0; i < lvPricing.Columns.Count; i++)
            {
                lvPricing.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);

                int contentWidth = lvPricing.Columns[i].Width;

                lvPricing.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.HeaderSize);

                int headerWidth = lvPricing.Columns[i].Width;

                lvPricing.Columns[i].Width = contentWidth > headerWidth ? contentWidth : headerWidth;
            }

            // Calculate Total Per Night
            decimal PerNightTotal = 0;

            foreach (ListViewItem item in lvPricing.Items)
            {
                PerNightTotal += Convert.ToDecimal(item.SubItems[1].Text.Replace("£", ""));
            }

            lblPPNValue.Text = PerNightTotal.ToString("C");

            // Add Number of Nights to UI
            lblNoOfNightsValue.Text = NumberOfNights.ToString();

            // Calculate Total
            decimal Total = PerNightTotal * NumberOfNights;

            lblTotalValue.Text = Total.ToString("C");
        }

        private void BookingInformationChanged(object sender, EventArgs e)
        {
            UpdateRoomAvailability();
            UpdateSelectedRoomAvailability(GetAvailableRooms());
        }

        private void EditBooking_Load(object sender, EventArgs e)
        {
            // Unbind dgvAvailability from the DataSource
            dgvAvailability.DataSource = null;
        }
    }
}
