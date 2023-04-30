namespace ohjelmistotuotanto
{
    partial class ServicesRemoveMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicesRemoveMenu));
            panel4 = new Panel();
            serviceErrorLabel = new Label();
            label2 = new Label();
            servicesCbx = new ComboBox();
            label10 = new Label();
            prevBtn = new PictureBox();
            label3 = new Label();
            removeBtn = new Button();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)prevBtn).BeginInit();
            SuspendLayout();
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
            panel4.Location = new Point(178, 157);
            panel4.Name = "panel4";
            panel4.Size = new Size(451, 202);
            panel4.TabIndex = 22;
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
            // prevBtn
            // 
            prevBtn.BackColor = Color.Transparent;
            prevBtn.Image = (Image)resources.GetObject("prevBtn.Image");
            prevBtn.Location = new Point(33, 32);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(124, 62);
            prevBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            prevBtn.TabIndex = 24;
            prevBtn.TabStop = false;
            prevBtn.Click += prevBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Script MT Bold", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(208, 32);
            label3.Name = "label3";
            label3.Size = new Size(407, 77);
            label3.TabIndex = 23;
            label3.Text = "Poista palvelu";
            // 
            // removeBtn
            // 
            removeBtn.BackColor = Color.DarkSlateGray;
            removeBtn.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            removeBtn.ForeColor = Color.Silver;
            removeBtn.Location = new Point(178, 384);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(451, 62);
            removeBtn.TabIndex = 25;
            removeBtn.Text = "Poista";
            removeBtn.UseVisualStyleBackColor = false;
            removeBtn.Click += removeBtn_Click;
            // 
            // ServicesRemoveMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.test3;
            Controls.Add(removeBtn);
            Controls.Add(prevBtn);
            Controls.Add(label3);
            Controls.Add(panel4);
            Name = "ServicesRemoveMenu";
            Size = new Size(804, 736);
            Load += ServicesRemoveMenu_Load;
            VisibleChanged += ServicesRemoveMenu_VisibleChanged;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)prevBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel4;
        private Label serviceErrorLabel;
        private Label label2;
        private ComboBox servicesCbx;
        private Label label10;
        private PictureBox prevBtn;
        private Label label3;
        private Button removeBtn;
    }
}
