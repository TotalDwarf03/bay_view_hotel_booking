using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
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

            string query = $"INSERT INTO Customer (Forename, Surname, PhoneNumber, Email) VALUES ('{Forename}', '{Surname}', '{PhoneNumber}', '{Email}')";

            int RecordsChanged = new SQLController().RunNonQuery(query);

            if (RecordsChanged > 0)
            {
                MessageBox.Show(
                    "Customer has been added.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "An Error has occured when adding the customer. Please try again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            this.Close();
        }

        private void tsmiCustomerHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner?.Show();
        }

        private void tsmiQuit_Click(object sender, EventArgs e)
        {
            this.Owner?.Close();
        }
    }
}
