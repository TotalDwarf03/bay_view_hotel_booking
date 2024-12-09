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
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }

        private void btnStaffAdd_Click(object sender, EventArgs e)
        {
            StaffAdd SAdd = new StaffAdd();
            SAdd.Show();
            this.Close();
        }

        private void btnStaffEdit_Click(object sender, EventArgs e)
        {
            StaffSearch SSearch = new StaffSearch("Edit");
            SSearch.Show();
            this.Close();
        }

        private void btnStaffView_Click(object sender, EventArgs e)
        {
            StaffView SView = new StaffView();
            SView.Show();
            this.Close();
        }

        private void btnStaffDelete_Click(object sender, EventArgs e)
        {
            StaffSearch SSearch = new StaffSearch("Delete");
            SSearch.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            homepage homepage = new homepage();
            homepage.Show();
            this.Close();
        }
    }
}
