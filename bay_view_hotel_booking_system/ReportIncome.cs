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

            SetDefaultDateRange();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Report_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner?.Show();
        }

        private void SetDefaultDateRange()
        {
            string query = """
                SELECT
                    MIN(StartDate) AS StartDate,
                    MAX(EndDate) AS EndDate
                FROM Booking
                """;

            DataTable dt = controller.RunQuery(query);

            // Check for Null values
            // If there is a null value, there are no bookings
            if (dt.Rows[0]["StartDate"].ToString() == "" || dt.Rows[0]["EndDate"].ToString() == "")
            {
                MessageBox.Show(
                    "No bookings found.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            dtpStartDate.Value = Convert.ToDateTime(dt.Rows[0]["StartDate"].ToString());
            dtpEndDate.Value = Convert.ToDateTime(dt.Rows[0]["EndDate"].ToString());
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
            UpdateChart(dt);
        }

        private void UpdateChart(DataTable dt)
        {
            // Clear the chart
            IncomeChart.Series.Clear();
            // Add a new series
            IncomeChart.Series.Add("Income");
            // Set the chart type
            IncomeChart.Series["Income"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            // Set the x-axis to be the DateGroup
            IncomeChart.Series["Income"].XValueMember = "Date";
            // Set the y-axis to be the Income
            IncomeChart.Series["Income"].YValueMembers = "IncomeRaw";
            // Set the data source
            IncomeChart.DataSource = dt;
            // Set the x-axis to be a date
            IncomeChart.ChartAreas[0].AxisX.LabelStyle.Format = "MMM yyyy";
            // Set the y-axis to be a currency
            IncomeChart.ChartAreas[0].AxisY.LabelStyle.Format = "C";
            // Set the title
            IncomeChart.Titles.Clear();
            IncomeChart.Titles.Add("Income Breakdown");
            // Set the title font
            IncomeChart.Titles[0].Font = new Font("Arial", 16, FontStyle.Bold);
            // Set the title alignment
            IncomeChart.Titles[0].Alignment = ContentAlignment.TopCenter;
        }

        private void btnSortDate_Click(object sender, EventArgs e)
        {
            dgvMonthlyBreakdown.Sort(dgvMonthlyBreakdown.Columns["Date"], ListSortDirection.Ascending);
        }

        private void btnSortIncome_Click(object sender, EventArgs e)
        {
            dgvMonthlyBreakdown.Sort(dgvMonthlyBreakdown.Columns["IncomeRaw"], ListSortDirection.Descending);
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            SetDefaultDateRange();
        }
    }
}
