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
    public partial class BillingUpdateControl : UserControl
    {
        public delegate void MenuSwitchRequestHandler(string menu); // Function pointer 
        public event MenuSwitchRequestHandler MenuSwitchRequested;
        public static bool nameChanged = false;
        private bool isFirstLoad = true;
        private static int counter = 0;
        public List<InvoiceDataModel> Invoices { get; set; }
        public BillingUpdateControl()
        {
            InitializeComponent();
        }

        private async void BillingUpdateControl_Load(object sender, EventArgs e)
        {
            isFirstLoad = false;

            // Initialize lists
            Invoices = new List<InvoiceDataModel>();
            string billQuery = $"SELECT r.start_date, r.end_date, b.id AS bill_id, b.status AS tilanne, b.sum, b.issue_date, b.due_date, c.city AS c_city, c.postal_code AS c_postal_code, c.address AS c_address, CONCAT(c.firstname, ' ', c.lastname) AS c_full_name, co.description FROM bill b JOIN reservation r ON b.reservation_id = r.id JOIN customer c ON r.customer_id = c.id JOIN cottage co ON r.cottage_id = co.id;";
            Invoices = await VillageNewbies._dbManager.GetBillDetails(billQuery);

            billsDataGridView.DataSource = Invoices;
        }
        private void PopulatePlaceholderValues()
        {
            DataGridViewRow selectedRow = billsDataGridView.CurrentRow;
            if (selectedRow != null)
            {
                // Set the bill placeholder
                string billStatus = (string)selectedRow.Cells["status"].Value;
                string billId = (string)selectedRow.Cells["BillId"].Value;
                if (billStatus != null)
                {
                    InvoiceDataModel selectedBill = Invoices.FirstOrDefault(b => b.BillId == billId);
                    if (selectedBill.Status == "PENDING")
                    {
                        billsCbx.SelectedIndex = 0;
                    } else if (selectedBill.Status == "PAID")
                    {
                        billsCbx.SelectedIndex = 1;
                    } else if (selectedBill.Status == "CANCELLED")
                    {
                        billsCbx.SelectedIndex = 2;
                    }
                }
            }
        }

        private void billsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulatePlaceholderValues();
        }

        // private void 

        private bool Validate()
        {
            if (billsCbx.SelectedIndex == -1)
                return false;
            else
                return true;
        }

        private async void editBillBtn_Click(object sender, EventArgs e)
        {
            if (!Validate())
                return;

            try
            {
                DataGridViewRow selectedRow = billsDataGridView.CurrentRow;
                var selectedIndex= (int)billsCbx.SelectedIndex;
                string billId = (string)selectedRow.Cells["BillId"].Value;

                Dictionary<string, object> columnValues = new Dictionary<string, object>();

                if (selectedIndex == 0)
                {
                    columnValues.Add("status", "PENDING");

                } else if(selectedIndex == 1)
                {
                    columnValues.Add("status", "PAID");
                } else if (selectedIndex == 2)
                {
                    columnValues.Add("status", "CANCELLED");
                }

                var response = await VillageNewbies._dbManager.AlterDataAsync("bill", columnValues, $"id = {billId}");
                if (response == null || response <= 0)
                {
                    throw new Exception("Error occurred while inserting data into the database.");
                }
                else
                {
                    MessageBox.Show("Palvelu muokattu onnistuneesti!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("jokin meni pieleen: " + ex.Message);
            }
        }
    }
}
