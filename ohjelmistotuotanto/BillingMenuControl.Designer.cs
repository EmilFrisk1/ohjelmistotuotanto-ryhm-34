﻿namespace ohjelmistotuotanto
{
    partial class BillingMenuControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingMenuControl));
            this.LaskuLabel1 = new System.Windows.Forms.Label();
            this.BillingSearchBtn = new System.Windows.Forms.Button();
            this.BillingUpdateBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.prevBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // LaskuLabel1
            // 
            this.LaskuLabel1.AutoSize = true;
            this.LaskuLabel1.BackColor = System.Drawing.Color.Transparent;
            this.LaskuLabel1.Font = new System.Drawing.Font("Script MT Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LaskuLabel1.ForeColor = System.Drawing.Color.Silver;
            this.LaskuLabel1.Location = new System.Drawing.Point(293, 18);
            this.LaskuLabel1.Name = "LaskuLabel1";
            this.LaskuLabel1.Size = new System.Drawing.Size(215, 77);
            this.LaskuLabel1.TabIndex = 0;
            this.LaskuLabel1.Text = "Laskut";
            // 
            // BillingSearchBtn
            // 
            this.BillingSearchBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BillingSearchBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BillingSearchBtn.ForeColor = System.Drawing.Color.Silver;
            this.BillingSearchBtn.Location = new System.Drawing.Point(176, 150);
            this.BillingSearchBtn.Name = "BillingSearchBtn";
            this.BillingSearchBtn.Size = new System.Drawing.Size(451, 62);
            this.BillingSearchBtn.TabIndex = 1;
            this.BillingSearchBtn.Text = "Hae";
            this.BillingSearchBtn.UseVisualStyleBackColor = false;
            this.BillingSearchBtn.Click += new System.EventHandler(this.BillingSearchBtn_Click);
            // 
            // BillingUpdateBtn
            // 
            this.BillingUpdateBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BillingUpdateBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BillingUpdateBtn.ForeColor = System.Drawing.Color.Silver;
            this.BillingUpdateBtn.Location = new System.Drawing.Point(176, 262);
            this.BillingUpdateBtn.Name = "BillingUpdateBtn";
            this.BillingUpdateBtn.Size = new System.Drawing.Size(451, 62);
            this.BillingUpdateBtn.TabIndex = 3;
            this.BillingUpdateBtn.Text = "Päivitä";
            this.BillingUpdateBtn.UseVisualStyleBackColor = false;
            this.BillingUpdateBtn.Click += new System.EventHandler(this.BillingUpdateBtn_Click);
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
            // BillingMenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ohjelmistotuotanto.Properties.Resources.test3;
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.BillingUpdateBtn);
            this.Controls.Add(this.BillingSearchBtn);
            this.Controls.Add(this.LaskuLabel1);
            this.Name = "BillingMenuControl";
            this.Size = new System.Drawing.Size(804, 736);
            ((System.ComponentModel.ISupportInitialize)(this.prevBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LaskuLabel1;
        private Button BillingSearchBtn;
        private Button BillingUpdateBtn;
        private PictureBox prevBtn;
    }
}
