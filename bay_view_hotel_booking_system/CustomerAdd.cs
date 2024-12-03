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
    public partial class CustomerAdd : Form
    {
        public CustomerAdd()
        {
            InitializeComponent();
        }

        private void customerHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm CHome = new CustomerForm();
            CHome.Show();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string Forename = tbForename.Text;
            string Surname = tbSurname.Text;
            string PhoneNumber = tbPhoneNumber.Text;
            string Email = tbEmail.Text;

            string query = $"INSERT INTO Customer (Forename, Surname, PhoneNumber, Email VALUES '{Forename}', '{Surname}', '{PhoneNumber}', '{Email}'";

            int recordschanged = new SQLController().RunNonQuery(query);

            if (recordschanged > 0)
            {
                tbForename.Text = "";
                tbSurname.Text = "";
                tbPhoneNumber.Text = "";
                tbEmail.Text = "";

                MessageBox.Show("Customer has been saved");
            }

            if (recordschanged == 0)
            {
                MessageBox.Show("Customer is unabled to be saved. Please contact an admin.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
