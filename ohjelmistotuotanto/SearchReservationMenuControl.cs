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
    public partial class SearchReservationMenuControl : UserControl
    {
        public delegate void MenuSwitchRequestHandler(string menu); // Function pointer 
        public event MenuSwitchRequestHandler MenuSwitchRequested;

        public List<Area> Areas { get; set; }
        public SearchReservationMenuControl()
        {
            InitializeComponent();
        }

        private void SearchReservationMenuControl_Load(object sender, EventArgs e)
        {
            Areas = new List<Area>() { new Area { Id = -1, Name = string.Empty } };

            // Set the default value to the current date
            datePickerStart.Value = DateTime.Today;
            datePickerEnd.Value = DateTime.Today;

            // Set the MinDate and MaxDate to the current date
            datePickerStart.MinDate = DateTime.Today;
            datePickerEnd.MinDate = DateTime.Today;

            // Get all areas and display them on the comboBox
            var areas = VillageNewbies._dbManager.SelectDataAsync("area", new List<string>() { "id", "name" });
            setUpAreasCbx(areas);
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuSwitchRequested?.Invoke(Constants.rrvtMenu);
        }

        private void setUpAreasCbx(Task<DataTable> areas)
        {
            if (areas.Result?.Rows != null && areas.Result.Rows.Count > 0)
            {
                foreach (DataRow row in areas.Result.Rows)
                {
                    var id = (int)row[0];
                    var email = (string)row[1];

                    Areas.Add(new Area { Id = id, Name = email });
                }
                areaCbx.DataSource = Areas;
                areaCbx.DisplayMember = "Name";
                areaCbx.ValueMember = "Id";
            }
        }

        private async void searchReservationBtn_Click(object sender, EventArgs e)
        {
            // Validate input
            if (DateTime.Compare(datePickerStart.Value.Date, datePickerEnd.Value.Date) > 0)
            {
                dateErrorLabel.Visible = true;
                return;
            } else
            {
                if (dateErrorLabel.Visible) 
                    dateErrorLabel.Visible = false;
            }

            var queryString = BuildSearchReservationsQuery();
            var response = await VillageNewbies._dbManager.SearchReservations(queryString);
            if (response.Count == 0)
            {
                MessageBox.Show("Yhtään tulosta ei löytynt");
            }
            else
            {
                // Transport the matches to the search resulst menu
                EventUtility.RaiseDisplayReservationSearchResults(response);
                MenuSwitchRequested?.Invoke(Constants.searchResults); // TODO - some problems with this logic probably the event
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


    }
}
