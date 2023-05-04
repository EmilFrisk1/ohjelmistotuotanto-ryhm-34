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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ohjelmistotuotanto
{
    public partial class CustomersUpdateControl : UserControl
    {
        public delegate void MenuSwitchRequestHandler(string newControl); // Function pointer 
        public event MenuSwitchRequestHandler MenuSwitchRequested;
        public List<ClientDatamodel> ClientDatamodels { get; set; }
        public List<Customer> Customers { get; set; }
        private bool isFirstLoad = true;
        private static int counter = 0;
        public static bool firstNameChanged = false;
        public static bool lastNameChanged = false;
        public static bool emailChanged = false;
        public static bool phoneNumberChanged = false;
        public static bool addressChanged = false;
        public static bool postalNumberChanged = false;
        public static bool cityChanged = false;
        public CustomersUpdateControl()
        {
            InitializeComponent();
        }
        
        private void MenuDefaultState() //empty all textboxes and combobox
        {
            customerTxtBox.Text = "";
            textBox.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            customerCbx.SelectedIndex = 0;
        }

        private void customerTxtBox_TextChanged(object sender, EventArgs e) 
        {
            ComboBoxUtility.FilterCustomers(customerCbx, Customers, customerTxtBox.Text); //search function for customertextbox
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuDefaultState();
            VillageNewbies.menuhistory.RemoveAt(VillageNewbies.menuhistory.Count - 1);
            MenuSwitchRequested?.Invoke(Constants.customersMenu);
        }

        private async void CustomersUpdateControl_Load(object sender, EventArgs e)
        {
            isFirstLoad = false;

            // Initialize lists
            Customers = new List<Customer>() { new Customer { Id = -1, Email = string.Empty } };
            ClientDatamodels = new List<ClientDatamodel>();
            GetCustomers();
        }
        private void setUpCustomersCbx(DataTable customers) //set combobox
        {

            if (customers.Rows != null && customers.Rows.Count > 0)
            {
                if(ClientDatamodels.Count > 0)
                {
                    ClientDatamodels.Clear();
                }
                customerCbx.DataSource = null;
                Customers.RemoveRange(1, Customers.Count - 1);
                foreach (DataRow row in customers.Rows)
                {
                    var id = (int)row[0];
                    var email = (string)row[1];
                    var firstname = (string)row[2];
                    var lastname = (string)row[3];
                    var phonenumber = (string)row[4];
                    var postalnumber = (int)row[5];
                    var address = (string)row[6];
                    var city = (string)row[7];

                    ClientDatamodels.Add(new ClientDatamodel
                    {
                        Id = id,
                        Email = email,
                        FirstName = firstname,
                        LastName = lastname,
                        Address = address,
                        PostalNumber = postalnumber,
                        PhoneNumber = phonenumber,
                        City = city
                    });
                    Customers.Add(new Customer
                    {
                        Id = id,
                        Email = email
                    });
                }
                customerCbx.DataSource = Customers;
                customerCbx.DisplayMember = "Email";
                customerCbx.ValueMember = "Id";

            }
        }

        private void customerCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            var val = customerCbx.SelectedValue;

            if (val is ClientDatamodel clientdatamodel)
            {
                if (clientdatamodel.Id == -1)
                {
                    return;
                }
            }
            else if (val is int)
            {
                int clientmodelid = (int)val;
                if (clientmodelid == -1)
                    return;

                // Valid choice
                // fill in place holders for the selection
                ClientDatamodel targetClientModels = ClientDatamodels.FirstOrDefault(clientdatamodel => clientdatamodel.Id == clientmodelid);
                textBox.Text = targetClientModels.FirstName;
                textBox1.Text = targetClientModels.LastName;
                textBox2.Text = targetClientModels.Email;
                textBox3.Text = targetClientModels.PhoneNumber;
                textBox4.Text = targetClientModels.Address;
                textBox5.Text = targetClientModels.PostalNumber.ToString();
                textBox6.Text = targetClientModels.City;
            }
        }
        private async Task<bool> UpdateCustomer()
        {
            try
            {
                int clientmodelid = (int)customerCbx.SelectedValue;
                Dictionary<string, object> columnValues = new Dictionary<string, object>();

                if (firstNameChanged)
                    columnValues.Add("firstname", textBox.Text);
                if (lastNameChanged)
                    columnValues.Add("lastname", textBox1.Text);
                if (emailChanged)
                    columnValues.Add("email", textBox2.Text);
                if (phoneNumberChanged)
                    columnValues.Add("phone", textBox3.Text);
                if (addressChanged)
                    columnValues.Add("address", textBox4.Text);
                if (postalNumberChanged)
                    columnValues.Add("postal_code", textBox5.Text);
                if (cityChanged)
                    columnValues.Add("city", textBox6.Text);

                var response = await VillageNewbies._dbManager.AlterDataAsync("customer", columnValues, $"id = {clientmodelid}");
                if (response == null || response <= 0)
                {
                    throw new Exception("Error occurred while inserting data into the database.");
                }
                else
                {
                    MessageBox.Show("Asiakas muokattu onnistuneesti!");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("jokin meni pieleen: " + ex.Message);
                return false;
            }
        }
        private bool Validate()
        {
            // validate
            if ((int)customerCbx.SelectedValue == -1)
            {
                customerErrorLabel.Visible = true;
                customerErrorLabel.Text = "Valitse asiakas";
                return false;
            }
            else
            {
                if (customerErrorLabel.Visible)
                {
                    customerErrorLabel.Visible = false;
                }
                return true;
            }
        }
        private async void GetCustomers() {
            var customers = await VillageNewbies._dbManager.SelectDataAsync("customer");
            setUpCustomersCbx(customers);
        }

        private async void editCustomerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validate())
                    return;

                if (!ConfirmChange())
                    return;

                if (!await UpdateCustomer())
                    return;
                MenuDefaultState();
                GetCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("jokin meni pieleen: " + ex.Message);
            }
        }
        private bool ConfirmChange()
        {
            int clientdatamodelid = (int)customerCbx.SelectedValue;
            ClientDatamodel targetService = ClientDatamodels.FirstOrDefault(clientdatamodel => clientdatamodel.Id == clientdatamodelid);

            if (targetService.FirstName != textBox.Text)
                firstNameChanged = true;
            if (targetService.LastName != textBox1.Text)
                lastNameChanged = true;
            if (targetService.Email != textBox2.Text)
                emailChanged = true;
            if (targetService.PhoneNumber != textBox3.Text)
                phoneNumberChanged = true;
            if (targetService.Address != textBox4.Text)
                addressChanged = true;
            if (targetService.PostalNumber.ToString() != textBox5.Text)
                postalNumberChanged = true;
            if (targetService.City != textBox5.Text)
                cityChanged = true;

            if (targetService.FirstName == textBox.Text && targetService.LastName == textBox1.Text && targetService.Email == textBox2.Text &&
                targetService.PhoneNumber == textBox3.Text && targetService.Address == textBox4.Text && targetService.PostalNumber.ToString() == textBox5.Text && targetService.City == textBox6.Text)
            {
                customerErrorLabel.Visible = true;
                customerErrorLabel.Text = "Muuta jonkun kentän arvoa";
                return false;
            }
            else
            {
                if (customerErrorLabel.Visible)
                    customerErrorLabel.Visible = false;
                return true;
            }
        }

        private void customerTxtBox_TextChanged_1(object sender, EventArgs e)
        {
            ComboBoxUtility.FilterCustomers(customerCbx, Customers, customerTxtBox.Text);
        }

        private void CustomersUpdateControl_VisibleChanged(object sender, EventArgs e)
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
