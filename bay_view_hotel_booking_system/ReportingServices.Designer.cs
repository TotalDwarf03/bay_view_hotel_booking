namespace bay_view_hotel_booking_system
{
    partial class ReportingServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportingServices));
            pnlHeader = new Panel();
            pbLogo = new PictureBox();
            lblTitle = new Label();
            btnBack = new Button();
            btnIncome = new Button();
            btnTimeOccupancy = new Button();
            btnRoomOccupancy = new Button();
            lblIncome = new Label();
            lblOccupancy = new Label();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = SystemColors.Info;
            pnlHeader.BorderStyle = BorderStyle.FixedSingle;
            pnlHeader.Controls.Add(pbLogo);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(btnBack);
            pnlHeader.Location = new Point(9, 9);
            pnlHeader.Margin = new Padding(0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(665, 54);
            pnlHeader.TabIndex = 16;
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
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(117, 2);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(366, 46);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Reporting Services";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(578, 2);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(82, 46);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnIncome
            // 
            btnIncome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnIncome.Location = new Point(9, 94);
            btnIncome.Margin = new Padding(3, 2, 3, 2);
            btnIncome.Name = "btnIncome";
            btnIncome.Size = new Size(305, 56);
            btnIncome.TabIndex = 15;
            btnIncome.Text = "View Income Report";
            btnIncome.UseVisualStyleBackColor = true;
            btnIncome.Click += btnIncome_Click;
            // 
            // btnTimeOccupancy
            // 
            btnTimeOccupancy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTimeOccupancy.Location = new Point(369, 94);
            btnTimeOccupancy.Margin = new Padding(3, 2, 3, 2);
            btnTimeOccupancy.Name = "btnTimeOccupancy";
            btnTimeOccupancy.Size = new Size(305, 56);
            btnTimeOccupancy.TabIndex = 14;
            btnTimeOccupancy.Text = "View Time Occupancy Report";
            btnTimeOccupancy.UseVisualStyleBackColor = true;
            btnTimeOccupancy.Click += btnTimeOccupancy_Click;
            // 
            // btnRoomOccupancy
            // 
            btnRoomOccupancy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRoomOccupancy.Location = new Point(369, 154);
            btnRoomOccupancy.Margin = new Padding(3, 2, 3, 2);
            btnRoomOccupancy.Name = "btnRoomOccupancy";
            btnRoomOccupancy.Size = new Size(305, 56);
            btnRoomOccupancy.TabIndex = 13;
            btnRoomOccupancy.Text = "View Room Occupancy Report";
            btnRoomOccupancy.UseVisualStyleBackColor = true;
            btnRoomOccupancy.Click += btnRoomOccupancy_Click;
            // 
            // lblIncome
            // 
            lblIncome.AutoSize = true;
            lblIncome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblIncome.Location = new Point(9, 77);
            lblIncome.Name = "lblIncome";
            lblIncome.Size = new Size(96, 15);
            lblIncome.TabIndex = 17;
            lblIncome.Text = "Income Reports";
            // 
            // lblOccupancy
            // 
            lblOccupancy.AutoSize = true;
            lblOccupancy.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblOccupancy.Location = new Point(369, 77);
            lblOccupancy.Name = "lblOccupancy";
            lblOccupancy.Size = new Size(114, 15);
            lblOccupancy.TabIndex = 18;
            lblOccupancy.Text = "Occupancy Reports";
            // 
            // ReportingServices
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 340);
            Controls.Add(lblOccupancy);
            Controls.Add(lblIncome);
            Controls.Add(pnlHeader);
            Controls.Add(btnIncome);
            Controls.Add(btnTimeOccupancy);
            Controls.Add(btnRoomOccupancy);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ReportingServices";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Reporting Services";
            FormClosing += Report_FormClosing;
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private PictureBox pbLogo;
        private Label lblTitle;
        private Button btnBack;
        private Button btnIncome;
        private Button btnTimeOccupancy;
        private Button btnRoomOccupancy;
        private Label lblIncome;
        private Label lblOccupancy;
    }
}