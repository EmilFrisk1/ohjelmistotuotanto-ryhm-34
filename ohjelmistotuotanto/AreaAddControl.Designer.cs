namespace ohjelmistotuotanto
{
    partial class AreaAddControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreaAddControl));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.addAreaBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prevBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(248, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 77);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lisää alue";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nameTxtBox);
            this.panel1.Controls.Add(this.addAreaBtn);
            this.panel1.ForeColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(173, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 235);
            this.panel1.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(140, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 50);
            this.label8.TabIndex = 27;
            this.label8.Text = "Uusi alue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(53, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nimi *";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.nameTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTxtBox.ForeColor = System.Drawing.Color.Silver;
            this.nameTxtBox.Location = new System.Drawing.Point(205, 108);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(205, 29);
            this.nameTxtBox.TabIndex = 15;
            // 
            // addAreaBtn
            // 
            this.addAreaBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addAreaBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addAreaBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addAreaBtn.Location = new System.Drawing.Point(51, 170);
            this.addAreaBtn.Name = "addAreaBtn";
            this.addAreaBtn.Size = new System.Drawing.Size(359, 34);
            this.addAreaBtn.TabIndex = 14;
            this.addAreaBtn.Text = "lisää";
            this.addAreaBtn.UseVisualStyleBackColor = false;
            this.addAreaBtn.Click += new System.EventHandler(this.addAreaBtn_Click);
            // 
            // prevBtn
            // 
            this.prevBtn.BackColor = System.Drawing.Color.Transparent;
            this.prevBtn.Image = ((System.Drawing.Image)(resources.GetObject("prevBtn.Image")));
            this.prevBtn.Location = new System.Drawing.Point(33, 32);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(124, 62);
            this.prevBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prevBtn.TabIndex = 22;
            this.prevBtn.TabStop = false;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // AreaAddControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ohjelmistotuotanto.Properties.Resources.test3;
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "AreaAddControl";
            this.Size = new System.Drawing.Size(804, 736);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prevBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label8;
        private Label label2;
        private TextBox nameTxtBox;
        private Button addAreaBtn;
        private PictureBox prevBtn;
    }
}
