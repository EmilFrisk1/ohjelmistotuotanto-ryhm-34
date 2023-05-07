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

            // Check if the service is bound on a reservation that cannot be cancelled, if so it can't be removed
            if (!await IsRemovable())
            {
                MessageBox.Show("Tämä palvelu on sidottuna varaukseen, sitä ei voi poistaa");
                return;
            }

            if (!await RemoveService())
                return;

            GetServices();
        }

        private async Task<bool> IsRemovable()
        {
            try
            {
                var response = await VillageNewbies._dbManager.IsRemovable($"SELECT * FROM reservation_service r_s JOIN reservation r ON r_s.reservation_id = r.id WHERE service_id = {(int)servicesCbx.SelectedValue} AND r.reservation_status = 'ACTIVE' OR r.reservation_status = 'PENDING'");
                if (response == null)
                {
                    return false;
                    
                } else if (response > 0)
                {
                    return false;
                }
                else
                    return true;
            } catch (Exception ex)
            {
                return false;
            }
        }

        private async Task<bool> CheckService()
        {
            try
            {
                var response = await VillageNewbies._dbManager.IsRemovable($"SELECT * FROM reservation_service r_s JOIN reservation r ON r_s.reservation_id = r.id WHERE service_id = {(int)servicesCbx.SelectedValue} AND r.reservation_status = 'PENDING'");
                if (response <= 0)
                {
                    throw new Exception("Error occurred while inserting data into the database.");
                }
                else
                    return true;
            } catch (Exception ex)
            {
                return false;
            }
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
            try
            {
                var response = await VillageNewbies._dbManager.DeleteDataAsync("service", $"id = {(int)servicesCbx.SelectedValue}");
                if (response == null || response <= 0)
                {
                    return false;
                }
                else
                {
                    MessageBox.Show("Palvelu poistettu onnistuneesti");
                    return true;
                }
            }  catch(InvalidOperationException ex)
            {
                MessageBox.Show("Tämä palvelu onjo käytössä varauksessa, sitä ei voi poistaa.");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
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
