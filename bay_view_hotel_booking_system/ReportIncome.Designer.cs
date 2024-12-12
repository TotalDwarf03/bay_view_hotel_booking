namespace bay_view_hotel_booking_system
{
    partial class ReportIncome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportIncome));
            pnlHeader = new Panel();
            lblEndDate = new Label();
            pbLogo = new PictureBox();
            dtpEndDate = new DateTimePicker();
            lblTitle = new Label();
            lblStartDate = new Label();
            dtpStartDate = new DateTimePicker();
            btnBack = new Button();
            dgvMonthlyBreakdown = new DataGridView();
            btnSortDate = new Button();
            btnSortIncome = new Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMonthlyBreakdown).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = SystemColors.Info;
            pnlHeader.BorderStyle = BorderStyle.FixedSingle;
            pnlHeader.Controls.Add(lblEndDate);
            pnlHeader.Controls.Add(pbLogo);
            pnlHeader.Controls.Add(dtpEndDate);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblStartDate);
            pnlHeader.Controls.Add(dtpStartDate);
            pnlHeader.Location = new Point(9, 9);
            pnlHeader.Margin = new Padding(0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(665, 54);
            pnlHeader.TabIndex = 17;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEndDate.Location = new Point(510, 8);
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
            dtpEndDate.Location = new Point(510, 25);
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
            lblTitle.Size = new Size(135, 46);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Income";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStartDate.Location = new Point(354, 8);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(71, 15);
            lblStartDate.TabIndex = 19;
            lblStartDate.Text = "Start Date: ";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(354, 25);
            dtpStartDate.Margin = new Padding(3, 2, 3, 2);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(150, 23);
            dtpStartDate.TabIndex = 18;
            dtpStartDate.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpStartDate.ValueChanged += ParametersChanged;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(592, 337);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(82, 23);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvMonthlyBreakdown
            // 
            dgvMonthlyBreakdown.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMonthlyBreakdown.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMonthlyBreakdown.Location = new Point(9, 66);
            dgvMonthlyBreakdown.Name = "dgvMonthlyBreakdown";
            dgvMonthlyBreakdown.ReadOnly = true;
            dgvMonthlyBreakdown.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMonthlyBreakdown.Size = new Size(253, 266);
            dgvMonthlyBreakdown.TabIndex = 18;
            // 
            // btnSortDate
            // 
            btnSortDate.Location = new Point(9, 337);
            btnSortDate.Margin = new Padding(3, 2, 3, 2);
            btnSortDate.Name = "btnSortDate";
            btnSortDate.Size = new Size(120, 23);
            btnSortDate.TabIndex = 19;
            btnSortDate.Text = "Sort by Date";
            btnSortDate.UseVisualStyleBackColor = true;
            btnSortDate.Click += btnSortDate_Click;
            // 
            // btnSortIncome
            // 
            btnSortIncome.Location = new Point(142, 337);
            btnSortIncome.Margin = new Padding(3, 2, 3, 2);
            btnSortIncome.Name = "btnSortIncome";
            btnSortIncome.Size = new Size(120, 23);
            btnSortIncome.TabIndex = 20;
            btnSortIncome.Text = "Sort by Income";
            btnSortIncome.UseVisualStyleBackColor = true;
            btnSortIncome.Click += btnSortIncome_Click;
            // 
            // ReportIncome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 371);
            Controls.Add(btnSortIncome);
            Controls.Add(btnSortDate);
            Controls.Add(dgvMonthlyBreakdown);
            Controls.Add(pnlHeader);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ReportIncome";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Income Report";
            FormClosing += Report_FormClosing;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMonthlyBreakdown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private PictureBox pbLogo;
        private Label lblTitle;
        private Button btnBack;
        private Label lblEndDate;
        private DateTimePicker dtpEndDate;
        private Label lblStartDate;
        private DateTimePicker dtpStartDate;
        private DataGridView dgvMonthlyBreakdown;
        private Button btnSortDate;
        private Button btnSortIncome;
    }
}