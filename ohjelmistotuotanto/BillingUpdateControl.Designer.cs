namespace ohjelmistotuotanto
{
    partial class BillingUpdateControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingUpdateControl));
            label3 = new Label();
            label6 = new Label();
            billsDataGridView = new DataGridView();
            prevBtn = new PictureBox();
            panel1 = new Panel();
            billsCbx = new ComboBox();
            label8 = new Label();
            label11 = new Label();
            editBillBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)billsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)prevBtn).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Script MT Bold", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(213, 18);
            label3.Name = "label3";
            label3.Size = new Size(378, 77);
            label3.TabIndex = 20;
            label3.Text = "Päivitä lasku";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(176, 109);
            label6.Name = "label6";
            label6.Size = new Size(452, 37);
            label6.TabIndex = 24;
            label6.Text = "Valitse lasku, minkä haluat päivittää";
            // 
            // billsDataGridView
            // 
            billsDataGridView.AllowUserToAddRows = false;
            billsDataGridView.AllowUserToDeleteRows = false;
            billsDataGridView.AllowUserToResizeColumns = false;
            billsDataGridView.AllowUserToResizeRows = false;
            billsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            billsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            billsDataGridView.Location = new Point(117, 149);
            billsDataGridView.MultiSelect = false;
            billsDataGridView.Name = "billsDataGridView";
            billsDataGridView.RowTemplate.Height = 25;
            billsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            billsDataGridView.Size = new Size(567, 285);
            billsDataGridView.TabIndex = 23;
            billsDataGridView.CellClick += billsDataGridView_CellClick;
            // 
            // prevBtn
            // 
            prevBtn.BackColor = Color.Transparent;
            prevBtn.Image = (Image)resources.GetObject("prevBtn.Image");
            prevBtn.Location = new Point(33, 32);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(124, 62);
            prevBtn.TabIndex = 21;
            prevBtn.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(billsCbx);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(editBillBtn);
            panel1.ForeColor = Color.Silver;
            panel1.Location = new Point(176, 456);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 218);
            panel1.TabIndex = 26;
            // 
            // billsCbx
            // 
            billsCbx.BackColor = Color.DarkSlateGray;
            billsCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            billsCbx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            billsCbx.ForeColor = Color.Silver;
            billsCbx.FormattingEnabled = true;
            billsCbx.Items.AddRange(new object[] { "Maksamaton", "Maksettu", "Peruutettu" });
            billsCbx.Location = new Point(124, 102);
            billsCbx.Name = "billsCbx";
            billsCbx.Size = new Size(267, 29);
            billsCbx.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(74, 30);
            label8.Name = "label8";
            label8.Size = new Size(237, 50);
            label8.TabIndex = 27;
            label8.Text = "Päivitä Lasku";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.WhiteSmoke;
            label11.Location = new Point(53, 108);
            label11.Name = "label11";
            label11.Size = new Size(65, 23);
            label11.TabIndex = 16;
            label11.Text = "Tilanne";
            // 
            // editBillBtn
            // 
            editBillBtn.BackColor = Color.DarkSlateGray;
            editBillBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            editBillBtn.ForeColor = Color.WhiteSmoke;
            editBillBtn.Location = new Point(53, 160);
            editBillBtn.Name = "editBillBtn";
            editBillBtn.Size = new Size(357, 34);
            editBillBtn.TabIndex = 14;
            editBillBtn.Text = "Lisää muokkaus";
            editBillBtn.UseVisualStyleBackColor = false;
            editBillBtn.Click += editBillBtn_Click;
            // 
            // BillingUpdateControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.test3;
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(billsDataGridView);
            Controls.Add(prevBtn);
            Controls.Add(label3);
            Name = "BillingUpdateControl";
            Size = new Size(804, 736);
            Load += BillingUpdateControl_Load;
            ((System.ComponentModel.ISupportInitialize)billsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)prevBtn).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label6;
        private DataGridView billsDataGridView;
        private PictureBox prevBtn;
        private Panel panel1;
        private Label label8;
        private Label label11;
        private Button editBillBtn;
        private ComboBox billsCbx;
    }
}
