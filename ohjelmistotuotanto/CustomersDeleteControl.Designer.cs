namespace ohjelmistotuotanto
{
    partial class CustomersDeleteControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersDeleteControl));
            this.prevBtn = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.customerErrorLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerCbx = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prevBtn)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // prevBtn
            // 
            this.prevBtn.BackColor = System.Drawing.Color.Transparent;
            this.prevBtn.Image = ((System.Drawing.Image)(resources.GetObject("prevBtn.Image")));
            this.prevBtn.Location = new System.Drawing.Point(33, 32);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(124, 62);
            this.prevBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prevBtn.TabIndex = 19;
            this.prevBtn.TabStop = false;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(176, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(451, 37);
            this.label6.TabIndex = 23;
            this.label6.Text = "Valitse asiakas, jonka haluat poistaa";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.ForeColor = System.Drawing.Color.Silver;
            this.deleteBtn.Location = new System.Drawing.Point(176, 395);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(451, 62);
            this.deleteBtn.TabIndex = 22;
            this.deleteBtn.Text = "Poista";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click_1);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(197, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 77);
            this.label1.TabIndex = 20;
            this.label1.Text = "Poista asiakas";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.customerErrorLabel);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.customerCbx);
            this.panel4.Controls.Add(this.label10);
            this.panel4.ForeColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(176, 167);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(451, 202);
            this.panel4.TabIndex = 24;
            // 
            // customerErrorLabel
            // 
            this.customerErrorLabel.AutoSize = true;
            this.customerErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.customerErrorLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerErrorLabel.ForeColor = System.Drawing.Color.Cyan;
            this.customerErrorLabel.Location = new System.Drawing.Point(103, 135);
            this.customerErrorLabel.Name = "customerErrorLabel";
            this.customerErrorLabel.Size = new System.Drawing.Size(250, 37);
            this.customerErrorLabel.TabIndex = 23;
            this.customerErrorLabel.Text = "Valitse jokin asiakas";
            this.customerErrorLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(145, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 50);
            this.label2.TabIndex = 12;
            this.label2.Text = "Asiakas";
            // 
            // customerCbx
            // 
            this.customerCbx.BackColor = System.Drawing.Color.DarkSlateGray;
            this.customerCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerCbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerCbx.ForeColor = System.Drawing.Color.Silver;
            this.customerCbx.FormattingEnabled = true;
            this.customerCbx.Items.AddRange(new object[] {
            ""});
            this.customerCbx.Location = new System.Drawing.Point(120, 74);
            this.customerCbx.Name = "customerCbx";
            this.customerCbx.Size = new System.Drawing.Size(315, 29);
            this.customerCbx.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(-1, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 37);
            this.label10.TabIndex = 4;
            this.label10.Text = "Asiakas";
            // 
            // CustomersDeleteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ohjelmistotuotanto.Properties.Resources.test3;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prevBtn);
            this.Name = "CustomersDeleteControl";
            this.Size = new System.Drawing.Size(804, 736);
            this.Load += new System.EventHandler(this.CustomersDeleteControl_Load);
            this.VisibleChanged += new System.EventHandler(this.CustomersDeleteControl_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.prevBtn)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox prevBtn;
        private Label label6;
        private Button deleteBtn;
        private Label label1;
        private Panel panel4;
        private Label customerErrorLabel;
        private Label label2;
        private ComboBox customerCbx;
        private Label label10;
    }
}
