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
            var billsdetails = await VillageNewbies._dbManager.GetBillDetails(billQuery);
            billsDataGridView.DataSource = billsdetails;
        }
        private void PopulatePlaceholderValues()
        {
            DataGridViewRow selectedRow = billsDataGridView.CurrentRow;
            if (selectedRow != null)
            {
                // Set the bill placeholder
                string billStatus = (string)selectedRow.Cells["status"].Value;
                if (billStatus != null)
                {
                    InvoiceDataModel selectedBill = Invoices.FirstOrDefault(b => b.BillId == billStatus);
                    billsCbx.SelectedValue = selectedBill.Status;
                }
            }
        }

        private void billsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulatePlaceholderValues();
        }
    }
}
