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
    }
}
