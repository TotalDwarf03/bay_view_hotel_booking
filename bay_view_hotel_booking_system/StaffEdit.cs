using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bay_view_hotel_booking_system
{
    public partial class StaffEdit : Form
    {
        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
        SQLController controller = new SQLController();

        string StaffPassword;

        public StaffEdit(string StaffID)
        {
            InitializeComponent();

            string query = $"SELECT * FROM Staff WHERE StaffID = '{StaffID}'";

            DataTable dtStaff = controller.RunQuery(query);

            tbStaffID.Text = StaffID;
            tbForename.Text = dtStaff.Rows[0]["Forename"].ToString();
            tbSurname.Text = dtStaff.Rows[0]["Surname"].ToString();
            tbPhoneNumber.Text = dtStaff.Rows[0]["PhoneNumber"].ToString();
            tbEmail.Text = dtStaff.Rows[0]["Email"].ToString();
            StaffPassword = dtStaff.Rows[0]["Password"].ToString();

            // Populate Staff Type
            string StaffType = dtStaff.Rows[0]["StaffType"].ToString();

            query = $"""
                SELECT DISTINCT
                    s.StaffType
                FROM Staff AS s
                ORDER BY s.StaffType ASC
                """;

            DataTable dt = controller.RunQuery(query);

            cbStaffType.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                cbStaffType.Items.Add(ti.ToTitleCase(dr["StaffType"].ToString()));
            }

            cbStaffType.SelectedItem = ti.ToTitleCase(StaffType);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string StaffID = tbStaffID.Text;
            string StaffType = cbStaffType.Text.ToLower();
            string Forename = tbForename.Text;
            string Surname = tbSurname.Text;
            string PhoneNumber = tbPhoneNumber.Text;
            string Email = tbEmail.Text;

            // Validate Inputs

            bool ValidationFailed = false;
            string message = "";

            // Check if all fields are populated

            if (Forename.Length == 0)
            {
                ValidationFailed = true;
                message = "Forename is a required field. Please fill it in.";
            }
            else if (Surname.Length == 0)
            {
                ValidationFailed = true;
                message = "Surname is a required field. Please fill it in.";
            }
            else if (PhoneNumber.Length == 0)
            {
                ValidationFailed = true;
                message = "Phone Number is a required field. Please fill it in.";
            }
            else if (Email.Length == 0)
            {
                ValidationFailed = true;
                message = "Email is a required field. Please fill it in.";
            }
            else if (StaffType.Length == 0)
            {
                ValidationFailed = true;
                message = "Staff Type is a required field. Please fill it in.";
            }

            // Check Valid Email
            else if (!(new EmailAddressAttribute().IsValid(Email)))
            {
                ValidationFailed = true;
                message = "Email Address Invalid.";
            }

            if (ValidationFailed)
            {
                MessageBox.Show(
                    message,
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // If the password field is not empty, hash the new password
            // and replace the existing password with the new one.
            // If the password field is empty, keep the existing password.
            if (tbPassword.Text.Length > 0)
            {
                StaffPassword = PasswordManager.HashPassword(tbPassword.Text);
            }

            string query = $"""
                UPDATE Staff
                SET
                    Forename = '{Forename}',
                    Surname = '{Surname}',
                    PhoneNumber = '{PhoneNumber}',
                    Email = '{Email}',
                    Password = '{StaffPassword}',
                    StaffType = '{StaffType}'
                WHERE StaffID = '{StaffID}'
                """;

            int RecordsChanged = controller.RunNonQuery(query);

            if (RecordsChanged > 0)
            {
                MessageBox.Show(
                    "Staff Member has been updated.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "An Error has occured when updating the Staff Member. Please try again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            this.Close();
        }
    }
}
