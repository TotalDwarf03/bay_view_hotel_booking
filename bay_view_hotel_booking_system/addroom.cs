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
    public partial class addroom : Form
    {
        public addroom()
        {
            InitializeComponent();
            //this.StartPosition = FormStartPosition.CenterScreen;
        }

        SQLController controller = new SQLController();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SQLController controller = new SQLController();

            int disabled = radioButton1.Checked ? 1 : 0;

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

                rType.Items.Clear();
                cbStatus.Items.Clear();
                txtPrice.Clear();
                txtCapacity.Clear();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewrooms frm = new viewrooms();
            frm.Owner = this;

            frm.Show();
            this.Hide();
        }
    }
}
