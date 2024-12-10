using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private (bool, string, string?, string?) VerifyLoginDetails(string email, string password)
        {
            string query = $"SELECT * FROM Staff WHERE Email = '{email}' AND StaffID != 1";

            DataTable dt = new SQLController().RunQuery(query);

            if (dt.Rows.Count == 0)
            {
                return (false, "User Not Found.", null, null);
            }

            string? dbPassword = dt.Rows[0]["password"].ToString();

            if (dbPassword == null)
            {
                return (false, "Password missing from Database, please contact your manager.", null, null);
            }

            string InputPassword = PasswordManager.HashPassword(password);

            if (dbPassword == InputPassword)
            {
                string username = $"{dt.Rows[0]["forename"].ToString()} {dt.Rows[0]["surname"].ToString()}";
                string? usertype = dt.Rows[0]["stafftype"].ToString();

                return (true, "Login Successful.", username, usertype);
            }

            return (false, "Invalid Credentials.", null, null);
        }

        /// <summary>
        /// Shows the homepage form and hides the login form.
        /// </summary>
        private void ShowHomepage(string username, string usertype)
        {
            homepage frm = new homepage(username, usertype);
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

                Environment.SetEnvironmentVariable("USER_EMAIL", email);

                tbEmail.Text = "";
                tbPassword.Text = "";

                tbEmail.Focus();

                ShowHomepage(LoginStatus.Item3, LoginStatus.Item4);
            }
            else
            {
                tbPassword.Text = "";

                MessageBox.Show(LoginStatus.Item2, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If enter pressed, login
            if (e.KeyChar == 13)
            {
                login_btn_Click(this, e);
            }
        }
    }
}
