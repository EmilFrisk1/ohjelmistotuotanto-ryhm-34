namespace ohjelmistotuotanto
{
    partial class TestMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestMenu));
            reservationsBtn = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // reservationsBtn
            // 
            reservationsBtn.BackColor = Color.DarkSlateGray;
            resources.ApplyResources(reservationsBtn, "reservationsBtn");
            reservationsBtn.ForeColor = Color.Silver;
            reservationsBtn.Name = "reservationsBtn";
            reservationsBtn.UseVisualStyleBackColor = false;
            reservationsBtn.Click += reservationsBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            resources.ApplyResources(button1, "button1");
            button1.ForeColor = Color.Silver;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateGray;
            resources.ApplyResources(button2, "button2");
            button2.ForeColor = Color.Silver;
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSlateGray;
            resources.ApplyResources(button3, "button3");
            button3.ForeColor = Color.Silver;
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Silver;
            label2.Name = "label2";
            // 
            // TestMenu
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(reservationsBtn);
            Name = "TestMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button reservationsBtn;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
    }
}
