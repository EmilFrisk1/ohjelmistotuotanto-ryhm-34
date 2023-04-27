using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Datatypes.Scalar.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using Button = System.Windows.Forms.Button;
using TextBox = System.Windows.Forms.TextBox;

namespace ohjelmistotuotanto
{
    public partial class AddReservationMenuControl : UserControl
    {
        public delegate void MenuSwitchRequestHandler(string menu); // Function pointer 
        public event MenuSwitchRequestHandler MenuSwitchRequested;
        public StatusStrip statusStrip;
        public Panel appContainer;
        public List<Customer> Customers { get; set; }
        public List<Cottage> Cottages { get; set; }
        public List<Service> Services { get; set; }
        public List<ClientServices> ClientServices { get; set; }
        public List<TextBox> ServiceTextBoxes { get; set; }
        public List<Button> ServiceButtons { get; set; }


        public AddReservationMenuControl()
        {
            InitializeComponent();
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

        private void setUpServicesCbx(Task<DataTable> services)
        {
            if (services.Result?.Rows != null && services.Result.Rows.Count > 0)
            {
                foreach (DataRow row in services.Result.Rows)
                {
                    var id = (int)row[0];
                    var name = (string)row[1];

                    Services.Add(new Service { Id = id, Name = name });
                }
                servicesCbx.DataSource = Services;
                servicesCbx.DisplayMember = "Name";
                servicesCbx.ValueMember = "Id";
            }
        }

        private TextBox CreateTextBox(string text, Point loc, Size sz, string name)
        {
            var tb = new TextBox();
            tb.Location = loc;
            tb.Size = sz;
            tb.Name = name;
            tb.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            clientServicesContainer.Controls.Add(tb);
            tb.Text = text;
            tb.Enabled = false;

            return tb;
        }

        Button CreateButton(string text, Point loc, Size sz, string name)
        {
            var button = new Button();
            button.Text = text;
            button.Location = loc;
            button.Size = sz;
            button.Name = name;
            button.ForeColor = Color.WhiteSmoke;
            button.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            button.BackColor = Color.Crimson;
            button.Click += new EventHandler(deleteService);

            clientServicesContainer.Controls.Add(button);

            return button;
        }

        void deleteService(object sender, EventArgs e)
        {
            var button = (Button)sender;

            int index = button.Name.IndexOf("_");
            string idString = button.Name.Substring(index + 1);

            // Find the clients service from the services list and remove it
            try
            {
                int.TryParse(idString, out int id);
                ClientServices targetService = ClientServices.FirstOrDefault(service => service.Id == id);
                if (targetService != null)
                {
                    ClientServices.Remove(targetService);
                }
                else
                {
                    MessageBox.Show("Target service was not found");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


            // Find all textboxes and delete button on this row
            var matchingTextBoxes = ServiceTextBoxes.Where(txtBox =>
            {
                int index = txtBox.Name.IndexOf("_");
                string serviceId = txtBox.Name.Substring(index + 1);
                if (serviceId == idString)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });

            var deleteButton = ServiceButtons.FirstOrDefault(btn =>
            {
                int index = btn.Name.IndexOf("_");
                string serviceId = btn.Name.Substring(index + 1);
                if (serviceId == idString)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });

            // remove them
            if (matchingTextBoxes.Any())
            {
                foreach (var matchingTextBox in matchingTextBoxes)
                {
                    clientServicesContainer.Controls.Remove(matchingTextBox);
                    matchingTextBox.Dispose();
                }
            }

            if (deleteButton != null)
            {
                clientServicesContainer.Controls.Remove(deleteButton);
                deleteButton.Dispose();
            }
        }

        void menuDefaultState()
        {
            cottageTxtBox.Text = "";
            cottageCbx.SelectedIndex = 0;
            customerTxtBox.Text = "";
            customerCbx.SelectedIndex = 0;
            servicesCbx.SelectedIndex = 0;
            serviceQuantityTxtBox.Text = "";

            // Remove all client services if they exist
            if (ServiceButtons.Count > 0)
            {
                foreach (var serviceBtn in ServiceButtons)
                {
                    serviceBtn.PerformClick();
                }
            }
        }

        private static void HideErrors(StatusStrip statusStrip, Label dateErrorLabel, Label serviceErrorLabel)
        {
            if (statusStrip.Visible)
            {
                statusStrip.Visible = false;
            }

            if (dateErrorLabel.Visible)
            {
                dateErrorLabel.Visible = false;
            }

            if (serviceErrorLabel.Visible)
            {
                serviceErrorLabel.Visible = false;
            }
        }

        private void AddReservationMenuControl_Load_1(object sender, EventArgs e)
        {
            // Initialize all needed lists
            Cottages = new List<Cottage>() { new Cottage { Id = -1, Name = string.Empty } };
            Customers = new List<Customer>() { new Customer { Id = -1, Email = string.Empty } };
            Services = new List<Service>() { new Service { Id = -1, Name = string.Empty } };
            ClientServices = new List<ClientServices>();
            ServiceTextBoxes = new List<TextBox>();
            ServiceButtons = new List<Button>();

            // Set the default value to the current date
            fromDatePicker.Value = DateTime.Today;
            whereDatePicker.Value = DateTime.Today;

            // Set the MinDate and MaxDate to the current date
            fromDatePicker.MinDate = DateTime.Today;
            whereDatePicker.MinDate = DateTime.Today;

            // Get customers and display then on a combobox | each entry linked with id
            var customers = VillageNewbies._dbManager.SelectDataAsync("customer", new List<string>() { "id", "email" });
            setUpCustomersCbx(customers);

            // Get cottages and display then on a combobox | each entry linked with id
            var cottages = VillageNewbies._dbManager.SelectDataAsync("cottage", new List<string>() { "id", "cottage_name" });
            setUpCottagesCbx(cottages);

            // Get services and display then on a combobox | each entry linked with id
            var services = VillageNewbies._dbManager.SelectDataAsync("service", new List<string>() { "id", "name" });
            setUpServicesCbx(services);
        }

        private async void addReservationBtn_Click_1(object sender, EventArgs e)
        {
            // Check that all form fields are valid
            if (cottageCbx.SelectedIndex == -1 || string.IsNullOrEmpty(cottageCbx.Text) || customerCbx.SelectedIndex == -1 || string.IsNullOrEmpty(cottageCbx.Text))
            {
                statusStrip.Visible = true;
                // Scroll the form to the bottom to show the status label
                appContainer.VerticalScroll.Value = appContainer.VerticalScroll.Maximum;

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

            // Prepare column data
            string startDate = fromDatePicker.Value.ToString("yyyy-MM-dd");
            string endDate = whereDatePicker.Value.ToString("yyyy-MM-dd");
            int customerId = (int)customerCbx.SelectedValue;
            int cottageId = (int)cottageCbx.SelectedValue;
            var distanceInDays = (fromDatePicker.Value - DateTime.Now).Days;
            bool reservationCancelable = true;

            if (distanceInDays <= 7)
            {
                reservationCancelable = false;
            }

            var res = VillageNewbies._dbManager.CallCheckAvailabilityAndReserveAsync(cottageId, startDate, endDate, customerId);

            int reservationId = res.Result;
            if (reservationId == -1)
            {
                MessageBox.Show("Tämä varaushaarukka onjo käytössä");
            }
            else
            {
                MessageBox.Show("Varaus lisätty onnistuneesti"); // TODO - what next? mainmenu?

                // LInk the reservation with the possible services
                if (ClientServices.Count > 0)
                {
                    AddServices(reservationId);
                }

                // add a bill if reservation is not cancelable
                if (!reservationCancelable)
                {
                    VillageNewbies._dbManager.CreateBill(reservationId, endDate);
                }

                // Clear the menu to default state
                menuDefaultState();
            }
        }

        private void addServiceBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Input validation
                // Check that user has selected a service
                if (servicesCbx.SelectedIndex == -1 || string.IsNullOrEmpty(servicesCbx.Text))
                {
                    serviceErrorLabel.Visible = true;
                    serviceErrorLabel.Text = "Valitse jokin palvelu";
                    return;
                }
                else
                {// hide err
                    if (serviceErrorLabel.Visible)
                    {
                        serviceErrorLabel.Visible = false;
                    }
                }

                // Check that the quantity is bigger than 0
                int serviceQuantity = 0;
                int.TryParse(serviceQuantityTxtBox.Text, out serviceQuantity);

                if (serviceQuantity <= 0)
                {
                    serviceErrorLabel.Visible = true;
                    serviceErrorLabel.Text = "määrä liian pieni";
                    return;
                }
                else
                { // hide err
                    if (serviceErrorLabel.Visible)
                    {
                        serviceErrorLabel.Visible = false;
                    }
                }

                // Check that the service is not already added
                var srvc = ClientServices.FirstOrDefault(service => service.Id == (int)servicesCbx.SelectedValue);
                if (srvc != null)
                {
                    serviceErrorLabel.Visible = true;
                    serviceErrorLabel.Text = "Palvelu onjo lisätty";
                    return;
                }
                else
                { // hide err
                    if (serviceErrorLabel.Visible)
                    {
                        serviceErrorLabel.Visible = false;
                    }
                }

                // Input OK - set quantity back to one
                serviceQuantityTxtBox.Text = "1";

                // Layout cooridnates for clients service rows and columns
                int baseX1 = 10;
                int baseX2 = 216;
                int baseX3 = 300;
                int baseY = 34;
                int margin = 10;
                int rowHeight = 29;

                // Get comboBox service values and make it into an object
                string serviceName = servicesCbx.Text;
                int serviceId = (int)servicesCbx.SelectedValue;
                ClientServices.Add(new ClientServices() { Id = serviceId, Name = serviceName, Quantity = serviceQuantity });
                int row = ClientServices.Count - 1;

                // Create controls
                TextBox serviceNameTxtBox = CreateTextBox(serviceName, new Point(baseX1, baseY + (row * (rowHeight + margin))), new Size(194, rowHeight), $"1-{serviceName}_{serviceId}");
                TextBox clientServiceQuantityTxtBox = CreateTextBox(serviceQuantity.ToString(), new Point(baseX2, baseY + (row * (rowHeight + margin))), new Size(74, rowHeight), $"2-{serviceName}_{serviceId}");
                Button deleteBtn = CreateButton("poista", new Point(baseX3, baseY + (row * (rowHeight + margin))), new Size(88, rowHeight), $"del-{serviceName}_{serviceId}");


                // save them to list
                ServiceTextBoxes.Add(serviceNameTxtBox);
                ServiceTextBoxes.Add(clientServiceQuantityTxtBox);
                ServiceButtons.Add(deleteBtn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Jokin meni pieleen");
            }
        }

        private void serviceQuantityTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow numbers and backspace
            if (Regex.IsMatch(e.KeyChar.ToString(), @"^[0-9]+$") || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void customerTxtBox_TextChanged_1(object sender, EventArgs e)
        {
            ComboBoxUtility.FilterCustomers(customerCbx, Customers, customerTxtBox.Text);
        }

        private void cottageTxtBox_TextChanged_1(object sender, EventArgs e)
        {
            ComboBoxUtility.FilterCottages(cottageCbx, Cottages, cottageTxtBox.Text);
        }

        private async void AddServices(int reservationId)
        {
            try
            {
                foreach (var clientService in ClientServices)
                {
                    Dictionary<string, object> columnValues = new Dictionary<string, object>
                        {
                            { "reservation_id", reservationId },
                            { "service_id", clientService.Id },
                            { "quantity", clientService.Quantity }
                        };

                    int result = await VillageNewbies._dbManager.InsertDataAsync("reservation_service", columnValues);

                    if (result <= 0)
                    {
                        throw new Exception("Error occurred while inserting data into the database.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Jokin meni pieleen palvelun lisäämisessä. \n" + ex.Message);
            }
        }

        private void prevBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MenuSwitchRequested?.Invoke(Constants.rrvtMenu);
            HideErrors(statusStrip, dateErrorLabel, serviceErrorLabel);
            menuDefaultState();
        }
    }
}
