namespace bay_view_hotel_booking_system
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            ProgressBar = new ProgressBar();
            splash_screen_timer = new System.Windows.Forms.Timer(components);
            pbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // ProgressBar
            // 
            ProgressBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ProgressBar.Location = new Point(12, 454);
            ProgressBar.Margin = new Padding(3, 2, 3, 2);
            ProgressBar.Maximum = 60;
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new Size(776, 35);
            ProgressBar.TabIndex = 0;
            // 
            // splash_screen_timer
            // 
            splash_screen_timer.Enabled = true;
            splash_screen_timer.Interval = 500;
            splash_screen_timer.Tick += timer1_Tick;
            // 
            // pbLogo
            // 
            pbLogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbLogo.Image = Properties.Resources.bay_view_logo;
            pbLogo.Location = new Point(12, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(776, 437);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(pbLogo);
            Controls.Add(ProgressBar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "SplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "splash_screen";
            Load += splash_screen_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Timer splash_screen_timer;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}