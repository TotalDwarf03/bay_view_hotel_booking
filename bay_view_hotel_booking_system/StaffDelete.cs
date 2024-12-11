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
    public partial class StaffDelete : Form
    {
        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
        SQLController controller = new SQLController();

        public StaffDelete(string StaffID)
        {
            InitializeComponent();

            string query = $"SELECT * FROM Staff WHERE StaffID = '{StaffID}'";

            DataTable dtStaff = controller.RunQuery(query);

            tbStaffID.Text = StaffID;
            tbStaffType.Text = ti.ToTitleCase(dtStaff.Rows[0]["StaffType"].ToString());
            tbForename.Text = ti.ToTitleCase(dtStaff.Rows[0]["Forename"].ToString());
            tbSurname.Text = ti.ToTitleCase(dtStaff.Rows[0]["Surname"].ToString());
            tbPhoneNumber.Text = dtStaff.Rows[0]["PhoneNumber"].ToString();
            tbEmail.Text = dtStaff.Rows[0]["Email"].ToString();
        }

        private void tsmiStaffHome_Click(object sender, EventArgs e)
        {
            this.Owner?.Close();
        }

        private void StaffFormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner?.Show();
        }

        private void tsmiQuit_Click(object sender, EventArgs e)
        {
            this.Owner?.Owner?.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string StaffID = tbStaffID.Text;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this Staff member?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                this.Close();
                return;
            }

            // To Remove Staff from any bookings
            string query = $"""
                UPDATE Booking
                SET
                    StaffID = 1
                WHERE
                    StaffID = '{StaffID}'
                """;

            int RecordsChanged = controller.RunNonQuery(query);

            if (RecordsChanged == 0)
            {
                MessageBox.Show(
                    "Staff member hasn't created any bookings. Skipping process.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    $"Staff member had {RecordsChanged.ToString()} existing bookings created. These have been ammended appropriately.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            query = $"DELETE FROM Staff WHERE StaffID = '{StaffID}'";

            RecordsChanged = controller.RunNonQuery(query);

            if (RecordsChanged > 0)
            {
                MessageBox.Show(
                    "Staff member has been deleted.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "An error has occured when deleting the Staff Member. Please try again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            this.Close();
        }
    }
}
