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
    public partial class StaffView : Form
    {
        SQLController controller = new SQLController();

        public StaffView()
        {
            InitializeComponent();
        }

        private void staffManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffForm SHome = new StaffForm();
            SHome.Show();
            this.Close();
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
                    s.PhoneNumber,
                    s.Password
                FROM Staff AS s 
                WHERE s.Forename || ' ' || s.Surname LIKE '%{StaffName}%'
                    AND s.StaffID != 1;
                """;

            DataTable dtStaff = new SQLController().RunQuery(query);

            if (dtStaff.Rows.Count > 0)
            {
                dgStaff.DataSource = dtStaff;
            }
            else
            {
                MessageBox.Show(
                      "No Staff Members have been found.",
                      "Warning",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning
               );

                dgStaff.DataSource = null;
            }
        }

        private void StaffView_Load(object sender, EventArgs e)
        {
            DataTable dtStaff = controller.RunQuery("SELECT * FROM Staff");
            dgStaff.DataSource = dtStaff;
        }
    }
}
