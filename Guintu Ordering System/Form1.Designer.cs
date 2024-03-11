namespace Guintu_Ordering_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label11 = new Label();
            label6 = new Label();
            label10 = new Label();
            btnReset = new Button();
            priceDrinks = new Label();
            priceDish = new Label();
            label3 = new Label();
            label2 = new Label();
            cbDrinks = new ComboBox();
            lblDrinks = new Label();
            lblDish = new Label();
            cbDish = new ComboBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            lblChange = new Label();
            txtPayment = new TextBox();
            lblTax = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            lblTotalPrice = new Label();
            label5 = new Label();
            label4 = new Label();
            btnPurchase = new Button();
            label1 = new Label();
            panel7 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(priceDrinks);
            panel1.Controls.Add(priceDish);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cbDrinks);
            panel1.Controls.Add(lblDrinks);
            panel1.Controls.Add(lblDish);
            panel1.Controls.Add(cbDish);
            panel1.Font = new Font("Lucida Sans", 11.25F);
            panel1.Location = new Point(86, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(655, 205);
            panel1.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Lucida Sans", 11.25F);
            label11.Location = new Point(601, 42);
            label11.Name = "label11";
            label11.Size = new Size(15, 17);
            label11.TabIndex = 18;
            label11.Text = "₱";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans", 11.25F);
            label6.Location = new Point(152, 42);
            label6.Name = "label6";
            label6.Size = new Size(15, 17);
            label6.TabIndex = 17;
            label6.Text = "₱";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Lucida Sans", 11.25F);
            label10.Location = new Point(300, 9);
            label10.Name = "label10";
            label10.Size = new Size(53, 17);
            label10.TabIndex = 16;
            label10.Text = "MENU";
            label10.Click += label10_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Red;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Lucida Sans", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(152, 160);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(351, 28);
            btnReset.TabIndex = 8;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += button1_Click;
            // 
            // priceDrinks
            // 
            priceDrinks.AutoSize = true;
            priceDrinks.Font = new Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceDrinks.Location = new Point(612, 44);
            priceDrinks.Name = "priceDrinks";
            priceDrinks.Size = new Size(23, 17);
            priceDrinks.TabIndex = 7;
            priceDrinks.Text = "---";
            priceDrinks.Click += priceDrinks_Click;
            // 
            // priceDish
            // 
            priceDish.AutoSize = true;
            priceDish.Font = new Font("Lucida Sans", 11.25F);
            priceDish.Location = new Point(165, 42);
            priceDish.Name = "priceDish";
            priceDish.Size = new Size(23, 17);
            priceDish.TabIndex = 6;
            priceDish.Text = "---";
            priceDish.Click += priceDish_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans", 9.75F);
            label3.Location = new Point(466, 44);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 5;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 9.75F);
            label2.Location = new Point(21, 42);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 4;
            label2.Text = "Price";
            label2.Click += label2_Click;
            // 
            // cbDrinks
            // 
            cbDrinks.Font = new Font("Lucida Sans", 9F);
            cbDrinks.FormattingEnabled = true;
            cbDrinks.Items.AddRange(new object[] { "McCafe Coffee Float", "Original McCafe Iced Coffee", "Coke McFloat", "Mc Freeze", "Mc Iced Coffee Chocolate" });
            cbDrinks.Location = new Point(468, 67);
            cbDrinks.Name = "cbDrinks";
            cbDrinks.Size = new Size(167, 23);
            cbDrinks.TabIndex = 3;
            cbDrinks.SelectedIndexChanged += cbDrinks_SelectedIndexChanged;
            // 
            // lblDrinks
            // 
            lblDrinks.AutoSize = true;
            lblDrinks.Font = new Font("Lucida Sans", 9.75F);
            lblDrinks.Location = new Point(466, 12);
            lblDrinks.Name = "lblDrinks";
            lblDrinks.Size = new Size(73, 15);
            lblDrinks.TabIndex = 2;
            lblDrinks.Text = "Beverages";
            // 
            // lblDish
            // 
            lblDish.AutoSize = true;
            lblDish.Font = new Font("Lucida Sans", 9.75F);
            lblDish.Location = new Point(21, 12);
            lblDish.Name = "lblDish";
            lblDish.Size = new Size(36, 15);
            lblDish.TabIndex = 1;
            lblDish.Text = "Meal";
            lblDish.Click += label1_Click;
            // 
            // cbDish
            // 
            cbDish.Font = new Font("Lucida Sans", 9F);
            cbDish.FormattingEnabled = true;
            cbDish.Items.AddRange(new object[] { "McSpaghetti Solo", "Cheeseburger", "1pc Chicken McDo Original", "1pc Chicken McDo Spicy", "Big Mac" });
            cbDish.Location = new Point(21, 67);
            cbDish.Name = "cbDish";
            cbDish.Size = new Size(167, 23);
            cbDish.TabIndex = 0;
            cbDish.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.McDonalds_logo_png__1_;
            pictureBox1.InitialImage = Properties.Resources.McDonalds_logo_png__1_;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkRed;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(12, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(68, 205);
            panel2.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(3, 225);
            panel5.Name = "panel5";
            panel5.Size = new Size(49, 173);
            panel5.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.Location = new Point(0, 225);
            panel6.Name = "panel6";
            panel6.Size = new Size(49, 173);
            panel6.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 225);
            panel3.Name = "panel3";
            panel3.Size = new Size(49, 173);
            panel3.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(lblChange);
            panel4.Controls.Add(txtPayment);
            panel4.Controls.Add(lblTax);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(lblTotalPrice);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(btnPurchase);
            panel4.Controls.Add(label1);
            panel4.Font = new Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel4.Location = new Point(86, 236);
            panel4.Name = "panel4";
            panel4.Size = new Size(655, 233);
            panel4.TabIndex = 4;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Lucida Sans", 11.25F);
            label14.Location = new Point(538, 156);
            label14.Name = "label14";
            label14.Size = new Size(15, 17);
            label14.TabIndex = 21;
            label14.Text = "₱";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Lucida Sans", 11.25F);
            label13.Location = new Point(538, 59);
            label13.Name = "label13";
            label13.Size = new Size(15, 17);
            label13.TabIndex = 20;
            label13.Text = "₱";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Lucida Sans", 11.25F);
            label12.Location = new Point(538, 31);
            label12.Name = "label12";
            label12.Size = new Size(15, 17);
            label12.TabIndex = 19;
            label12.Text = "₱";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Lucida Sans", 11.25F);
            lblChange.Location = new Point(553, 156);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(23, 17);
            lblChange.TabIndex = 18;
            lblChange.Text = "---";
            // 
            // txtPayment
            // 
            txtPayment.Location = new Point(152, 111);
            txtPayment.Name = "txtPayment";
            txtPayment.Size = new Size(351, 25);
            txtPayment.TabIndex = 17;
            txtPayment.TextChanged += textBox1_TextChanged;
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Font = new Font("Lucida Sans", 11.25F);
            lblTax.Location = new Point(553, 59);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(23, 17);
            lblTax.TabIndex = 16;
            lblTax.Text = "---";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Lucida Sans", 11.25F);
            label9.Location = new Point(38, 87);
            label9.Name = "label9";
            label9.Size = new Size(74, 17);
            label9.TabIndex = 15;
            label9.Text = "Payment:";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Sans", 11.25F);
            label8.Location = new Point(38, 156);
            label8.Name = "label8";
            label8.Size = new Size(62, 17);
            label8.TabIndex = 14;
            label8.Text = "Change";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Sans", 11.25F);
            label7.Location = new Point(553, 68);
            label7.Name = "label7";
            label7.Size = new Size(0, 17);
            label7.TabIndex = 13;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Lucida Sans", 11.25F);
            lblTotalPrice.Location = new Point(553, 31);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(23, 17);
            lblTotalPrice.TabIndex = 12;
            lblTotalPrice.Text = "---";
            lblTotalPrice.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Sans", 11.25F);
            label5.Location = new Point(38, 59);
            label5.Name = "label5";
            label5.Size = new Size(34, 17);
            label5.TabIndex = 11;
            label5.Text = "Tax";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans", 11.25F);
            label4.Location = new Point(38, 31);
            label4.Name = "label4";
            label4.Size = new Size(45, 17);
            label4.TabIndex = 10;
            label4.Text = "Total";
            // 
            // btnPurchase
            // 
            btnPurchase.BackColor = Color.ForestGreen;
            btnPurchase.FlatAppearance.BorderSize = 0;
            btnPurchase.FlatStyle = FlatStyle.Flat;
            btnPurchase.Font = new Font("Lucida Sans", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPurchase.ForeColor = Color.White;
            btnPurchase.Location = new Point(152, 188);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(351, 28);
            btnPurchase.TabIndex = 9;
            btnPurchase.Text = "PURCHASE";
            btnPurchase.UseVisualStyleBackColor = false;
            btnPurchase.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 11.25F);
            label1.Location = new Point(295, 7);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 4;
            label1.Text = "RECEIPT";
            label1.Click += label1_Click_1;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Maroon;
            panel7.Location = new Point(12, 236);
            panel7.Name = "panel7";
            panel7.Size = new Size(68, 233);
            panel7.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(750, 481);
            Controls.Add(panel7);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Lucida Sans", 8.25F);
            Name = "Form1";
            Text = "Mc Donalds";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Label lblDish;
        private ComboBox cbDish;
        private ComboBox cbDrinks;
        private Label lblDrinks;
        private Label label2;
        private Label label1;
        private Button btnReset;
        private Label priceDrinks;
        private Label priceDish;
        private Label label3;
        private Button btnPurchase;
        private Label label7;
        private Label lblTotalPrice;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label lblTax;
        private TextBox txtPayment;
        private Label lblChange;
        private Label label11;
        private Label label6;
        private Label label14;
        private Label label13;
        private Label label12;
    }
}
