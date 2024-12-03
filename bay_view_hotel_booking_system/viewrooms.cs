using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bay_view_hotel_booking_system
{
    public partial class viewrooms : Form
    {
        public viewrooms()
        {
            InitializeComponent();
        }

        SQLController controller = new SQLController();

        private void homepage_Load(object sender, EventArgs e)
        {
            DataTable dtRoom = controller.RunQuery("SELECT * FROM Room");
            dgRoom.DataSource = dtRoom;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewrooms_Load(object sender, EventArgs e)
        {
            DataTable dtRoom = controller.RunQuery("SELECT * FROM Room");
            dgRoom.DataSource = dtRoom;
        }

        private void addRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addroom frm = new addroom();
            frm.Owner = this;

            frm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String RoomType = rType.Text;
            
            string query = $"""
                SELECT 
                    RoomID,
                    RoomType,
                    RoomStatusID,
                    Price,
                    Capacity,
                    IsDisabled

                FROM Room

                WHERE RoomType = '{RoomType}'
                """;

            DataTable dtRoom = controller.RunQuery(query);
            dgRoom.DataSource = dtRoom;
        }

        //private void btnLoad_Click(object sender, EventArgs e)
        //{
        //SQLController controller = new SQLController();

        //string load = $"""
        //SELECT * FROM Room
        //""";

        //DataTable dgRooms = controller.RunQuery(load);

        //}
    }
}

