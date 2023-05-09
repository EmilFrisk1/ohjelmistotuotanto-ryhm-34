using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ohjelmistotuotanto
{
    public partial class CottagesSearchMenu : UserControl
    {
        public delegate void MenuSwitchRequestHandler(string menu); // Function pointer 
        public event MenuSwitchRequestHandler MenuSwitchRequested;
        public List<Area> Areas { get; set; }
        public List<CottageDataModel> Cottages { get; set; }

        public static int counter = 0;
        public static bool isFirstLoad = true;

        public CottagesSearchMenu()
        {
            InitializeComponent();
        }

        private async void CottagesSearchMenu_Load(object sender, EventArgs e)
        {
            isFirstLoad = false;

            Areas = new List<Area>() { new Area { Id = -1, Name = "Kaikki" } };
            Cottages = new List<CottageDataModel>();

            GetAreas();
        }

        private async void GetAreas()
        {
            var areas = await VillageNewbies._dbManager.SelectDataAsync("area", new List<string>() { "id", "name" });
            ComboBoxUtility.SetUpAreasCbx(areas, Areas, areaCbx);
        }

        private async void searchBtn_Click(object sender, EventArgs e)
        {
            if (Cottages.Count > 0) { Cottages.Clear(); }

            string query = BuildSearchQuery();

            // get services
            var res = await VillageNewbies._dbManager.SearchDataAsync(query);
            ConvertDatatableToList(res);

            //// Transport the matches to the search resulst menu
            this.Hide();
            MenuSwitchRequested?.Invoke(Constants.displayResultsMenu);
            EventUtility.RaiseDisplayCottagesSearchResults(Cottages);

        }

        private void ConvertDatatableToList(DataTable cottages)
        {
            if (cottages.Rows != null && cottages.Rows.Count > 0)
            {
                foreach (DataRow row in cottages.Rows)
                {
                    var id = (int)row[0];
                    var areaId = (int)row[1];
                    var price = (decimal)row[2];
                    var description = (string)row[3];
                    var equipment = (string)row[4];
                    var squares = (int)row[5];
                    var address = (string)row[6];
                    var cottageName = (string)row[7];

                    Cottages.Add(new CottageDataModel { Id = id, AreaId = areaId, Price = price, Description = description, Equipment = equipment, Squares = squares, Address = address, CottageName = cottageName });
                }
            }
        }

        private string BuildSearchQuery()
        {
            string query = "SELECT * FROM cottage WHERE 1 = 1";

            if ((int)areaCbx.SelectedValue != -1)
            {
                query += $" AND area_id = {(int)areaCbx.SelectedValue}";
            }

            if (!string.IsNullOrEmpty(lowPriceTxtBox.Text))
            {
                query += $" AND price >= {lowPriceTxtBox.Text}";
            }

            if (!string.IsNullOrEmpty(highPriceTxtBox.Text))
            {
                query += $" AND price <= {highPriceTxtBox.Text}";
            }

            return query;
        }

        private void lowPriceTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxUtility.AllowOnlyNumbers(sender, e);
        }

        private void highPriceTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxUtility.AllowOnlyNumbers(sender, e);
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            VillageNewbies.menuhistory.RemoveAt(VillageNewbies.menuhistory.Count - 1);
            MenuSwitchRequested?.Invoke(Constants.cottagesMenu);
        }

        private void CottagesSearchMenu_VisibleChanged(object sender, EventArgs e)
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
