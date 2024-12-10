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

        private void CustomerSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner?.Show();
        }

        private void tsmiCustomerHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiQuit_Click(object sender, EventArgs e)
        {
            this.Owner?.Close();
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            string CustomerName = tbCustomerName.Text;

            string query = $"""
                SELECT 
                    c.CustomerID, 
                    c.Forename || ' ' || c.Surname AS Name, 
                    c.Email, 
                    c.PhoneNumber 
                FROM Customer AS c 
                WHERE c.Forename || ' ' || c.Surname LIKE '%{CustomerName}%'
                    AND c.CustomerID != 1;
                """;

            DataTable dtCustomer = new SQLController().RunQuery(query);

            if (dtCustomer.Rows.Count > 0)
            {
                dgCustomer.DataSource = dtCustomer;
            }
            else
            {
                MessageBox.Show(
                      "No Customers have been found.",
                      "Warning",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning
               );

                dgCustomer.DataSource = null;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbCustomerName.Text = "";

            CustomerView_Load(sender, e);
        }
    }
}
