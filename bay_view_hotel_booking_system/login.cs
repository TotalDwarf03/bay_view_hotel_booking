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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Checks that a given username and password matches a record in the database.
        /// </summary>
        /// <param name="email">The user's email</param>
        /// <param name="password">The user's password</param>
        /// <returns></returns>
        private (bool, string) VerifyLoginDetails(string email, string password)
        {
            string query = $"SELECT * FROM staff WHERE email = '{email}'";

            DataTable dt = new SQLController().RunQuery(query);

            if (dt.Rows.Count == 0)
            {
                return (false, "User Not Found.");
            }

            string? dbPassword = dt.Rows[0]["password"].ToString();

            if (dbPassword == null)
            {
                return (false, "Password missing from Database, please contact your manager.");
            }

            string InputPassword = PasswordManager.HashPassword(password);

            if (dbPassword == InputPassword)
            {
                return (true, "Login Successful.");
            }

            return (false, "Invalid Credentials.");
        }

        /// <summary>
        /// Shows the homepage form and hides the login form.
        /// </summary>
        private void ShowHomepage()
        {
            homepage frm = new homepage();
            frm.Owner = this;

            frm.Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string password = tbPassword.Text;

            var LoginStatus = VerifyLoginDetails(email, password);

            if (LoginStatus.Item1)
            {
                MessageBox.Show(LoginStatus.Item2, "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ShowHomepage();
            }
            else
            {
                tbPassword.Text = "";

                MessageBox.Show(LoginStatus.Item2, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
