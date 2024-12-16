namespace bay_view_hotel_booking_system
{
    partial class RoomAdd
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
            label1 = new Label();
            label2 = new Label();
            rType = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtPrice = new TextBox();
            txtCapacity = new TextBox();
            btnAdd = new Button();
            button2 = new Button();
            menuStrip1 = new MenuStrip();
            viewRoomsToolStripMenuItem = new ToolStripMenuItem();
            returnToHomepageToolStripMenuItem = new ToolStripMenuItem();
            cbStatus = new ComboBox();
            cbDisabled = new ComboBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(194, 33);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 0;
            label1.Text = "Add New Room";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 97);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Room Type:";
            label2.Click += label2_Click;
            // 
            // rType
            // 
            rType.AllowDrop = true;
            rType.FormattingEnabled = true;
            rType.Items.AddRange(new object[] { "Single", "Double", "Family" });
            rType.Location = new Point(160, 94);
            rType.Margin = new Padding(3, 2, 3, 2);
            rType.Name = "rType";
            rType.Size = new Size(133, 23);
            rType.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 130);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 3;
            label3.Text = "Room Status:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 164);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 5;
            label4.Text = "Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 197);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 6;
            label5.Text = "Capacity:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(60, 234);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 7;
            label6.Text = "Disabled Room:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(160, 163);
            txtPrice.Margin = new Padding(3, 2, 3, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(133, 23);
            txtPrice.TabIndex = 8;
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(160, 196);
            txtCapacity.Margin = new Padding(3, 2, 3, 2);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(133, 23);
            txtCapacity.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightGreen;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ActiveCaptionText;
            btnAdd.Location = new Point(380, 117);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(116, 28);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add Room";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(380, 160);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(116, 29);
            button2.TabIndex = 14;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { viewRoomsToolStripMenuItem, returnToHomepageToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(546, 24);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // viewRoomsToolStripMenuItem
            // 
            viewRoomsToolStripMenuItem.Name = "viewRoomsToolStripMenuItem";
            viewRoomsToolStripMenuItem.Size = new Size(84, 20);
            viewRoomsToolStripMenuItem.Text = "View Rooms";
            viewRoomsToolStripMenuItem.Click += viewRoomsToolStripMenuItem_Click;
            // 
            // returnToHomepageToolStripMenuItem
            // 
            returnToHomepageToolStripMenuItem.Name = "returnToHomepageToolStripMenuItem";
            returnToHomepageToolStripMenuItem.Size = new Size(130, 20);
            returnToHomepageToolStripMenuItem.Text = "Return to Homepage";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Available", "Under Refurbishment", "Off Sale" });
            cbStatus.Location = new Point(160, 128);
            cbStatus.Margin = new Padding(3, 2, 3, 2);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(133, 23);
            cbStatus.TabIndex = 16;
            // 
            // cbDisabled
            // 
            cbDisabled.FormattingEnabled = true;
            cbDisabled.Items.AddRange(new object[] { "Yes", "No" });
            cbDisabled.Location = new Point(160, 234);
            cbDisabled.Name = "cbDisabled";
            cbDisabled.Size = new Size(133, 23);
            cbDisabled.TabIndex = 17;
            // 
            // addroom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 338);
            Controls.Add(cbDisabled);
            Controls.Add(cbStatus);
            Controls.Add(button2);
            Controls.Add(btnAdd);
            Controls.Add(txtCapacity);
            Controls.Add(txtPrice);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(rType);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "addroom";
            Text = "addroom";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox rType;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtPrice;
        private TextBox txtCapacity;
        private Button btnAdd;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem viewRoomsToolStripMenuItem;
        private ToolStripMenuItem returnToHomepageToolStripMenuItem;
        private ComboBox cbStatus;
        private ComboBox cbDisabled;
    }
}