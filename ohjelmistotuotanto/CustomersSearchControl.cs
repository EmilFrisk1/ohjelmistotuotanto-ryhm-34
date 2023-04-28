using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ohjelmistotuotanto
{
    public partial class CustomersSearchControl : UserControl
    {
        public delegate void MenuSwitchRequestHandler(string newControl); // Function pointer 
        public event MenuSwitchRequestHandler MenuSwitchRequested;
        public CustomersSearchControl()
        {
            InitializeComponent();
        }
        void menuDefaultState()
        {
            textBox.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
        private void addCustomertxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            VillageNewbies.menuhistory.RemoveAt(VillageNewbies.menuhistory.Count - 1);
            MenuSwitchRequested?.Invoke(Constants.customersMenu);
        }

        private async void addCustomerBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> customerColumnValues = new Dictionary<string, object>
                                {
                                    { "email",textBox2.Text},
                                    { "firstname", textBox.Text},
                                    { "lastname", textBox1.Text},
                                    { "phone", textBox3.Text},
                                    { "postal_code", textBox5.Text},
                                    { "address", textBox4.Text},
                                };

            int billInsRes = await VillageNewbies._dbManager.InsertDataAsync("customer", customerColumnValues);
            if (billInsRes <= 0)
            {
                MessageBox.Show("Error occurred while inserting data into the database.");
            }
            else
            {
                MessageBox.Show("Asiakas lisätty onnistuneesti!");
            }
            menuDefaultState();
        }
    }
}
