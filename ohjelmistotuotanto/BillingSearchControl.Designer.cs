namespace ohjelmistotuotanto
{
    partial class BillingSearchControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingSearchControl));
            label1 = new Label();
            searchBtn = new Button();
            searchGrid = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)searchGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Script MT Bold", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(240, 18);
            label1.Name = "label1";
            label1.Size = new Size(324, 77);
            label1.TabIndex = 18;
            label1.Text = "Hae laskut";
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.DarkSlateGray;
            searchBtn.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            searchBtn.ForeColor = Color.Silver;
            searchBtn.Location = new Point(117, 462);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(567, 62);
            searchBtn.TabIndex = 17;
            searchBtn.Text = "Hae";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // searchGrid
            // 
            searchGrid.AllowUserToAddRows = false;
            searchGrid.AllowUserToDeleteRows = false;
            searchGrid.AllowUserToResizeColumns = false;
            searchGrid.AllowUserToResizeRows = false;
            searchGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            searchGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchGrid.Location = new Point(117, 149);
            searchGrid.MultiSelect = false;
            searchGrid.Name = "searchGrid";
            searchGrid.RowTemplate.Height = 25;
            searchGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            searchGrid.Size = new Size(567, 285);
            searchGrid.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 62);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // BillingSearchControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.test3;
            Controls.Add(label1);
            Controls.Add(searchBtn);
            Controls.Add(searchGrid);
            Controls.Add(pictureBox1);
            Name = "BillingSearchControl";
            Size = new Size(804, 736);
            Load += BillingSearchControl_Load;
            ((System.ComponentModel.ISupportInitialize)searchGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button searchBtn;
        private DataGridView searchGrid;
        private PictureBox pictureBox1;
    }
}
