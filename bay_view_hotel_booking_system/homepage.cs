﻿using System;
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
        public homepage()
        {
            InitializeComponent();
        }

        SQLController controller = new SQLController();

        private void homepage_Load(object sender, EventArgs e)
        {
            // This code is temporary to check the database is working
            string query = "SELECT * FROM staff";

            DataTable dt = controller.RunQuery(query);
            datagrid.DataSource = dt;
        }

        private void homepage_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner?.Show();
        }
    }
}
