using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ohjelmistotuotanto
{
    public partial class MainMenuControl : UserControl
    {
        public delegate void MenuSwitchRequestHandler(string newControl); // Function pointer 
        public event MenuSwitchRequestHandler MenuSwitchRequested;
        public StatusStrip statusStrip;
        public MainMenuControl()
        {
            InitializeComponent();
        }

        private void customersBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuSwitchRequested?.Invoke(Constants.customersMenu);
        }

        private void reservationsBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MenuSwitchRequested?.Invoke(Constants.rrvtMenu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            statusStrip.Show();
        }

        private void MainMenuControl_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var test = VillageNewbies._dbManager.SelectDataAsync("area", null, "id=1");
            var a = 5;
            foreach (DataRow row in test.Result.Rows)
            {
                var firstColumnValue = row[0];
                var secondColumnValue = row[1];

                // Process the data as needed
               MessageBox.Show($"id: {firstColumnValue}, area name: {secondColumnValue}");
            }

        }
    }
}
