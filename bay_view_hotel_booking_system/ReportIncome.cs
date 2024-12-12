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

        private void ParametersChanged(object sender, EventArgs e)
        {
            // If the date is the default value, return
            if ((dtpStartDate.Value == new DateTime(1900, 01, 01)) || (dtpEndDate.Value == new DateTime(1900, 01, 01)))
            {
                return;
            }

            string query = $"""
                SELECT
                    strftime('%m %Y', StartDate) AS DateGroup,
                    SUM(p.Amount) AS IncomeRaw
                FROM Booking AS b
                JOIN Payment AS p
                    ON b.BookingID = p.BookingID
                WHERE
                    b.StartDate BETWEEN '{dtpStartDate.Value.ToString("yyyy-MM-dd")}' AND '{dtpEndDate.Value.ToString("yyyy-MM-dd")}'
                GROUP BY strftime('%m %Y', StartDate)
                ORDER BY strftime('%m %Y', StartDate)
                """;

            DataTable dt = controller.RunQuery(query);

            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Income", typeof(string));

            foreach (DataRow row in dt.Rows)
            {
                // Convert the DateGroup to a DateTime for sorting
                row["Date"] = DateTime.ParseExact(row["DateGroup"].ToString(), "MM yyyy", CultureInfo.InvariantCulture);

                // Convert DateGroup to a more readable format (i.e. 01 2021 -> Jan 2021)
                row["DateGroup"] = DateTime.ParseExact(row["DateGroup"].ToString(), "MM yyyy", CultureInfo.InvariantCulture).ToString("MMM yyyy");

                // Convert the IncomeRaw to a currency string
                row["Income"] = Convert.ToDecimal(row["IncomeRaw"]).ToString("C");
            }

            dgvMonthlyBreakdown.DataSource = dt;

            dgvMonthlyBreakdown.Columns["Date"].Visible = false;
            dgvMonthlyBreakdown.Columns["IncomeRaw"].Visible = false;

            btnSortDate_Click(sender, e);
        }

        private void btnSortDate_Click(object sender, EventArgs e)
        {
            dgvMonthlyBreakdown.Sort(dgvMonthlyBreakdown.Columns["Date"], ListSortDirection.Ascending);
        }

        private void btnSortIncome_Click(object sender, EventArgs e)
        {
            dgvMonthlyBreakdown.Sort(dgvMonthlyBreakdown.Columns["IncomeRaw"], ListSortDirection.Descending);
        }
    }
}
