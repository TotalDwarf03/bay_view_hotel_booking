namespace bay_view_hotel_booking_system
{
    partial class splash_screen
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
            components = new System.ComponentModel.Container();
            loading_bar = new System.Windows.Forms.ProgressBar();
            splash_screen_timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // loading_bar
            // 
            loading_bar.Location = new System.Drawing.Point(12, 409);
            loading_bar.Maximum = 60;
            loading_bar.Name = "loading_bar";
            loading_bar.Size = new System.Drawing.Size(776, 29);
            loading_bar.TabIndex = 0;
            // 
            // splash_screen_timer
            // 
            splash_screen_timer.Enabled = true;
            splash_screen_timer.Interval = 500;
            splash_screen_timer.Tick += timer1_Tick;
            // 
            // splash_screen
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(loading_bar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "splash_screen";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "splash_screen";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ProgressBar loading_bar;
        private System.Windows.Forms.Timer splash_screen_timer;
    }
}