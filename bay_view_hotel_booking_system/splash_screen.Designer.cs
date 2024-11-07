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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splash_screen));
            loading_bar = new ProgressBar();
            splash_screen_timer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loading_bar
            // 
            loading_bar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loading_bar.Location = new Point(12, 454);
            loading_bar.Margin = new Padding(3, 2, 3, 2);
            loading_bar.Maximum = 60;
            loading_bar.Name = "loading_bar";
            loading_bar.Size = new Size(776, 35);
            loading_bar.TabIndex = 0;
            // 
            // splash_screen_timer
            // 
            splash_screen_timer.Enabled = true;
            splash_screen_timer.Interval = 500;
            splash_screen_timer.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.bay_view_logo;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 437);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // splash_screen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(pictureBox1);
            Controls.Add(loading_bar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "splash_screen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "splash_screen";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ProgressBar loading_bar;
        private System.Windows.Forms.Timer splash_screen_timer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}