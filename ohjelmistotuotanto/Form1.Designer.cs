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
            button2 = new Button();
            toolStrip1 = new ToolStrip();
            mainMenuToolStrip = new ToolStripLabel();
            appContainer = new Panel();
            toolStrip1.SuspendLayout();
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
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 467);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { mainMenuToolStrip });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(804, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // mainMenuToolStrip
            // 
            mainMenuToolStrip.Name = "mainMenuToolStrip";
            mainMenuToolStrip.Size = new Size(63, 22);
            mainMenuToolStrip.Text = "Päävalikko";
            mainMenuToolStrip.Click += mainMenuToolStrip_Click;
            // 
            // appContainer
            // 
            appContainer.Dock = DockStyle.Fill;
            appContainer.Location = new Point(0, 25);
            appContainer.Name = "appContainer";
            appContainer.Size = new Size(804, 736);
            appContainer.TabIndex = 3;
            // 
            // VillageNewbies
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(804, 761);
            Controls.Add(appContainer);
            Controls.Add(toolStrip1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "VillageNewbies";
            Tag = "";
            Text = "Village Newbies";
            Load += VillageNewbies_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private ToolStrip toolStrip1;
        private ToolStripLabel mainMenuToolStrip;
        private Panel appContainer;
    }
}