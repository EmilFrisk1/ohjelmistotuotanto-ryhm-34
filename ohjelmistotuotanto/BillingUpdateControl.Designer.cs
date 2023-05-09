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
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.billsDataGridView = new System.Windows.Forms.DataGridView();
            this.prevBtn = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.editBillBtn = new System.Windows.Forms.Button();
            this.billsCbx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.billsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevBtn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(213, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(378, 77);
            this.label3.TabIndex = 20;
            this.label3.Text = "Päivitä lasku";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(176, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(452, 37);
            this.label6.TabIndex = 24;
            this.label6.Text = "Valitse lasku, minkä haluat päivittää";
            // 
            // billsDataGridView
            // 
            this.billsDataGridView.AllowUserToAddRows = false;
            this.billsDataGridView.AllowUserToDeleteRows = false;
            this.billsDataGridView.AllowUserToResizeColumns = false;
            this.billsDataGridView.AllowUserToResizeRows = false;
            this.billsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billsDataGridView.Location = new System.Drawing.Point(117, 149);
            this.billsDataGridView.MultiSelect = false;
            this.billsDataGridView.Name = "billsDataGridView";
            this.billsDataGridView.RowTemplate.Height = 25;
            this.billsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.billsDataGridView.Size = new System.Drawing.Size(567, 285);
            this.billsDataGridView.TabIndex = 23;
            this.billsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billsDataGridView_CellClick);
            // 
            // prevBtn
            // 
            this.prevBtn.BackColor = System.Drawing.Color.Transparent;
            this.prevBtn.Image = ((System.Drawing.Image)(resources.GetObject("prevBtn.Image")));
            this.prevBtn.Location = new System.Drawing.Point(33, 32);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(124, 62);
            this.prevBtn.TabIndex = 21;
            this.prevBtn.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.billsCbx);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.editBillBtn);
            this.panel1.ForeColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(176, 456);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 218);
            this.panel1.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(74, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 50);
            this.label8.TabIndex = 27;
            this.label8.Text = "Päivitä Lasku";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(53, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 23);
            this.label11.TabIndex = 16;
            this.label11.Text = "Tilanne";
            // 
            // editBillBtn
            // 
            this.editBillBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.editBillBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editBillBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.editBillBtn.Location = new System.Drawing.Point(53, 160);
            this.editBillBtn.Name = "editBillBtn";
            this.editBillBtn.Size = new System.Drawing.Size(357, 34);
            this.editBillBtn.TabIndex = 14;
            this.editBillBtn.Text = "Lisää muokkaus";
            this.editBillBtn.UseVisualStyleBackColor = false;
            // 
            // billsCbx
            // 
            this.billsCbx.BackColor = System.Drawing.Color.DarkSlateGray;
            this.billsCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.billsCbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.billsCbx.ForeColor = System.Drawing.Color.Silver;
            this.billsCbx.FormattingEnabled = true;
            this.billsCbx.Items.AddRange(new object[] {
            ""});
            this.billsCbx.Location = new System.Drawing.Point(124, 102);
            this.billsCbx.Name = "billsCbx";
            this.billsCbx.Size = new System.Drawing.Size(267, 29);
            this.billsCbx.TabIndex = 28;
            // 
            // BillingUpdateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ohjelmistotuotanto.Properties.Resources.test3;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.billsDataGridView);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.label3);
            this.Name = "BillingUpdateControl";
            this.Size = new System.Drawing.Size(804, 736);
            this.Load += new System.EventHandler(this.BillingUpdateControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
