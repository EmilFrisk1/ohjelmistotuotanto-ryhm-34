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

namespace ohjelmistotuotanto
{
    public partial class CottagesAddMenu : UserControl
    {
        public delegate void MenuSwitchRequestHandler(string newControl); // Function pointer 
        public event MenuSwitchRequestHandler MenuSwitchRequested;
        public StatusStrip statusStrip;
        public Panel appContainer;

        public List<Area> Areas { get; set; }

        public CottagesAddMenu()
        {
            InitializeComponent();
        }

        private async void CottagesAddMenu_Load(object sender, EventArgs e)
        {
            // Initialize lists
            Areas = new List<Area>() { new Area { Id = -1, Name = string.Empty } };

            // Get all areas and display them on the comboBox
            var areas = await VillageNewbies._dbManager.SelectDataAsync("area", new List<string>() { "id", "name" });
            ComboBoxUtility.SetUpAreasCbx(areas, Areas, areaCbx);
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HideErrors();
            MenuDefaultState();
            VillageNewbies.menuhistory.RemoveAt(VillageNewbies.menuhistory.Count - 1);
            MenuSwitchRequested?.Invoke(Constants.cottagesMenu);
        }

        private async void addCustomerBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                // Scroll the form to the bottom to show the status label
                appContainer.VerticalScroll.Value = appContainer.VerticalScroll.Maximum;
                return;
            }

            if (!await CreateCottage())
                return;

            MessageBox.Show("mökki lisätty onnistuneesti!");
            MenuDefaultState();
        }

        async Task<bool> CreateCottage()
        {
            try
            {
                decimal.TryParse(priceTxtBox.Text, out decimal price);
                int.TryParse(squaresTxtBox.Text, out int squares);
                Dictionary<string, object> columnValues = new Dictionary<string, object>
                        {
                            { "area_id",  (int)areaCbx.SelectedValue},
                            { "price",  price },
                            { "description", descriptionTxtBox.Text },
                            { "equipment", equipmentTxtBox.Text },
                            { "squares", squares },
                            { "address", addressTxtBox.Text },
                            { "cottage_name", cottageNameTxtBox.Text }
                        };

                int result = await VillageNewbies._dbManager.InsertDataAsync("cottage", columnValues);
                if (result > 0)
                {
                    return true;
                } else
                {
                    throw new Exception("Error occurred while inserting data into the database.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool ValidateFields()
        {
            if ((int)areaCbx.SelectedValue == -1 || string.IsNullOrEmpty(priceTxtBox.Text) ||
                string.IsNullOrEmpty(descriptionTxtBox.Text) || string.IsNullOrEmpty(equipmentTxtBox.Text) ||
                string.IsNullOrEmpty(squaresTxtBox.Text) || string.IsNullOrEmpty(addressTxtBox.Text) ||
                string.IsNullOrEmpty(cottageNameTxtBox.Text))
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

        private void priceTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        { // returns false if the max length has been reached
            if (!TextBoxUtility.MaxLength(sender, e, 10))
            {
                priceErrLbl.Visible = true;
                priceErrLbl.Text = "Vain 10 merkkiä sallittu";
                return;
            }
               

            if (TextBoxUtility.AllowOnlyNumbers(sender, e))
            {
                priceErrLbl.Visible = true;
                priceErrLbl.Text = "Vain numerot ja 1 piste sallittu";
                return;
            }

            // No errors
            if (priceErrLbl.Visible)
                priceErrLbl.Visible = false;
        }

        private void squaresTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TextBoxUtility.AllowOnlyNumbers(sender, e))
            {
                squaresErrLbl.Visible = true;
                squaresErrLbl.Text = "Vain numerot ja 1 piste sallittu";
                return;
            }

            // No errors
            if (squaresErrLbl.Visible)
                squaresErrLbl.Visible= false;
        }

        private void HideErrors()
        {
            if (squaresErrLbl.Visible)
                squaresErrLbl.Visible = false;

            if (priceErrLbl.Visible)
                priceErrLbl.Visible = false;

            if (statusStrip.Visible)
                statusStrip.Visible = false;
        }

        private void MenuDefaultState()
        {
            areaCbx.SelectedIndex = 0;
            priceTxtBox.Text = string.Empty;
            descriptionTxtBox.Text = string.Empty;
            equipmentTxtBox.Text = string.Empty;
            squaresTxtBox.Text = string.Empty;
            addressTxtBox.Text = string.Empty;
            cottageNameTxtBox.Text = string.Empty;
        }
    }
}
