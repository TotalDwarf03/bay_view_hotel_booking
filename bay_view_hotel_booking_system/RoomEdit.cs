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

namespace bay_view_hotel_booking_system
{
    public partial class RoomEdit : Form
    {
        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
        SQLController controller = new SQLController();

        public RoomEdit(int SelectedRoomID, string SelectedRoomType, string SelectedRoomStatus, decimal Price, int Capacity, bool IsDisabledRoom)
        {
            InitializeComponent();

            txtID.Text = SelectedRoomID.ToString();
            cbType.Text = ti.ToTitleCase(SelectedRoomType);
            cbStatus.Text = ti.ToTitleCase(SelectedRoomStatus);
            txtPrice.Text = Price.ToString();
            txtCapacity.Text = Capacity.ToString();
            cbDisabled.Text = IsDisabledRoom ? "Yes" : "No";
        }

        private void editroom_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner?.Show();
        }

        private void viewRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate Inputs

            string message = "";
            bool ValidationFailed = false;

            if (cbType.Text == "")
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
                UPDATE Room 
                SET RoomType = '{cbType.Text.ToLower()}',
                    RoomStatusID = '{RoomStatusID}',
                    Price = '{txtPrice.Text}',
                    Capacity = '{txtCapacity.Text}',
                    IsDisabled = '{disabled}'

                WHERE RoomID = '{txtID.Text}'
                    
                """;

            int RecordsUpdated = controller.RunNonQuery(sql);

            if (RecordsUpdated == 1)
            {
                MessageBox.Show(
                    "Room successfully edited.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "An error occurred while editing the room. Please try again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            this.Close();
        }

        private void returnToHomepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Owner?.Close();
        }
    }
}
