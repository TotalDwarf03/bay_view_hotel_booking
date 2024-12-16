using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bay_view_hotel_booking_system
{
    public partial class RoomAdd : Form
    {
        public RoomAdd()
        {
            InitializeComponent();
        }

        SQLController controller = new SQLController();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate Inputs

            string message = "";
            bool ValidationFailed = false;

            if (rType.Text == "")
            {
                message = "Please select a room type.";
                ValidationFailed = true;
            }
            else if (cbStatus.Text == "")
            {
                message = "Please select a room status.";
                ValidationFailed = true;
            }
            else if (txtPrice.Text == "")
            {
                message = "Please enter a price.";
                ValidationFailed = true;
            }
            else if (txtCapacity.Text == "")
            {
                message = "Please enter a capacity.";
                ValidationFailed = true;
            }

            // Make sure price is a number

            else if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                message = "Price must be a number.";
                ValidationFailed = true;
            }

            // Make sure capacity is a number

            else if (!int.TryParse(txtCapacity.Text, out int capacity))
            {
                message = "Capacity must be a number.";
                ValidationFailed = true;
            }

            if (ValidationFailed)
            {
                MessageBox.Show(
                    message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            int disabled = cbDisabled.Text == "Yes" ? 1 : 0;

            string roomstatus = cbStatus.Text.ToLower();

            string sql = $"""
                SELECT RoomStatusID 
                FROM RoomStatus
                WHERE RoomStatus = '{roomstatus}'
                Limit 1
                """;

            DataTable dt = controller.RunQuery(sql);

            string RoomStatusID = dt.Rows[0]["RoomStatusID"].ToString();

            sql = $"""
                INSERT INTO Room (
                    RoomType,
                    RoomStatusID,
                    Price,
                    Capacity,
                    IsDisabled
                )
                VALUES (
                    '{rType.Text.ToLower()}',
                    '{RoomStatusID}',
                    '{txtPrice.Text}',
                    '{txtCapacity.Text}',
                    '{disabled}'
                )
                """;

            int RecordsInserted = controller.RunNonQuery(sql);

            if (RecordsInserted == 1)
            {
                MessageBox.Show(
                    "Room successfully added.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "An error occurred while adding the room. Please try again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            this.Close();
        }

        private void viewRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void RoomAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner?.Show();
        }

        private void returnToHomepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Owner?.Close();
        }
    }
}
