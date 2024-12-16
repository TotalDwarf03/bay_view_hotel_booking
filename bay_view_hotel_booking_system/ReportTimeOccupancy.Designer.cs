namespace bay_view_hotel_booking_system
{
    partial class ReportTimeOccupancy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportTimeOccupancy));
            BookingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnSortBookings = new Button();
            btnSortDate = new Button();
            dgvMonthlyBreakdown = new DataGridView();
            pnlHeader = new Panel();
            btnDefault = new Button();
            lblEndDate = new Label();
            pbLogo = new PictureBox();
            dtpEndDate = new DateTimePicker();
            lblTitle = new Label();
            lblStartDate = new Label();
            dtpStartDate = new DateTimePicker();
            btnBack = new Button();
            ProportionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)BookingChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMonthlyBreakdown).BeginInit();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProportionChart).BeginInit();
            SuspendLayout();
            // 
            // BookingChart
            // 
            chartArea1.Name = "ChartArea1";
            BookingChart.ChartAreas.Add(chartArea1);
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Legend1";
            BookingChart.Legends.Add(legend1);
            BookingChart.Location = new Point(222, 67);
            BookingChart.Name = "BookingChart";
            BookingChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            BookingChart.Series.Add(series1);
            BookingChart.Size = new Size(792, 376);
            BookingChart.TabIndex = 27;
            BookingChart.Text = "chart1";
            // 
            // btnSortBookings
            // 
            btnSortBookings.Location = new Point(144, 448);
            btnSortBookings.Margin = new Padding(3, 2, 3, 2);
            btnSortBookings.Name = "btnSortBookings";
            btnSortBookings.Size = new Size(120, 23);
            btnSortBookings.TabIndex = 26;
            btnSortBookings.Text = "Sort by Bookings";
            btnSortBookings.UseVisualStyleBackColor = true;
            btnSortBookings.Click += btnSortIncome_Click;
            // 
            // btnSortDate
            // 
            btnSortDate.Location = new Point(11, 448);
            btnSortDate.Margin = new Padding(3, 2, 3, 2);
            btnSortDate.Name = "btnSortDate";
            btnSortDate.Size = new Size(120, 23);
            btnSortDate.TabIndex = 25;
            btnSortDate.Text = "Sort by Date";
            btnSortDate.UseVisualStyleBackColor = true;
            btnSortDate.Click += btnSortDate_Click;
            // 
            // dgvMonthlyBreakdown
            // 
            dgvMonthlyBreakdown.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMonthlyBreakdown.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMonthlyBreakdown.Location = new Point(11, 67);
            dgvMonthlyBreakdown.Name = "dgvMonthlyBreakdown";
            dgvMonthlyBreakdown.ReadOnly = true;
            dgvMonthlyBreakdown.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMonthlyBreakdown.Size = new Size(205, 376);
            dgvMonthlyBreakdown.TabIndex = 24;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = SystemColors.Info;
            pnlHeader.BorderStyle = BorderStyle.FixedSingle;
            pnlHeader.Controls.Add(btnDefault);
            pnlHeader.Controls.Add(lblEndDate);
            pnlHeader.Controls.Add(pbLogo);
            pnlHeader.Controls.Add(dtpEndDate);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblStartDate);
            pnlHeader.Controls.Add(dtpStartDate);
            pnlHeader.Location = new Point(11, 10);
            pnlHeader.Margin = new Padding(0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1163, 54);
            pnlHeader.TabIndex = 23;
            // 
            // btnDefault
            // 
            btnDefault.Location = new Point(1076, 25);
            btnDefault.Margin = new Padding(3, 2, 3, 2);
            btnDefault.Name = "btnDefault";
            btnDefault.Size = new Size(82, 23);
            btnDefault.TabIndex = 29;
            btnDefault.Text = "Set Default";
            btnDefault.UseVisualStyleBackColor = true;
            btnDefault.Click += btnDefault_Click;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEndDate.Location = new Point(920, 8);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(60, 15);
            lblEndDate.TabIndex = 21;
            lblEndDate.Text = "End Date:";
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.bay_view_logo;
            pbLogo.Location = new Point(3, 2);
            pbLogo.Margin = new Padding(3, 2, 3, 2);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(109, 46);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(920, 25);
            dtpEndDate.Margin = new Padding(3, 2, 3, 2);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(150, 23);
            dtpEndDate.TabIndex = 20;
            dtpEndDate.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpEndDate.ValueChanged += ParametersChanged;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(117, 2);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(274, 46);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Time Occupancy";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStartDate.Location = new Point(764, 8);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(71, 15);
            lblStartDate.TabIndex = 19;
            lblStartDate.Text = "Start Date: ";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(764, 25);
            dtpStartDate.Margin = new Padding(3, 2, 3, 2);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(150, 23);
            dtpStartDate.TabIndex = 18;
            dtpStartDate.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpStartDate.ValueChanged += ParametersChanged;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1092, 448);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(82, 23);
            btnBack.TabIndex = 22;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ProportionChart
            // 
            chartArea2.Name = "ChartArea1";
            ProportionChart.ChartAreas.Add(chartArea2);
            legend2.DockedToChartArea = "ChartArea1";
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.IsDockedInsideChartArea = false;
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend2.Name = "Legend1";
            ProportionChart.Legends.Add(legend2);
            ProportionChart.Location = new Point(1020, 67);
            ProportionChart.Name = "ProportionChart";
            ProportionChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            ProportionChart.Series.Add(series2);
            ProportionChart.Size = new Size(154, 376);
            ProportionChart.TabIndex = 28;
            ProportionChart.Text = "chart1";
            // 
            // ReportTimeOccupancy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 481);
            Controls.Add(ProportionChart);
            Controls.Add(BookingChart);
            Controls.Add(btnSortBookings);
            Controls.Add(btnSortDate);
            Controls.Add(dgvMonthlyBreakdown);
            Controls.Add(pnlHeader);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ReportTimeOccupancy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Time Occupancy Report";
            FormClosing += Report_FormClosing;
            ((System.ComponentModel.ISupportInitialize)BookingChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMonthlyBreakdown).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProportionChart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart BookingChart;
        private Button btnSortBookings;
        private Button btnSortDate;
        private DataGridView dgvMonthlyBreakdown;
        private Panel pnlHeader;
        private Label lblEndDate;
        private PictureBox pbLogo;
        private DateTimePicker dtpEndDate;
        private Label lblTitle;
        private Label lblStartDate;
        private DateTimePicker dtpStartDate;
        private Button btnBack;
        private System.Windows.Forms.DataVisualization.Charting.Chart ProportionChart;
        private Button btnDefault;
    }
}