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
    public partial class ReportTimeOccupancy : Form
    {
        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
        SQLController controller = new SQLController();

        public ReportTimeOccupancy()
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
                    COUNT(b.BookingID) AS Bookings,
                    SUM (
                            CASE 
                                WHEN b.IsCancelled = 0 
                                    THEN 1
                                ELSE 0
                            END
                        ) AS ActiveBookings,
                    SUM (
                            CASE 
                                WHEN b.IsCancelled = 1 
                                    THEN 1
                                ELSE 0
                            END
                        ) AS CancelledBookings
                FROM Booking AS b
                WHERE
                    b.StartDate BETWEEN '{dtpStartDate.Value.ToString("yyyy-MM-dd")}' AND '{dtpEndDate.Value.ToString("yyyy-MM-dd")}'
                GROUP BY strftime('%m %Y', StartDate)
                ORDER BY strftime('%m %Y', StartDate)
                """;

            DataTable dt = controller.RunQuery(query);

            dt.Columns.Add("Date", typeof(DateTime));

            foreach (DataRow row in dt.Rows)
            {
                // Convert the DateGroup to a DateTime for sorting
                row["Date"] = DateTime.ParseExact(row["DateGroup"].ToString(), "MM yyyy", CultureInfo.InvariantCulture);

                // Convert DateGroup to a more readable format (i.e. 01 2021 -> Jan 2021)
                row["DateGroup"] = DateTime.ParseExact(row["DateGroup"].ToString(), "MM yyyy", CultureInfo.InvariantCulture).ToString("MMM yyyy");
            }

            dgvMonthlyBreakdown.DataSource = dt;

            dgvMonthlyBreakdown.Columns["Date"].Visible = false;
            dgvMonthlyBreakdown.Columns["ActiveBookings"].Visible = false;
            dgvMonthlyBreakdown.Columns["CancelledBookings"].Visible = false;

            btnSortDate_Click(sender, e);
            UpdateChart(dt);
        }

        private void UpdateChart(DataTable dt)
        {
            // Booking Chart

            // Clear the chart
            BookingChart.Series.Clear();

            // Add a new series (Cancelled Bookings)
            BookingChart.Series.Add("CancelledBookings");
            // Set the series chart type
            BookingChart.Series["CancelledBookings"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            // Set the series X value member
            BookingChart.Series["CancelledBookings"].XValueMember = "Date";
            // Set the series Y value member
            BookingChart.Series["CancelledBookings"].YValueMembers = "CancelledBookings";
            // Show Labels on the chart
            BookingChart.Series["CancelledBookings"].IsValueShownAsLabel = true;
            // Set the series name
            BookingChart.Series["CancelledBookings"].Name = "Cancelled Bookings";


            // Add a new series (Active Bookings)
            BookingChart.Series.Add("ActiveBookings");
            // Set the series chart type
            BookingChart.Series["ActiveBookings"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            // Set the series X value member
            BookingChart.Series["ActiveBookings"].XValueMember = "Date";
            // Set the series Y value member
            BookingChart.Series["ActiveBookings"].YValueMembers = "ActiveBookings";
            // Show Labels on the chart
            BookingChart.Series["ActiveBookings"].IsValueShownAsLabel = true;
            // Set the series name
            BookingChart.Series["ActiveBookings"].Name = "Active Bookings";


            // Set the data source
            BookingChart.DataSource = dt;
            // Set the x-axis to be a date
            BookingChart.ChartAreas[0].AxisX.LabelStyle.Format = "MMM yyyy";
            // Set the title
            BookingChart.Titles.Clear();
            BookingChart.Titles.Add("Booking Breakdown");
            // Set the title font
            BookingChart.Titles[0].Font = new Font("Arial", 16, FontStyle.Bold);
            // Set the title alignment
            BookingChart.Titles[0].Alignment = ContentAlignment.TopCenter;


            // Proportion Chart

            // Clear the chart
            ProportionChart.Series.Clear();

            // Pie Chart showing cancelled bookings to active bookings
            ProportionChart.Series.Add("Proportion");
            // Set the series chart type
            ProportionChart.Series["Proportion"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            // Add points to the Pie Chart
            ProportionChart.Series["Proportion"].Points.AddXY("Cancelled Bookings", dt.Compute("SUM(CancelledBookings)", ""));
            ProportionChart.Series["Proportion"].Points.AddXY("Active Bookings", dt.Compute("SUM(ActiveBookings)", ""));

            // Set the label to show the percentage
            ProportionChart.Series["Proportion"].Label = "#PERCENT{P1}";

            // Set the Point Legend Text
            ProportionChart.Series["Proportion"].LegendText = "#VALX";

            // Set the title
            ProportionChart.Titles.Clear();
            ProportionChart.Titles.Add("Proportion of Active to Cancelled Bookings");
            // Set the title font
            ProportionChart.Titles[0].Font = new Font("Arial", 16, FontStyle.Bold);
            // Set the title alignment
            ProportionChart.Titles[0].Alignment = ContentAlignment.TopCenter;
        }

        private void btnSortDate_Click(object sender, EventArgs e)
        {
            dgvMonthlyBreakdown.Sort(dgvMonthlyBreakdown.Columns["Date"], ListSortDirection.Ascending);
        }

        private void btnSortIncome_Click(object sender, EventArgs e)
        {
            dgvMonthlyBreakdown.Sort(dgvMonthlyBreakdown.Columns["Bookings"], ListSortDirection.Descending);
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            SetDefaultDateRange();
        }
    }
}
