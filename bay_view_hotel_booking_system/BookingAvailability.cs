using System.Data;
using System.Globalization;

namespace bay_view_hotel_booking_system
{
    public partial class BookingAvailability : Form
    {
        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
        SQLController controller = new SQLController();

        public BookingAvailability()
        {
            InitializeComponent();

            // Add default values to the Start and End Date pickers
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today.AddDays(7);


            // Populate ComboBox for Room Type with Data
            String query = "SELECT DISTINCT r.RoomType FROM Room AS r";

            DataTable dtRoomTypes = controller.RunQuery(query);

            cbRoomType.Items.Clear();

            if (dtRoomTypes.Columns.Contains("RoomType"))
            {
                cbRoomType.Items.Add("All");
                cbRoomType.SelectedIndex = 0;

                foreach (DataRow dr in dtRoomTypes.Rows)
                {
                    cbRoomType.Items.Add(ti.ToTitleCase(dr["RoomType"].ToString()));
                }
            }
            else
            {
                MessageBox.Show(
                    "An error has occured with the database, please contact an admin.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            // Populate ComboBox for Disabled with Data
            cbDisabled.Items.Clear();
            cbDisabled.Items.AddRange(["Any", "Yes", "No"]);
            cbDisabled.SelectedIndex = 0;
        }

        private void AddBooking_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner?.Show();
        }

        private void tsmiQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime StartDate = dtpStartDate.Value.Date;
            DateTime EndDate = dtpEndDate.Value.Date;
            String RoomType = cbRoomType.Text;

            int DisabledRoom = cbDisabled.Text == "Yes" ? 1 : 0;

            if (EndDate.Date <= StartDate)
            {
                MessageBox.Show(
                    "Error: The Start Date must not be later than the End Date.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            if (StartDate.Date < DateTime.Today)
            {
                MessageBox.Show(
                    "Error: The Start Date must not be less than the current date.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            if (EndDate.Date <= DateTime.Today)
            {
                MessageBox.Show(
                    "Error: The End Date must not be less than the current date.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            String query = $"""
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
                		-- If there is another booking in the date range for the Room
                		-- Cannot Book
                		WHEN 0 < 	(
                							SELECT
                								COUNT(b.BookingID)
                							FROM Booking AS b
                							WHERE
                                                (
                								    (
                									    b.StartDate BETWEEN '{StartDate.ToString("yyyy-MM-dd")}' AND '{EndDate.ToString("yyyy-MM-dd")}'
                									    OR
                									    b.EndDate BETWEEN '{StartDate.ToString("yyyy-MM-dd")}' AND '{EndDate.ToString("yyyy-MM-dd")}'
                								    )
                                                    OR
                                                    (
                                                        '{StartDate.ToString("yyyy-MM-dd")}' BETWEEN b.StartDate AND b.EndDate
                                                        OR
                                                        '{EndDate.ToString("yyyy-MM-dd")}' BETWEEN b.StartDate AND b.EndDate
                                                    )
                                                )
                								AND b.RoomID = r.RoomID
                                                AND b.IsCancelled = 0
                					)
                			THEN 'Not Available'
                
                		-- If the Room Status is not available (ID = 1)
                		-- Cannot Book as it's being refurbished or is off sale
                		WHEN r.RoomStatusID != 1
                			THEN 'Not Available'
                
                		ELSE 'Available'
                	END AS Availability
                FROM Room AS r
                WHERE (r.RoomType = '{RoomType.ToLower()}' OR '{RoomType}' = 'All')
                    AND (r.IsDisabled = {DisabledRoom} OR '{cbDisabled.Text}' = 'Any')
                ORDER BY Availability;
                """;

            DataTable rooms = controller.RunQuery(query);

            dgvAvailability.DataSource = rooms;

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
                else
                {
                    dgvAvailability.Rows[i].Cells[5].Style.BackColor = Color.DarkGreen;
                    dgvAvailability.Rows[i].Cells[5].Style.ForeColor = Color.White;

                    AvailableRooms++;
                }
            }

            lblRoomsAvailable.Text = $"{AvailableRooms.ToString()} Rooms Available.";
            lblRoomsAvailable.Visible = true;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (dgvAvailability.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a room to book.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (dgvAvailability.SelectedRows[0].Cells[5].Value.ToString() == "Not Available")
            {
                MessageBox.Show(
                    "This room has already been booked for the selected period. Please select another room or try another date.",
                    "Unavailable",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );

                return;
            }

            int SelectedRoomID = Convert.ToInt32(dgvAvailability.SelectedRows[0].Cells[0].Value);
            string SelectedRoomType = dgvAvailability.SelectedRows[0].Cells[1].Value.ToString();
            decimal RoomPrice = Convert.ToDecimal(dgvAvailability.SelectedRows[0].Cells[2].Value);
            int RoomCapacity = Convert.ToInt32(dgvAvailability.SelectedRows[0].Cells[3].Value);
            bool IsDisabledRoom = dgvAvailability.SelectedRows[0].Cells[4].Value.ToString() == "Yes" ? true : false;
            DateTime StartDate = dtpStartDate.Value.Date;
            DateTime EndDate = dtpEndDate.Value.Date;

            CreateBooking frm = new CreateBooking(SelectedRoomID, SelectedRoomType, RoomPrice, RoomCapacity, IsDisabledRoom, StartDate, EndDate);
            frm.Owner = this;

            frm.Show();
            this.Hide();
        }

        private void BookingAvailability_VisibleChanged(object sender, EventArgs e)
        {
            dgvAvailability.DataSource = null;
            lblRoomsAvailable.Visible = false;
        }

        private void tsmiEditBooking_Click(object sender, EventArgs e)
        {
            FindBooking frm = new FindBooking("EditBooking");
            frm.Owner = this;

            frm.Show();
            this.Hide();
        }

        private void tsmiViewBookings_Click(object sender, EventArgs e)
        {
            ViewBookings frm = new ViewBookings();
            frm.Owner = this;

            frm.Show();
            this.Hide();
        }
    }
}
