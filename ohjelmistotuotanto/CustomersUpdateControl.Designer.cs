namespace ohjelmistotuotanto
{
    partial class CustomersUpdateControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersUpdateControl));
            panel2 = new Panel();
            label4 = new Label();
            customerCbx = new ComboBox();
            label5 = new Label();
            customerTxtBox = new TextBox();
            label6 = new Label();
            label3 = new Label();
            prevBtn = new PictureBox();
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            textBox5 = new TextBox();
            label1 = new Label();
            textBox4 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label9 = new Label();
            textBox2 = new TextBox();
            label10 = new Label();
            textBox1 = new TextBox();
            label11 = new Label();
            textBox = new TextBox();
            addCustomerBtn = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)prevBtn).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(customerCbx);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(customerTxtBox);
            panel2.Controls.Add(label6);
            panel2.ForeColor = Color.Silver;
            panel2.Location = new Point(177, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(451, 186);
            panel2.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(145, -1);
            label4.Name = "label4";
            label4.Size = new Size(146, 50);
            label4.TabIndex = 12;
            label4.Text = "Asiakas";
            // 
            // customerCbx
            // 
            customerCbx.BackColor = Color.DarkSlateGray;
            customerCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            customerCbx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customerCbx.ForeColor = Color.Silver;
            customerCbx.FormattingEnabled = true;
            customerCbx.Items.AddRange(new object[] { "" });
            customerCbx.Location = new Point(105, 118);
            customerCbx.Name = "customerCbx";
            customerCbx.Size = new Size(315, 29);
            customerCbx.TabIndex = 1;
            customerCbx.SelectedIndexChanged += customerCbx_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(-1, 110);
            label5.Name = "label5";
            label5.Size = new Size(95, 37);
            label5.TabIndex = 2;
            label5.Text = "valitse";
            // 
            // customerTxtBox
            // 
            customerTxtBox.BackColor = Color.DarkSlateGray;
            customerTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customerTxtBox.ForeColor = Color.Silver;
            customerTxtBox.Location = new Point(105, 72);
            customerTxtBox.Name = "customerTxtBox";
            customerTxtBox.Size = new Size(315, 29);
            customerTxtBox.TabIndex = 3;
            customerTxtBox.Text = " ";
            customerTxtBox.TextChanged += customerTxtBox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(-1, 64);
            label6.Name = "label6";
            label6.Size = new Size(61, 37);
            label6.TabIndex = 4;
            label6.Text = "hae";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Script MT Bold", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(161, 20);
            label3.Name = "label3";
            label3.Size = new Size(502, 77);
            label3.TabIndex = 19;
            label3.Text = "Päivitä asiakkaita";
            // 
            // prevBtn
            // 
            prevBtn.BackColor = Color.Transparent;
            prevBtn.Image = (Image)resources.GetObject("prevBtn.Image");
            prevBtn.Location = new Point(33, 32);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(124, 62);
            prevBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            prevBtn.TabIndex = 20;
            prevBtn.TabStop = false;
            prevBtn.Click += prevBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(textBox);
            panel1.Controls.Add(addCustomerBtn);
            panel1.ForeColor = Color.Silver;
            panel1.Location = new Point(177, 301);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 444);
            panel1.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(74, 30);
            label8.Name = "label8";
            label8.Size = new Size(336, 50);
            label8.TabIndex = 27;
            label8.Text = "Muokkaa asiakasta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(53, 333);
            label7.Name = "label7";
            label7.Size = new Size(111, 23);
            label7.TabIndex = 26;
            label7.Text = "Posti numero";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.DarkSlateGray;
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.ForeColor = Color.Silver;
            textBox5.Location = new Point(205, 333);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(205, 29);
            textBox5.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(51, 288);
            label1.Name = "label1";
            label1.Size = new Size(59, 23);
            label1.TabIndex = 24;
            label1.Text = "Osoite";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.DarkSlateGray;
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.ForeColor = Color.Silver;
            textBox4.Location = new Point(205, 288);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(205, 29);
            textBox4.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(53, 243);
            label2.Name = "label2";
            label2.Size = new Size(132, 23);
            label2.TabIndex = 22;
            label2.Text = "Puhelin numero";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.DarkSlateGray;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.Silver;
            textBox3.Location = new Point(205, 243);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(205, 29);
            textBox3.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(53, 198);
            label9.Name = "label9";
            label9.Size = new Size(94, 23);
            label9.TabIndex = 20;
            label9.Text = "Sähköposti";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DarkSlateGray;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Silver;
            textBox2.Location = new Point(205, 198);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(205, 29);
            textBox2.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(53, 153);
            label10.Name = "label10";
            label10.Size = new Size(81, 23);
            label10.TabIndex = 18;
            label10.Text = "Sukunimi";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkSlateGray;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Silver;
            textBox1.Location = new Point(205, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 29);
            textBox1.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.WhiteSmoke;
            label11.Location = new Point(53, 108);
            label11.Name = "label11";
            label11.Size = new Size(68, 23);
            label11.TabIndex = 16;
            label11.Text = "Etunimi";
            // 
            // textBox
            // 
            textBox.BackColor = Color.DarkSlateGray;
            textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox.ForeColor = Color.Silver;
            textBox.Location = new Point(205, 108);
            textBox.Name = "textBox";
            textBox.Size = new Size(205, 29);
            textBox.TabIndex = 15;
            // 
            // addCustomerBtn
            // 
            addCustomerBtn.BackColor = Color.DarkSlateGray;
            addCustomerBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            addCustomerBtn.ForeColor = Color.WhiteSmoke;
            addCustomerBtn.Location = new Point(51, 373);
            addCustomerBtn.Name = "addCustomerBtn";
            addCustomerBtn.Size = new Size(359, 34);
            addCustomerBtn.TabIndex = 14;
            addCustomerBtn.Text = "Lisää muokkaus";
            addCustomerBtn.UseVisualStyleBackColor = false;
            // 
            // CustomersUpdateControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.test3;
            Controls.Add(panel1);
            Controls.Add(prevBtn);
            Controls.Add(label3);
            Controls.Add(panel2);
            Name = "CustomersUpdateControl";
            Size = new Size(804, 800);
            Load += CustomersUpdateControl_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)prevBtn).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label4;
        private ComboBox customerCbx;
        private Label label5;
        private TextBox customerTxtBox;
        private Label label6;
        private Label label3;
        private PictureBox prevBtn;
        private Panel panel1;
        private Label label8;
        private Label label7;
        private TextBox textBox5;
        private Label label1;
        private TextBox textBox4;
        private Label label2;
        private TextBox textBox3;
        private Label label9;
        private TextBox textBox2;
        private Label label10;
        private TextBox textBox1;
        private Label label11;
        private TextBox textBox;
        private Button addCustomerBtn;
    }
}
