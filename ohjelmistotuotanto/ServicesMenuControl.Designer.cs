namespace ohjelmistotuotanto
{
    partial class ServicesMenuControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicesMenuControl));
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
            this.updateBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateBtn.ForeColor = System.Drawing.Color.Silver;
            this.updateBtn.Location = new System.Drawing.Point(189, 443);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(451, 62);
            this.updateBtn.TabIndex = 21;
            this.updateBtn.Text = "Päivitä";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            updateBtn.BackColor = Color.DarkSlateGray;
            updateBtn.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            updateBtn.ForeColor = Color.Silver;
            updateBtn.Location = new Point(189, 443);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(451, 62);
            updateBtn.TabIndex = 21;
            updateBtn.Text = "Päivitä";
            updateBtn.UseVisualStyleBackColor = false;
            // 
            // prevBtn
            // 
            prevBtn.BackColor = Color.Transparent;
            prevBtn.Image = (Image)resources.GetObject("prevBtn.Image");
            prevBtn.Location = new Point(33, 32);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(124, 62);
            prevBtn.TabIndex = 20;
            prevBtn.TabStop = false;
            prevBtn.Click += prevBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Script MT Bold", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(267, 27);
            label1.Name = "label1";
            label1.Size = new Size(253, 77);
            label1.TabIndex = 19;
            label1.Text = "Palvelut";
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.DarkSlateGray;
            searchBtn.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            searchBtn.ForeColor = Color.Silver;
            searchBtn.Location = new Point(189, 147);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(451, 62);
            searchBtn.TabIndex = 18;
            searchBtn.Text = "Hae";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.ForeColor = System.Drawing.Color.Silver;
            this.deleteBtn.Location = new System.Drawing.Point(189, 351);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(451, 62);
            this.deleteBtn.TabIndex = 17;
            this.deleteBtn.Text = "Poista";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            deleteBtn.BackColor = Color.DarkSlateGray;
            deleteBtn.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteBtn.ForeColor = Color.Silver;
            deleteBtn.Location = new Point(189, 351);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(451, 62);
            deleteBtn.TabIndex = 17;
            deleteBtn.Text = "Poista";
            deleteBtn.UseVisualStyleBackColor = false;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addBtn.ForeColor = System.Drawing.Color.Silver;
            this.addBtn.Location = new System.Drawing.Point(189, 249);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(451, 62);
            this.addBtn.TabIndex = 16;
            this.addBtn.Text = "Lisää";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            addBtn.BackColor = Color.DarkSlateGray;
            addBtn.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            addBtn.ForeColor = Color.Silver;
            addBtn.Location = new Point(189, 249);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(451, 62);
            addBtn.TabIndex = 16;
            addBtn.Text = "Lisää";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // ServicesMenuControl
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
            Name = "ServicesMenuControl";
            Size = new Size(804, 736);
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
