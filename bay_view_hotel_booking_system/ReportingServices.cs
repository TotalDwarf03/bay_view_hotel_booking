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
    public partial class ReportingServices : Form
    {
        public ReportingServices()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Report_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner?.Show();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            ReportIncome frm = new ReportIncome();
            frm.Owner = this;

            this.Hide();
            frm.Show();
        }

        private void btnTimeOccupancy_Click(object sender, EventArgs e)
        {
            ReportTimeOccupancy frm = new ReportTimeOccupancy();
            frm.Owner = this;

            this.Hide();
            frm.Show();
        }

        private void btnRoomOccupancy_Click(object sender, EventArgs e)
        {
            ReportRoomOccupancy frm = new ReportRoomOccupancy();
            frm.Owner = this;

            this.Hide();
            frm.Show();
        }
    }
}
