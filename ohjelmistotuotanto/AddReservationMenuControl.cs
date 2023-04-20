using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ohjelmistotuotanto
{
    public partial class AddReservationMenuControl : UserControl
    {
        public delegate void MenuSwitchRequestHandler(string menu); // Function pointer 
        public event MenuSwitchRequestHandler MenuSwitchRequested;

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
    }
}
