using System.Data;
using System.Diagnostics;
using System.Globalization;

namespace bay_view_hotel_booking_system
{
    public partial class CreateBooking : Form
    {
        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
        SQLController controller = new SQLController();

        public CreateBooking(int SelectedRoomID, string RoomType, decimal RoomPrice, int RoomCapacity, bool IsDisabledRoom, DateTime StartDate, DateTime EndDate)
        {
            InitializeComponent();

            // Import UI Defaults from previous screen
            dtpStartDate.Value = StartDate;
            dtpEndDate.Value = EndDate;

            tbRoomID.Text = SelectedRoomID.ToString();
            tbRoomType.Text = ti.ToTitleCase(RoomType);
            tbDisabled.Text = IsDisabledRoom ? "Yes" : "No";
            tbPricePerNight.Text = RoomPrice.ToString("C");
            tbCapacity.Text = RoomCapacity.ToString();

            calculateSummary();
        }

        private void CreateBooking_FormClosing(object sender, FormClosingEventArgs e)
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

        private void CostingChanged(object sender, EventArgs e)
        {
            calculateSummary();
        }

        private bool ValidateInputs(List<string> ItemsToValidate)
        {
            // Number of Guests Validation

            if (ItemsToValidate.Contains("guest"))
            {
                int NumberOfGuests = Convert.ToInt32(nudAdult.Value + nudChild.Value);

                // Check if booking has at least one adult
                if (nudAdult.Value == 0)
                {
                    MessageBox.Show(
                        "You must have at least one adult in the room.",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return false;
                }

                // Check if number of guests exceeds room capacity
                if (NumberOfGuests > Convert.ToInt32(tbCapacity.Text))
                {
                    MessageBox.Show(
                        "The number of guests exceeds the room capacity. Please select a larger room or reduce the number of guests.",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return false;
                }
            }


            // Customer Details Validation

            if (ItemsToValidate.Contains("customer"))
            {
                // Check if a customer has been selected
                if (dgvCustomer.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                        "Please search for and select a customer to book a room.",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return false;
                }
            }

            // Staff Validation

            if (ItemsToValidate.Contains("staff"))
            {
                // Check if the user has ticked the confirmation box
                if (chbConfirm.Checked == false)
                {
                    MessageBox.Show(
                        "Please confirm that the details are correct before booking.",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return false;
                }
            }

            return true;
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
            if (tbRoomType.Text == "Family")
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
            if (NumberOfGuests == 1 & tbRoomType.Text == "Double")
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

        private void NumberOfGuestsChanged(object sender, EventArgs e)
        {
            // If default values, skip validation to avoid error message spam
            if (nudAdult.Value == 1 & nudChild.Value == 0)
            {
                calculateSummary();
                return;
            }


            if (ValidateInputs(["guest"]))
            {
                calculateSummary();
            }
            else
            {
                // Reset the number of guests to the default values
                nudAdult.Value = 1;
                nudChild.Value = 0;
            }
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

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (ValidateInputs(["guest", "customer", "staff"]))
            {
                // Collect Booking Details from the UI
                int CustomerID = Convert.ToInt32(dgvCustomer.SelectedRows[0].Cells[0].Value);
                int RoomID = Convert.ToInt32(tbRoomID.Text);
                DateTime StartDate = dtpStartDate.Value;
                DateTime EndDate = dtpEndDate.Value;
                int NumberOfAdults = Convert.ToInt32(nudAdult.Value);
                int NumberOfChildren = Convert.ToInt32(nudChild.Value);
                int Breakfast = rbBreakfastYes.Checked ? 1 : 0;
                int BreakfastRateID = CalculateBreakfastRateID(NumberOfAdults + NumberOfChildren);
                decimal Total = Convert.ToDecimal(lblTotalValue.Text.Substring(1));

                // Collect User Details to keep track of who made the booking
                string? username = Environment.GetEnvironmentVariable("USER_EMAIL");

                string query = $"""
                    SELECT 
                        s.StaffID
                    FROM Staff AS s
                    WHERE s.Email = '{username}';
                    """;

                DataTable dt = controller.RunQuery(query);

                int StaffID = Convert.ToInt32(dt.Rows[0][0]);

                // Insert Booking into the Database
                query = $"""
                    INSERT INTO Booking (
                        CustomerID,
                        RoomID,
                        StartDate,
                        EndDate,
                        NoAdults,
                        NoChildren,
                        Breakfast,
                        BreakfastRateID,
                        Price,
                        IsCancelled,
                        IsPaid,
                        CreatedBy,
                        CreationDate,
                        LastUpdatedBy,
                        LastUpdatedDate,
                        CancelledBy,
                        CancellationDate
                    ) 
                    VALUES (
                        {CustomerID},
                        {RoomID},
                        '{StartDate.ToString("yyyy-MM-dd")}',
                        '{EndDate.ToString("yyyy-MM-dd")}',
                        {NumberOfAdults},
                        {NumberOfChildren},
                        {Breakfast},
                        {BreakfastRateID},
                        {Total},
                        0,
                        0,
                        {StaffID},
                        '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}',
                        NULL,
                        NULL,
                        NULL,
                        NULL
                    );
                    """;

                int RecordsChanged = controller.RunNonQuery(query);

                if (RecordsChanged == 1)
                {
                    MessageBox.Show(
                        "Booking successfully created.",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "An error occurred while creating the booking. Please try again.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
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
    }
}
