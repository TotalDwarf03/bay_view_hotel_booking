namespace bay_view_hotel_booking_system
{
    partial class ReportRoomOccupancy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportRoomOccupancy));
            ProportionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            RoomChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            pnlHeader = new Panel();
            cbRoom = new ComboBox();
            lblRoom = new Label();
            cbRoomType = new ComboBox();
            lblRoomType = new Label();
            btnDefault = new Button();
            lblEndDate = new Label();
            pbLogo = new PictureBox();
            dtpEndDate = new DateTimePicker();
            lblTitle = new Label();
            lblStartDate = new Label();
            dtpStartDate = new DateTimePicker();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)ProportionChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RoomChart).BeginInit();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // ProportionChart
            // 
            chartArea1.Name = "ChartArea1";
            ProportionChart.ChartAreas.Add(chartArea1);
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.IsDockedInsideChartArea = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Legend1";
            ProportionChart.Legends.Add(legend1);
            ProportionChart.Location = new Point(11, 67);
            ProportionChart.Name = "ProportionChart";
            ProportionChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            ProportionChart.Series.Add(series1);
            ProportionChart.Size = new Size(223, 376);
            ProportionChart.TabIndex = 35;
            ProportionChart.Text = "chart1";
            // 
            // RoomChart
            // 
            chartArea2.Name = "ChartArea1";
            RoomChart.ChartAreas.Add(chartArea2);
            legend2.DockedToChartArea = "ChartArea1";
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend2.Name = "Legend1";
            RoomChart.Legends.Add(legend2);
            RoomChart.Location = new Point(240, 67);
            RoomChart.Name = "RoomChart";
            RoomChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            RoomChart.Series.Add(series2);
            RoomChart.Size = new Size(934, 376);
            RoomChart.TabIndex = 34;
            RoomChart.Text = "chart1";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = SystemColors.Info;
            pnlHeader.BorderStyle = BorderStyle.FixedSingle;
            pnlHeader.Controls.Add(cbRoom);
            pnlHeader.Controls.Add(lblRoom);
            pnlHeader.Controls.Add(cbRoomType);
            pnlHeader.Controls.Add(lblRoomType);
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
            pnlHeader.TabIndex = 30;
            // 
            // cbRoom
            // 
            cbRoom.FormattingEnabled = true;
            cbRoom.Location = new Point(452, 25);
            cbRoom.Name = "cbRoom";
            cbRoom.Size = new Size(150, 23);
            cbRoom.TabIndex = 39;
            cbRoom.SelectedIndexChanged += ParametersChanged;
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRoom.Location = new Point(452, 7);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(56, 15);
            lblRoom.TabIndex = 38;
            lblRoom.Text = "RoomID:";
            // 
            // cbRoomType
            // 
            cbRoomType.FormattingEnabled = true;
            cbRoomType.Location = new Point(608, 25);
            cbRoomType.Name = "cbRoomType";
            cbRoomType.Size = new Size(150, 23);
            cbRoomType.TabIndex = 37;
            cbRoomType.SelectedIndexChanged += ParametersChanged;
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRoomType.Location = new Point(608, 7);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(72, 15);
            lblRoomType.TabIndex = 36;
            lblRoomType.Text = "Room Type:";
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
            lblTitle.Text = "Room Occupancy";
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
            btnBack.TabIndex = 29;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ReportRoomOccupancy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 481);
            Controls.Add(ProportionChart);
            Controls.Add(RoomChart);
            Controls.Add(pnlHeader);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ReportRoomOccupancy";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Room Occupancy Report";
            FormClosing += Report_FormClosing;
            ((System.ComponentModel.ISupportInitialize)ProportionChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)RoomChart).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ProportionChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart RoomChart;
        private Panel pnlHeader;
        private Button btnDefault;
        private Label lblEndDate;
        private PictureBox pbLogo;
        private DateTimePicker dtpEndDate;
        private Label lblTitle;
        private Label lblStartDate;
        private DateTimePicker dtpStartDate;
        private Button btnBack;
        private ComboBox cbRoomType;
        private Label lblRoomType;
        private ComboBox cbRoom;
        private Label lblRoom;
    }
}