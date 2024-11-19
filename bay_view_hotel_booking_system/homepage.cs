﻿using System;
using System.Globalization;

namespace bay_view_hotel_booking_system
{
    public partial class homepage : Form
    {
        public homepage(string username, string usertype)
        {
            InitializeComponent();

            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;

            lblUser.Text = $"Logged in as: {ti.ToTitleCase(username)}.\n User Type: {ti.ToTitleCase(usertype)}.";

            if (usertype == "manager")
            {
                fpnlRoom.Visible = true;
                fpnlStaff.Visible = true;
                fpnlReporting.Visible = true;
            }
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
