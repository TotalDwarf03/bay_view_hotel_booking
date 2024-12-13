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
    public partial class editroom : Form
    {
        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
        SQLController controller = new SQLController();

        public editroom(int SelectedRoomID, string SelectedRoomType, string SelectedRoomStatus, decimal Price, int Capacity, bool IsDisabledRoom)
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

        private void button2_Click(object sender, EventArgs e)
        {
            viewrooms frm = Application.OpenForms["viewrooms"] as viewrooms;
            if (frm != null)
            {
                frm.Show();
            }

            this.Close();
        }

        private void viewRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewrooms frm = Application.OpenForms["viewrooms"] as viewrooms;
            if (frm != null)
            {
                frm.Show();
            }

            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SQLController con = new SQLController();

            int disabled = cbDisabled.Text == "Yes" ? 1 : 0;

            string roomstatus = cbStatus.Text.ToLower();

            string sql = $"""
                SELECT RoomStatusID 
                FROM RoomStatus
                WHERE RoomStatus = '{roomstatus}'
                Limit 1
                """;

            DataTable dt = con.RunQuery(sql);

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

            int RecordsUpdated = con.RunNonQuery(sql);

            if (RecordsUpdated == 1)
            {
                MessageBox.Show(
                    "Room successfully edited.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                cbType.Items.Clear();
                cbStatus.Items.Clear();
                txtPrice.Clear();
                txtCapacity.Clear();
                cbDisabled.Items.Clear();

                viewrooms frm = Application.OpenForms["viewrooms"] as viewrooms;
                if (frm != null)
                {
                    frm.Show();
                }

                this.Close();
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
        }
    }
}
