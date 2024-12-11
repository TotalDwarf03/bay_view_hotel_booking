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
    public partial class StaffSearch : Form
    {
        public StaffSearch(String NextPage)
        {
            InitializeComponent();

            lblNextPage.Text = NextPage;
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

        private void btnSearch_Click(object sender, EventArgs e)
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
                      "No Staff members have been found.",
                      "Warning",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning
               );
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string NextPage = lblNextPage.Text;

            if (dgvStaff.SelectedRows.Count > 0)
            {
                string StaffID = dgvStaff.SelectedRows[0].Cells[0].Value.ToString();

                if (NextPage == "Edit")
                {
                    StaffEdit frm = new StaffEdit(StaffID);
                    frm.Owner = this;

                    frm.Show();
                    this.Hide();
                }

                if (NextPage == "Delete")
                {
                    StaffDelete frm = new StaffDelete(StaffID);
                    frm.Owner = this;

                    frm.Show();
                    this.Hide();
                }
            }

            else
            {
                MessageBox.Show(
                       "Please select a customer.",
                       "Warning",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning
                );
            }
        }

        private void StaffSearch_VisibleChanged(object sender, EventArgs e)
        {
            dgvStaff.DataSource = null;
        }
    }
}
