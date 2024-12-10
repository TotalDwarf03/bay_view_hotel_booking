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
    public partial class CustomerSearch : Form
    {
        public CustomerSearch(string NextPage)
        {
            InitializeComponent();

            lblNextPage.Text = NextPage;
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string NextPage = lblNextPage.Text;

            if (dgCustomer.SelectedRows.Count > 0)
            {
                string CustomerID = dgCustomer.SelectedRows[0].Cells[0].Value.ToString();

                if (NextPage == "Edit")
                {
                    CustomerEdit frm = new CustomerEdit(CustomerID);
                    frm.Owner = this;

                    frm.Show();
                    this.Hide();
                }

                if (NextPage == "Delete")
                {
                    CustomerDelete frm = new CustomerDelete(CustomerID);
                    frm.Owner = this;

                    frm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show(
                       "Please select a customer.",
                       "Warning",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning
                );
            }
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

        private void CustomerSearch_VisibleChanged(object sender, EventArgs e)
        {
            dgCustomer.DataSource = null;
        }
    }
}
