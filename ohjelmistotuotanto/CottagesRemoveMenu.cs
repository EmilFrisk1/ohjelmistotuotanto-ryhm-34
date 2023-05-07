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
    public partial class CottagesRemoveMenu : UserControl
    {
        public delegate void MenuSwitchRequestHandler(string menu); // Function pointer 
        public event MenuSwitchRequestHandler MenuSwitchRequested;
        public StatusStrip statusStrip;
        public List<Cottage> Cottages { get; set; }
        public CottagesRemoveMenu()
        {
            InitializeComponent();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            HideErrors();
            this.Hide();
            MenuSwitchRequested?.Invoke(Constants.cottagesMenu);
            VillageNewbies.menuhistory.RemoveAt(VillageNewbies.menuhistory.Count - 1);
        }

        private async void removeBtn_Click(object sender, EventArgs e)
        {
            if (!Validate())
                return;

            if (!await RemoveCottage())
                return;

            MessageBox.Show("mökki poistettu onnistuneesti");

            GetCottages();
        }

        private void HideErrors()
        {
            if (statusStrip.Visible) statusStrip.Hide();
        }

        private async Task<bool> RemoveCottage()
        {
            try
            {
                var response = await VillageNewbies._dbManager.DeleteDataAsync("cottage", $"id = {(int)cottageCbx.SelectedValue}");
                if (response == null || response <= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private async void CottagesRemoveMenu_Load(object sender, EventArgs e)
        {
            // Initialize all needed lists
            Cottages = new List<Cottage>() { new Cottage { Id = -1, Name = string.Empty } };

            GetCottages();
        }

        private async void GetCottages()
        {
            // Get cottages and display then on a combobox | each entry linked with id
            var cottages = await VillageNewbies._dbManager.SelectDataAsync("cottage", new List<string>() { "id", "cottage_name" });

            if (Cottages.Count > 1)
                Cottages.RemoveRange(1, Cottages.Count - 1);

            ComboBoxUtility.SetUpCottagesCbx(cottages, Cottages, cottageCbx);
        }

        private bool Validate()
        {
            // validate
            if ((int)cottageCbx.SelectedValue == -1)
            {
                statusStrip.Visible = true;
                return false;
            }
            else
            {
                if (cottageCbx.Visible)
                {
                    statusStrip.Visible = false;
                    return true;
                }
                return true;
            }
        }

        private void cottageTxtBox_TextChanged(object sender, EventArgs e)
        {
            ComboBoxUtility.FilterCottages(cottageCbx, Cottages, cottageTxtBox.Text);
        }
    }
}
