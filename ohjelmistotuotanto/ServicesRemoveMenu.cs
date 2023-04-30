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
    public partial class ServicesRemoveMenu : UserControl
    {
        public ServicesRemoveMenu()
        {
            InitializeComponent();
        }

        private void ServicesRemoveMenu_Load(object sender, EventArgs e)
        {
            // Get services and display then on a combobox | each entry linked with id
            var services = VillageNewbies._dbManager.SelectDataAsync("service", new List<string>() { "id", "name" });
            //setUpServicesCbx(services);
        }
    }
}
