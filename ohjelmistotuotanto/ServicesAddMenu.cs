using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Datatypes.Scalar.Types;

namespace ohjelmistotuotanto
{
    public partial class ServicesAddMenu : UserControl
    {
        public delegate void MenuSwitchRequestHandler(string menu); // Function pointer 
        public event MenuSwitchRequestHandler MenuSwitchRequested;
        public StatusStrip statusStrip;

        public ServicesAddMenu()
        {
            InitializeComponent();
        }

        private void ServicesAddMenu_Load(object sender, EventArgs e)
        {

        }

        private void priceTxtBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void prevBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            VillageNewbies.menuhistory.RemoveAt(VillageNewbies.menuhistory.Count - 1);
            MenuSwitchRequested?.Invoke(Constants.srvcMenu);
            MenuDefaultState();
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrEmpty(nameTxtBox.Text) || string.IsNullOrEmpty(priceTxtBox.Text))
            {
                statusStrip.Show();
                return false;
            }
            else
            {
                if (statusStrip.Visible)
                {
                    statusStrip.Hide();
                    return true;
                }
                return true;
            }
        }

        private async Task<bool> AddService()
        {
            try
            {
                // create new service
                int.TryParse(priceTxtBox.Text, out int price);
                Dictionary<string, object> columnValues = new Dictionary<string, object>
                        {
                            { "name", nameTxtBox.Text },
                            { "price", price },
                        };

                int result = await VillageNewbies._dbManager.InsertDataAsync("service", columnValues);

                if (result == null || result <= 0)
                {
                    throw new Exception("Error occurred while inserting data into the database.");
                }
                else
                {
                    MessageBox.Show("Palvelu loisätty onnistuneesti");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Jokin meni pieleen: " + ex.Message);
                return false;
            }
        }

        private async void addServiceBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            if (!await AddService())
                return;

            MenuDefaultState();
        }

        private void MenuDefaultState()
        {
            nameTxtBox.Text = string.Empty;
            priceTxtBox.Text = string.Empty;

            if (statusStrip.Visible)
                statusStrip.Visible = false;
        }
    }
}
