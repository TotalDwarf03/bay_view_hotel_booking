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
    public partial class StaffAdd : Form
    {
        public StaffAdd()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffForm SHome = new StaffForm();
            SHome.Show();
            this.Close();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffView SView = new StaffView();
            SView.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string StaffType = tbStaffType.Text;
            string Forename = tbForename.Text;
            string Surname = tbSurname.Text;
            string PhoneNumber = tbPhoneNumber.Text;
            string Email = tbEmail.Text;
            string Password = tbPassword.Text;

            string query = $"INSERT INTO Staff (StaffType, Forename, Surname, PhoneNumber, Email, Password) VALUES ('{StaffType}', '{Forename}', '{Surname}', '{PhoneNumber}', '{Email}', '{Password}')";

            int recordschanged = new SQLController().RunNonQuery(query);

            if (recordschanged > 0) {
                tbStaffType.Text = "";
                tbForename.Text = "";
                tbSurname.Text = "";
                tbPhoneNumber.Text = "";
                tbEmail.Text = "";
                tbPassword.Text = "";

                MessageBox.Show("Staff has been saved.");
            }

            if (recordschanged == 0) {
                MessageBox.Show("Staff is unable to be saved. Please contact an admin.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
