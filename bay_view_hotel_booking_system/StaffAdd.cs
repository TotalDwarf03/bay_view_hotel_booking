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
    public partial class StaffAdd : Form
    {
        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
        SQLController controller = new SQLController();

        public StaffAdd()
        {
            InitializeComponent();

            // Populate the Staff Type Combo Box
            string query = $"""
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
        }

        private void tsmiStaffHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StaffFormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner?.Show();
        }

        private void tsmiQuit_Click(object sender, EventArgs e)
        {
            this.Owner?.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string StaffType = cbStaffType.Text.ToLower();
            string Forename = tbForename.Text;
            string Surname = tbSurname.Text;
            string PhoneNumber = tbPhoneNumber.Text;
            string Email = tbEmail.Text;
            string Password = tbPassword.Text;

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
            else if (Password.Length == 0)
            {
                ValidationFailed = true;
                message = "Password is a required field. Please fill it in.";
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

            string HashedPassword = PasswordManager.HashPassword(Password);

            string query = $"""
                INSERT INTO Staff (StaffType, Forename, Surname, PhoneNumber, Email, Password)
                VALUES ('{StaffType}', '{Forename}', '{Surname}', '{PhoneNumber}', '{Email}', '{HashedPassword}')
                """;

            int RecordsChanged = controller.RunNonQuery(query);

            if (RecordsChanged > 0)
            {
                MessageBox.Show(
                    "Staff Member has been added.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "Staff Member could not be added.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            this.Close();
        }
    }
}
