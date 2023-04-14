namespace ohjelmistotuotanto
{
    partial class CustomersMenuControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersMenuControl));
            this.aBtn2 = new System.Windows.Forms.Button();
            this.aBtn3 = new System.Windows.Forms.Button();
            this.aBtn1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aBtn4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // aBtn2
            // 
            this.aBtn2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.aBtn2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aBtn2.ForeColor = System.Drawing.Color.Silver;
            this.aBtn2.Location = new System.Drawing.Point(176, 238);
            this.aBtn2.Name = "aBtn2";
            this.aBtn2.Size = new System.Drawing.Size(451, 62);
            this.aBtn2.TabIndex = 2;
            this.aBtn2.Text = "Lisää";
            this.aBtn2.UseVisualStyleBackColor = false;
            this.aBtn2.Click += new System.EventHandler(this.aBtn2_Click);
            // 
            // aBtn3
            // 
            this.aBtn3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.aBtn3.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aBtn3.ForeColor = System.Drawing.Color.Silver;
            this.aBtn3.Location = new System.Drawing.Point(177, 340);
            this.aBtn3.Name = "aBtn3";
            this.aBtn3.Size = new System.Drawing.Size(451, 62);
            this.aBtn3.TabIndex = 4;
            this.aBtn3.Text = "Poista";
            this.aBtn3.UseVisualStyleBackColor = false;
            // 
            // aBtn1
            // 
            this.aBtn1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.aBtn1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aBtn1.ForeColor = System.Drawing.Color.Silver;
            this.aBtn1.Location = new System.Drawing.Point(176, 136);
            this.aBtn1.Name = "aBtn1";
            this.aBtn1.Size = new System.Drawing.Size(451, 62);
            this.aBtn1.TabIndex = 5;
            this.aBtn1.Text = "Hae";
            this.aBtn1.UseVisualStyleBackColor = false;
            this.aBtn1.Click += new System.EventHandler(this.aBtn1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(254, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 77);
            this.label1.TabIndex = 7;
            this.label1.Text = "Asiakkaat";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 62);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // aBtn4
            // 
            this.aBtn4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.aBtn4.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aBtn4.ForeColor = System.Drawing.Color.Silver;
            this.aBtn4.Location = new System.Drawing.Point(177, 432);
            this.aBtn4.Name = "aBtn4";
            this.aBtn4.Size = new System.Drawing.Size(451, 62);
            this.aBtn4.TabIndex = 9;
            this.aBtn4.Text = "Päivitä";
            this.aBtn4.UseVisualStyleBackColor = false;
            // 
            // CustomersMenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.aBtn4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aBtn1);
            this.Controls.Add(this.aBtn3);
            this.Controls.Add(this.aBtn2);
            this.Name = "CustomersMenuControl";
            this.Size = new System.Drawing.Size(804, 736);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button aBtn2;
        private Button aBtn3;
        private Button aBtn1;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button aBtn4;
    }
}
