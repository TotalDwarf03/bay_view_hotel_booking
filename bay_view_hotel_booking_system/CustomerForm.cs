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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            CustomerAdd frm = new CustomerAdd();
            frm.Owner = this;

            frm.Show();
            this.Hide();
        }

        private void CustomerEdit_Click(object sender, EventArgs e)
        {
            CustomerSearch frm = new CustomerSearch("Edit");
            frm.Owner = this;

            frm.Show();
            this.Hide();
        }

        private void CustomerDelete_Click(object sender, EventArgs e)
        {
            CustomerSearch frm = new CustomerSearch("Delete");
            frm.Owner = this;

            frm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCustomerView_Click(object sender, EventArgs e)
        {
            CustomerView frm = new CustomerView();
            frm.Owner = this;

            frm.Show();
            this.Hide();
        }

        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner?.Show();
        }
    }
}
