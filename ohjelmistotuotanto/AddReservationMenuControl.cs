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

            // TODO - search all the customers from DB And attach their id to the combobox
            // TODO - search all the cottages from DB And attach their id to the combobox
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuSwitchRequested?.Invoke(Constants.rrvtMenu);
        }

        async private void addReservationBtn_Click(object sender, EventArgs e)
        {
            // Check that all form fields are valid
            if (cottageCbx.SelectedIndex == -1 || string.IsNullOrEmpty(cottageCbx.Text) || customerCbx.SelectedIndex == -1 || string.IsNullOrEmpty(cottageCbx.Text))
            {
                statusStrip.Visible = true;
                return;
            }
            else
            { // no error hide it
                if (statusStrip.Visible)
                {
                    //formErrorLabel.Visible = false;
                    statusStrip.Visible = false;
                }
            }

            if (fromDatePicker.Value == whereDatePicker.Value) // special validation for dates
            {
                dateErrorLabel.Visible = true;
                dateErrorLabel.Text = "Valitse mihin asti varaus on";
                return;
            } else if (fromDatePicker.Value > whereDatePicker.Value)
            {
                dateErrorLabel.Visible = true;
                dateErrorLabel.Text = "Mihin liian pieni";
                return;
            }
            else
            { // no error hide it
                if (dateErrorLabel.Visible)
                {
                    dateErrorLabel.Visible = false;
                }
            }

            string startDate = fromDatePicker.Value.ToString("yyyy-MM-dd");
            string endDate = whereDatePicker.Value.ToString("yyyy-MM-dd");
            int customerId = 1;
            int cottageId = 1;

            var res = VillageNewbies._dbManager.CallCheckAvailabilityAndReserveAsync(cottageId, startDate, endDate, customerId);

            if (res.Result == -1)
            {
                MessageBox.Show("Tämä varaushaarukka onjo käytössä");
            }
            else
            {
                MessageBox.Show("Varaus lisätty onnistuneesti"); // TODO - what next? mainmenu?
            }
        }
    }
}
