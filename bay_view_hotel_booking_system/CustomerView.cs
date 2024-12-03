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
    public partial class CustomerView : Form
    {
        SQLController controller = new SQLController();
        public CustomerView()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm CHome = new CustomerForm();
            CHome.Show();
            this.Hide();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerAdd CAdd = new CustomerAdd();
            CAdd.Show();
            this.Hide();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerSearch CSearch = new CustomerSearch("Edit");
            CSearch.Show();
            this.Hide();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerSearch CSearch = new CustomerSearch("Delete");
            CSearch.Show();
            this.Hide();
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            DataTable dtCustomer = controller.RunQuery("SELECT * FROM Customer");
            dgCustomer.DataSource = dtCustomer;
        }
    }
}
