namespace ohjelmistotuotanto
{
    partial class AreaSearchControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreaSearchControl));
            this.prevBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchGrid = new System.Windows.Forms.DataGridView();
            this.searchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prevBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // prevBtn
            // 
            this.prevBtn.BackColor = System.Drawing.Color.Transparent;
            this.prevBtn.Image = ((System.Drawing.Image)(resources.GetObject("prevBtn.Image")));
            this.prevBtn.Location = new System.Drawing.Point(33, 32);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(124, 62);
            this.prevBtn.TabIndex = 33;
            this.prevBtn.TabStop = false;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(245, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 77);
            this.label1.TabIndex = 34;
            this.label1.Text = "Hae alueet";
            // 
            // searchGrid
            // 
            this.searchGrid.AllowUserToAddRows = false;
            this.searchGrid.AllowUserToDeleteRows = false;
            this.searchGrid.AllowUserToResizeColumns = false;
            this.searchGrid.AllowUserToResizeRows = false;
            this.searchGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchGrid.Location = new System.Drawing.Point(119, 149);
            this.searchGrid.MultiSelect = false;
            this.searchGrid.Name = "searchGrid";
            this.searchGrid.RowTemplate.Height = 25;
            this.searchGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchGrid.Size = new System.Drawing.Size(567, 285);
            this.searchGrid.TabIndex = 35;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBtn.ForeColor = System.Drawing.Color.Silver;
            this.searchBtn.Location = new System.Drawing.Point(119, 462);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(567, 62);
            this.searchBtn.TabIndex = 36;
            this.searchBtn.Text = "Hae";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // AreaSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ohjelmistotuotanto.Properties.Resources.test3;
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prevBtn);
            this.Name = "AreaSearchControl";
            this.Size = new System.Drawing.Size(804, 736);
            ((System.ComponentModel.ISupportInitialize)(this.prevBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox prevBtn;
        private Label label1;
        private DataGridView searchGrid;
        private Button searchBtn;
    }
}
