using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bay_view_hotel_booking_system
{
    public partial class ReportIncome : Form
    {
        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
        SQLController controller = new SQLController();

        public ReportIncome()
        {
            InitializeComponent();

            string query = """
                SELECT
                    MIN(StartDate) AS StartDate,
                    MAX(EndDate) AS EndDate
                FROM Booking
                """;

            DataTable dt = controller.RunQuery(query);

            dtpStartDate.Value = Convert.ToDateTime(dt.Rows[0]["StartDate"].ToString());
            dtpEndDate.Value = Convert.ToDateTime(dt.Rows[0]["EndDate"].ToString());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Report_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner?.Show();
        }

        private void ParametersChanged (object sender, EventArgs e)
        {
            // If the date is the default value, return
            if ((dtpStartDate.Value == new DateTime(1900, 01, 01)) || (dtpEndDate.Value == new DateTime(1900, 01, 01))
            {
                return;
            }

            string query = $"""

                """;
        }
    }
}
