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
    public partial class CustomersAddControl : UserControl
    {
        public delegate void MenuSwitchRequestHandler(string newControl); // Function pointer 
        public event MenuSwitchRequestHandler MenuSwitchRequested;
        public CustomersAddControl()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VillageNewbies.menuhistory.RemoveAt(VillageNewbies.menuhistory.Count - 1);
            MenuSwitchRequested?.Invoke(Constants.customersMenu);
        }
        private async Task<List<FullCustomerDatamodel>> PrepareCustomersList(List<FullCustomerDatamodel> customers)
        {
            var response = await VillageNewbies._dbManager.SelectDataAsync("customer");
            foreach (DataRow row in response.Rows)
            {
                var id = (int)row["id"];
                var email = (string)row["email"];
                var firstName = (string)row["firstname"];
                var lastName = (string)row["lastname"];
                var phone = (string)row["phone"];
                var postalCode = (int)row["postal_code"];
                var address = (string)row["address"];
                customers.Add(new FullCustomerDatamodel() { Id = id, Email = email, Etunimi = firstName, Sukunimi = lastName, Phone = phone, PostalCode = postalCode, Address = address });
            }
            return customers;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var customers = PrepareCustomersList(new List<FullCustomerDatamodel>());
            searchGrid.DataSource = customers.Result;
        }
    }
}
