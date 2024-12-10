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
            StaffAdd frm = new StaffAdd();
            frm.Owner = this;

            frm.Show();
            this.Hide();
        }

        private void btnStaffEdit_Click(object sender, EventArgs e)
        {
            StaffSearch frm = new StaffSearch("Edit");
            frm.Owner = this;

            frm.Show();
            this.Hide();
        }

        private void btnStaffView_Click(object sender, EventArgs e)
        {
            StaffView frm = new StaffView();
            frm.Owner = this;

            frm.Show();
            this.Hide();
        }

        private void btnStaffDelete_Click(object sender, EventArgs e)
        {
            StaffSearch frm = new StaffSearch("Delete");
            frm.Owner = this;

            frm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StaffForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner?.Show();
        }
    }
}
