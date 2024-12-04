using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace bay_view_hotel_booking_system
{
    public partial class PaymentManagement : Form
    {
        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
        SQLController controller = new SQLController();

        public PaymentManagement(int BookingID)
        {
            InitializeComponent();

            string query = $"""
                SELECT
                    b.BookingID,
                    b.StartDate,
                    b.EndDate,
                    b.NoAdults,
                    b.NoChildren,
                    b.Price,
                    b.Breakfast,
                    r.RoomID,
                    r.RoomType,
                    r.Price AS RoomPrice,
                    r.IsDisabled,
                    c.Forename,
                    c.Surname,
                    c.Email,
                    c.PhoneNumber
                FROM Booking AS b
                JOIN Customer AS c
                    ON b.CustomerID = c.CustomerID
                JOIN Room AS r
                    ON b.RoomID = r.RoomID
                WHERE b.BookingID = {BookingID};
                """;

            DataTable dt = controller.RunQuery(query);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No booking found with that ID.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            DataRow row = dt.Rows[0];

            tbBooking.Text = row["BookingID"].ToString();
            tbStartDate.Text = Convert.ToDateTime(row["StartDate"]).ToString("dd MMMM yyyy");
            tbEndDate.Text = Convert.ToDateTime(row["EndDate"]).ToString("dd MMMM yyyy");
            tbAdult.Text = row["NoAdults"].ToString();
            tbChild.Text = row["NoChildren"].ToString();
            tbPrice.Text = Convert.ToDecimal(row["Price"]).ToString("C");
            cbBreakfast.Checked = row["Breakfast"].ToString() == "1";
            cbBreakfast.Text = row["Breakfast"].ToString() == "1" ? "True" : "False";

            tbRoom.Text = row["RoomID"].ToString();
            tbRoomType.Text = row["RoomType"].ToString();
            tbRoomPrice.Text = Convert.ToDecimal(row["RoomPrice"]).ToString("C");
            cbDisabled.Checked = row["IsDisabled"].ToString() == "1";
            cbDisabled.Text = row["IsDisabled"].ToString() == "1" ? "True" : "False";

            tbForename.Text = ti.ToTitleCase(row["Forename"].ToString() ?? "Forename not found");
            tbSurname.Text = ti.ToTitleCase(row["Surname"].ToString() ?? "Surname not found");
            tbEmail.Text = row["Email"].ToString();
            tbPhone.Text = row["PhoneNumber"].ToString();
        }

        private void PaymentManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner?.Show();
        }

        private void tsmiQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int GetStaffID()
        {
            string username = Environment.GetEnvironmentVariable("USER_EMAIL");

            string query = $"""
                SELECT 
                    s.StaffID
                FROM Staff AS s
                WHERE s.Email = '{username}';
                """;

            DataTable dt = controller.RunQuery(query);

            return Convert.ToInt32(dt.Rows[0][0]);
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                $"This booking has a total price of {tbPrice.Text}. Are you sure you want to mark this booking as paid?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                bool OperationFailed = false;

                int StaffID = GetStaffID();

                string query = $"""
                    UPDATE booking
                    SET 
                        IsPaid = 1,
                        LastUpdatedBy = '{StaffID}',
                        LastUpdatedDate = '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}'
                    WHERE BookingID = {tbBooking.Text};
                    """;

                int recordsChanged = controller.RunNonQuery(query);

                if (recordsChanged > 0)
                {
                    query = $"""
                        INSERT INTO Payment (BookingID, Amount)
                        VALUES ({tbBooking.Text}, {Convert.ToDecimal(tbPrice.Text.Substring(1))});
                        """;

                    recordsChanged = controller.RunNonQuery(query);

                    if (recordsChanged > 0)
                    {
                        MessageBox.Show(
                            "Booking has been marked as paid.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    else
                    {
                        OperationFailed = true;
                    }
                }
                else
                {
                    OperationFailed = true;
                }

                if (OperationFailed)
                {
                    MessageBox.Show(
                        "An error occurred while marking the booking as paid.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }

            tsmiQuit_Click(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to cancel this booking?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                bool OperationFailed = false;

                int StaffID = GetStaffID();

                decimal CancelFee = 0.00m;

                // Check if the booking cancellation has a fee
                // 15% of the total booking price if the booking is cancelled within 3 weeks (21 days) of the start date
                DateTime StartDate = Convert.ToDateTime(tbStartDate.Text);

                if ((DateTime.Now.Date - StartDate).Days < 21)
                {
                    CancelFee = Math.Round(Convert.ToDecimal(tbPrice.Text.Substring(1)) * 0.15m, 2);
                    string CancelFeeStr = CancelFee.ToString("C");

                    result = MessageBox.Show(
                        $"This booking has a cancellation fee of 15% of the total booking price. The cancellation fee is {CancelFeeStr}. Has this transaction been completed?",
                        "Cancellation Fee",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information
                    );

                    if (result == DialogResult.No)
                    {
                        MessageBox.Show(
                            "Please complete the transaction before cancelling the booking. Please try again.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );

                        tsmiQuit_Click(sender, e);
                        return;
                    }
                }

                string query = $"""
                UPDATE booking
                SET 
                    IsCancelled = 1,
                    CancelledBy = '{StaffID}',
                    CancellationDate = '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}'
                WHERE BookingID = {tbBooking.Text};
                """;

                int recordsChanged = controller.RunNonQuery(query);

                if (recordsChanged > 0)
                {
                    if (CancelFee > 0)
                    {
                        query = $"""
                        INSERT INTO Payment (BookingID, Amount)
                        VALUES ({tbBooking.Text}, {CancelFee});
                        """;

                        recordsChanged = controller.RunNonQuery(query);

                        if (recordsChanged == 0)
                        {
                            OperationFailed = true;
                        }
                    }

                    MessageBox.Show(
                        "Booking has been cancelled.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    OperationFailed = true;
                }

                if (OperationFailed)
                {
                    MessageBox.Show(
                        "An error occurred while cancelling the booking. Please try again.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }

            tsmiQuit_Click(sender, e);
        }
    }
}
