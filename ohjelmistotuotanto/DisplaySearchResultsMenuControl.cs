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
    public partial class DisplaySearchResultsMenuControl : UserControl
    {
        public delegate void MenuSwitchRequestHandler(string menu); // Function pointer 
        public event MenuSwitchRequestHandler MenuSwitchRequested;
        public DisplaySearchResultsMenuControl()
        {
            InitializeComponent();
        }

        private void DisplaySearchResultsMenuControl_Load(object sender, EventArgs e)
        {
            // initialize event listeners
            EventUtility.DisplayReservationSearchResults += DisplaySearchResults;

        }

        public void DisplaySearchResults<T>(List<T> results)
        {
            searchResultsContainer.DataSource = results;
        }
    }
}
