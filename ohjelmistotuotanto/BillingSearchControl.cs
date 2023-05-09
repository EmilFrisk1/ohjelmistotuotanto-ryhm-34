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
    public partial class BillingSearchControl : UserControl
    {
        public delegate void MenuSwitchRequestHandler(string newControl); // Function pointer 
        public event MenuSwitchRequestHandler MenuSwitchRequested;
        public BillingSearchControl()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VillageNewbies.menuhistory.RemoveAt(VillageNewbies.menuhistory.Count - 1);
            MenuSwitchRequested?.Invoke(Constants.billingMenu);
        }
        public static async void GetBills()
        { // Gets details of the bill that requires an invoice
            string billQuery = $"SELECT r.start_date, r.end_date, b.id AS bill_id, b.sum, b.issue_date, b.due_date, c.city AS c_city, c.postal_code AS c_postal_code, c.address AS c_address, CONCAT(c.firstname, ' ', c.lastname) AS c_full_name, co.description FROM bill b JOIN reservation r ON b.reservation_id = r.id JOIN customer c ON r.customer_id = c.id JOIN cottage co ON r.cottage_id = co.id";
            var billsdetails = await VillageNewbies._dbManager.GetBillDetails(billQuery);
        }
        private async void searchBtn_Click(object sender, EventArgs e)
        {
            GetBills();
        }

        private void BillingSearchControl_Load(object sender, EventArgs e)
        {

        }
    }
}
