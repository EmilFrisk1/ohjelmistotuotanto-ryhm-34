using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ohjelmistotuotanto
{
    public partial class SearchReservationMenuControl : UserControl
    {
        public delegate void MenuSwitchRequestHandler(string menu); // Function pointer 
        public event MenuSwitchRequestHandler MenuSwitchRequested;
        private List<Reservation> reservationsList = new List<Reservation>();

        public static int counter = 0;
        public static bool isFirstLoad = true;

        public List<Area> Areas { get; set; }
        public SearchReservationMenuControl()
        {
            InitializeComponent();
        }

        private async void SearchReservationMenuControl_Load(object sender, EventArgs e)
        {
            isFirstLoad = false;

            Areas = new List<Area>() { new Area { Id = -1, Name = "Kaikki" } };

            // Set the default value to the current date
            datePickerStart.Value = DateTime.Today;
            datePickerEnd.Value = DateTime.Today;

            // Set the MinDate and MaxDate to the current date
            datePickerStart.MinDate = DateTime.Today;
            datePickerEnd.MinDate = DateTime.Today;

            GetAreas();
        }

        private async void GetAreas()
        {
            var areas = await VillageNewbies._dbManager.SelectDataAsync("area", new List<string>() { "id", "name" });
            ComboBoxUtility.SetUpAreasCbx(areas, Areas, areaCbx);
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            VillageNewbies.menuhistory.RemoveAt(VillageNewbies.menuhistory.Count - 1);
            MenuSwitchRequested?.Invoke(Constants.rrvtMenu);
        }

        private async void searchReservationBtn_Click(object sender, EventArgs e)
        {


            // Validate input
            if (DateTime.Compare(datePickerStart.Value.Date, datePickerEnd.Value.Date) > 0)
            {
                dateErrorLabel.Visible = true;
                return;
            }
            else
            {
                if (dateErrorLabel.Visible)
                    dateErrorLabel.Visible = false;
            }

            var queryString = BuildSearchReservationsQuery();
            // Get reservations
            var reservations = await VillageNewbies._dbManager.SearchDataAsync(queryString);
            if (reservations == null || reservations.Rows.Count <= 0)
            {
                MessageBox.Show("Yhtään tulosta ei löytynt");
            }
            else
            {
                if (reservationsList.Count > 0)
                    reservationsList.Clear();

                ConvertDatatableToList(queryString, reservations);
                this.Hide();
                MenuSwitchRequested?.Invoke(Constants.displayResultsMenu);
                // Transport the matches to the search resulst menu
                EventUtility.RaiseDisplayReservationSearchResults(reservationsList);
            }
        }

        private string BuildSearchReservationsQuery()
        {
            StringBuilder queryBuilder = new StringBuilder("SELECT r.* FROM reservation r JOIN cottage c ON r.cottage_id = c.id WHERE 1 = 1");

            if (!dateRangeCheckBox.Checked)
            {
                DateTime startDate = datePickerStart.Value;
                DateTime endDate = datePickerEnd.Value;

                queryBuilder.Append($" AND start_date >= '{startDate.ToString("yyyy-MM-dd")}'");
                queryBuilder.Append($" AND end_date <= '{endDate.ToString("yyyy-MM-dd")}'");
            }

            if ((int)areaCbx.SelectedValue != -1)
            {
                int areaId = (int)areaCbx.SelectedValue;
                queryBuilder.Append($" AND c.area_id = {areaId}");
            }

            // Add more conditions for other filters here

            return queryBuilder.ToString();
        }

        private void ConvertDatatableToList(string queryString, DataTable reservations)
        {
            foreach (DataRow row in reservations.Rows)
            {
                var id = (int)row["id"];
                var cottageId = (int)row["cottage_id"];
                var startDate = (DateTime)row["start_date"];
                var endDate = (DateTime)row["end_date"];
                var customerId = (int)row["customer_id"];
                reservationsList.Add(new Reservation() { Id = id, MökkiId = cottageId, AloitusPvm = startDate, LoppuPvm = endDate, AsiakasId = customerId });
            }
        }

        private void SearchReservationMenuControl_VisibleChanged(object sender, EventArgs e)
        {
            counter++;
            if (isFirstLoad || counter <= 2)
                return;

            if (this.Visible)
            {
                GetAreas();
            }
        }
    }
}
