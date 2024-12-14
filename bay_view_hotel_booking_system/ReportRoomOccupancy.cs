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
    public partial class ReportRoomOccupancy : Form
    {
        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
        SQLController controller = new SQLController();

        public ReportRoomOccupancy()
        {
            InitializeComponent();

            SetDefaultParameters();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Report_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner?.Show();
        }

        private void SetDefaultParameters()
        {
            // Room Type Combo Box
            string query = $"""
                SELECT DISTINCT
                    RoomType
                FROM Room
                """;

            DataTable dt = controller.RunQuery(query);

            cbRoomType.Items.Clear();

            cbRoomType.Items.Add("All");

            foreach (DataRow row in dt.Rows)
            {
                cbRoomType.Items.Add(ti.ToTitleCase(row["RoomType"].ToString()));
            }

            cbRoomType.SelectedIndex = 0;

            // RoomID Combo Box

            query = $"""
                SELECT DISTINCT
                    RoomID
                FROM Room
                WHERE '{cbRoomType.Text.ToLower()}' IN ('all', RoomType)
                ORDER BY RoomID
                """;

            dt = controller.RunQuery(query);

            cbRoom.Items.Clear();

            cbRoom.Items.Add("All");

            foreach (DataRow row in dt.Rows)
            {
                cbRoom.Items.Add(row["RoomID"].ToString());
            }

            cbRoom.SelectedIndex = 0;

            // Date Time Pickers

            query = """
                SELECT
                    MIN(StartDate) AS StartDate,
                    MAX(EndDate) AS EndDate
                FROM Booking
                """;

            dt = controller.RunQuery(query);

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
                    r.RoomType
                FROM Booking AS b
                JOIN Room AS r
                    ON b.RoomID = r.RoomID
                WHERE
                    b.StartDate BETWEEN '{dtpStartDate.Value.ToString("yyyy-MM-dd")}' AND '{dtpEndDate.Value.ToString("yyyy-MM-dd")}'
                    AND '{cbRoomType.Text.ToLower()}' IN ('all', r.RoomType)
                    AND '{cbRoom.Text}' IN ('All', CAST(r.RoomID AS TEXT))
                GROUP BY strftime('%m %Y', StartDate),
                    r.RoomType
                ORDER BY strftime('%m %Y', StartDate)
                """;

            DataTable dt = controller.RunQuery(query);

            dt.Columns.Add("Date", typeof(DateTime));

            foreach (DataRow row in dt.Rows)
            {
                // Convert the DateGroup to a DateTime for sorting
                row["Date"] = DateTime.ParseExact(row["DateGroup"].ToString(), "MM yyyy", CultureInfo.InvariantCulture);
            }

            // Pivot the data table
            DataTable pivotTable = new DataTable();

            pivotTable.Columns.Add("Date", typeof(DateTime));

            // Add the RoomTypes as columns
            foreach (DataRow row in dt.Rows)
            {
                if (!pivotTable.Columns.Contains(ti.ToTitleCase(row["RoomType"].ToString())))
                {
                    pivotTable.Columns.Add(ti.ToTitleCase(row["RoomType"].ToString()), typeof(int));
                }
            }

            // Add the data
            foreach (DataRow row in dt.Rows)
            {
                // Check if the date already exists
                DataRow[] rows = pivotTable.Select($"Date = '{row["Date"]}'");

                DataRow newRow;

                if (rows.Length == 0)
                {
                    newRow = pivotTable.NewRow();
                    newRow["Date"] = row["Date"];
                    pivotTable.Rows.Add(newRow);
                }
                else
                {
                    newRow = rows[0];
                }

                // Add the RoomType data
                newRow[ti.ToTitleCase(row["RoomType"].ToString())] = row["Bookings"];
            }

            UpdateChart(pivotTable);
        }

        private void UpdateChart(DataTable dt)
        {
            // Room Chart

            // Get the room types
            List<string> RoomTypes = new List<string>();

            foreach (DataColumn column in dt.Columns)
            {
                if (column.ColumnName != "Date")
                {
                    RoomTypes.Add(column.ColumnName);
                }
            }

            RoomTypes.Sort();

            // Clear the chart
            RoomChart.Series.Clear();

            foreach (var RoomType in RoomTypes)
            {
                // Add a new series (Single Rooms)
                RoomChart.Series.Add(RoomType);
                // Set the series chart type
                RoomChart.Series[RoomType].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
                // Set the series X value member
                RoomChart.Series[RoomType].XValueMember = "Date";
                // Set the series Y value member
                RoomChart.Series[RoomType].YValueMembers = ti.ToTitleCase(RoomType);
                // Show Labels on the chart
                RoomChart.Series[RoomType].IsValueShownAsLabel = true;
                // Set the series name
                RoomChart.Series[RoomType].Name = ti.ToTitleCase(RoomType);
            }

            // Set the data source
            RoomChart.DataSource = dt;
            // Set the x-axis to be a date
            RoomChart.ChartAreas[0].AxisX.LabelStyle.Format = "MMM yyyy";
            // Set the title
            RoomChart.Titles.Clear();
            RoomChart.Titles.Add("Room Occupancy Breakdown");
            // Set the title font
            RoomChart.Titles[0].Font = new Font("Arial", 16, FontStyle.Bold);
            // Set the title alignment
            RoomChart.Titles[0].Alignment = ContentAlignment.TopCenter;


            // Proportion Chart

            // Clear the chart
            ProportionChart.Series.Clear();

            // Pie Chart showing cancelled bookings to active bookings
            ProportionChart.Series.Add("Proportion");
            // Set the series chart type
            ProportionChart.Series["Proportion"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            // Add points to the Pie Chart
            foreach (var RoomType in RoomTypes)
            {
                ProportionChart.Series["Proportion"].Points.AddXY(ti.ToTitleCase(RoomType), dt.Compute($"SUM({ti.ToTitleCase(RoomType)})", ""));
            }

            // Set the label to show the percentage
            ProportionChart.Series["Proportion"].Label = "#PERCENT{P1}";

            // Set the Point Legend Text
            ProportionChart.Series["Proportion"].LegendText = "#VALX";

            // Set the title
            ProportionChart.Titles.Clear();
            ProportionChart.Titles.Add("Proportion of Room Types Booked");
            // Set the title font
            ProportionChart.Titles[0].Font = new Font("Arial", 16, FontStyle.Bold);
            // Set the title alignment
            ProportionChart.Titles[0].Alignment = ContentAlignment.TopCenter;
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            SetDefaultParameters();
        }
    }
}
