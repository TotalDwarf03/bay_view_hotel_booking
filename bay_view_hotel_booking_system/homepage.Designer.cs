namespace bay_view_hotel_booking_system
{
    partial class homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homepage));
            dgStaff = new DataGridView();
            dgRoom = new DataGridView();
            dgCustomer = new DataGridView();
            dgTransaction = new DataGridView();
            dgBooking = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgStaff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgRoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgTransaction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgBooking).BeginInit();
            SuspendLayout();
            // 
            // dgStaff
            // 
            dgStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStaff.Location = new Point(12, 12);
            dgStaff.Name = "dgStaff";
            dgStaff.Size = new Size(350, 437);
            dgStaff.TabIndex = 0;
            // 
            // dgRoom
            // 
            dgRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgRoom.Location = new Point(368, 12);
            dgRoom.Name = "dgRoom";
            dgRoom.Size = new Size(350, 437);
            dgRoom.TabIndex = 1;
            // 
            // dgCustomer
            // 
            dgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCustomer.Location = new Point(368, 455);
            dgCustomer.Name = "dgCustomer";
            dgCustomer.Size = new Size(350, 437);
            dgCustomer.TabIndex = 3;
            // 
            // dgTransaction
            // 
            dgTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTransaction.Location = new Point(12, 455);
            dgTransaction.Name = "dgTransaction";
            dgTransaction.Size = new Size(350, 437);
            dgTransaction.TabIndex = 2;
            // 
            // dgBooking
            // 
            dgBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgBooking.Location = new Point(724, 12);
            dgBooking.Name = "dgBooking";
            dgBooking.Size = new Size(350, 437);
            dgBooking.TabIndex = 4;
            // 
            // homepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 935);
            Controls.Add(dgBooking);
            Controls.Add(dgCustomer);
            Controls.Add(dgTransaction);
            Controls.Add(dgRoom);
            Controls.Add(dgStaff);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "homepage";
            Text = "Home";
            FormClosing += homepage_FormClosing;
            Load += homepage_Load;
            ((System.ComponentModel.ISupportInitialize)dgStaff).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgRoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgTransaction).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgBooking).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgStaff;
        private DataGridView dgRoom;
        private DataGridView dgCustomer;
        private DataGridView dgTransaction;
        private DataGridView dgBooking;
    }
}