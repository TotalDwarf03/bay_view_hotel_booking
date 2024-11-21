using System.Data;

namespace bay_view_hotel_booking_system
{
    public partial class AddBooking : Form
    {
        // Create SQLController instance to execute SQL
        SQLController controller = new SQLController();

        public AddBooking()
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
                    cbRoomType.Items.Add(dr["RoomType"].ToString());
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

            String query = $"""
                SELECT DISTINCT
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
                        WHEN 
                            (('{StartDate}' NOT BETWEEN b.StartDate and b.EndDate) AND ('{EndDate}' NOT BETWEEN b.StartDate AND b.EndDate)) -- Room isn't already booked
                            OR b.BookingID IS NULL -- Room has no current bookings
                            AND r.RoomStatusID = 1 -- Room is available for sale (Not being refurbished or off sale)

                            THEN 'Available'
                        ELSE 
                            'Not Available'
                    END AS Availability
                FROM Room as r
                LEFT JOIN Booking as b
                    ON r.RoomID = b.RoomID
                WHERE (r.RoomType = '{RoomType}' OR '{RoomType}' = 'All')
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

        }
    }
}
