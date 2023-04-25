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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (IsAnyRowSelected())
            {
                DataGridViewRow selectedRow = reservationContainer.SelectedRows[0];
                int reservationId = (int)selectedRow.Cells["Id"].Value;

                var response = VillageNewbies._dbManager.DeleteReservationAsync(reservationId);
                if (response != null || response.Result != -1) {
                    MessageBox.Show("Varaus poistettu onnistuneesti");
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

        private void GetReservations()
        {
            var response = VillageNewbies._dbManager.GetReservationWithDetails();

            if (response.Result == null || response.Result.Count == 0)
            {
                MessageBox.Show("Varauksia ei ole");
            }
            else
            {
                reservationContainer.DataSource = response.Result;
            }
        }
    }
}
