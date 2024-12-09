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
    public partial class StaffEdit : Form
    {

        SQLController controller = new SQLController();

        public StaffEdit(string StaffID)
        {
            InitializeComponent();

            string query = $"SELECT * FROM Staff WHERE StaffID = '{StaffID}'";

            DataTable dtStaff = controller.RunQuery(query);

            tbStaffID.Text = StaffID;
            tbStaffType.Text = dtStaff.Rows[0]["StaffType"].ToString();
            tbForename.Text = dtStaff.Rows[0]["Forename"].ToString();
            tbSurname.Text = dtStaff.Rows[0]["Surname"].ToString();
            tbPhoneNumber.Text = dtStaff.Rows[0]["PhoneNumber"].ToString();
            tbEmail.Text = dtStaff.Rows[0]["Email"].ToString();
            tbPassword.Text = dtStaff.Rows[0]["Password"].ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string StaffID = tbStaffID.Text;
            string StaffType = tbStaffType.Text;
            string Forename = tbForename.Text;
            string Surname = tbSurname.Text;
            string PhoneNumber = tbPhoneNumber.Text;
            string Email = tbEmail.Text;
            string Password = tbPassword.Text;

            string query = $"UPDATE Staff SET StaffID = '{StaffID}', StaffType = '{StaffType}', Forename = '{Forename}', Surname = '{Surname}', PhoneNumber = '{PhoneNumber}', Email = '{Email}', Password = '{Password}' WHERE StaffID = '{StaffID}'";

            int recordschanged = new SQLController().RunNonQuery(query);

            if (recordschanged > 0)
            {
                tbStaffID.Text = "";
                tbStaffType.Text = "";
                tbForename.Text = "";
                tbSurname.Text = "";
                tbPhoneNumber.Text = "";
                tbEmail.Text = "";
                tbPassword.Text = "";

                MessageBox.Show("Staff has been saved");

                StaffForm SHome = new StaffForm();
                SHome.Show();
                this.Close();
            }

            if (recordschanged == 0)
            {
                MessageBox.Show("The Staff member is unable to be saved. Please contact an admin",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                StaffForm sHome = new StaffForm();
                sHome.Show();
                this.Close();
            }
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
    }
}
