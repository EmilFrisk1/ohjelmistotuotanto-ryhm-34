﻿namespace ohjelmistotuotanto
{
    partial class AreasRootMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreasRootMenu));
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
            updateBtn.Location = new Point(189, 445);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(451, 62);
            updateBtn.TabIndex = 33;
            updateBtn.Text = "Päivitä";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // prevBtn
            // 
            prevBtn.BackColor = Color.Transparent;
            prevBtn.Image = (Image)resources.GetObject("prevBtn.Image");
            prevBtn.Location = new Point(33, 32);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(124, 62);
            prevBtn.TabIndex = 32;
            prevBtn.TabStop = false;
            prevBtn.Click += prevBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Script MT Bold", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(276, 29);
            label1.Name = "label1";
            label1.Size = new Size(194, 77);
            label1.TabIndex = 31;
            label1.Text = "Alueet";
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.DarkSlateGray;
            searchBtn.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            searchBtn.ForeColor = Color.Silver;
            searchBtn.Location = new Point(189, 146);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(451, 62);
            searchBtn.TabIndex = 30;
            searchBtn.Text = "Hae";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.DarkSlateGray;
            deleteBtn.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteBtn.ForeColor = Color.Silver;
            deleteBtn.Location = new Point(189, 353);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(451, 62);
            deleteBtn.TabIndex = 29;
            deleteBtn.Text = "Poista";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.DarkSlateGray;
            addBtn.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            addBtn.ForeColor = Color.Silver;
            addBtn.Location = new Point(189, 251);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(451, 62);
            addBtn.TabIndex = 28;
            addBtn.Text = "Lisää";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // AreasRootMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.test3;
            Controls.Add(updateBtn);
            Controls.Add(prevBtn);
            Controls.Add(label1);
            Controls.Add(searchBtn);
            Controls.Add(deleteBtn);
            Controls.Add(addBtn);
            Name = "AreasRootMenu";
            Size = new Size(804, 736);
            Load += AreasRootMenu_Load;
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