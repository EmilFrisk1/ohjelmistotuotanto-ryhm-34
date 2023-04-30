namespace ohjelmistotuotanto
{
    partial class ServicesAddMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicesAddMenu));
            prevBtn = new PictureBox();
            panel1 = new Panel();
            label8 = new Label();
            label3 = new Label();
            priceTxtBox = new TextBox();
            label2 = new Label();
            nameTxtBox = new TextBox();
            addServiceBtn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)prevBtn).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // prevBtn
            // 
            prevBtn.BackColor = Color.Transparent;
            prevBtn.Image = (Image)resources.GetObject("prevBtn.Image");
            prevBtn.Location = new Point(33, 32);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(124, 62);
            prevBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            prevBtn.TabIndex = 21;
            prevBtn.TabStop = false;
            prevBtn.Click += prevBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(priceTxtBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(nameTxtBox);
            panel1.Controls.Add(addServiceBtn);
            panel1.ForeColor = Color.Silver;
            panel1.Location = new Point(187, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 282);
            panel1.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(117, 30);
            label8.Name = "label8";
            label8.Size = new Size(228, 50);
            label8.TabIndex = 27;
            label8.Text = "Uusi palvelu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(53, 153);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 18;
            label3.Text = "Hinta *";
            // 
            // priceTxtBox
            // 
            priceTxtBox.BackColor = Color.DarkSlateGray;
            priceTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceTxtBox.ForeColor = Color.Silver;
            priceTxtBox.Location = new Point(205, 153);
            priceTxtBox.Name = "priceTxtBox";
            priceTxtBox.Size = new Size(205, 29);
            priceTxtBox.TabIndex = 17;
            priceTxtBox.KeyPress += priceTxtBox_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(53, 108);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 16;
            label2.Text = "Nimi *";
            // 
            // nameTxtBox
            // 
            nameTxtBox.BackColor = Color.DarkSlateGray;
            nameTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameTxtBox.ForeColor = Color.Silver;
            nameTxtBox.Location = new Point(205, 108);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(205, 29);
            nameTxtBox.TabIndex = 15;
            // 
            // addServiceBtn
            // 
            addServiceBtn.BackColor = Color.DarkSlateGray;
            addServiceBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            addServiceBtn.ForeColor = Color.WhiteSmoke;
            addServiceBtn.Location = new Point(51, 210);
            addServiceBtn.Name = "addServiceBtn";
            addServiceBtn.Size = new Size(359, 34);
            addServiceBtn.TabIndex = 14;
            addServiceBtn.Text = "lisää";
            addServiceBtn.UseVisualStyleBackColor = false;
            addServiceBtn.Click += addServiceBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Script MT Bold", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(219, 17);
            label1.Name = "label1";
            label1.Size = new Size(392, 77);
            label1.TabIndex = 19;
            label1.Text = "Lisää palvelu";
            // 
            // ServicesAddMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.test3;
            Controls.Add(prevBtn);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "ServicesAddMenu";
            Size = new Size(804, 736);
            Load += ServicesAddMenu_Load;
            ((System.ComponentModel.ISupportInitialize)prevBtn).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox prevBtn;
        private Panel panel1;
        private Label label8;
        private Label label7;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private TextBox nameTxtBox;
        private Button addServiceBtn;
        private Label label1;
        private TextBox priceTxtBox;
    }
}
