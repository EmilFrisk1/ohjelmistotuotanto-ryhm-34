namespace ohjelmistotuotanto
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
            this.updateBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prevBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateBtn.ForeColor = System.Drawing.Color.Silver;
            this.updateBtn.Location = new System.Drawing.Point(189, 445);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(451, 62);
            this.updateBtn.TabIndex = 33;
            this.updateBtn.Text = "Päivitä";
            this.updateBtn.UseVisualStyleBackColor = false;
            // 
            // prevBtn
            // 
            this.prevBtn.BackColor = System.Drawing.Color.Transparent;
            this.prevBtn.Image = ((System.Drawing.Image)(resources.GetObject("prevBtn.Image")));
            this.prevBtn.Location = new System.Drawing.Point(33, 32);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(124, 62);
            this.prevBtn.TabIndex = 32;
            this.prevBtn.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(305, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 77);
            this.label1.TabIndex = 31;
            this.label1.Text = "Alueet";
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBtn.ForeColor = System.Drawing.Color.Silver;
            this.searchBtn.Location = new System.Drawing.Point(189, 146);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(451, 62);
            this.searchBtn.TabIndex = 30;
            this.searchBtn.Text = "Hae";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click_1);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.ForeColor = System.Drawing.Color.Silver;
            this.deleteBtn.Location = new System.Drawing.Point(189, 353);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(451, 62);
            this.deleteBtn.TabIndex = 29;
            this.deleteBtn.Text = "Poista";
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addBtn.ForeColor = System.Drawing.Color.Silver;
            this.addBtn.Location = new System.Drawing.Point(189, 251);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(451, 62);
            this.addBtn.TabIndex = 28;
            this.addBtn.Text = "Lisää";
            this.addBtn.UseVisualStyleBackColor = false;
            // 
            // AreasRootMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ohjelmistotuotanto.Properties.Resources.test3;
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Name = "AreasRootMenu";
            this.Size = new System.Drawing.Size(804, 736);
            ((System.ComponentModel.ISupportInitialize)(this.prevBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
