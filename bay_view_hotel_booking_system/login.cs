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

        private bool verify_login_details(string username, string password)
        {
            string email = email_textbox.Text;
            string pass = password_textbox.Text;

            string query = $"SELECT * FROM staff WHERE email = '{email}'";

            DataTable dt = new SQLController().RunQuery(query);

            if (dt.Rows.Count == 0)
            {
                return false;
            }

            string? db_pass = dt.Rows[0]["password"].ToString();

            if (db_pass == null)
            {
                return false;
            }

            string input_pass = password_manager.HashPassword(pass);

            if (db_pass == input_pass)
            {
                return true;
            }

            return false;
        }

        private void show_homepage()
        {
            homepage frm = new homepage();
            frm.Owner = this;

            frm.Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            bool login = verify_login_details("username", "password");

            if (login)
            {
                show_homepage();
            }
            else
            {
                password_textbox.Text = "";

                error_message_lbl.Visible = true;
            }
        }
    }
}
