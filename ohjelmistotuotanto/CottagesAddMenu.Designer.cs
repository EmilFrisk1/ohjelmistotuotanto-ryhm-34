namespace ohjelmistotuotanto
{
    partial class CottagesAddMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CottagesAddMenu));
            prevBtn = new PictureBox();
            panel1 = new Panel();
            squaresErrLbl = new Label();
            priceErrLbl = new Label();
            panel2 = new Panel();
            label9 = new Label();
            areaCbx = new ComboBox();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            cottageNameTxtBox = new TextBox();
            label6 = new Label();
            addressTxtBox = new TextBox();
            label5 = new Label();
            squaresTxtBox = new TextBox();
            label4 = new Label();
            equipmentTxtBox = new TextBox();
            label3 = new Label();
            descriptionTxtBox = new TextBox();
            label2 = new Label();
            priceTxtBox = new TextBox();
            addCustomerBtn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)prevBtn).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            panel1.Controls.Add(squaresErrLbl);
            panel1.Controls.Add(priceErrLbl);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cottageNameTxtBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(addressTxtBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(squaresTxtBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(equipmentTxtBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(descriptionTxtBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(priceTxtBox);
            panel1.Controls.Add(addCustomerBtn);
            panel1.ForeColor = Color.Silver;
            panel1.Location = new Point(181, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 675);
            panel1.TabIndex = 20;
            // 
            // squaresErrLbl
            // 
            squaresErrLbl.AutoSize = true;
            squaresErrLbl.BackColor = Color.Transparent;
            squaresErrLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            squaresErrLbl.ForeColor = Color.Cyan;
            squaresErrLbl.Location = new Point(210, 463);
            squaresErrLbl.Name = "squaresErrLbl";
            squaresErrLbl.Size = new Size(207, 21);
            squaresErrLbl.TabIndex = 30;
            squaresErrLbl.Text = "Vain numerot ja piste sallittu";
            squaresErrLbl.Visible = false;
            // 
            // priceErrLbl
            // 
            priceErrLbl.AutoSize = true;
            priceErrLbl.BackColor = Color.Transparent;
            priceErrLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceErrLbl.ForeColor = Color.Cyan;
            priceErrLbl.Location = new Point(212, 283);
            priceErrLbl.Name = "priceErrLbl";
            priceErrLbl.Size = new Size(207, 21);
            priceErrLbl.TabIndex = 29;
            priceErrLbl.Text = "Vain numerot ja piste sallittu";
            priceErrLbl.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(areaCbx);
            panel2.Controls.Add(label10);
            panel2.ForeColor = Color.Silver;
            panel2.Location = new Point(-2, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(458, 129);
            panel2.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(173, 0);
            label9.Name = "label9";
            label9.Size = new Size(125, 50);
            label9.TabIndex = 12;
            label9.Text = "Alue *";
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(8, 58);
            label10.Name = "label10";
            label10.Size = new Size(95, 37);
            label10.TabIndex = 2;
            label10.Text = "valitse";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(117, 30);
            label8.Name = "label8";
            label8.Size = new Size(209, 50);
            label8.TabIndex = 27;
            label8.Text = "Uusi mökki";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(60, 546);
            label7.Name = "label7";
            label7.Size = new Size(109, 23);
            label7.TabIndex = 26;
            label7.Text = "Mökin nimi *";
            // 
            // cottageNameTxtBox
            // 
            cottageNameTxtBox.BackColor = Color.DarkSlateGray;
            cottageNameTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cottageNameTxtBox.ForeColor = Color.Silver;
            cottageNameTxtBox.Location = new Point(212, 546);
            cottageNameTxtBox.Name = "cottageNameTxtBox";
            cottageNameTxtBox.Size = new Size(205, 29);
            cottageNameTxtBox.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(58, 487);
            label6.Name = "label6";
            label6.Size = new Size(71, 23);
            label6.TabIndex = 24;
            label6.Text = "Osoite *";
            // 
            // addressTxtBox
            // 
            addressTxtBox.BackColor = Color.DarkSlateGray;
            addressTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addressTxtBox.ForeColor = Color.Silver;
            addressTxtBox.Location = new Point(212, 487);
            addressTxtBox.Name = "addressTxtBox";
            addressTxtBox.Size = new Size(205, 29);
            addressTxtBox.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(60, 428);
            label5.Name = "label5";
            label5.Size = new Size(107, 23);
            label5.TabIndex = 22;
            label5.Text = "neliömäärä *";
            // 
            // squaresTxtBox
            // 
            squaresTxtBox.BackColor = Color.DarkSlateGray;
            squaresTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            squaresTxtBox.ForeColor = Color.Silver;
            squaresTxtBox.Location = new Point(212, 428);
            squaresTxtBox.Name = "squaresTxtBox";
            squaresTxtBox.Size = new Size(205, 29);
            squaresTxtBox.TabIndex = 21;
            squaresTxtBox.KeyPress += squaresTxtBox_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(60, 369);
            label4.Name = "label4";
            label4.Size = new Size(86, 23);
            label4.TabIndex = 20;
            label4.Text = "varustus *";
            // 
            // equipmentTxtBox
            // 
            equipmentTxtBox.BackColor = Color.DarkSlateGray;
            equipmentTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            equipmentTxtBox.ForeColor = Color.Silver;
            equipmentTxtBox.Location = new Point(212, 369);
            equipmentTxtBox.Name = "equipmentTxtBox";
            equipmentTxtBox.Size = new Size(205, 29);
            equipmentTxtBox.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(60, 313);
            label3.Name = "label3";
            label3.Size = new Size(77, 23);
            label3.TabIndex = 18;
            label3.Text = "Kuvaus *";
            // 
            // descriptionTxtBox
            // 
            descriptionTxtBox.BackColor = Color.DarkSlateGray;
            descriptionTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionTxtBox.ForeColor = Color.Silver;
            descriptionTxtBox.Location = new Point(212, 310);
            descriptionTxtBox.Name = "descriptionTxtBox";
            descriptionTxtBox.Size = new Size(205, 29);
            descriptionTxtBox.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(60, 251);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 16;
            label2.Text = "Hinta *";
            // 
            // priceTxtBox
            // 
            priceTxtBox.BackColor = Color.DarkSlateGray;
            priceTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceTxtBox.ForeColor = Color.Silver;
            priceTxtBox.Location = new Point(212, 251);
            priceTxtBox.Name = "priceTxtBox";
            priceTxtBox.Size = new Size(205, 29);
            priceTxtBox.TabIndex = 15;
            priceTxtBox.KeyPress += priceTxtBox_KeyPress;
            // 
            // addCustomerBtn
            // 
            addCustomerBtn.BackColor = Color.DarkSlateGray;
            addCustomerBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            addCustomerBtn.ForeColor = Color.WhiteSmoke;
            addCustomerBtn.Location = new Point(58, 605);
            addCustomerBtn.Name = "addCustomerBtn";
            addCustomerBtn.Size = new Size(359, 34);
            addCustomerBtn.TabIndex = 14;
            addCustomerBtn.Text = "lisää";
            addCustomerBtn.UseVisualStyleBackColor = false;
            addCustomerBtn.Click += addCustomerBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Script MT Bold", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(228, 21);
            label1.Name = "label1";
            label1.Size = new Size(348, 77);
            label1.TabIndex = 19;
            label1.Text = "Lisää mökki";
            // 
            // CottagesAddMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.test3;
            Controls.Add(prevBtn);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "CottagesAddMenu";
            Size = new Size(804, 1000);
            Load += CottagesAddMenu_Load;
            VisibleChanged += CottagesAddMenu_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)prevBtn).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox prevBtn;
        private Panel panel1;
        private Label label8;
        private Label label7;
        private TextBox cottageNameTxtBox;
        private Label label6;
        private TextBox addressTxtBox;
        private Label label5;
        private TextBox squaresTxtBox;
        private Label label4;
        private TextBox equipmentTxtBox;
        private Label label3;
        private TextBox descriptionTxtBox;
        private Label label2;
        private TextBox priceTxtBox;
        private Button addCustomerBtn;
        private Label label1;
        private Panel panel2;
        private Label label9;
        private ComboBox areaCbx;
        private Label label10;
        private Label squaresErrLbl;
        private Label priceErrLbl;
    }
}
