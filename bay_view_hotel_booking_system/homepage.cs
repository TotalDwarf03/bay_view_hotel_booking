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
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        SQLController controller = new SQLController();

        private void homepage_Load(object sender, EventArgs e)
        {
            // This code is temporary to check the database is working

            DataTable dtStaff = controller.RunQuery("SELECT * FROM Staff");
            dgStaff.DataSource = dtStaff;

            DataTable dtRoom = controller.RunQuery("SELECT * FROM Room");
            dgRoom.DataSource = dtRoom;

            DataTable dtBooking = controller.RunQuery("SELECT * FROM Booking");
            dgBooking.DataSource = dtBooking;

            DataTable dtCustomer = controller.RunQuery("SELECT * FROM Customer");
            dgCustomer.DataSource = dtCustomer;

            DataTable dtPayment = controller.RunQuery("SELECT * FROM Payment");
            dgTransaction.DataSource = dtPayment;
        }

        private void homepage_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner?.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerForm cform = new CustomerForm();
            cform.Show();
            this.Hide();
        }
    }
}
