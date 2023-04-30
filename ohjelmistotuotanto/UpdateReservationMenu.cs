using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ohjelmistotuotanto
{
    public partial class UpdateReservationMenu : UserControl
    {
        public delegate void MenuSwitchRequestHandler(string menu); // Function pointer 
        public event MenuSwitchRequestHandler MenuSwitchRequested;
        private bool isFirstLoad = true;
        private static int counter = 0;
        private static bool datesChanged = false;
        private static bool cottageChanged = false;

        public List<Cottage> Cottages { get; set; }
        public UpdateReservationMenu()
        {
            InitializeComponent();
        }

        private void UpdateReservationMenu_Load(object sender, EventArgs e)
        {
            isFirstLoad = false;

            Cottages = new List<Cottage>() { new Cottage { Id = -1, Name = string.Empty } };

            // Set the default value to the current date
            startDatePicker.Value = DateTime.Today;
            endDatePicker.Value = DateTime.Today;

            // Set the MinDate and MaxDate to the current date
            startDatePicker.MinDate = DateTime.Today;
            endDatePicker.MinDate = DateTime.Today;

            // Get cottages and display then on a combobox | each entry linked with id
            var cottages = VillageNewbies._dbManager.SelectDataAsync("cottage", new List<string>() { "id", "cottage_name" });
            ComboBoxUtility.setUpCottagesCbx(cottages, Cottages, cottageCbx);

            GetReservations();
        }

        private async void GetReservations()
        {
            var response = await VillageNewbies._dbManager.GetReservationWithDetails();

            if (response == null || response.Count <= 0)
            {
                reservationContainer.DataSource = null;
                reservationContainer.DataSource = response;
                MessageBox.Show("Varauksia ei ole");
            }
            else
            {
                reservationContainer.DataSource = null;
                reservationContainer.DataSource = response;
                // populatee ne kaikki fieldit se ekan rivin mukaan
                if (RowIsSelected())
                {
                    PopulatePlaceholderValues();
                }
            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuSwitchRequested?.Invoke(Constants.rrvtMenu);
            VillageNewbies.menuhistory.RemoveAt(VillageNewbies.menuhistory.Count - 1);
        }

        private void cottageTxtBox_TextChanged(object sender, EventArgs e)
        {
            ComboBoxUtility.FilterCottages(cottageCbx, Cottages, cottageTxtBox.Text);
        }

        private async void updateReservationBtn_Click(object sender, EventArgs e)
        {
            if (!RowIsSelected())
                return;

            if (!ConfirmChange())
                return;

            ValidateChange();

            UpdateReservation();
        }

        private void ValidateChange()
        {
            DataGridViewRow selectedRow = reservationContainer.CurrentRow;
            if (selectedRow != null)
            {
                //Cottage selectedCottage = Cottages.FirstOrDefault(c => c.Name == cottageName);
                if ((int)cottageCbx.SelectedValue == -1)
                {
                    updateReservationErrLabel.Text = "Valitse jokin mökki";
                    updateReservationErrLabel.Visible = true;
                    return;
                }
                else
                {
                    if (updateReservationErrLabel.Visible)
                    {
                        updateReservationErrLabel.Visible = false;
                    }
                }

                // end_date cant be smaller than startDate
                if (DateTime.Compare(startDatePicker.Value.Date, endDatePicker.Value.Date) > 0 || startDatePicker.Value.Date == endDatePicker.Value.Date)
                {
                    updateReservationErrLabel.Text = "Mihin on liian pieni pvm";
                    updateReservationErrLabel.Visible = true;
                    return;
                }
                else
                {
                    if (updateReservationErrLabel.Visible)
                    {
                        updateReservationErrLabel.Visible = false;
                    }
                }
            }
        }

        private void reservationContainer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulatePlaceholderValues();
        }

        // Checks if some values has been changed
        private bool ConfirmChange()
        {
            DataGridViewRow selectedRow = reservationContainer.CurrentRow;
            if (selectedRow != null)
            {
                string cottageName = (string)selectedRow.Cells["MökinNimi"].Value;
                Cottage selectedCottage = Cottages.FirstOrDefault(c => c.Name == cottageName);
                var startDate = (DateTime)selectedRow.Cells["AloitusPvm"].Value;
                var endDate = (DateTime)selectedRow.Cells["LoppuPvm"].Value;

                if (startDate != startDatePicker.Value || endDate != endDatePicker.Value)
                {
                    datesChanged = true;
                }

                if ((int)cottageCbx.SelectedValue != selectedCottage.Id)
                {
                    cottageChanged = true;
                }

                if (!datesChanged && !cottageChanged) // cottage and dates are the same
                {
                    updateReservationErrLabel.Text = "Muuta jotain arvoa, jota haluat päivittää";
                    updateReservationErrLabel.Visible = true;
                    return false;
                }
                else
                {
                    if (updateReservationErrLabel.Visible)
                    {
                        updateReservationErrLabel.Visible = false;
                        return true;
                    }
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Jokin meni pieleen");
                return false;
            }

        }
        private bool RowIsSelected()
        {
            DataGridViewRow selectedRow = reservationContainer.CurrentRow;
            if (selectedRow != null)
            {
                if (updateReservationErrLabel.Visible)
                { updateReservationErrLabel.Visible = false; }
                return true;
            }
            else
            {
                updateReservationErrLabel.Text = "Valitse jokin varaus, jonka haluat päivitää";
                updateReservationErrLabel.Visible = true;
                return false;
            }
        }

        private void PopulatePlaceholderValues()
        {
            DataGridViewRow selectedRow = reservationContainer.CurrentRow;
            if (selectedRow != null)
            {
                // Set the cottage placeholder
                string cottageName = (string)selectedRow.Cells["MökinNimi"].Value;
                if (cottageName != null)
                {
                    Cottage selectedCottage = Cottages.FirstOrDefault(c => c.Name == cottageName);
                    cottageCbx.SelectedValue = selectedCottage.Id;
                }

                // Set the dates place holders
                var startDate = (DateTime)selectedRow.Cells["AloitusPvm"].Value;
                var endDate = (DateTime)selectedRow.Cells["LoppuPvm"].Value;
                if (startDate != null && endDate != null)
                {
                    startDatePicker.Value = startDate;
                    endDatePicker.Value = endDate;
                }
            }
        }

        private void UpdateReservationMenu_VisibleChanged(object sender, EventArgs e)
        {
            counter++;
            if (isFirstLoad || counter <= 2)
                return;

            if (this.Visible)
            {
                GetReservations();
            }
        }

        private async void UpdateReservation()
        {
            // Prepare database update values
            DataGridViewRow selectedRow = reservationContainer.CurrentRow;
            int reservationId = (int)selectedRow.Cells["Id"].Value;
            int cottageId = (int)cottageCbx.SelectedValue;
            string startDate = startDatePicker.Value.ToString("yyyy-MM-dd");
            string endDate = endDatePicker.Value.ToString("yyyy-MM-dd");

            // Make the update

            if (datesChanged)
            {
                var res = await VillageNewbies._dbManager.CheckAvailabilityAndUpdateAsync(reservationId, cottageId, startDate, endDate);
                if (res <= 0)
                {
                    MessageBox.Show("jokin meni pieleen");
                }
            }

            if (cottageChanged)
            {

                // Update the reservation to indicate its not cancelable anymore
                Dictionary<string, object> reservationColumnValues = new Dictionary<string, object> { { "cottage_id", cottageId } };
                var res = await VillageNewbies._dbManager.AlterDataAsync("reservation", reservationColumnValues, $"id = {reservationId}");
                if (res <= 0)
                {
                    MessageBox.Show("jokin meni pieleen");
                }
            }
        }
    }
}
