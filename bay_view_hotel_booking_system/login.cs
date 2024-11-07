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
            // TODO

            return true;
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
                error_message_lbl.Visible = true;
            }
        }
    }
}
