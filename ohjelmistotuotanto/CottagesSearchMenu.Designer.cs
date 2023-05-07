namespace ohjelmistotuotanto
{
    partial class CottagesSearchMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CottagesSearchMenu));
            panel1 = new Panel();
            label8 = new Label();
            areaCbx = new ComboBox();
            label2 = new Label();
            prevBtn = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            highPriceTxtBox = new TextBox();
            label6 = new Label();
            lowPriceTxtBox = new TextBox();
            label3 = new Label();
            searchBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)prevBtn).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(areaCbx);
            panel1.Controls.Add(label2);
            panel1.ForeColor = Color.Silver;
            panel1.Location = new Point(172, 147);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 129);
            panel1.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(173, 0);
            label8.Name = "label8";
            label8.Size = new Size(99, 50);
            label8.TabIndex = 12;
            label8.Text = "Alue";
            // 
            // areaCbx
            // 
            areaCbx.BackColor = Color.DarkSlateGray;
            areaCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            areaCbx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            areaCbx.ForeColor = Color.Silver;
            areaCbx.FormattingEnabled = true;
            areaCbx.Location = new Point(114, 66);
            areaCbx.Name = "areaCbx";
            areaCbx.Size = new Size(315, 29);
            areaCbx.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(8, 58);
            label2.Name = "label2";
            label2.Size = new Size(95, 37);
            label2.TabIndex = 2;
            label2.Text = "valitse";
            // 
            // prevBtn
            // 
            prevBtn.BackColor = Color.Transparent;
            prevBtn.Image = (Image)resources.GetObject("prevBtn.Image");
            prevBtn.Location = new Point(33, 32);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(124, 62);
            prevBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            prevBtn.TabIndex = 26;
            prevBtn.TabStop = false;
            prevBtn.Click += prevBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Script MT Bold", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(246, 18);
            label1.Name = "label1";
            label1.Size = new Size(313, 77);
            label1.TabIndex = 25;
            label1.Text = "Hae mökki";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(highPriceTxtBox);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(lowPriceTxtBox);
            panel2.Controls.Add(label3);
            panel2.ForeColor = Color.Silver;
            panel2.Location = new Point(177, 304);
            panel2.Name = "panel2";
            panel2.Size = new Size(451, 141);
            panel2.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(239, 58);
            label5.Name = "label5";
            label5.Size = new Size(68, 23);
            label5.TabIndex = 22;
            label5.Text = "Korkein";
            // 
            // highPriceTxtBox
            // 
            highPriceTxtBox.BackColor = Color.DarkSlateGray;
            highPriceTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            highPriceTxtBox.ForeColor = Color.Silver;
            highPriceTxtBox.Location = new Point(239, 84);
            highPriceTxtBox.Name = "highPriceTxtBox";
            highPriceTxtBox.Size = new Size(185, 29);
            highPriceTxtBox.TabIndex = 21;
            highPriceTxtBox.KeyPress += highPriceTxtBox_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(28, 58);
            label6.Name = "label6";
            label6.Size = new Size(39, 23);
            label6.TabIndex = 20;
            label6.Text = "Alin";
            // 
            // lowPriceTxtBox
            // 
            lowPriceTxtBox.BackColor = Color.DarkSlateGray;
            lowPriceTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lowPriceTxtBox.ForeColor = Color.Silver;
            lowPriceTxtBox.Location = new Point(28, 84);
            lowPriceTxtBox.Name = "lowPriceTxtBox";
            lowPriceTxtBox.Size = new Size(190, 29);
            lowPriceTxtBox.TabIndex = 19;
            lowPriceTxtBox.KeyPress += lowPriceTxtBox_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(173, 0);
            label3.Name = "label3";
            label3.Size = new Size(113, 50);
            label3.TabIndex = 12;
            label3.Text = "Hinta";
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.DarkSlateGray;
            searchBtn.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            searchBtn.ForeColor = Color.WhiteSmoke;
            searchBtn.Location = new Point(177, 474);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(451, 62);
            searchBtn.TabIndex = 29;
            searchBtn.Text = "Hae mökki";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // CottagesSearchMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.test3;
            Controls.Add(searchBtn);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(prevBtn);
            Controls.Add(label1);
            Name = "CottagesSearchMenu";
            Size = new Size(804, 736);
            Load += CottagesSearchMenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)prevBtn).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label8;
        private ComboBox areaCbx;
        private Label label2;
        private PictureBox prevBtn;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private Label label5;
        private TextBox highPriceTxtBox;
        private Label label6;
        private TextBox lowPriceTxtBox;
        private Button searchBtn;
    }
}
