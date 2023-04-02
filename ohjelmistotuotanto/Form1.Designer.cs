namespace ohjelmistotuotanto
{
    partial class VillageNewbies
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VillageNewbies));
            button1 = new Button();
            mainMenuHeader = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 512);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // mainMenuHeader
            // 
            mainMenuHeader.AutoSize = true;
            mainMenuHeader.BackColor = Color.Transparent;
            mainMenuHeader.Font = new Font("Script MT Bold", 48F, FontStyle.Bold, GraphicsUnit.Point);
            mainMenuHeader.ForeColor = Color.Silver;
            mainMenuHeader.Location = new Point(191, 9);
            mainMenuHeader.Name = "mainMenuHeader";
            mainMenuHeader.Size = new Size(451, 77);
            mainMenuHeader.TabIndex = 1;
            mainMenuHeader.Text = "Village Newbies";
            // 
            // button2
            // 
            button2.BackColor = Color.Orange;
            button2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(191, 137);
            button2.Name = "button2";
            button2.Size = new Size(451, 50);
            button2.TabIndex = 2;
            button2.Text = "varaukset";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Orange;
            button3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(191, 249);
            button3.Name = "button3";
            button3.Size = new Size(451, 50);
            button3.TabIndex = 3;
            button3.Text = "palvelut";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Orange;
            button4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(191, 362);
            button4.Name = "button4";
            button4.Size = new Size(451, 50);
            button4.TabIndex = 4;
            button4.Text = "asiakkaat";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Orange;
            button5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(191, 466);
            button5.Name = "button5";
            button5.Size = new Size(451, 50);
            button5.TabIndex = 5;
            button5.Text = "alueet";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Orange;
            button6.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(191, 558);
            button6.Name = "button6";
            button6.Size = new Size(451, 50);
            button6.TabIndex = 6;
            button6.Text = "laskut";
            button6.UseVisualStyleBackColor = false;
            // 
            // VillageNewbies
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(806, 650);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(mainMenuHeader);
            Controls.Add(button1);
            Name = "VillageNewbies";
            Text = "Village Newbies";
            FormClosed += Form1_FormClosed_1;
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label mainMenuHeader;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}