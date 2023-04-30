namespace ohjelmistotuotanto
{
    partial class UpdateReservationMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateReservationMenu));
            prevBtn = new PictureBox();
            label1 = new Label();
            reservationContainer = new DataGridView();
            label6 = new Label();
            panel1 = new Panel();
            da = new Label();
            label8 = new Label();
            cottageCbx = new ComboBox();
            label2 = new Label();
            cottageTxtBox = new TextBox();
            panel3 = new Panel();
            dateErrorLabel = new Label();
            whereDateLabel = new Label();
            startDatePicker = new DateTimePicker();
            label9 = new Label();
            endDatePicker = new DateTimePicker();
            updateReservationBtn = new Button();
            updateReservationErrLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)prevBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reservationContainer).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // prevBtn
            // 
            prevBtn.BackColor = Color.Transparent;
            prevBtn.Image = (Image)resources.GetObject("prevBtn.Image");
            prevBtn.Location = new Point(33, 32);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(124, 62);
            prevBtn.TabIndex = 15;
            prevBtn.TabStop = false;
            prevBtn.Click += prevBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Script MT Bold", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(219, 32);
            label1.Name = "label1";
            label1.Size = new Size(410, 77);
            label1.TabIndex = 16;
            label1.Text = "Päivitä varaus";
            // 
            // reservationContainer
            // 
            reservationContainer.AllowUserToAddRows = false;
            reservationContainer.AllowUserToDeleteRows = false;
            reservationContainer.AllowUserToResizeColumns = false;
            reservationContainer.AllowUserToResizeRows = false;
            reservationContainer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            reservationContainer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reservationContainer.Location = new Point(117, 149);
            reservationContainer.MultiSelect = false;
            reservationContainer.Name = "reservationContainer";
            reservationContainer.RowTemplate.Height = 25;
            reservationContainer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            reservationContainer.Size = new Size(567, 285);
            reservationContainer.TabIndex = 17;
            reservationContainer.CellClick += reservationContainer_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(177, 109);
            label6.Name = "label6";
            label6.Size = new Size(469, 37);
            label6.TabIndex = 18;
            label6.Text = "Valitse varaus, minkä haluat päivittää";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(da);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(cottageCbx);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cottageTxtBox);
            panel1.ForeColor = Color.Silver;
            panel1.Location = new Point(178, 496);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 186);
            panel1.TabIndex = 19;
            // 
            // da
            // 
            da.AutoSize = true;
            da.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            da.ForeColor = Color.WhiteSmoke;
            da.Location = new Point(-2, 72);
            da.Name = "da";
            da.Size = new Size(61, 37);
            da.TabIndex = 13;
            da.Text = "hae";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(145, -1);
            label8.Name = "label8";
            label8.Size = new Size(126, 50);
            label8.TabIndex = 12;
            label8.Text = "Mökki";
            // 
            // cottageCbx
            // 
            cottageCbx.BackColor = Color.DarkSlateGray;
            cottageCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            cottageCbx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cottageCbx.ForeColor = Color.Silver;
            cottageCbx.FormattingEnabled = true;
            cottageCbx.Location = new Point(105, 118);
            cottageCbx.Name = "cottageCbx";
            cottageCbx.Size = new Size(315, 29);
            cottageCbx.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(-1, 110);
            label2.Name = "label2";
            label2.Size = new Size(95, 37);
            label2.TabIndex = 2;
            label2.Text = "valitse";
            // 
            // cottageTxtBox
            // 
            cottageTxtBox.BackColor = Color.DarkSlateGray;
            cottageTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cottageTxtBox.ForeColor = Color.Silver;
            cottageTxtBox.Location = new Point(105, 72);
            cottageTxtBox.Name = "cottageTxtBox";
            cottageTxtBox.Size = new Size(315, 29);
            cottageTxtBox.TabIndex = 3;
            cottageTxtBox.TextChanged += cottageTxtBox_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(dateErrorLabel);
            panel3.Controls.Add(whereDateLabel);
            panel3.Controls.Add(startDatePicker);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(endDatePicker);
            panel3.ForeColor = Color.Transparent;
            panel3.Location = new Point(177, 744);
            panel3.Name = "panel3";
            panel3.Size = new Size(451, 152);
            panel3.TabIndex = 20;
            // 
            // dateErrorLabel
            // 
            dateErrorLabel.AutoSize = true;
            dateErrorLabel.BackColor = Color.Transparent;
            dateErrorLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateErrorLabel.ForeColor = Color.Cyan;
            dateErrorLabel.Location = new Point(45, 96);
            dateErrorLabel.Name = "dateErrorLabel";
            dateErrorLabel.Size = new Size(337, 37);
            dateErrorLabel.TabIndex = 22;
            dateErrorLabel.Text = "Valitse mihin asti varaus on";
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
            // startDatePicker
            // 
            startDatePicker.Location = new Point(45, 58);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(150, 23);
            startDatePicker.TabIndex = 14;
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
            // endDatePicker
            // 
            endDatePicker.Location = new Point(256, 58);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(150, 23);
            endDatePicker.TabIndex = 16;
            // 
            // updateReservationBtn
            // 
            updateReservationBtn.BackColor = Color.DarkSlateGray;
            updateReservationBtn.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            updateReservationBtn.ForeColor = Color.WhiteSmoke;
            updateReservationBtn.Location = new Point(177, 952);
            updateReservationBtn.Name = "updateReservationBtn";
            updateReservationBtn.Size = new Size(451, 62);
            updateReservationBtn.TabIndex = 21;
            updateReservationBtn.Text = "Päivitä varaus";
            updateReservationBtn.UseVisualStyleBackColor = false;
            updateReservationBtn.Click += updateReservationBtn_Click;
            // 
            // updateReservationErrLabel
            // 
            updateReservationErrLabel.AutoSize = true;
            updateReservationErrLabel.BackColor = Color.Transparent;
            updateReservationErrLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            updateReservationErrLabel.ForeColor = Color.Cyan;
            updateReservationErrLabel.Location = new Point(164, 1040);
            updateReservationErrLabel.Name = "updateReservationErrLabel";
            updateReservationErrLabel.Size = new Size(492, 37);
            updateReservationErrLabel.TabIndex = 23;
            updateReservationErrLabel.Text = "Muuta jotain arvoa, jota haluat päivittää";
            updateReservationErrLabel.Visible = false;
            // 
            // UpdateReservationMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.test3;
            Controls.Add(updateReservationErrLabel);
            Controls.Add(updateReservationBtn);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(reservationContainer);
            Controls.Add(label1);
            Controls.Add(prevBtn);
            Name = "UpdateReservationMenu";
            Size = new Size(804, 1200);
            Load += UpdateReservationMenu_Load;
            VisibleChanged += UpdateReservationMenu_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)prevBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)reservationContainer).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox prevBtn;
        private Label label1;
        private DataGridView reservationContainer;
        private Label label6;
        private Panel panel1;
        private Label da;
        private Label label8;
        private ComboBox cottageCbx;
        private Label label2;
        private TextBox cottageTxtBox;
        private Panel panel3;
        private Label dateErrorLabel;
        private Label whereDateLabel;
        private DateTimePicker startDatePicker;
        private Label label9;
        private DateTimePicker endDatePicker;
        private Button updateReservationBtn;
        private Label updateReservationErrLabel;
    }
}
