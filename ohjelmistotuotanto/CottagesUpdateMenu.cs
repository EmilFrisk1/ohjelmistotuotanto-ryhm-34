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
    public partial class CottagesUpdateMenu : UserControl
    {
        public delegate void MenuSwitchRequestHandler(string menu); // Function pointer 
        public event MenuSwitchRequestHandler MenuSwitchRequested;
        public StatusStrip statusStrip;
        public Panel appContainer;

        private bool cottageNameChanged = false;
        private bool priceChanged = false;
        private bool descriptionChanged = false;
        private bool equipmentChanged = false;
        private bool squaresChanged = false;
        private bool addressChanged = false;
        private bool areaChanged = false;

        public List<CottageDataModel> Cottages { get; set; }
        public List<Area> Areas { get; set; }
        public CottagesUpdateMenu()
        {
            InitializeComponent();
        }

        private void priceTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
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
                squaresErrLbl.Visible = false;
        }

        private async void editBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                // Scroll the form to the bottom to show the status label
                appContainer.VerticalScroll.Value = appContainer.VerticalScroll.Maximum;
                return;
            }

            if (!ConfirmChange()) return;

            if (!await UpdateCottage()) return;

            MessageBox.Show("Mökki muokattu onnistuneesti!");

            MenuDefaultState();
            GetCottages();
        }

        private void MenuDefaultState()
        {
            areaCbx.SelectedIndex = 0;
            cottageCbx.SelectedIndex = 0;
            priceTxtBox.Text = string.Empty;
            descriptionTxtBox.Text = string.Empty;
            equipmentTxtBox.Text = string.Empty;
            squaresTxtBox.Text = string.Empty;
            addressTxtBox.Text = string.Empty;
            cottageNameTxtBox.Text = string.Empty;
        }

        private bool ConfirmChange()
        {
            int cottageId = (int)cottageCbx.SelectedValue;
            CottageDataModel targetCottage = Cottages.FirstOrDefault(cottageCbx => cottageCbx.Id == cottageId);

            if (targetCottage.CottageName != cottageNameTxtBox.Text)
                cottageNameChanged = true;

            if (targetCottage.Price.ToString() != priceTxtBox.Text)
                priceChanged = true;

            if (targetCottage.Description != descriptionTxtBox.Text)
                descriptionChanged = true;

            if (targetCottage.Equipment != equipmentTxtBox.Text)
                equipmentChanged = true;

            if (targetCottage.Squares.ToString() != squaresTxtBox.Text) squaresChanged = true;

            if (targetCottage.AreaId != (int)areaCbx.SelectedValue) areaChanged = true;

            if (targetCottage.CottageName == cottageNameTxtBox.Text && targetCottage.Price.ToString() == priceTxtBox.Text
                && targetCottage.Description == descriptionTxtBox.Text && targetCottage.Squares.ToString() == squaresTxtBox.Text
                && targetCottage.Address == addressTxtBox.Text && targetCottage.AreaId == (int)areaCbx.SelectedValue)
            {
                cottageErrorLabel.Visible = true;
                cottageErrorLabel.Text = "Muuta jotain kentän arvoa";
                return false;
            }
            else
            {
                if (cottageErrorLabel.Visible)
                    cottageErrorLabel.Visible = false;
                return true;
            }
        }

        private async Task<bool> UpdateCottage()
        {
            try
            {
                int cottageId = (int)cottageCbx.SelectedValue;
                Dictionary<string, object> columnValues = new Dictionary<string, object>();

                if (areaChanged)
                    columnValues.Add("area_id", (int)areaCbx.SelectedValue);

                if (priceChanged)
                { // Trim price text field out of spaces
                    decimal.TryParse(priceTxtBox.Text.Replace(" ", ""), out decimal price);
                    columnValues.Add("price", price);
                }

                if (descriptionChanged)
                    columnValues.Add("description", descriptionTxtBox.Text);

                if (equipmentChanged)
                    columnValues.Add("equipment", equipmentTxtBox.Text);

                if (squaresChanged)
                    columnValues.Add("squares", squaresTxtBox.Text);

                if (addressChanged)
                    columnValues.Add("address", addressTxtBox.Text);

                if (cottageNameChanged)
                    columnValues.Add("cottage_name", cottageNameTxtBox.Text);

                var response = await VillageNewbies._dbManager.AlterDataAsync("cottage", columnValues, $"id = {cottageId}");
                if (response == null || response <= 0)
                {
                    throw new Exception("Error occurred while inserting data into the database.");
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("jokin meni pieleen: " + ex.Message);
                return false;
            }
        }

        private bool ValidateFields()
        {
            if ((int)cottageCbx.SelectedValue == -1 || string.IsNullOrEmpty(priceTxtBox.Text) ||
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

        private async void CottagesUpdateMenu_Load(object sender, EventArgs e)
        {
            // Initialize all needed lists
            Cottages = new List<CottageDataModel>() { new CottageDataModel { Id = -1, AreaId = -1, Price = -1, Description = string.Empty, Equipment = string.Empty, Squares = -1, Address = string.Empty, CottageName = string.Empty } };
            Areas = new List<Area>() { new Area { Id = -1, Name = string.Empty } };

            GetCottages();
            // Get all areas and display them on the comboBox
            var areas = await VillageNewbies._dbManager.SelectDataAsync("area", new List<string>() { "id", "name" });
            ComboBoxUtility.SetUpAreasCbx(areas, Areas, areaCbx);
        }

        private async void GetCottages()
        {
            if (Cottages.Count > 1)
                Cottages.RemoveRange(1, Cottages.Count - 1);

            var cottages = await VillageNewbies._dbManager.SelectDataAsync("cottage");
            ComboBoxUtility.SetUpCottagesCbx(cottages, Cottages, cottageCbx);
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuSwitchRequested?.Invoke(Constants.cottagesMenu);
            VillageNewbies.menuhistory.RemoveAt(VillageNewbies.menuhistory.Count - 1);
        }

        private void cottageTxtBox_TextChanged(object sender, EventArgs e)
        {
            ComboBoxUtility.FilterCottages(cottageCbx, Cottages, cottageTxtBox.Text);
        }

        private void cottageCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            var val = cottageCbx.SelectedValue;

            if (val is CottageDataModel cottage)
            {
                if (cottage.Id == -1)
                    return;
            }
            else if (val is int)
            {
                CottageDataModel targetCottage = Cottages.FirstOrDefault(cottage => cottage.Id == (int)val);
                Area targetArea = Areas.FirstOrDefault(area => area.Id == targetCottage.AreaId);

                // valid selection set placeholder values
                priceTxtBox.Text = targetCottage.Price.ToString();
                descriptionTxtBox.Text = targetCottage.Description;
                equipmentTxtBox.Text = targetCottage.Equipment;
                squaresTxtBox.Text = targetCottage.Squares.ToString();
                addressTxtBox.Text = targetCottage.Address;
                cottageNameTxtBox.Text = targetCottage.CottageName;
                areaCbx.SelectedItem = targetArea;
            }
        }
    }
}
