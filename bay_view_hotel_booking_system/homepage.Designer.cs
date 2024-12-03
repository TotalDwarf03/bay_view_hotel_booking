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
            button1 = new Button();
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
            dgStaff.Location = new Point(14, 16);
            dgStaff.Margin = new Padding(3, 4, 3, 4);
            dgStaff.Name = "dgStaff";
            dgStaff.RowHeadersWidth = 51;
            dgStaff.Size = new Size(400, 583);
            dgStaff.TabIndex = 0;
            // 
            // dgRoom
            // 
            dgRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgRoom.Location = new Point(421, 16);
            dgRoom.Margin = new Padding(3, 4, 3, 4);
            dgRoom.Name = "dgRoom";
            dgRoom.RowHeadersWidth = 51;
            dgRoom.Size = new Size(400, 583);
            dgRoom.TabIndex = 1;
            // 
            // dgCustomer
            // 
            dgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCustomer.Location = new Point(421, 607);
            dgCustomer.Margin = new Padding(3, 4, 3, 4);
            dgCustomer.Name = "dgCustomer";
            dgCustomer.RowHeadersWidth = 51;
            dgCustomer.Size = new Size(400, 583);
            dgCustomer.TabIndex = 3;
            // 
            // dgTransaction
            // 
            dgTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTransaction.Location = new Point(14, 607);
            dgTransaction.Margin = new Padding(3, 4, 3, 4);
            dgTransaction.Name = "dgTransaction";
            dgTransaction.RowHeadersWidth = 51;
            dgTransaction.Size = new Size(400, 583);
            dgTransaction.TabIndex = 2;
            // 
            // dgBooking
            // 
            dgBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgBooking.Location = new Point(827, 16);
            dgBooking.Margin = new Padding(3, 4, 3, 4);
            dgBooking.Name = "dgBooking";
            dgBooking.RowHeadersWidth = 51;
            dgBooking.Size = new Size(400, 583);
            dgBooking.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(981, 805);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // homepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 1055);
            Controls.Add(button1);
            Controls.Add(dgBooking);
            Controls.Add(dgCustomer);
            Controls.Add(dgTransaction);
            Controls.Add(dgRoom);
            Controls.Add(dgStaff);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
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
        private Button button1;
    }
}