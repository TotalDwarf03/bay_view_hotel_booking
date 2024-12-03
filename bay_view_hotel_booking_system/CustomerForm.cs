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
            CustomerAdd CAdd = new CustomerAdd();
            CAdd.Show();
            this.Hide();
        }

        private void CustomerEdit_Click(object sender, EventArgs e)
        {
            CustomerSearch CSearch = new CustomerSearch("Edit");
            CSearch.Show();
            this.Hide();
        }

        private void CustomerDelete_Click(object sender, EventArgs e)
        {
            CustomerSearch CSearch = new CustomerSearch("Delete");
            CSearch.Show();
            this.Hide();
        }
    }
}
