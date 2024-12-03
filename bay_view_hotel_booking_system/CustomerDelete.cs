using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bay_view_hotel_booking_system
{
    public partial class CustomerDelete : Form
    {
        SQLController controller = new SQLController();
        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;

        public CustomerDelete(string CustomerID)
        {
            InitializeComponent();

            string query = $"SELECT * FROM Customer WHERE CustomerID = '{CustomerID}'";

            DataTable dtCustomer = controller.RunQuery(query);

            if (dtCustomer.Columns.Contains("CustomerID"))
            {
                cbCustomerID.Items.Add("All");
                cbCustomerID.SelectedIndex = 0;

                foreach (DataRow dr in dtCustomer.Rows)
                {
                    cbCustomerID.Items.Add(dr["CustomerID"].ToString());
                }
            }

        }

        private void customerHomeToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void cbCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CustomerDelete_Load(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerSearch CSearch = new CustomerSearch("Edit");
            CSearch.Show();
            this.Hide();
        }
    }
}
