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
    public partial class AreaRemoveControl : UserControl
    {
        public delegate void MenuSwitchRequestHandler(string menu); // Function pointer 
        public event MenuSwitchRequestHandler MenuSwitchRequested;
        private bool isFirstLoad = true;
        private static int counter = 0;
        public List<Area> Areas { get; set; }

        public AreaRemoveControl()
        {
            InitializeComponent();
        }

        private void AreaRemoveControl_Load(object sender, EventArgs e)
        {
            isFirstLoad = false;

            Areas = new List<Area>() { new Area { Id = -1, Name = string.Empty } };

            GetAreas();
        }

        private async void GetAreas()
        {
            // Get services and display then on a combobox | each entry linked with id
            var areas = await VillageNewbies._dbManager.SelectDataAsync("area", new List<string>() { "id", "name" });
            ComboBoxUtility.SetUpAreasCbx(areas, Areas, areaCbx);
        }
        private bool Validate()
        {
            // validate
            if ((int)areaCbx.SelectedValue == -1)
            {
                areaErrorLabel.Visible = true;
                return false;
            }
            else
            {
                if (areaErrorLabel.Visible)
                {
                    areaErrorLabel.Visible = false;
                    return true;
                }
                return true;
            }
        }
        private void MenuDefaultState()
        {
            areaCbx.SelectedIndex = 0;
            if (areaErrorLabel.Visible)
                areaErrorLabel.Visible = false;
        }
        private async Task<bool> RemoveArea()
        {
            try
            {
                var response = await VillageNewbies._dbManager.DeleteDataAsync("area", $"id = {(int)areaCbx.SelectedValue}");
                if (response == null || response <= 0)
                {
                    return false;
                }
                else
                {
                    MessageBox.Show("Alue poistettu onnistuneesti");
                    return true;
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Tämä alue on jo käytössä varauksessa, sitä ei voi poistaa.");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!Validate())
                return;

            if (!await RemoveArea())
                return;

            GetAreas();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuDefaultState();
            VillageNewbies.menuhistory.RemoveAt(VillageNewbies.menuhistory.Count - 1);
            MenuSwitchRequested?.Invoke(Constants.areasMenu);
        }

        private void AreaRemoveControl_VisibleChanged(object sender, EventArgs e)
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
