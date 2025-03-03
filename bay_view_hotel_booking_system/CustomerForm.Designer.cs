﻿namespace bay_view_hotel_booking_system
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
            btnCustomerAdd.Location = new Point(368, 133);
            btnCustomerAdd.Margin = new Padding(3, 2, 3, 2);
            btnCustomerAdd.Name = "btnCustomerAdd";
            btnCustomerAdd.Size = new Size(305, 56);
            btnCustomerAdd.TabIndex = 1;
            btnCustomerAdd.Text = "Add a New Customer";
            btnCustomerAdd.UseVisualStyleBackColor = true;
            btnCustomerAdd.Click += btnCustomerAdd_Click;
            // 
            // CustomerEdit
            // 
            CustomerEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            CustomerEdit.Location = new Point(8, 133);
            CustomerEdit.Margin = new Padding(3, 2, 3, 2);
            CustomerEdit.Name = "CustomerEdit";
            CustomerEdit.Size = new Size(305, 56);
            CustomerEdit.TabIndex = 2;
            CustomerEdit.Text = "Edit an Existing Customer";
            CustomerEdit.UseVisualStyleBackColor = true;
            CustomerEdit.Click += CustomerEdit_Click;
            // 
            // CustomerDelete
            // 
            CustomerDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            CustomerDelete.Location = new Point(368, 72);
            CustomerDelete.Margin = new Padding(3, 2, 3, 2);
            CustomerDelete.Name = "CustomerDelete";
            CustomerDelete.Size = new Size(305, 56);
            CustomerDelete.TabIndex = 3;
            CustomerDelete.Text = "Delete an Existing Customer";
            CustomerDelete.UseVisualStyleBackColor = true;
            CustomerDelete.Click += CustomerDelete_Click;
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
            // btnCustomerView
            // 
            btnCustomerView.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCustomerView.Location = new Point(8, 72);
            btnCustomerView.Margin = new Padding(3, 2, 3, 2);
            btnCustomerView.Name = "btnCustomerView";
            btnCustomerView.Size = new Size(305, 56);
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
            pnlHeader.Location = new Point(8, 7);
            pnlHeader.Margin = new Padding(0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(665, 54);
            pnlHeader.TabIndex = 6;
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
            lblTitle.Text = "Customer Management";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 340);
            Controls.Add(pnlHeader);
            Controls.Add(btnCustomerView);
            Controls.Add(CustomerDelete);
            Controls.Add(CustomerEdit);
            Controls.Add(btnCustomerAdd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "CustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
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