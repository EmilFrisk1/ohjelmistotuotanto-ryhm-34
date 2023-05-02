using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ohjelmistotuotanto
{
    public partial class RemoveReservationMenuControl : UserControl
    {
        public delegate void MenuSwitchRequestHandler(string newControl); // Function pointer 
        public event MenuSwitchRequestHandler MenuSwitchRequested;
        private bool isFirstLoad = true;
        private static int counter = 0;

        public RemoveReservationMenuControl()
        {
            InitializeComponent();
        }

        private void RemoveReservationMenuControl_Load(object sender, EventArgs e)
        {
            isFirstLoad = false;
            GetReservations();
        }

        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            if (IsAnyRowSelected())
            {
                RemoveReservation();
            }
            else
            {
                MessageBox.Show("Valitse jokin varaus ensin, jonka haluat poistaa");
            }
        }

        private bool IsAnyRowSelected()
        {
            return reservationContainer.SelectedRows.Count > 0;
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            VillageNewbies.menuhistory.RemoveAt(VillageNewbies.menuhistory.Count - 1);
            MenuSwitchRequested?.Invoke(Constants.rrvtMenu);
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
            }
        }

        private async void RemoveReservation()
        {
            try
            {
                DataGridViewRow selectedRow = reservationContainer.SelectedRows[0];
                int reservationId = (int)selectedRow.Cells["Id"].Value;

                // check if the reservation has any services linked to it and remove them first
                if (await CheckReservationServices(reservationId))
                {
                    var res = await VillageNewbies._dbManager.DeleteDataAsync("reservation_service", $"reservation_id = {reservationId}");
                    if (res == null || res <= 0)
                    {
                        throw new Exception("Palvelun poisto epäonnistui");
                    }
                }

                // remove reservation
                var response = await VillageNewbies._dbManager.DeleteDataAsync("reservation", $"id = {reservationId}");
                if (response == null || response <= 0)
                {
                    throw new Exception("Varauksen poisto epäonnistui");
                } else
                {
                    MessageBox.Show("Varaus poistettu onnistuneesti");
                    GetReservations();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task<bool> CheckReservationServices(int reservationId)
        {
            try
            {
                var reservationServices = await VillageNewbies._dbManager.SelectDataAsync("reservation_service", null, $"reservation_id = {reservationId}");
                if (reservationServices == null || reservationServices.Rows.Count <= 0)
                {
                    return false;
                } else
                {
                    return true;
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Jokin meni pieleen: " + ex.Message);
                return false;
            }
        }
             
        private void RemoveReservationMenuControl_VisibleChanged(object sender, EventArgs e)
        {
            counter++;
            if (isFirstLoad || counter <= 2)
                return;

            if (this.Visible)
            {
                GetReservations();
            }
        }
    }
}
