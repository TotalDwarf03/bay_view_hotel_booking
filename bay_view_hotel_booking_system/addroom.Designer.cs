namespace bay_view_hotel_booking_system
{
    partial class addroom
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
            txtrsID = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtPrice = new TextBox();
            txtCapacity = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            btnAdd = new Button();
            button2 = new Button();
            menuStrip1 = new MenuStrip();
            viewRoomsToolStripMenuItem = new ToolStripMenuItem();
            returnToHomepageToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(222, 44);
            label1.Name = "label1";
            label1.Size = new Size(181, 31);
            label1.TabIndex = 0;
            label1.Text = "Add New Room";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 129);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "Room Type:";
            label2.Click += label2_Click;
            // 
            // rType
            // 
            rType.AllowDrop = true;
            rType.FormattingEnabled = true;
            rType.Items.AddRange(new object[] { "single\t", "double", "family" });
            rType.Location = new Point(183, 126);
            rType.Name = "rType";
            rType.Size = new Size(151, 28);
            rType.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 174);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 3;
            label3.Text = "Room Status ID:";
            label3.Click += label3_Click;
            // 
            // txtrsID
            // 
            txtrsID.Location = new Point(183, 172);
            txtrsID.Name = "txtrsID";
            txtrsID.Size = new Size(151, 27);
            txtrsID.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(127, 218);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 5;
            label4.Text = "Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(108, 263);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 6;
            label5.Text = "Capacity:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(96, 311);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 7;
            label6.Text = "IsDisabled:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(183, 217);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(151, 27);
            txtPrice.TabIndex = 8;
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(183, 262);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(151, 27);
            txtCapacity.TabIndex = 9;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(193, 309);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(58, 24);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "True";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(262, 309);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(62, 24);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "False";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightGreen;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ActiveCaptionText;
            btnAdd.Location = new Point(434, 156);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(132, 38);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add Room";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(434, 214);
            button2.Name = "button2";
            button2.Size = new Size(132, 39);
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
            menuStrip1.Size = new Size(624, 28);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // viewRoomsToolStripMenuItem
            // 
            viewRoomsToolStripMenuItem.Name = "viewRoomsToolStripMenuItem";
            viewRoomsToolStripMenuItem.Size = new Size(105, 24);
            viewRoomsToolStripMenuItem.Text = "View Rooms";
            // 
            // returnToHomepageToolStripMenuItem
            // 
            returnToHomepageToolStripMenuItem.Name = "returnToHomepageToolStripMenuItem";
            returnToHomepageToolStripMenuItem.Size = new Size(163, 24);
            returnToHomepageToolStripMenuItem.Text = "Return to Homepage";
            // 
            // addroom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 450);
            Controls.Add(button2);
            Controls.Add(btnAdd);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(txtCapacity);
            Controls.Add(txtPrice);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtrsID);
            Controls.Add(label3);
            Controls.Add(rType);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
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
        private TextBox txtrsID;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtPrice;
        private TextBox txtCapacity;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button btnAdd;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem viewRoomsToolStripMenuItem;
        private ToolStripMenuItem returnToHomepageToolStripMenuItem;
    }
}