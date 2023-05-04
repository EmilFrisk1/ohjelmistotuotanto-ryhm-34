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
    public partial class AreaAddControl : UserControl
    {
        public delegate void MenuSwitchRequestHandler(string menu); // Function pointer 
        public event MenuSwitchRequestHandler MenuSwitchRequested;
        public StatusStrip statusStrip;
        public AreaAddControl()
        {
            InitializeComponent();
        }
        private bool ValidateFields()
        {
            if (string.IsNullOrEmpty(nameTxtBox.Text))
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
        private async Task<bool> AddArea()
        {
            try
            {
                // create new area
                Dictionary<string, object> columnValue = new Dictionary<string, object>
                        {
                            { "name", nameTxtBox.Text },
                        };

                int result = await VillageNewbies._dbManager.InsertDataAsync("area", columnValue);

                if (result == null || result <= 0)
                {
                    throw new Exception("Error occurred while inserting data into the database.");
                }
                else
                {
                    MessageBox.Show("Alue lisätty onnistuneesti!");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Jokin meni pieleen: " + ex.Message);
                return false;
            }
        }
        private void MenuDefaultState()
        {
            nameTxtBox.Text = string.Empty;
            if (statusStrip.Visible)
                statusStrip.Visible = false;
        }
        private void prevBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            VillageNewbies.menuhistory.RemoveAt(VillageNewbies.menuhistory.Count - 1);
            MenuSwitchRequested?.Invoke(Constants.areasMenu);
            MenuDefaultState();
        }

        private async void addAreaBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            if (!await AddArea())
                return;

            MenuDefaultState();
        }
    }
}
