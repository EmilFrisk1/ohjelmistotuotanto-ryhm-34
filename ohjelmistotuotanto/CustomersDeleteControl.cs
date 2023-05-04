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
    public partial class CustomersDeleteControl : UserControl
    {
        public delegate void MenuSwitchRequestHandler(string newControl); // Function pointer 
        public event MenuSwitchRequestHandler MenuSwitchRequested;
        private bool isFirstLoad = true;
        private static int counter = 0;
        public List<Customer> Customers { get; set; }
        public CustomersDeleteControl()
        {
            InitializeComponent();
        }
        private void MenuDefaultState()
        {
            customerCbx.SelectedIndex = 0;
            if (customerErrorLabel.Visible)
                customerErrorLabel.Visible = false;
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            VillageNewbies.menuhistory.RemoveAt(VillageNewbies.menuhistory.Count - 1);
            MenuSwitchRequested?.Invoke(Constants.customersMenu);
            MenuDefaultState();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        private async Task<bool> RemoveCustomer()
        {
            try
            {
                var response = await VillageNewbies._dbManager.DeleteDataAsync("customer", $"id = {(int)customerCbx.SelectedValue}");
                if (response == null || response <= 0)
                {
                    return false;
                }
                else
                {
                    MessageBox.Show("Asiakas poistettu onnistuneesti");
                    return true;
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Tämä asiakas on jo käytössä varauksessa, sitä ei voi poistaa.");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private async void GetCustomers()
        {
            // Get services and display then on a combobox | each entry linked with id
            var customers = await VillageNewbies._dbManager.SelectDataAsync("customer", new List<string>() { "id", "email" });
            ComboBoxUtility.SetUpCustomersCbx(customers, Customers, customerCbx);
        }

        private void CustomersDeleteControl_Load(object sender, EventArgs e)
        {
            isFirstLoad = false;
            Customers = new List<Customer>() { new Customer { Id = -1, Email = string.Empty } };
            GetCustomers();
        }
        private bool Validate()
        {
            // validate
            if ((int)customerCbx.SelectedValue == -1)
            {
                customerErrorLabel.Visible = true;
                return false;
            }
            else
            {
                if (customerErrorLabel.Visible)
                {
                    customerErrorLabel.Visible = false;
                    return true;
                }
                return true;
            }
        }

        private async void deleteBtn_Click_1(object sender, EventArgs e)
        {
            if (!Validate())
                return;

            if (!await RemoveCustomer())
                return;

            GetCustomers();
        }

        private void CustomersDeleteControl_VisibleChanged(object sender, EventArgs e)
        {
            counter++;
            if (isFirstLoad || counter <= 2)
                return;

            if (this.Visible)
            {
                GetCustomers();
            }

        }
    }
}
