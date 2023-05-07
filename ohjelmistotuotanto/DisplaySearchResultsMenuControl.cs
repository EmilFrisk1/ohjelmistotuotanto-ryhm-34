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
        public SearchReservationMenuControl searchReservationMenuControl;
        public ServicesSearchMenu servicesSearchMenuControl;
        public CottagesSearchMenu cottagesSearchMenuControl;

        public DisplaySearchResultsMenuControl()
        {
            InitializeComponent();
        }

        private void DisplaySearchResultsMenuControl_Load(object sender, EventArgs e)
        {
            // initialize event listeners
            EventUtility.DisplayReservationSearchResults += DisplaySearchResults;
            EventUtility.DisplayServicesSearchResults += DisplaySearchResults;
            EventUtility.DisplayCottagesSearchResults += DisplaySearchResults;
        }

        private void EventUtility_DisplayCottagesSearchResults(List<CottageDataModel> results)
        {
            throw new NotImplementedException();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            VillageNewbies.menuhistory.RemoveAt(VillageNewbies.menuhistory.Count - 1);
            // Show the previous menu
            string prevMenu = VillageNewbies.menuhistory[VillageNewbies.menuhistory.Count - 1];
            switch (prevMenu)
            {
                case Constants.searchRrvtMenu:
                    searchReservationMenuControl.Show();
                    break;
                case Constants.srvcSearchMenu:
                    servicesSearchMenuControl.Show();
                    break;
                case Constants.cottagesSearchMenu:
                    cottagesSearchMenuControl.Show();
                    break;
                default:
                    MessageBox.Show("Jokin meni pieleen menuhistoriassa");
                    break;
            }
        }

        public void DisplaySearchResults<T>(List<T> results)
        {
           // if (results.Count > 0) results.Clear();
            searchResultsContainer.DataSource = null;
            searchResultsContainer.DataSource = results;
        }
    }
}
