using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bay_view_hotel_booking_system
{
    public partial class RoomView : Form
    {
        public RoomView()
        {
            InitializeComponent();
        }

        SQLController controller = new SQLController();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewrooms_Load(object sender, EventArgs e)
        {
            string query = $"""
                SELECT 
                    r.RoomID,
                    r.RoomType,
                    CAST(rs.RoomStatus AS text) AS RoomStatus,
                    r.Price,
                    r.Capacity,

                    CASE
                        WHEN r.IsDisabled = 1
                            THEN 'Yes'
                        ELSE
                            'No'
                    END AS IsDisabled

                FROM Room as r
                JOIN RoomStatus as rs
                    ON r.RoomStatusID = rs.RoomStatusID
                """;

            DataTable dtRoom = controller.RunQuery(query);
            dgRoom.DataSource = dtRoom;

            rType.SelectedIndex = 0;
            cbStatus.SelectedIndex = 0;
            cbDisabled.SelectedIndex = 0;
        }

        private void addRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomAdd frm = new RoomAdd();
            frm.Owner = this;

            frm.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String RoomType = rType.Text;

            int DisabledRoom = cbDisabled.Text == "Yes" ? 1 : 0;

            string RoomStatus = cbStatus.Text.ToLower();

            string query = $"""
                SELECT RoomStatusID 
                FROM RoomStatus
                WHERE RoomStatus = '{RoomStatus}'
                Limit 1
                """;

            DataTable dt = controller.RunQuery(query);

            string RoomStatusID = "";

            try
            {
                RoomStatusID = dt.Rows[0]["RoomStatusID"].ToString();
            }
            catch (Exception ex)
            {
                RoomStatusID = "-1";
            }

            query = $"""
                SELECT 
                    r.RoomID,
                    r.RoomType,
                    CAST(rs.RoomStatus AS text) AS RoomStatus,
                    r.Price,
                    r.Capacity,

                    CASE
                        WHEN r.IsDisabled = 1
                            THEN 'Yes'
                        ELSE
                            'No'
                    END AS IsDisabled

                FROM Room as r
                JOIN RoomStatus as rs
                    ON r.RoomStatusID = rs.RoomStatusID

                WHERE (RoomType = '{RoomType.ToLower()}' OR '{RoomType}' = 'All')
                    AND (IsDisabled = {DisabledRoom} OR '{cbDisabled.Text}' = 'Any')
                    AND (r.RoomStatusID = {RoomStatusID} OR '{RoomStatusID}' = '-1') 
                    
                """;

            DataTable dtRoom = controller.RunQuery(query);
            dgRoom.DataSource = dtRoom;
        }

        private void lblEdit_Click(object sender, EventArgs e)
        {
            if (dgRoom.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "You must select a Booking before you can edit it.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            int SelectedRoomID = Convert.ToInt32(dgRoom.SelectedRows[0].Cells[0].Value);
            string SelectedRoomType = dgRoom.SelectedRows[0].Cells[1].Value.ToString();
            string SelectedRoomStatus = dgRoom.SelectedRows[0].Cells[2].Value.ToString();
            decimal Price = Convert.ToDecimal(dgRoom.SelectedRows[0].Cells[3].Value);
            int Capacity = Convert.ToInt32(dgRoom.SelectedRows[0].Cells[4].Value);
            bool IsDisabledRoom = dgRoom.SelectedRows[0].Cells[5].Value.ToString() == "Yes" ? true : false;

            RoomEdit frm = new RoomEdit(SelectedRoomID, SelectedRoomType, SelectedRoomStatus, Price, Capacity, IsDisabledRoom);
            frm.Owner = this;

            frm.Show();
            this.Hide();
        }

        private void RefreshDataGrid()
        {
            String RoomType = rType.Text;

            int DisabledRoom = cbDisabled.Text == "Yes" ? 1 : 0;

            string RoomStatus = cbStatus.Text.ToLower();

            string query = $"""
                SELECT RoomStatusID 
                FROM RoomStatus
                WHERE RoomStatus = '{RoomStatus}'
                Limit 1
                """;

            DataTable dt = controller.RunQuery(query);

            string RoomStatusID = "";

            try
            {
                RoomStatusID = dt.Rows[0]["RoomStatusID"].ToString();
            }
            catch (Exception ex)
            {
                RoomStatusID = "-1";
            }

            query = $"""
                SELECT 
                    r.RoomID,
                    r.RoomType,
                    CAST(rs.RoomStatus AS text) AS RoomStatus,
                    r.Price,
                    r.Capacity,

                    CASE
                        WHEN r.IsDisabled = 1
                            THEN 'Yes'
                        ELSE
                            'No'
                    END AS IsDisabled

                FROM Room as r
                JOIN RoomStatus as rs
                    ON r.RoomStatusID = rs.RoomStatusID
                    
                """;

            DataTable dtRoom = controller.RunQuery(query);
            dgRoom.DataSource = dtRoom;
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }
    }
}

