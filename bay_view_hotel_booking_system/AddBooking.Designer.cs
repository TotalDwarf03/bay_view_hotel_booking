namespace bay_view_hotel_booking_system
{
    partial class AddBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBooking));
            MenuStrip = new MenuStrip();
            tsmiAvailability = new ToolStripMenuItem();
            tsmiEditBooking = new ToolStripMenuItem();
            tsmiQuit = new ToolStripMenuItem();
            MenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MenuStrip
            // 
            MenuStrip.ImageScalingSize = new Size(20, 20);
            MenuStrip.Items.AddRange(new ToolStripItem[] { tsmiAvailability, tsmiEditBooking, tsmiQuit });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(782, 28);
            MenuStrip.TabIndex = 1;
            MenuStrip.Text = "menuStrip1";
            // 
            // tsmiAvailability
            // 
            tsmiAvailability.Name = "tsmiAvailability";
            tsmiAvailability.Size = new Size(133, 24);
            tsmiAvailability.Text = "View Availability";
            // 
            // tsmiEditBooking
            // 
            tsmiEditBooking.Name = "tsmiEditBooking";
            tsmiEditBooking.Size = new Size(108, 24);
            tsmiEditBooking.Text = "Edit Booking";
            // 
            // tsmiQuit
            // 
            tsmiQuit.Name = "tsmiQuit";
            tsmiQuit.Size = new Size(51, 24);
            tsmiQuit.Text = "Quit";
            tsmiQuit.Click += tsmiQuit_Click;
            // 
            // AddBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(MenuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = MenuStrip;
            Name = "AddBooking";
            Text = "Booking Management: Availability";
            FormClosing += AddBooking_FormClosing;
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuStrip;
        private ToolStripMenuItem tsmiAvailability;
        private ToolStripMenuItem tsmiEditBooking;
        private ToolStripMenuItem tsmiQuit;
    }
}