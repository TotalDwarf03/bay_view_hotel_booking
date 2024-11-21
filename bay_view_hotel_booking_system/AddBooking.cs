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
    public partial class AddBooking : Form
    {
        public AddBooking()
        {
            InitializeComponent();
        }

        private void AddBooking_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner?.Show();
        }

        private void tsmiQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBooking_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today.AddDays(7);

            SQLController controller = new SQLController();

            String query = "SELECT DISTINCT r.RoomType FROM Room AS r";

            DataTable dtRoomTypes = controller.RunQuery(query);

            cbRoomType.Items.Clear();

            if (dtRoomTypes.Columns.Contains("RoomType"))
            {
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
        }
    }
}
