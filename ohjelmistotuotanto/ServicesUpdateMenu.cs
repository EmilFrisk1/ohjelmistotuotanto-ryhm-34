using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Datatypes.Scalar.Types;

namespace ohjelmistotuotanto
{
    public partial class ServicesUpdateMenu : UserControl
    {
        public delegate void MenuSwitchRequestHandler(string menu); // Function pointer 
        public event MenuSwitchRequestHandler MenuSwitchRequested;
        public List<Service> Services { get; set; }
        public List<ServiceDataModel> ServicesDetails { get; set; }
        public static bool nameChanged = false;
        public static bool priceChanged = false;
        private bool isFirstLoad = true;
        private static int counter = 0;
        public ServicesUpdateMenu()
        {
            InitializeComponent();
        }

        private void ServicesUpdateMenu_Load(object sender, EventArgs e)
        {
            isFirstLoad = false;

            // INitialize lists
            Services = new List<Service>() { new Service { Id = -1, Name = string.Empty } };
            ServicesDetails = new List<ServiceDataModel>();

            GetServices();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuDefaultState();
            VillageNewbies.menuhistory.RemoveAt(VillageNewbies.menuhistory.Count - 1);
            MenuSwitchRequested?.Invoke(Constants.srvcMenu);
        }
        private async void GetServices()
        {
            // Get services and display then on a combobox | each entry linked with id
            var services = await VillageNewbies._dbManager.SelectDataAsync("service");
            ComboBoxUtility.setUpServicesCbx(services, Services, servicesCbx);

            if (ServicesDetails.Count > 0)
                ServicesDetails.Clear();

            foreach (DataRow row in services.Rows)
            {
                var id = (int)row[0];
                var name = (string)row[1];
                var price = (decimal)row[2];

                ServicesDetails.Add(new ServiceDataModel { Id = id, Name = name, Price = price });
            }
        }

        private async void editServiceBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validate())
                    return;
                
                if (!ConfirmChange())
                    return;

                if (!await UpdateService())
                    return;

                MenuDefaultState();

                GetServices();
            }
            catch (Exception ex)
            {
                MessageBox.Show("jokin meni pieleen: " + ex.Message);
            }
        }

        private void priceTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {// Allow numbers, spaces and one dot
            TextBoxUtility.AllowOnlyNumbers(sender, e);
        }

        private void MenuDefaultState()
        {
            nameTxtBox.Text = string.Empty;
            priceTxtBox.Text = string.Empty;
            servicesCbx.SelectedIndex = 0;
            if (serviceErrorLabel.Visible)
                serviceErrorLabel.Visible = false;
            if(priceErrLabel.Visible)
                priceErrLabel.Visible = false;  
        }

        private bool Validate()
        {
            // validate
            if ((int)servicesCbx.SelectedValue == -1)
            {
                serviceErrorLabel.Visible = true;
                serviceErrorLabel.Text = "Valitse palvelu";
                return false;
            }
            else if (priceTxtBox.Text.Length > 9)
            {
                priceErrLabel.Visible = true;
                return false;
            }
            else
            {
                if (serviceErrorLabel.Visible)
                {
                    serviceErrorLabel.Visible = false;
                } 

                if (priceErrLabel.Visible)
                {
                    priceErrLabel.Visible = false;
                }

                return true;
            }
        }

        private void servicesCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            var val = servicesCbx.SelectedValue;

            if (val is Service service)
            {
                if (service.Id == -1)
                {
                    return;
                }
            }
            else if (val is int)
            {
                int serviceId = (int)val;
                if (serviceId == -1)
                    return;

                // Valid choice
                // fill in place holders for the selection
                ServiceDataModel targetService = ServicesDetails.FirstOrDefault(service => service.Id == serviceId);
                nameTxtBox.Text = targetService.Name;
                priceTxtBox.Text = targetService.Price.ToString();
            }
        }

        private bool ConfirmChange()
        {
            int serviceId = (int)servicesCbx.SelectedValue;
            ServiceDataModel targetService = ServicesDetails.FirstOrDefault(service => service.Id == serviceId);

            if (targetService.Name != nameTxtBox.Text)
                nameChanged = true;

            if (targetService.Price.ToString() != priceTxtBox.Text)
                priceChanged = true;

            if (targetService.Name == nameTxtBox.Text && targetService.Price.ToString() == priceTxtBox.Text)
            {
                serviceErrorLabel.Visible = true;
                serviceErrorLabel.Text = "Muuta jotain kentän arvoa";
                return false;
            }
            else
            {
                if (serviceErrorLabel.Visible)
                    serviceErrorLabel.Visible = false;
                return true;
            }
        }

        private async Task<bool> UpdateService()
        {
            try
            {
                int serviceId = (int)servicesCbx.SelectedValue;
                Dictionary<string, object> columnValues = new Dictionary<string, object>();

                if (nameChanged)
                    columnValues.Add("name", nameTxtBox.Text);

                if (priceChanged)
                { // Trim price text field out of spaces
                    Double.TryParse(priceTxtBox.Text.Replace(" ", ""), out double price);
                    columnValues.Add("price", price);
                }

                var response = await VillageNewbies._dbManager.AlterDataAsync("service", columnValues, $"id = {serviceId}");
                if (response == null || response <= 0)
                {
                    throw new Exception("Error occurred while inserting data into the database.");
                }
                else
                {
                    MessageBox.Show("Palvelu muokattu onnistuneesti!");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("jokin meni pieleen: " + ex.Message);
                return false;
            }
        }

        private void ServicesUpdateMenu_VisibleChanged(object sender, EventArgs e)
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
