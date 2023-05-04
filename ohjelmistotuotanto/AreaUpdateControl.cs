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
    public partial class AreaUpdateControl : UserControl
    {
        public delegate void MenuSwitchRequestHandler(string menu); // Function pointer 
        public event MenuSwitchRequestHandler MenuSwitchRequested;
        public List<Area> Areas { get; set; }
        public static bool nameChanged = false;
        private bool isFirstLoad = true;
        private static int counter = 0;
        public AreaUpdateControl()
        {
            InitializeComponent();
        }

        private void AreaUpdateControl_Load(object sender, EventArgs e)
        {
            isFirstLoad = false;
            // Initialize lists
            Areas = new List<Area>() { new Area { Id = -1, Name = string.Empty } };
            GetAreas();
        }
        private async void GetAreas()
        {
            // Get services and display then on a combobox | each entry linked with id
            var areas = await VillageNewbies._dbManager.SelectDataAsync("area", new List<string>() { "id", "name" });
            ComboBoxUtility.SetUpAreasCbx(areas, Areas, areaCbx);
        }

        private void MenuDefaultState()
        {
            nameTxtBox.Text = string.Empty;
            areaCbx.SelectedIndex = 0;
            if (areaErrorLabel.Visible)
                areaErrorLabel.Visible = false;
        }
        private bool Validate()
        {
            // validate
            if ((int)areaCbx.SelectedValue == -1)
            {
                areaErrorLabel.Visible = true;
                areaErrorLabel.Text = "Valitse alue";
                return false;
            }
            else
            {
                if (areaErrorLabel.Visible)
                {
                    areaErrorLabel.Visible = false;
                }
                return true;
            }
        }

        private void areaCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            var val = areaCbx.SelectedValue;

            if (val is Area area)
            {
                if (area.Id == -1)
                {
                    return;
                }
            }
            else if (val is int)
            {
                int areaId = (int)val;
                if (areaId == -1)
                    return;
                Area targetArea = Areas.FirstOrDefault(area => area.Id == areaId);
                nameTxtBox.Text = targetArea.Name;
            }
        }
        private bool ConfirmChange()
        {
            int areaId = (int)areaCbx.SelectedValue;
            Area targetArea = Areas.FirstOrDefault(area => area.Id == areaId);

            if (targetArea.Name != nameTxtBox.Text)
                nameChanged = true;
            if (targetArea.Name == nameTxtBox.Text)
            {
                areaErrorLabel.Visible = true;
                areaErrorLabel.Text = "Muuta alueen nimeä!";
                return false;
            }
            else
            {
                if (areaErrorLabel.Visible)
                    areaErrorLabel.Visible = false;
                return true;
            }
        }
        private async Task<bool> UpdateArea()
        {
            try
            {
                int areaId = (int)areaCbx.SelectedValue;
                Dictionary<string, object> columnValues = new Dictionary<string, object>();

                if (nameChanged)
                    columnValues.Add("name", nameTxtBox.Text);
                var response = await VillageNewbies._dbManager.AlterDataAsync("area", columnValues, $"id = {areaId}");
                if (response == null || response <= 0)
                {
                    throw new Exception("Error occurred while inserting data into the database.");
                }
                else
                {
                    MessageBox.Show("Alue muokattu onnistuneesti!");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("jokin meni pieleen: " + ex.Message);
                return false;
            }
        }
        private void AreaUpdateControl_VisibleChanged(object sender, EventArgs e)
        {
            counter++;
            if (isFirstLoad || counter <= 2)
                return;

            if (this.Visible)
            {
                GetAreas();
            }
        }

        private async void editAreaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validate())
                    return;

                if (!ConfirmChange())
                    return;

                if (!await UpdateArea())
                    return;

                MenuDefaultState();

                GetAreas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("jokin meni pieleen: " + ex.Message);
            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuDefaultState();
            VillageNewbies.menuhistory.RemoveAt(VillageNewbies.menuhistory.Count - 1);
            MenuSwitchRequested?.Invoke(Constants.areasMenu);
        }
    }
}
