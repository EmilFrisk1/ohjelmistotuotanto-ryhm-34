﻿namespace ohjelmistotuotanto
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
            this.reservationContainer = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prevBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationContainer)).BeginInit();
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
            this.deleteBtn.Location = new System.Drawing.Point(119, 462);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(567, 62);
            this.deleteBtn.TabIndex = 22;
            this.deleteBtn.Text = "Poista";
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // reservationContainer
            // 
            this.reservationContainer.AllowUserToAddRows = false;
            this.reservationContainer.AllowUserToDeleteRows = false;
            this.reservationContainer.AllowUserToResizeColumns = false;
            this.reservationContainer.AllowUserToResizeRows = false;
            this.reservationContainer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reservationContainer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationContainer.Location = new System.Drawing.Point(119, 149);
            this.reservationContainer.MultiSelect = false;
            this.reservationContainer.Name = "reservationContainer";
            this.reservationContainer.RowTemplate.Height = 25;
            this.reservationContainer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reservationContainer.Size = new System.Drawing.Size(567, 285);
            this.reservationContainer.TabIndex = 21;
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
            // CustomersDeleteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ohjelmistotuotanto.Properties.Resources.test3;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.reservationContainer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prevBtn);
            this.Name = "CustomersDeleteControl";
            this.Size = new System.Drawing.Size(804, 736);
            ((System.ComponentModel.ISupportInitialize)(this.prevBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationContainer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox prevBtn;
        private Label label6;
        private Button deleteBtn;
        private DataGridView reservationContainer;
        private Label label1;
    }
}
