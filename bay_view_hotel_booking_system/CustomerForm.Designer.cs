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
            lblCustomerForm = new Label();
            btnCustomerAdd = new Button();
            CustomerEdit = new Button();
            CustomerDelete = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblCustomerForm
            // 
            lblCustomerForm.AutoSize = true;
            lblCustomerForm.Location = new Point(328, 59);
            lblCustomerForm.Name = "lblCustomerForm";
            lblCustomerForm.Size = new Size(110, 20);
            lblCustomerForm.TabIndex = 0;
            lblCustomerForm.Text = "Customer Form";
            // 
            // btnCustomerAdd
            // 
            btnCustomerAdd.Location = new Point(57, 175);
            btnCustomerAdd.Name = "btnCustomerAdd";
            btnCustomerAdd.Size = new Size(162, 142);
            btnCustomerAdd.TabIndex = 1;
            btnCustomerAdd.Text = "Add";
            btnCustomerAdd.UseVisualStyleBackColor = true;
            btnCustomerAdd.Click += btnCustomerAdd_Click;
            // 
            // CustomerEdit
            // 
            CustomerEdit.Location = new Point(310, 175);
            CustomerEdit.Name = "CustomerEdit";
            CustomerEdit.Size = new Size(162, 142);
            CustomerEdit.TabIndex = 2;
            CustomerEdit.Text = "Edit";
            CustomerEdit.UseVisualStyleBackColor = true;
            CustomerEdit.Click += CustomerEdit_Click;
            // 
            // CustomerDelete
            // 
            CustomerDelete.Location = new Point(564, 175);
            CustomerDelete.Name = "CustomerDelete";
            CustomerDelete.Size = new Size(162, 142);
            CustomerDelete.TabIndex = 3;
            CustomerDelete.Text = "Delete";
            CustomerDelete.UseVisualStyleBackColor = true;
            CustomerDelete.Click += CustomerDelete_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(9, 419);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(CustomerDelete);
            Controls.Add(CustomerEdit);
            Controls.Add(btnCustomerAdd);
            Controls.Add(lblCustomerForm);
            Name = "CustomerForm";
            Text = "CustomerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomerForm;
        private Button btnCustomerAdd;
        private Button CustomerEdit;
        private Button CustomerDelete;
        private Button btnBack;
    }
}