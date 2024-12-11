using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class StaffView : Form
    {
        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
        SQLController controller = new SQLController();

        public StaffView()
        {
            InitializeComponent();

            // Populate Staff Type
            string query = $"""
                SELECT DISTINCT
                    s.StaffType
                FROM Staff AS s
                ORDER BY s.StaffType ASC
                """;

            DataTable dt = controller.RunQuery(query);

            cbStaffType.Items.Clear();

            cbStaffType.Items.Add("Any");

            foreach (DataRow dr in dt.Rows)
            {
                cbStaffType.Items.Add(ti.ToTitleCase(dr["StaffType"].ToString()));
            }

            cbStaffType.SelectedIndex = 0;
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string StaffName = tbStaffName.Text;

            string query = $"""
                SELECT 
                    s.StaffID, 
                    s.StaffType,
                    s.Forename || ' ' || s.Surname AS Name, 
                    s.Email, 
                    s.PhoneNumber
                FROM Staff AS s 
                WHERE s.Forename || ' ' || s.Surname LIKE '%{StaffName}%'
                    AND '{cbStaffType.Text.ToLower()}' IN (s.StaffType, 'any')
                    AND s.StaffID != 1;
                """;

            DataTable dtStaff = new SQLController().RunQuery(query);

            if (dtStaff.Rows.Count > 0)
            {
                dgvStaff.DataSource = dtStaff;
            }
            else
            {
                MessageBox.Show(
                      "No Staff Members have been found.",
                      "Warning",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning
               );

                dgvStaff.DataSource = null;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbStaffName.Text = "";
            cbStaffType.SelectedIndex = 0;

            btnLoad_Click(sender, e);
        }
    }
}
