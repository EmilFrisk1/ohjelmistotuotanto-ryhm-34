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
    public partial class AreaSearchControl : UserControl
    {
        public delegate void MenuSwitchRequestHandler(string newControl); // Function pointer 
        public event MenuSwitchRequestHandler MenuSwitchRequested;
        public AreaSearchControl()
        {
            InitializeComponent();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            VillageNewbies.menuhistory.RemoveAt(VillageNewbies.menuhistory.Count - 1);
            MenuSwitchRequested?.Invoke(Constants.areasMenu);
        }
        private async Task<List<Area>> PrepareAreasList(List<Area> areas)
        {
            var response = await VillageNewbies._dbManager.SelectDataAsync("area");
            foreach (DataRow row in response.Rows)
            {
                var id = (int)row["id"];
                var name = (string)row["name"];
                areas.Add(new Area() { Id = id, Name = name });
            }
            return areas;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var areas = PrepareAreasList(new List<Area>());
            searchGrid.DataSource = areas.Result;
        }
    }
}
