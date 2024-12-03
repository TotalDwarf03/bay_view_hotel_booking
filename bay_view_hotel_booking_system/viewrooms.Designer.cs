namespace bay_view_hotel_booking_system
{
    partial class viewrooms
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
            dgRoom = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgRoom).BeginInit();
            SuspendLayout();
            // 
            // dgRoom
            // 
            dgRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgRoom.Location = new Point(12, 12);
            dgRoom.Name = "dgRoom";
            dgRoom.RowHeadersWidth = 51;
            dgRoom.Size = new Size(776, 504);
            dgRoom.TabIndex = 0;
            dgRoom.CellContentClick += dataGridView1_CellContentClick;
            // 
            // viewrooms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 528);
            Controls.Add(dgRoom);
            Name = "viewrooms";
            Text = "viewrooms";
            Load += viewrooms_Load;
            ((System.ComponentModel.ISupportInitialize)dgRoom).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgRoom;
    }
}