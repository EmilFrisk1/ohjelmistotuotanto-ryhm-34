namespace ohjelmistotuotanto
{
    partial class AddReservationMenuControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddReservationMenuControl));
            panel1 = new Panel();
            da = new Label();
            label8 = new Label();
            cottageCbx = new ComboBox();
            label1 = new Label();
            cottageTxtBox = new TextBox();
            prevBtn = new PictureBox();
            label3 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            customerCbx = new ComboBox();
            label5 = new Label();
            customerTxtBox = new TextBox();
            label6 = new Label();
            panel3 = new Panel();
            dateErrorLabel = new Label();
            whereDateLabel = new Label();
            fromDatePicker = new DateTimePicker();
            label9 = new Label();
            whereDatePicker = new DateTimePicker();
            addReservationBtn = new Button();
            panel4 = new Panel();
            serviceErrorLabel = new Label();
            clientServicesContainer = new Panel();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            addServiceBtn = new Button();
            label2 = new Label();
            servicesCbx = new ComboBox();
            label7 = new Label();
            serviceQuantityTxtBox = new TextBox();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)prevBtn).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            clientServicesContainer.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(da);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(cottageCbx);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cottageTxtBox);
            panel1.ForeColor = Color.Silver;
            panel1.Location = new Point(176, 147);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 186);
            panel1.TabIndex = 14;
            // 
            // da
            // 
            da.AutoSize = true;
            da.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            da.ForeColor = Color.WhiteSmoke;
            da.Location = new Point(-2, 72);
            da.Name = "da";
            da.Size = new Size(61, 37);
            da.TabIndex = 13;
            da.Text = "hae";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(145, -1);
            label8.Name = "label8";
            label8.Size = new Size(152, 50);
            label8.TabIndex = 12;
            label8.Text = "Mökki *";
            // 
            // cottageCbx
            // 
            cottageCbx.BackColor = Color.DarkSlateGray;
            cottageCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            cottageCbx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cottageCbx.ForeColor = Color.Silver;
            cottageCbx.FormattingEnabled = true;
            cottageCbx.Location = new Point(105, 118);
            cottageCbx.Name = "cottageCbx";
            cottageCbx.Size = new Size(315, 29);
            cottageCbx.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(-1, 110);
            label1.Name = "label1";
            label1.Size = new Size(95, 37);
            label1.TabIndex = 2;
            label1.Text = "valitse";
            // 
            // cottageTxtBox
            // 
            cottageTxtBox.BackColor = Color.DarkSlateGray;
            cottageTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cottageTxtBox.ForeColor = Color.Silver;
            cottageTxtBox.Location = new Point(105, 72);
            cottageTxtBox.Name = "cottageTxtBox";
            cottageTxtBox.Size = new Size(315, 29);
            cottageTxtBox.TabIndex = 3;
            cottageTxtBox.TextChanged += cottageTxtBox_TextChanged;
            // 
            // prevBtn
            // 
            prevBtn.BackColor = Color.Transparent;
            prevBtn.Image = (Image)resources.GetObject("prevBtn.Image");
            prevBtn.Location = new Point(33, 32);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(124, 62);
            prevBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            prevBtn.TabIndex = 16;
            prevBtn.TabStop = false;
            prevBtn.Click += prevBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Script MT Bold", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(215, 27);
            label3.Name = "label3";
            label3.Size = new Size(373, 77);
            label3.TabIndex = 15;
            label3.Text = "Lisää varaus";
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
            panel2.Location = new Point(176, 373);
            panel2.Name = "panel2";
            panel2.Size = new Size(451, 186);
            panel2.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(145, -1);
            label4.Name = "label4";
            label4.Size = new Size(172, 50);
            label4.TabIndex = 12;
            label4.Text = "Asiakas *";
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
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(dateErrorLabel);
            panel3.Controls.Add(whereDateLabel);
            panel3.Controls.Add(fromDatePicker);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(whereDatePicker);
            panel3.ForeColor = Color.Transparent;
            panel3.Location = new Point(176, 1066);
            panel3.Name = "panel3";
            panel3.Size = new Size(451, 152);
            panel3.TabIndex = 19;
            // 
            // dateErrorLabel
            // 
            dateErrorLabel.AutoSize = true;
            dateErrorLabel.BackColor = Color.Transparent;
            dateErrorLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateErrorLabel.ForeColor = Color.Cyan;
            dateErrorLabel.Location = new Point(45, 96);
            dateErrorLabel.Name = "dateErrorLabel";
            dateErrorLabel.Size = new Size(337, 37);
            dateErrorLabel.TabIndex = 22;
            dateErrorLabel.Text = "Valitse mihin asti varaus on";
            dateErrorLabel.Visible = false;
            // 
            // whereDateLabel
            // 
            whereDateLabel.AutoSize = true;
            whereDateLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            whereDateLabel.ForeColor = Color.WhiteSmoke;
            whereDateLabel.Location = new Point(288, 6);
            whereDateLabel.Name = "whereDateLabel";
            whereDateLabel.Size = new Size(88, 37);
            whereDateLabel.TabIndex = 18;
            whereDateLabel.Text = "Mihin";
            // 
            // fromDatePicker
            // 
            fromDatePicker.Location = new Point(45, 58);
            fromDatePicker.Name = "fromDatePicker";
            fromDatePicker.Size = new Size(150, 23);
            fromDatePicker.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(75, 6);
            label9.Name = "label9";
            label9.Size = new Size(85, 37);
            label9.TabIndex = 15;
            label9.Text = "Mistä";
            // 
            // whereDatePicker
            // 
            whereDatePicker.Location = new Point(256, 58);
            whereDatePicker.Name = "whereDatePicker";
            whereDatePicker.Size = new Size(150, 23);
            whereDatePicker.TabIndex = 16;
            // 
            // addReservationBtn
            // 
            addReservationBtn.BackColor = Color.DarkSlateGray;
            addReservationBtn.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            addReservationBtn.ForeColor = Color.WhiteSmoke;
            addReservationBtn.Location = new Point(177, 1241);
            addReservationBtn.Name = "addReservationBtn";
            addReservationBtn.Size = new Size(451, 62);
            addReservationBtn.TabIndex = 20;
            addReservationBtn.Text = "Lisää varaus";
            addReservationBtn.UseVisualStyleBackColor = false;
            addReservationBtn.Click += addReservationBtn_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(serviceErrorLabel);
            panel4.Controls.Add(clientServicesContainer);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(addServiceBtn);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(servicesCbx);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(serviceQuantityTxtBox);
            panel4.Controls.Add(label10);
            panel4.ForeColor = Color.Silver;
            panel4.Location = new Point(176, 585);
            panel4.Name = "panel4";
            panel4.Size = new Size(451, 448);
            panel4.TabIndex = 21;
            // 
            // serviceErrorLabel
            // 
            serviceErrorLabel.AutoSize = true;
            serviceErrorLabel.BackColor = Color.Transparent;
            serviceErrorLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            serviceErrorLabel.ForeColor = Color.Cyan;
            serviceErrorLabel.Location = new Point(74, 169);
            serviceErrorLabel.Name = "serviceErrorLabel";
            serviceErrorLabel.Size = new Size(252, 37);
            serviceErrorLabel.TabIndex = 23;
            serviceErrorLabel.Text = "Valitse jokin palvelu";
            serviceErrorLabel.Visible = false;
            // 
            // clientServicesContainer
            // 
            clientServicesContainer.AutoScroll = true;
            clientServicesContainer.BorderStyle = BorderStyle.Fixed3D;
            clientServicesContainer.Controls.Add(label13);
            clientServicesContainer.Controls.Add(label12);
            clientServicesContainer.Location = new Point(3, 292);
            clientServicesContainer.Name = "clientServicesContainer";
            clientServicesContainer.Size = new Size(441, 136);
            clientServicesContainer.TabIndex = 16;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.WhiteSmoke;
            label13.Location = new Point(216, 7);
            label13.Name = "label13";
            label13.Size = new Size(58, 21);
            label13.TabIndex = 20;
            label13.Text = "Määrä";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.WhiteSmoke;
            label12.Location = new Point(10, 7);
            label12.Name = "label12";
            label12.Size = new Size(67, 21);
            label12.TabIndex = 19;
            label12.Text = "Palvelu";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.WhiteSmoke;
            label11.Location = new Point(61, 230);
            label11.Name = "label11";
            label11.Size = new Size(335, 50);
            label11.TabIndex = 15;
            label11.Text = "Asiakkaan palvelut";
            // 
            // addServiceBtn
            // 
            addServiceBtn.BackColor = Color.DarkSlateGray;
            addServiceBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            addServiceBtn.ForeColor = Color.WhiteSmoke;
            addServiceBtn.Location = new Point(332, 169);
            addServiceBtn.Name = "addServiceBtn";
            addServiceBtn.Size = new Size(88, 34);
            addServiceBtn.TabIndex = 13;
            addServiceBtn.Text = "lisää";
            addServiceBtn.UseVisualStyleBackColor = false;
            addServiceBtn.Click += addServiceBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(145, -1);
            label2.Name = "label2";
            label2.Size = new Size(156, 50);
            label2.TabIndex = 12;
            label2.Text = "Palvelut";
            // 
            // servicesCbx
            // 
            servicesCbx.BackColor = Color.DarkSlateGray;
            servicesCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            servicesCbx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            servicesCbx.ForeColor = Color.Silver;
            servicesCbx.FormattingEnabled = true;
            servicesCbx.Items.AddRange(new object[] { "" });
            servicesCbx.Location = new Point(105, 74);
            servicesCbx.Name = "servicesCbx";
            servicesCbx.Size = new Size(315, 29);
            servicesCbx.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(-1, 110);
            label7.Name = "label7";
            label7.Size = new Size(93, 37);
            label7.TabIndex = 2;
            label7.Text = "määrä";
            // 
            // serviceQuantityTxtBox
            // 
            serviceQuantityTxtBox.BackColor = Color.DarkSlateGray;
            serviceQuantityTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            serviceQuantityTxtBox.ForeColor = Color.Silver;
            serviceQuantityTxtBox.Location = new Point(105, 120);
            serviceQuantityTxtBox.Name = "serviceQuantityTxtBox";
            serviceQuantityTxtBox.Size = new Size(315, 29);
            serviceQuantityTxtBox.TabIndex = 3;
            serviceQuantityTxtBox.Text = "1";
            serviceQuantityTxtBox.KeyPress += serviceQuantity_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(-1, 64);
            label10.Name = "label10";
            label10.Size = new Size(115, 37);
            label10.TabIndex = 4;
            label10.Text = "palvelut";
            // 
            // AddReservationMenuControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.test3;
            Controls.Add(panel4);
            Controls.Add(addReservationBtn);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(prevBtn);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "AddReservationMenuControl";
            Size = new Size(804, 1350);
            Load += AddReservationMenuControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)prevBtn).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            clientServicesContainer.ResumeLayout(false);
            clientServicesContainer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label8;
        private ComboBox cottageCbx;
        private Label label1;
        private TextBox cottageTxtBox;
        private PictureBox prevBtn;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private ComboBox customerCbx;
        private Label label5;
        private TextBox customerTxtBox;
        private Label label6;
        private Panel panel3;
        private Label whereDateLabel;
        private DateTimePicker fromDatePicker;
        private Label label9;
        private DateTimePicker whereDatePicker;
        private Button addReservationBtn;
        private Label da;
        private Label dateErrorLabel;
        private Panel panel4;
        private Label label2;
        private ComboBox servicesCbx;
        private Label label7;
        private TextBox serviceQuantityTxtBox;
        private Label label10;
        private Label label11;
        private Button addServiceBtn;
        private Panel clientServicesContainer;
        private Label label13;
        private Label label12;
        private Label serviceErrorLabel;
    }
}
