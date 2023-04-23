using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ohjelmistotuotanto
{
    public partial class AddReservationMenuControl : UserControl
    {
        public delegate void MenuSwitchRequestHandler(string menu); // Function pointer 
        public event MenuSwitchRequestHandler MenuSwitchRequested;
        public StatusStrip statusStrip;
        public List<Customer> Customers { get; set; }
        public List<Cottage> Cottages { get; set; }

        public AddReservationMenuControl()
        {
            InitializeComponent();
        }

        private void AddReservationMenuControl_Load(object sender, EventArgs e)
        {
            // Set the default value to the current date
            fromDatePicker.Value = DateTime.Today;
            whereDatePicker.Value = DateTime.Today;

            // Set the MinDate and MaxDate to the current date
            fromDatePicker.MinDate = DateTime.Today;
            whereDatePicker.MinDate = DateTime.Today;

            // Get customers and display then on a combobox | each entry linked with id
            var customers = VillageNewbies._dbManager.SelectDataAsync("customer", new List<string>() { "id", "email" });
            Customers = new List<Customer>();
            setUpCustomersCbx(customers);

            // Get cottages and display then on a combobox | each entry linked with id
            var cottages = VillageNewbies._dbManager.SelectDataAsync("cottage", new List<string>() { "id", "cottage_name" });
            Cottages = new List<Cottage>();
            setUpCottagesCbx(cottages);
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuSwitchRequested?.Invoke(Constants.rrvtMenu);
        }

        async private void addReservationBtn_Click(object sender, EventArgs e)
        {
            // Check that all form fields are valid
            if (cottageCbx.SelectedIndex == -1 || string.IsNullOrEmpty(cottageCbx.Text) || customerCbx.SelectedIndex == -1 || string.IsNullOrEmpty(cottageCbx.Text))
            {
                statusStrip.Visible = true;
                return;
            }
            else
            { // no error hide it
                if (statusStrip.Visible)
                {
                    //formErrorLabel.Visible = false;
                    statusStrip.Visible = false;
                }
            }

            if (fromDatePicker.Value == whereDatePicker.Value) // special validation for dates
            {
                dateErrorLabel.Visible = true;
                dateErrorLabel.Text = "Valitse mihin asti varaus on";
                return;
            }
            else if (fromDatePicker.Value > whereDatePicker.Value)
            {
                dateErrorLabel.Visible = true;
                dateErrorLabel.Text = "Mihin liian pieni";
                return;
            }
            else
            { // no error hide it
                if (dateErrorLabel.Visible)
                {
                    dateErrorLabel.Visible = false;
                }
            }

            string startDate = fromDatePicker.Value.ToString("yyyy-MM-dd");
            string endDate = whereDatePicker.Value.ToString("yyyy-MM-dd");
            int customerId = (int)customerCbx.SelectedValue;
            int cottageId = (int)cottageCbx.SelectedValue;

            var res = VillageNewbies._dbManager.CallCheckAvailabilityAndReserveAsync(cottageId, startDate, endDate, customerId);

            if (res.Result == -1)
            {
                MessageBox.Show("Tämä varaushaarukka onjo käytössä");
            }
            else
            {
                MessageBox.Show("Varaus lisätty onnistuneesti"); // TODO - what next? mainmenu?
            }
        }


        private void setUpCustomersCbx(Task<DataTable> customers)
        {
            if (customers.Result?.Rows != null && customers.Result.Rows.Count > 0)
            {
                foreach (DataRow row in customers.Result.Rows)
                {
                    var id = (int)row[0];
                    var email = (string)row[1];

                    Customers.Add(new Customer { Id = id, Email = email });
                }
                customerCbx.DataSource = Customers;
                customerCbx.DisplayMember = "Email";
                customerCbx.ValueMember = "Id";
            }
        }

        private void setUpCottagesCbx(Task<DataTable> cottages)
        {
            if (cottages.Result?.Rows != null && cottages.Result.Rows.Count > 0)
            {
                foreach (DataRow row in cottages.Result.Rows)
                {
                    var id = (int)row[0];
                    var name = (string)row[1];

                    Cottages.Add(new Cottage { Id = id, Name = name });
                }
                cottageCbx.DataSource = Cottages;
                cottageCbx.DisplayMember = "Name";
                cottageCbx.ValueMember = "Id";
            }
        }

        private void customerTxtBox_TextChanged(object sender, EventArgs e)
        {
            ComboBoxUtility.FilterCustomers(customerCbx, Customers, customerTxtBox.Text);
        }

        private void cottageTxtBox_TextChanged(object sender, EventArgs e)
        {
            ComboBoxUtility.FilterCottages(cottageCbx, Cottages, cottageTxtBox.Text);
        }
    }
}
