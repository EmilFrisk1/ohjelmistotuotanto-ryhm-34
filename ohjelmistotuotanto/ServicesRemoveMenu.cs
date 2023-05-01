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
    public partial class ServicesRemoveMenu : UserControl
    {
        public delegate void MenuSwitchRequestHandler(string menu); // Function pointer 
        public event MenuSwitchRequestHandler MenuSwitchRequested;
        private bool isFirstLoad = true;
        private static int counter = 0;
        public List<Service> Services { get; set; }
    
        public ServicesRemoveMenu()
        {
            InitializeComponent();
        }

        private async void ServicesRemoveMenu_Load(object sender, EventArgs e)
        {
            isFirstLoad = false;

            Services = new List<Service>() { new Service { Id = -1, Name = string.Empty } };

            GetServices();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            VillageNewbies.menuhistory.RemoveAt(VillageNewbies.menuhistory.Count - 1);
            MenuSwitchRequested?.Invoke(Constants.srvcMenu);
            MenuDefaultState();
        }

        private void MenuDefaultState()
        {
            servicesCbx.SelectedIndex = 0;
            if (serviceErrorLabel.Visible)
                serviceErrorLabel.Visible = false;
        }

        private async void removeBtn_Click(object sender, EventArgs e)
        {
            if (!Validate())
                return;

            if (!await RemoveService())
                return;

            GetServices();
        }

        private bool Validate()
        {
            // validate
            if ((int)servicesCbx.SelectedValue == -1)
            {
                serviceErrorLabel.Visible = true;
                return false;
            }
            else
            {
                if (serviceErrorLabel.Visible)
                {
                    serviceErrorLabel.Visible = false;
                    return true;
                }
                return true;
            }
        }

        private async Task<bool> RemoveService()
        {
            var response = await VillageNewbies._dbManager.DeleteDataAsync("service", $"id = {(int)servicesCbx.SelectedValue}");
            if (response == null || response <= 0)
            {
                MessageBox.Show("Jokin meni pieleen");
                return false;
            }
            else
            {
                MessageBox.Show("Palvelu poistettu onnistuneesti");
                return true;
            }
        }

        private async void GetServices()
        {
            // Get services and display then on a combobox | each entry linked with id
            var services = await VillageNewbies._dbManager.SelectDataAsync("service", new List<string>() { "id", "name" });
            ComboBoxUtility.setUpServicesCbx(services, Services, servicesCbx);
        }

        private void ServicesRemoveMenu_VisibleChanged(object sender, EventArgs e)
        {

            counter++;
            if (isFirstLoad || counter <= 2)
                return;

            if (this.Visible)
            {
                GetServices();
            }

        }
    }
}
