using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bay_view_hotel_booking_system
{
    public partial class CustomerEdit : Form
    {

        SQLController controller = new SQLController();

        public CustomerEdit(string CustomerID)
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

        private void tsmiCustomerHome_Click(object sender, EventArgs e)
        {
            this.Owner?.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string CustomerID = tbCustomerID.Text;
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

            string query = $"UPDATE Customer SET Forename = '{Forename}', Surname = '{Surname}', PhoneNumber = '{PhoneNumber}', Email = '{Email}' WHERE CustomerID = '{CustomerID}'";

            int RecordsChanged = new SQLController().RunNonQuery(query);

            if (RecordsChanged > 0)
            {
                MessageBox.Show(
                    "Customer has been updated.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "An Error has occured when updating the customer. Please try again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            this.Close();
        }

        private void CustomerEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner?.Show();
        }

        private void tsmiQuit_Click(object sender, EventArgs e)
        {
            this.Owner?.Owner?.Close();
        }
    }
}
