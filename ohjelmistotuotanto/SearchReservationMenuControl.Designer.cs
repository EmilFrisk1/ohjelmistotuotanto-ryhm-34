namespace ohjelmistotuotanto
{
    partial class SearchReservationMenuControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchReservationMenuControl));
            label1 = new Label();
            prevBtn = new PictureBox();
            panel1 = new Panel();
            label8 = new Label();
            areaCbx = new ComboBox();
            label2 = new Label();
            panel3 = new Panel();
            dateRangeCheckBox = new CheckBox();
            label3 = new Label();
            dateErrorLabel = new Label();
            whereDateLabel = new Label();
            datePickerStart = new DateTimePicker();
            label9 = new Label();
            datePickerEnd = new DateTimePicker();
            searchReservationBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)prevBtn).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Script MT Bold", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(233, 17);
            label1.Name = "label1";
            label1.Size = new Size(338, 77);
            label1.TabIndex = 2;
            label1.Text = "Hae varaus";
            // 
            // prevBtn
            // 
            prevBtn.BackColor = Color.Transparent;
            prevBtn.Image = (Image)resources.GetObject("prevBtn.Image");
            prevBtn.Location = new Point(33, 32);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(124, 62);
            prevBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            prevBtn.TabIndex = 17;
            prevBtn.TabStop = false;
            prevBtn.Click += prevBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(areaCbx);
            panel1.Controls.Add(label2);
            panel1.ForeColor = Color.Silver;
            panel1.Location = new Point(176, 136);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 129);
            panel1.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(173, 0);
            label8.Name = "label8";
            label8.Size = new Size(99, 50);
            label8.TabIndex = 12;
            label8.Text = "Alue";
            // 
            // areaCbx
            // 
            areaCbx.BackColor = Color.DarkSlateGray;
            areaCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            areaCbx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            areaCbx.ForeColor = Color.Silver;
            areaCbx.FormattingEnabled = true;
            areaCbx.Location = new Point(114, 66);
            areaCbx.Name = "areaCbx";
            areaCbx.Size = new Size(315, 29);
            areaCbx.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(8, 58);
            label2.Name = "label2";
            label2.Size = new Size(95, 37);
            label2.TabIndex = 2;
            label2.Text = "valitse";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(dateRangeCheckBox);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(dateErrorLabel);
            panel3.Controls.Add(whereDateLabel);
            panel3.Controls.Add(datePickerStart);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(datePickerEnd);
            panel3.ForeColor = Color.Transparent;
            panel3.Location = new Point(176, 295);
            panel3.Name = "panel3";
            panel3.Size = new Size(451, 198);
            panel3.TabIndex = 20;
            // 
            // dateRangeCheckBox
            // 
            dateRangeCheckBox.AutoSize = true;
            dateRangeCheckBox.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateRangeCheckBox.Location = new Point(350, 124);
            dateRangeCheckBox.Name = "dateRangeCheckBox";
            dateRangeCheckBox.Size = new Size(15, 14);
            dateRangeCheckBox.TabIndex = 24;
            dateRangeCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(93, 104);
            label3.Name = "label3";
            label3.Size = new Size(251, 37);
            label3.TabIndex = 23;
            label3.Text = "Ei varaushaarukkaa";
            // 
            // dateErrorLabel
            // 
            dateErrorLabel.AutoSize = true;
            dateErrorLabel.BackColor = Color.Transparent;
            dateErrorLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateErrorLabel.ForeColor = Color.Cyan;
            dateErrorLabel.Location = new Point(114, 141);
            dateErrorLabel.Name = "dateErrorLabel";
            dateErrorLabel.Size = new Size(208, 37);
            dateErrorLabel.TabIndex = 22;
            dateErrorLabel.Text = "Mihin liian pieni";
            dateErrorLabel.Visible = false;
            // 
            // whereDateLabel
            // 
            whereDateLabel.AutoSize = true;
            whereDateLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            whereDateLabel.ForeColor = Color.WhiteSmoke;
            whereDateLabel.Location = new Point(288, 6);
            whereDateLabel.Name = "whereDateLabel";
            whereDateLabel.Size = new Size(88, 37);
            whereDateLabel.TabIndex = 18;
            whereDateLabel.Text = "Mihin";
            // 
            // datePickerStart
            // 
            datePickerStart.Location = new Point(45, 58);
            datePickerStart.Name = "datePickerStart";
            datePickerStart.Size = new Size(150, 23);
            datePickerStart.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(75, 6);
            label9.Name = "label9";
            label9.Size = new Size(85, 37);
            label9.TabIndex = 15;
            label9.Text = "Mistä";
            // 
            // datePickerEnd
            // 
            datePickerEnd.Location = new Point(256, 58);
            datePickerEnd.Name = "datePickerEnd";
            datePickerEnd.Size = new Size(150, 23);
            datePickerEnd.TabIndex = 16;
            // 
            // searchReservationBtn
            // 
            searchReservationBtn.BackColor = Color.DarkSlateGray;
            searchReservationBtn.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            searchReservationBtn.ForeColor = Color.WhiteSmoke;
            searchReservationBtn.Location = new Point(176, 544);
            searchReservationBtn.Name = "searchReservationBtn";
            searchReservationBtn.Size = new Size(451, 62);
            searchReservationBtn.TabIndex = 21;
            searchReservationBtn.Text = "Hae varaus";
            searchReservationBtn.UseVisualStyleBackColor = false;
            searchReservationBtn.Click += searchReservationBtn_Click;
            // 
            // SearchReservationMenuControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.test3;
            Controls.Add(searchReservationBtn);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(prevBtn);
            Controls.Add(label1);
            Name = "SearchReservationMenuControl";
            Size = new Size(804, 736);
            Load += SearchReservationMenuControl_Load;
            VisibleChanged += SearchReservationMenuControl_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)prevBtn).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox prevBtn;
        private Panel panel1;
        private Label label8;
        private ComboBox areaCbx;
        private Label label2;
        private Panel panel3;
        private Label dateErrorLabel;
        private Label whereDateLabel;
        private DateTimePicker datePickerStart;
        private Label label9;
        private DateTimePicker datePickerEnd;
        private CheckBox dateRangeCheckBox;
        private Label label3;
        private Button searchReservationBtn;
    }
}
