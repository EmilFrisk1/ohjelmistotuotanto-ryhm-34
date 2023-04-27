namespace ohjelmistotuotanto
{
    partial class RemoveReservationMenuControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveReservationMenuControl));
            label1 = new Label();
            reservationContainer = new DataGridView();
            deleteBtn = new Button();
            label6 = new Label();
            prevBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)reservationContainer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)prevBtn).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Script MT Bold", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(208, 17);
            label1.Name = "label1";
            label1.Size = new Size(388, 77);
            label1.TabIndex = 1;
            label1.Text = "Poista varaus";
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
            reservationContainer.TabIndex = 2;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.DarkSlateGray;
            deleteBtn.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteBtn.ForeColor = Color.Silver;
            deleteBtn.Location = new Point(117, 462);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(567, 62);
            deleteBtn.TabIndex = 12;
            deleteBtn.Text = "Poista";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(174, 109);
            label6.Name = "label6";
            label6.Size = new Size(452, 37);
            label6.TabIndex = 13;
            label6.Text = "Valitse varaus, minkä haluat poistaa";
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
            // RemoveReservationMenuControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(prevBtn);
            Controls.Add(label6);
            Controls.Add(deleteBtn);
            Controls.Add(reservationContainer);
            Controls.Add(label1);
            Name = "RemoveReservationMenuControl";
            Size = new Size(804, 736);
            Load += RemoveReservationMenuControl_Load;
            VisibleChanged += RemoveReservationMenuControl_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)reservationContainer).EndInit();
            ((System.ComponentModel.ISupportInitialize)prevBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView reservationContainer;
        private Button deleteBtn;
        private Label label6;
        private PictureBox prevBtn;
    }
}
