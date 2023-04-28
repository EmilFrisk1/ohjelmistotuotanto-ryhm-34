using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ohjelmistotuotanto
{
    public partial class MainMenuControl : UserControl
    {
        public delegate void MenuSwitchRequestHandler(string newControl); // Function pointer 
        public event MenuSwitchRequestHandler MenuSwitchRequested;
        public StatusStrip statusStrip;
        public MainMenuControl()
        {
            InitializeComponent();
        }

        private void customersBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuSwitchRequested?.Invoke(Constants.customersMenu);
        }

        private void reservationsBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MenuSwitchRequested?.Invoke(Constants.rrvtMenu);
        }

        private void MainMenuControl_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var customers = PrepareCustomersList(new List<FullCustomerDatamodel>());
            testContainer.DataSource = customers.Result;
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

        private void servicesBtn_Click(object sender, EventArgs e)
        {

        }

        private void billsBtn_Click(object sender, EventArgs e)
        {

        }

        private void areasBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
