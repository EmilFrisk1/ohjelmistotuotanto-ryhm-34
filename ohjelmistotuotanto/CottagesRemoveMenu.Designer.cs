namespace ohjelmistotuotanto
{
    partial class CottagesRemoveMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CottagesRemoveMenu));
            panel1 = new Panel();
            da = new Label();
            label8 = new Label();
            cottageCbx = new ComboBox();
            label1 = new Label();
            cottageTxtBox = new TextBox();
            prevBtn = new PictureBox();
            label3 = new Label();
            removeBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)prevBtn).BeginInit();
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
            panel1.Location = new Point(182, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 186);
            panel1.TabIndex = 15;
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
            prevBtn.TabIndex = 18;
            prevBtn.TabStop = false;
            prevBtn.Click += prevBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Script MT Bold", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(216, 27);
            label3.Name = "label3";
            label3.Size = new Size(363, 77);
            label3.TabIndex = 17;
            label3.Text = "Poista mökki";
            // 
            // removeBtn
            // 
            removeBtn.BackColor = Color.DarkSlateGray;
            removeBtn.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            removeBtn.ForeColor = Color.Silver;
            removeBtn.Location = new Point(182, 358);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(451, 62);
            removeBtn.TabIndex = 26;
            removeBtn.Text = "Poista";
            removeBtn.UseVisualStyleBackColor = false;
            removeBtn.Click += removeBtn_Click;
            // 
            // CottagesRemoveMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.test3;
            Controls.Add(removeBtn);
            Controls.Add(prevBtn);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "CottagesRemoveMenu";
            Size = new Size(804, 736);
            Load += CottagesRemoveMenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)prevBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label da;
        private Label label8;
        private ComboBox cottageCbx;
        private Label label1;
        private TextBox cottageTxtBox;
        private PictureBox prevBtn;
        private Label label3;
        private Button removeBtn;
    }
}
