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
    public partial class ServicesSearchMenu : UserControl
    {
        public delegate void MenuSwitchRequestHandler(string menu); // Function pointer 
        public event MenuSwitchRequestHandler MenuSwitchRequested;
        public List<Area> Areas { get; set; }
        public List<ServicesReport> Services { get; set; }

        public ServicesSearchMenu()
        {
            InitializeComponent();
        }

        private async void ServicesSearchMenu_Load(object sender, EventArgs e)
        {
            // Initialize lists
            Areas = new List<Area>() { new Area { Id = -1, Name = "Kaikki" } };
            Services = new List<ServicesReport>();

            // Set the default value to the current date
            datePickerStart.Value = DateTime.Today;
            datePickerEnd.Value = DateTime.Today;

            // Set the MinDate and MaxDate to the current date
            datePickerStart.MinDate = DateTime.Today;
            datePickerEnd.MinDate = DateTime.Today;

            // Get all areas and display them on the comboBox
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
            if (Services.Count > 0)
                Services.Clear();

            if (!Validate())
                return;

            var queryString = BuildSearchServicesQuery(); // TODO ' täs on jotain häikkää

            // get services
            Services = await VillageNewbies._dbManager.SearchServicesAsync(queryString);

            // Transport the matches to the search resulst menu
            this.Hide();
            MenuSwitchRequested?.Invoke(Constants.displayResultsMenu);
            EventUtility.RaiseDisplayServicesSearchResults(Services);
        }

        private bool Validate()
        {
            // Validate input
            if (DateTime.Compare(datePickerStart.Value.Date, datePickerEnd.Value.Date) > 0)
            {
                dateErrorLabel.Visible = true;
                return false;
            }
            else
            {
                if (dateErrorLabel.Visible)
                    dateErrorLabel.Visible = false;
                return true;
            }
        }

        private string BuildSearchServicesQuery()
        {
            StringBuilder queryBuilder = new StringBuilder("SELECT a.name AS area_name, r_s.quantity, r_s.reservation_id, s.name AS service_name, s.price, r.start_date " +
                "FROM reservation_service r_s " +
                "JOIN reservation r ON r_s.reservation_id = r.id " +
                "JOIN cottage c ON r.cottage_id = c.id " +
                "JOIN service s ON r_s.service_id = s.id " +
                "JOIN area a ON c.area_id = a.id " +
                "WHERE 1 = 1");

            if (!dateRangeCheckBox.Checked)
            {
                DateTime startDate = datePickerStart.Value;
                DateTime endDate = datePickerEnd.Value;
                queryBuilder.Append($" AND r.start_date >= '{startDate.ToString("yyyy-MM-dd")}'");
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
