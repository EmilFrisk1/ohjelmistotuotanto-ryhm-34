namespace ohjelmistotuotanto
{
    partial class MainMenuControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuControl));
            this.label1 = new System.Windows.Forms.Label();
            this.reservationsBtn = new System.Windows.Forms.Button();
            this.servicesBtn = new System.Windows.Forms.Button();
            this.billsBtn = new System.Windows.Forms.Button();
            this.customersBtn = new System.Windows.Forms.Button();
            this.areasBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(176, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Village Newbies";
            // 
            // reservationsBtn
            // 
            this.reservationsBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.reservationsBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reservationsBtn.ForeColor = System.Drawing.Color.Silver;
            this.reservationsBtn.Location = new System.Drawing.Point(176, 136);
            this.reservationsBtn.Name = "reservationsBtn";
            this.reservationsBtn.Size = new System.Drawing.Size(451, 62);
            this.reservationsBtn.TabIndex = 1;
            this.reservationsBtn.Text = "Varaukset";
            this.reservationsBtn.UseVisualStyleBackColor = false;
            // 
            // servicesBtn
            // 
            this.servicesBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.servicesBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.servicesBtn.ForeColor = System.Drawing.Color.Silver;
            this.servicesBtn.Location = new System.Drawing.Point(176, 238);
            this.servicesBtn.Name = "servicesBtn";
            this.servicesBtn.Size = new System.Drawing.Size(451, 62);
            this.servicesBtn.TabIndex = 2;
            this.servicesBtn.Text = "Palvelut";
            this.servicesBtn.UseVisualStyleBackColor = false;
            // 
            // billsBtn
            // 
            this.billsBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.billsBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.billsBtn.ForeColor = System.Drawing.Color.Silver;
            this.billsBtn.Location = new System.Drawing.Point(177, 340);
            this.billsBtn.Name = "billsBtn";
            this.billsBtn.Size = new System.Drawing.Size(451, 62);
            this.billsBtn.TabIndex = 3;
            this.billsBtn.Text = "Laskut";
            this.billsBtn.UseVisualStyleBackColor = false;
            // 
            // customersBtn
            // 
            this.customersBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.customersBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customersBtn.ForeColor = System.Drawing.Color.Silver;
            this.customersBtn.Location = new System.Drawing.Point(176, 442);
            this.customersBtn.Name = "customersBtn";
            this.customersBtn.Size = new System.Drawing.Size(451, 62);
            this.customersBtn.TabIndex = 4;
            this.customersBtn.Text = "Asiakkaat";
            this.customersBtn.UseVisualStyleBackColor = false;
            this.customersBtn.Click += new System.EventHandler(this.customersBtn_Click);
            // 
            // areasBtn
            // 
            this.areasBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.areasBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.areasBtn.ForeColor = System.Drawing.Color.Silver;
            this.areasBtn.Location = new System.Drawing.Point(176, 544);
            this.areasBtn.Name = "areasBtn";
            this.areasBtn.Size = new System.Drawing.Size(451, 62);
            this.areasBtn.TabIndex = 5;
            this.areasBtn.Text = "Alueet";
            this.areasBtn.UseVisualStyleBackColor = false;
            // 
            // MainMenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.areasBtn);
            this.Controls.Add(this.customersBtn);
            this.Controls.Add(this.billsBtn);
            this.Controls.Add(this.servicesBtn);
            this.Controls.Add(this.reservationsBtn);
            this.Controls.Add(this.label1);
            this.Name = "MainMenuControl";
            this.Size = new System.Drawing.Size(804, 736);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button reservationsBtn;
        private Button servicesBtn;
        private Button billsBtn;
        private Button customersBtn;
        private Button areasBtn;
    }
}
