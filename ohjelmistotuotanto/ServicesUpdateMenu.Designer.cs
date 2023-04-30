namespace ohjelmistotuotanto
{
    partial class ServicesUpdateMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicesUpdateMenu));
            prevBtn = new PictureBox();
            label1 = new Label();
            panel4 = new Panel();
            serviceErrorLabel = new Label();
            label2 = new Label();
            servicesCbx = new ComboBox();
            label10 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            label5 = new Label();
            priceTxtBox = new TextBox();
            label11 = new Label();
            nameTxtBox = new TextBox();
            editServiceBtn = new Button();
            priceErrLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)prevBtn).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // prevBtn
            // 
            prevBtn.BackColor = Color.Transparent;
            prevBtn.Image = (Image)resources.GetObject("prevBtn.Image");
            prevBtn.Location = new Point(33, 33);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(124, 62);
            prevBtn.TabIndex = 22;
            prevBtn.TabStop = false;
            prevBtn.Click += prevBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Script MT Bold", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(209, 18);
            label1.Name = "label1";
            label1.Size = new Size(436, 77);
            label1.TabIndex = 21;
            label1.Text = "Päivitä Palvelu";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(serviceErrorLabel);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(servicesCbx);
            panel4.Controls.Add(label10);
            panel4.ForeColor = Color.Silver;
            panel4.Location = new Point(194, 143);
            panel4.Name = "panel4";
            panel4.Size = new Size(451, 202);
            panel4.TabIndex = 23;
            // 
            // serviceErrorLabel
            // 
            serviceErrorLabel.AutoSize = true;
            serviceErrorLabel.BackColor = Color.Transparent;
            serviceErrorLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            serviceErrorLabel.ForeColor = Color.Cyan;
            serviceErrorLabel.Location = new Point(103, 135);
            serviceErrorLabel.Name = "serviceErrorLabel";
            serviceErrorLabel.Size = new Size(252, 37);
            serviceErrorLabel.TabIndex = 23;
            serviceErrorLabel.Text = "Valitse jokin palvelu";
            serviceErrorLabel.Visible = false;
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
            servicesCbx.Location = new Point(120, 74);
            servicesCbx.Name = "servicesCbx";
            servicesCbx.Size = new Size(315, 29);
            servicesCbx.TabIndex = 1;
            servicesCbx.SelectedIndexChanged += servicesCbx_SelectedIndexChanged;
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
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(priceErrLabel);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(priceTxtBox);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(nameTxtBox);
            panel1.Controls.Add(editServiceBtn);
            panel1.ForeColor = Color.Silver;
            panel1.Location = new Point(194, 380);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 317);
            panel1.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(74, 30);
            label8.Name = "label8";
            label8.Size = new Size(326, 50);
            label8.TabIndex = 27;
            label8.Text = "Muokkaa Palvelua";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(53, 153);
            label5.Name = "label5";
            label5.Size = new Size(52, 23);
            label5.TabIndex = 18;
            label5.Text = "Hinta";
            // 
            // priceTxtBox
            // 
            priceTxtBox.BackColor = Color.DarkSlateGray;
            priceTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceTxtBox.ForeColor = Color.Silver;
            priceTxtBox.Location = new Point(120, 153);
            priceTxtBox.Name = "priceTxtBox";
            priceTxtBox.Size = new Size(290, 29);
            priceTxtBox.TabIndex = 17;
            priceTxtBox.KeyPress += priceTxtBox_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.WhiteSmoke;
            label11.Location = new Point(53, 108);
            label11.Name = "label11";
            label11.Size = new Size(46, 23);
            label11.TabIndex = 16;
            label11.Text = "Nimi";
            // 
            // nameTxtBox
            // 
            nameTxtBox.BackColor = Color.DarkSlateGray;
            nameTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameTxtBox.ForeColor = Color.Silver;
            nameTxtBox.Location = new Point(120, 108);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(290, 29);
            nameTxtBox.TabIndex = 15;
            // 
            // editServiceBtn
            // 
            editServiceBtn.BackColor = Color.DarkSlateGray;
            editServiceBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            editServiceBtn.ForeColor = Color.WhiteSmoke;
            editServiceBtn.Location = new Point(53, 238);
            editServiceBtn.Name = "editServiceBtn";
            editServiceBtn.Size = new Size(357, 34);
            editServiceBtn.TabIndex = 14;
            editServiceBtn.Text = "Lisää muokkaus";
            editServiceBtn.UseVisualStyleBackColor = false;
            editServiceBtn.Click += editServiceBtn_Click;
            // 
            // priceErrLabel
            // 
            priceErrLabel.AutoSize = true;
            priceErrLabel.BackColor = Color.Transparent;
            priceErrLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            priceErrLabel.ForeColor = Color.Cyan;
            priceErrLabel.Location = new Point(120, 185);
            priceErrLabel.Name = "priceErrLabel";
            priceErrLabel.Size = new Size(264, 37);
            priceErrLabel.TabIndex = 28;
            priceErrLabel.Text = "liian monta numeroa";
            priceErrLabel.Visible = false;
            // 
            // ServicesUpdateMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.test3;
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(prevBtn);
            Controls.Add(label1);
            Name = "ServicesUpdateMenu";
            Size = new Size(804, 736);
            Load += ServicesUpdateMenu_Load;
            VisibleChanged += ServicesUpdateMenu_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)prevBtn).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox prevBtn;
        private Label label1;
        private Panel panel4;
        private Label serviceErrorLabel;
        private Label label2;
        private ComboBox servicesCbx;
        private Label label10;
        private Panel panel1;
        private Label label8;
        private Label label5;
        private TextBox priceTxtBox;
        private Label label11;
        private TextBox nameTxtBox;
        private Button editServiceBtn;
        private Label priceErrLabel;
    }
}
