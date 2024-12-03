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

        public CustomerDelete(string CustomerID)
        {
            InitializeComponent();

            string query = $"SELECT * FROM Customer WHERE CustomerID = '{CustomerID}'";

            DataTable dtCustomer = controller.RunQuery(query);

            tbCustomerID.Text = CustomerID;
            tbForename.Text = dtCustomer.Rows[0]["Forename"].ToString();
            tbSurname.Text = dtCustomer.Rows[0]["Surname"].ToString();
            tbPhoneNumber.Text = dtCustomer.Rows[0]["PhoneNumber"].ToString();
            tbEmail.Text = dtCustomer.Rows[0]["Email"].ToString();
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
            string CustomerID = tbCustomerID.Text;

            string query = $"DELETE FROM Customer WHERE CustomerID = '{CustomerID}'";

            int recordschanged = controller.RunNonQuery(query);

            if (recordschanged > 0)
            {
                tbCustomerID.Text = "";
                tbForename.Text = "";
                tbSurname.Text = "";
                tbPhoneNumber.Text = "";
                tbEmail.Text = "";

                MessageBox.Show("Customer has been Deleted");
                CustomerForm CHome = new CustomerForm();
                CHome.Show();
                this.Hide();
            }
            if (recordschanged == 0)
            {
                MessageBox.Show("Customer is unable to be Deleted. Please contact an admin",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerSearch CSearch = new CustomerSearch("Edit");
            CSearch.Show();
            this.Hide();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerView CView = new CustomerView();
            CView.Show();
            this.Hide();
        }
    }
}
