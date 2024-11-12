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
    public partial class homepage : Form
    {
        public homepage(string username, string usertype)
        {
            InitializeComponent();

            lblUser.Text = $"Logged in as: {username}.\n User Type: {usertype}.";
        }

        SQLController controller = new SQLController();

        private void homepage_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner?.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this.Owner?.Show();
            this.Close();
        }
    }
}
