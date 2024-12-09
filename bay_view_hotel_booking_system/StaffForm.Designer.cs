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
            btnStaffAdd = new Button();
            btnStaffEdit = new Button();
            lblStaffForm = new Label();
            btnStaffView = new Button();
            btnStaffDelete = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // btnStaffAdd
            // 
            btnStaffAdd.Location = new Point(43, 164);
            btnStaffAdd.Name = "btnStaffAdd";
            btnStaffAdd.Size = new Size(139, 124);
            btnStaffAdd.TabIndex = 0;
            btnStaffAdd.Text = "Add";
            btnStaffAdd.UseVisualStyleBackColor = true;
            btnStaffAdd.Click += btnStaffAdd_Click;
            // 
            // btnStaffEdit
            // 
            btnStaffEdit.Location = new Point(247, 164);
            btnStaffEdit.Name = "btnStaffEdit";
            btnStaffEdit.Size = new Size(139, 124);
            btnStaffEdit.TabIndex = 1;
            btnStaffEdit.Text = "Edit";
            btnStaffEdit.UseVisualStyleBackColor = true;
            btnStaffEdit.Click += btnStaffEdit_Click;
            // 
            // lblStaffForm
            // 
            lblStaffForm.AutoSize = true;
            lblStaffForm.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStaffForm.Location = new Point(321, 55);
            lblStaffForm.Name = "lblStaffForm";
            lblStaffForm.Size = new Size(175, 46);
            lblStaffForm.TabIndex = 2;
            lblStaffForm.Text = "Staff Form";
            // 
            // btnStaffView
            // 
            btnStaffView.Location = new Point(450, 164);
            btnStaffView.Name = "btnStaffView";
            btnStaffView.Size = new Size(139, 124);
            btnStaffView.TabIndex = 3;
            btnStaffView.Text = "View";
            btnStaffView.UseVisualStyleBackColor = true;
            btnStaffView.Click += btnStaffView_Click;
            // 
            // btnStaffDelete
            // 
            btnStaffDelete.Location = new Point(654, 164);
            btnStaffDelete.Name = "btnStaffDelete";
            btnStaffDelete.Size = new Size(139, 124);
            btnStaffDelete.TabIndex = 4;
            btnStaffDelete.Text = "Delete";
            btnStaffDelete.UseVisualStyleBackColor = true;
            btnStaffDelete.Click += btnStaffDelete_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1, 370);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(88, 28);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 400);
            Controls.Add(btnBack);
            Controls.Add(btnStaffDelete);
            Controls.Add(btnStaffView);
            Controls.Add(lblStaffForm);
            Controls.Add(btnStaffEdit);
            Controls.Add(btnStaffAdd);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StaffForm";
            Text = "StaffForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStaffAdd;
        private Button btnStaffEdit;
        private Label lblStaffForm;
        private Button btnStaffView;
        private Button btnStaffDelete;
        private Button btnBack;
    }
}