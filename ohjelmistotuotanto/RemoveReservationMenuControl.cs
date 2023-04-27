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
    public partial class RemoveReservationMenuControl : UserControl
    {
        public delegate void MenuSwitchRequestHandler(string newControl); // Function pointer 
        public event MenuSwitchRequestHandler MenuSwitchRequested;
        public RemoveReservationMenuControl()
        {
            InitializeComponent();
        }

        private void RemoveReservationMenuControl_Load(object sender, EventArgs e)
        {
            GetReservations();
        }

        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            if (IsAnyRowSelected())
            {
                DataGridViewRow selectedRow = reservationContainer.SelectedRows[0];
                int reservationId = (int)selectedRow.Cells["Id"].Value;

                Dictionary<string, object> reservationColumnValues = new Dictionary<string, object>
                        {
                            { "reservation_status", "cancelled" }
                        };

                var response = await VillageNewbies._dbManager.AlterDataAsync("reservation", reservationColumnValues, $"id = {reservationId}"); 
                if (response != null || response <= 0)
                {
                    MessageBox.Show("Varaus peruttu onnistuneesti");

                    Dictionary<string, object> billColumnValues = new Dictionary<string, object>
                        {
                            { "status", "CANCELLED" }
                        };

                    // alter the bill status for this reservation
                    var billAlterRes = await VillageNewbies._dbManager.AlterDataAsync("bill", billColumnValues, $"reservation_id = {reservationId}");
                    if (billAlterRes != null || billAlterRes <= 0)
                    {
                        MessageBox.Show("Lasku muutettu");
                    } else
                    {
                        MessageBox.Show("Jokin meni pieleen");
                    }

                    GetReservations();
                }
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
            MenuSwitchRequested?.Invoke(Constants.rrvtMenu);
        }

        private async void GetReservations()
        {
            var response = await VillageNewbies._dbManager.GetReservationWithDetails();

            if (response == null || response.Count <= 0)
            {
                MessageBox.Show("Varauksia ei ole");
            }
            else
            {
                reservationContainer.DataSource = response;
            }
        }
    }
}
