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
            this.prevBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.serviceErrorLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.servicesCbx = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.priceErrLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.priceTxtBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.editServiceBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prevBtn)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // prevBtn
            // 
            this.prevBtn.BackColor = System.Drawing.Color.Transparent;
            this.prevBtn.Image = ((System.Drawing.Image)(resources.GetObject("prevBtn.Image")));
            this.prevBtn.Location = new System.Drawing.Point(33, 33);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(124, 62);
            this.prevBtn.TabIndex = 22;
            this.prevBtn.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(209, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 77);
            this.label1.TabIndex = 21;
            this.label1.Text = "Päivitä Palvelu";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.serviceErrorLabel);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.servicesCbx);
            this.panel4.Controls.Add(this.label10);
            this.panel4.ForeColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(194, 143);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(451, 202);
            this.panel4.TabIndex = 23;
            // 
            // serviceErrorLabel
            // 
            this.serviceErrorLabel.AutoSize = true;
            this.serviceErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.serviceErrorLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.serviceErrorLabel.ForeColor = System.Drawing.Color.Cyan;
            this.serviceErrorLabel.Location = new System.Drawing.Point(103, 135);
            this.serviceErrorLabel.Name = "serviceErrorLabel";
            this.serviceErrorLabel.Size = new System.Drawing.Size(252, 37);
            this.serviceErrorLabel.TabIndex = 23;
            this.serviceErrorLabel.Text = "Valitse jokin palvelu";
            this.serviceErrorLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(145, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 50);
            this.label2.TabIndex = 12;
            this.label2.Text = "Palvelut";
            // 
            // servicesCbx
            // 
            this.servicesCbx.BackColor = System.Drawing.Color.DarkSlateGray;
            this.servicesCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.servicesCbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.servicesCbx.ForeColor = System.Drawing.Color.Silver;
            this.servicesCbx.FormattingEnabled = true;
            this.servicesCbx.Items.AddRange(new object[] {
            ""});
            this.servicesCbx.Location = new System.Drawing.Point(120, 74);
            this.servicesCbx.Name = "servicesCbx";
            this.servicesCbx.Size = new System.Drawing.Size(315, 29);
            this.servicesCbx.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(-1, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 37);
            this.label10.TabIndex = 4;
            this.label10.Text = "palvelut";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.priceErrLabel);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.priceTxtBox);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.nameTxtBox);
            this.panel1.Controls.Add(this.editServiceBtn);
            this.panel1.ForeColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(194, 380);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 317);
            this.panel1.TabIndex = 24;
            // 
            // priceErrLabel
            // 
            this.priceErrLabel.AutoSize = true;
            this.priceErrLabel.BackColor = System.Drawing.Color.Transparent;
            this.priceErrLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceErrLabel.ForeColor = System.Drawing.Color.Cyan;
            this.priceErrLabel.Location = new System.Drawing.Point(120, 185);
            this.priceErrLabel.Name = "priceErrLabel";
            this.priceErrLabel.Size = new System.Drawing.Size(264, 37);
            this.priceErrLabel.TabIndex = 28;
            this.priceErrLabel.Text = "liian monta numeroa";
            this.priceErrLabel.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(74, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(326, 50);
            this.label8.TabIndex = 27;
            this.label8.Text = "Muokkaa Palvelua";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(53, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Hinta";
            // 
            // priceTxtBox
            // 
            this.priceTxtBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.priceTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceTxtBox.ForeColor = System.Drawing.Color.Silver;
            this.priceTxtBox.Location = new System.Drawing.Point(120, 153);
            this.priceTxtBox.Name = "priceTxtBox";
            this.priceTxtBox.Size = new System.Drawing.Size(290, 29);
            this.priceTxtBox.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(53, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 23);
            this.label11.TabIndex = 16;
            this.label11.Text = "Nimi";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.nameTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTxtBox.ForeColor = System.Drawing.Color.Silver;
            this.nameTxtBox.Location = new System.Drawing.Point(120, 108);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(290, 29);
            this.nameTxtBox.TabIndex = 15;
            // 
            // editServiceBtn
            // 
            this.editServiceBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.editServiceBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editServiceBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.editServiceBtn.Location = new System.Drawing.Point(53, 238);
            this.editServiceBtn.Name = "editServiceBtn";
            this.editServiceBtn.Size = new System.Drawing.Size(357, 34);
            this.editServiceBtn.TabIndex = 14;
            this.editServiceBtn.Text = "Lisää muokkaus";
            this.editServiceBtn.UseVisualStyleBackColor = false;
            // 
            // ServicesUpdateMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ohjelmistotuotanto.Properties.Resources.test3;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.label1);
            this.Name = "ServicesUpdateMenu";
            this.Size = new System.Drawing.Size(804, 736);
            ((System.ComponentModel.ISupportInitialize)(this.prevBtn)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
