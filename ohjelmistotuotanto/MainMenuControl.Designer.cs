namespace ohjelmistotuotanto
{
    partial class MainMenuControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuControl));
            label1 = new Label();
            reservationsBtn = new Button();
            servicesBtn = new Button();
            billsBtn = new Button();
            customersBtn = new Button();
            areasBtn = new Button();
            button1 = new Button();
            testContainer = new DataGridView();
            cottagesBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)testContainer).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Script MT Bold", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(176, 17);
            label1.Name = "label1";
            label1.Size = new Size(451, 77);
            label1.TabIndex = 0;
            label1.Text = "Village Newbies";
            // 
            // reservationsBtn
            // 
            reservationsBtn.BackColor = Color.DarkSlateGray;
            reservationsBtn.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            reservationsBtn.ForeColor = Color.Silver;
            reservationsBtn.Location = new Point(176, 136);
            reservationsBtn.Name = "reservationsBtn";
            reservationsBtn.Size = new Size(451, 62);
            reservationsBtn.TabIndex = 1;
            reservationsBtn.Text = "Varaukset";
            reservationsBtn.UseVisualStyleBackColor = false;
            reservationsBtn.Click += reservationsBtn_Click_1;
            // 
            // servicesBtn
            // 
            servicesBtn.BackColor = Color.DarkSlateGray;
            servicesBtn.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            servicesBtn.ForeColor = Color.Silver;
            servicesBtn.Location = new Point(176, 238);
            servicesBtn.Name = "servicesBtn";
            servicesBtn.Size = new Size(451, 62);
            servicesBtn.TabIndex = 2;
            servicesBtn.Text = "Palvelut";
            servicesBtn.UseVisualStyleBackColor = false;
            servicesBtn.Click += servicesBtn_Click;
            // 
            // billsBtn
            // 
            billsBtn.BackColor = Color.DarkSlateGray;
            billsBtn.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            billsBtn.ForeColor = Color.Silver;
            billsBtn.Location = new Point(177, 340);
            billsBtn.Name = "billsBtn";
            billsBtn.Size = new Size(451, 62);
            billsBtn.TabIndex = 3;
            billsBtn.Text = "Laskut";
            billsBtn.UseVisualStyleBackColor = false;
            billsBtn.Click += billsBtn_Click;
            // 
            // customersBtn
            // 
            customersBtn.BackColor = Color.DarkSlateGray;
            customersBtn.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            customersBtn.ForeColor = Color.Silver;
            customersBtn.Location = new Point(176, 442);
            customersBtn.Name = "customersBtn";
            customersBtn.Size = new Size(451, 62);
            customersBtn.TabIndex = 4;
            customersBtn.Text = "Asiakkaat";
            customersBtn.UseVisualStyleBackColor = false;
            customersBtn.Click += customersBtn_Click;
            // 
            // areasBtn
            // 
            areasBtn.BackColor = Color.DarkSlateGray;
            areasBtn.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            areasBtn.ForeColor = Color.Silver;
            areasBtn.Location = new Point(176, 544);
            areasBtn.Name = "areasBtn";
            areasBtn.Size = new Size(451, 62);
            areasBtn.TabIndex = 5;
            areasBtn.Text = "Alueet";
            areasBtn.UseVisualStyleBackColor = false;
            areasBtn.Click += areasBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(667, 184);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // testContainer
            // 
            testContainer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            testContainer.Location = new Point(549, 286);
            testContainer.Name = "testContainer";
            testContainer.RowTemplate.Height = 25;
            testContainer.Size = new Size(240, 150);
            testContainer.TabIndex = 7;
            // 
            // cottagesBtn
            // 
            cottagesBtn.BackColor = Color.DarkSlateGray;
            cottagesBtn.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            cottagesBtn.ForeColor = Color.Silver;
            cottagesBtn.Location = new Point(176, 646);
            cottagesBtn.Name = "cottagesBtn";
            cottagesBtn.Size = new Size(451, 62);
            cottagesBtn.TabIndex = 8;
            cottagesBtn.Text = "Mökit";
            cottagesBtn.UseVisualStyleBackColor = false;
            cottagesBtn.Click += cottagesBtn_Click;
            // 
            // MainMenuControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(cottagesBtn);
            Controls.Add(testContainer);
            Controls.Add(button1);
            Controls.Add(areasBtn);
            Controls.Add(customersBtn);
            Controls.Add(billsBtn);
            Controls.Add(servicesBtn);
            Controls.Add(reservationsBtn);
            Controls.Add(label1);
            Name = "MainMenuControl";
            Size = new Size(804, 736);
            Load += MainMenuControl_Load;
            ((System.ComponentModel.ISupportInitialize)testContainer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button reservationsBtn;
        private Button servicesBtn;
        private Button billsBtn;
        private Button customersBtn;
        private Button areasBtn;
        private Button button1;
        private DataGridView testContainer;
        private Button cottagesBtn;
    }
}
