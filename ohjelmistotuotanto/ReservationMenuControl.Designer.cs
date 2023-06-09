﻿namespace ohjelmistotuotanto
{
    partial class ReservationMenuControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationMenuControl));
            updateBtn = new Button();
            prevBtn = new PictureBox();
            label1 = new Label();
            searchBtn = new Button();
            deleteBtn = new Button();
            addBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)prevBtn).BeginInit();
            SuspendLayout();
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.DarkSlateGray;
            updateBtn.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            updateBtn.ForeColor = Color.Silver;
            updateBtn.Location = new Point(176, 443);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(451, 62);
            updateBtn.TabIndex = 15;
            updateBtn.Text = "Päivitä";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click_1;
            // 
            // prevBtn
            // 
            prevBtn.BackColor = Color.Transparent;
            prevBtn.Image = (Image)resources.GetObject("prevBtn.Image");
            prevBtn.Location = new Point(33, 32);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(124, 62);
            prevBtn.TabIndex = 14;
            prevBtn.TabStop = false;
            prevBtn.Click += prevBtn_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Script MT Bold", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(254, 27);
            label1.Name = "label1";
            label1.Size = new Size(296, 77);
            label1.TabIndex = 13;
            label1.Text = "Varaukset";
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.DarkSlateGray;
            searchBtn.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            searchBtn.ForeColor = Color.Silver;
            searchBtn.Location = new Point(176, 147);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(451, 62);
            searchBtn.TabIndex = 12;
            searchBtn.Text = "Hae";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click_1;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.DarkSlateGray;
            deleteBtn.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteBtn.ForeColor = Color.Silver;
            deleteBtn.Location = new Point(176, 351);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(451, 62);
            deleteBtn.TabIndex = 11;
            deleteBtn.Text = "Poista";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click_1;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.DarkSlateGray;
            addBtn.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            addBtn.ForeColor = Color.Silver;
            addBtn.Location = new Point(176, 249);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(451, 62);
            addBtn.TabIndex = 10;
            addBtn.Text = "Lisää";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click_1;
            // 
            // ReservationMenuControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(updateBtn);
            Controls.Add(prevBtn);
            Controls.Add(label1);
            Controls.Add(searchBtn);
            Controls.Add(deleteBtn);
            Controls.Add(addBtn);
            Name = "ReservationMenuControl";
            Size = new Size(804, 736);
            Load += ReservationMenuControl_Load_1;
            ((System.ComponentModel.ISupportInitialize)prevBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button updateBtn;
        private PictureBox prevBtn;
        private Label label1;
        private Button searchBtn;
        private Button deleteBtn;
        private Button addBtn;
    }
}
