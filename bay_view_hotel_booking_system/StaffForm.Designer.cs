namespace bay_view_hotel_booking_system
{
    partial class StaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            pnlHeader = new Panel();
            pbLogo = new PictureBox();
            lblTitle = new Label();
            btnBack = new Button();
            btnStaffView = new Button();
            btnStaffDelete = new Button();
            btnStaffEdit = new Button();
            btnStaffAdd = new Button();
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
            pnlHeader.Size = new Size(760, 71);
            pnlHeader.TabIndex = 11;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.bay_view_logo;
            pbLogo.Location = new Point(3, 3);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(125, 61);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(134, 3);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(418, 61);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Staff Management";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(661, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 61);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnStaffView
            // 
            btnStaffView.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnStaffView.Location = new Point(9, 96);
            btnStaffView.Name = "btnStaffView";
            btnStaffView.Size = new Size(349, 75);
            btnStaffView.TabIndex = 10;
            btnStaffView.Text = "View Existing Staff";
            btnStaffView.UseVisualStyleBackColor = true;
            btnStaffView.Click += btnStaffView_Click;
            // 
            // btnStaffDelete
            // 
            btnStaffDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnStaffDelete.Location = new Point(421, 96);
            btnStaffDelete.Name = "btnStaffDelete";
            btnStaffDelete.Size = new Size(349, 75);
            btnStaffDelete.TabIndex = 9;
            btnStaffDelete.Text = "Delete an Existing Staff Member";
            btnStaffDelete.UseVisualStyleBackColor = true;
            btnStaffDelete.Click += btnStaffDelete_Click;
            // 
            // btnStaffEdit
            // 
            btnStaffEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnStaffEdit.Location = new Point(9, 177);
            btnStaffEdit.Name = "btnStaffEdit";
            btnStaffEdit.Size = new Size(349, 75);
            btnStaffEdit.TabIndex = 8;
            btnStaffEdit.Text = "Edit an Existing Staff Member";
            btnStaffEdit.UseVisualStyleBackColor = true;
            btnStaffEdit.Click += btnStaffEdit_Click;
            // 
            // btnStaffAdd
            // 
            btnStaffAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnStaffAdd.Location = new Point(421, 177);
            btnStaffAdd.Name = "btnStaffAdd";
            btnStaffAdd.Size = new Size(349, 75);
            btnStaffAdd.TabIndex = 7;
            btnStaffAdd.Text = "Add a New Staff Member";
            btnStaffAdd.UseVisualStyleBackColor = true;
            btnStaffAdd.Click += btnStaffAdd_Click;
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(pnlHeader);
            Controls.Add(btnStaffView);
            Controls.Add(btnStaffDelete);
            Controls.Add(btnStaffEdit);
            Controls.Add(btnStaffAdd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StaffForm";
            Text = "Staff Management";
            FormClosing += StaffForm_FormClosing;
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private PictureBox pbLogo;
        private Label lblTitle;
        private Button btnBack;
        private Button btnStaffView;
        private Button btnStaffDelete;
        private Button btnStaffEdit;
        private Button btnStaffAdd;
    }
}