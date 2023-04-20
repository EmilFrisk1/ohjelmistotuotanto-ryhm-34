using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ohjelmistotuotanto
{
    public partial class AddReservationMenuControl : UserControl
    {
        public delegate void MenuSwitchRequestHandler(string menu); // Function pointer 
        public event MenuSwitchRequestHandler MenuSwitchRequested;
        public StatusStrip statusStrip;

        public AddReservationMenuControl()
        {
            InitializeComponent();
        }

        private void AddReservationMenuControl_Load(object sender, EventArgs e)
        {
            // Set the default value to the current date
            fromDatePicker.Value = DateTime.Today;
            whereDatePicker.Value = DateTime.Today;

            // Set the MinDate and MaxDate to the current date
            fromDatePicker.MinDate = DateTime.Today;
            whereDatePicker.MinDate = DateTime.Today;
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuSwitchRequested?.Invoke(Constants.rrvtMenu);
        }

        private void addReservationBtn_Click(object sender, EventArgs e)
        {
            // Check that all form fields are valid
            if (cottageCbx.SelectedIndex == -1 || string.IsNullOrEmpty(cottageCbx.Text) || customerCbx.SelectedIndex == -1 || string.IsNullOrEmpty(cottageCbx.Text))
            {
                //formErrorLabel.Visible = true;
                //formErrorLabel1.Visible = true;
                statusStrip.Visible = true;
            }
            else
            { // no error hide it
                if (statusStrip.Visible)
                {
                    //formErrorLabel.Visible = false;
                    statusStrip.Visible = false;
                }
            }

            if (fromDatePicker.Value == whereDatePicker.Value) // special validation
            {
                dateErrorLabel.Visible = true;
            }
            else
            { // no error hide it
                if (dateErrorLabel.Visible)
                {
                    dateErrorLabel.Visible = false;
                }
            }

            // Check if the date is available to reserve for this cottage
            string selectedDate = fromDatePicker.Value.ToString("yy-MM-dd"); ;

            MessageBox.Show($"The selected date is: {selectedDate}");
        }
    }
}
