﻿namespace ohjelmistotuotanto
{
    partial class DisplaySearchResultsMenuControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplaySearchResultsMenuControl));
            label1 = new Label();
            searchResultsContainer = new DataGridView();
            prevBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)searchResultsContainer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)prevBtn).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Script MT Bold", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(210, 17);
            label1.Name = "label1";
            label1.Size = new Size(385, 77);
            label1.TabIndex = 3;
            label1.Text = "Hakutulokset";
            // 
            // searchResultsContainer
            // 
            searchResultsContainer.AllowUserToAddRows = false;
            searchResultsContainer.AllowUserToDeleteRows = false;
            searchResultsContainer.AllowUserToResizeColumns = false;
            searchResultsContainer.AllowUserToResizeRows = false;
            searchResultsContainer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            searchResultsContainer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchResultsContainer.Location = new Point(117, 149);
            searchResultsContainer.MultiSelect = false;
            searchResultsContainer.Name = "searchResultsContainer";
            searchResultsContainer.RowTemplate.Height = 25;
            searchResultsContainer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            searchResultsContainer.Size = new Size(567, 285);
            searchResultsContainer.TabIndex = 4;
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
            // DisplaySearchResultsMenuControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.test3;
            Controls.Add(prevBtn);
            Controls.Add(searchResultsContainer);
            Controls.Add(label1);
            Name = "DisplaySearchResultsMenuControl";
            Size = new Size(804, 736);
            Load += DisplaySearchResultsMenuControl_Load;
            ((System.ComponentModel.ISupportInitialize)searchResultsContainer).EndInit();
            ((System.ComponentModel.ISupportInitialize)prevBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView searchResultsContainer;
        private PictureBox prevBtn;
    }
}
