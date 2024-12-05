namespace bay_view_hotel_booking_system
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            btnCustomerAdd = new Button();
            CustomerEdit = new Button();
            CustomerDelete = new Button();
            btnBack = new Button();
            btnCustomerView = new Button();
            pnlHeader = new Panel();
            pbLogo = new PictureBox();
            lblTitle = new Label();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // btnCustomerAdd
            // 
            btnCustomerAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCustomerAdd.Location = new Point(420, 177);
            btnCustomerAdd.Name = "btnCustomerAdd";
            btnCustomerAdd.Size = new Size(349, 75);
            btnCustomerAdd.TabIndex = 1;
            btnCustomerAdd.Text = "Add a New Customer";
            btnCustomerAdd.UseVisualStyleBackColor = true;
            btnCustomerAdd.Click += btnCustomerAdd_Click;
            // 
            // CustomerEdit
            // 
            CustomerEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            CustomerEdit.Location = new Point(9, 177);
            CustomerEdit.Name = "CustomerEdit";
            CustomerEdit.Size = new Size(349, 75);
            CustomerEdit.TabIndex = 2;
            CustomerEdit.Text = "Edit an Existing Customer";
            CustomerEdit.UseVisualStyleBackColor = true;
            CustomerEdit.Click += CustomerEdit_Click;
            // 
            // CustomerDelete
            // 
            CustomerDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            CustomerDelete.Location = new Point(420, 96);
            CustomerDelete.Name = "CustomerDelete";
            CustomerDelete.Size = new Size(349, 75);
            CustomerDelete.TabIndex = 3;
            CustomerDelete.Text = "Delete an Existing Customer";
            CustomerDelete.UseVisualStyleBackColor = true;
            CustomerDelete.Click += CustomerDelete_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(661, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 62);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnCustomerView
            // 
            btnCustomerView.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCustomerView.Location = new Point(9, 96);
            btnCustomerView.Name = "btnCustomerView";
            btnCustomerView.Size = new Size(349, 75);
            btnCustomerView.TabIndex = 5;
            btnCustomerView.Text = "View Existing Customers";
            btnCustomerView.UseVisualStyleBackColor = true;
            btnCustomerView.Click += btnCustomerView_Click;
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
            pnlHeader.TabIndex = 6;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.bay_view_logo;
            pbLogo.Location = new Point(3, 3);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(125, 62);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(134, 3);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(418, 62);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Customer Management";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(pnlHeader);
            Controls.Add(btnCustomerView);
            Controls.Add(CustomerDelete);
            Controls.Add(CustomerEdit);
            Controls.Add(btnCustomerAdd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CustomerForm";
            Text = "Customer Management";
            FormClosing += CustomerForm_FormClosing;
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCustomerAdd;
        private Button CustomerEdit;
        private Button CustomerDelete;
        private Button btnBack;
        private Button btnCustomerView;
        private Panel pnlHeader;
        private PictureBox pbLogo;
        private Label lblTitle;
    }
}