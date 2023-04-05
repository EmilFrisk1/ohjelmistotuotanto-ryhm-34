using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Drawing.Configuration;
using System.Windows.Forms;


namespace ohjelmistotuotanto
{
    public partial class VillageNewbies : Form // te
    {
        Form formVaraukset = new Form(); // luodaan varaukset form

        private DatabaseManager _dbManager;

        public VillageNewbies()
        {
            InitializeComponent();
            InitMenu1();//lataa varaus menun komponentit

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // add something to DB
            _dbManager.InsertArea("Kuopio");
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            _dbManager = new DatabaseManager(); // setup dbmanager
        }

        private void Form1_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            _dbManager.CloseConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); //piilottaa mainmenun
            formVaraukset.Show(); //n‰ytt‰‰ varaus formin
        }

        private void InitMenu1() //lataa varaukset menun komponentit
        {
            formVaraukset.Size = new Size(1000, 800);
            formVaraukset.Location = new Point(100, 100);
            Label varaukset = ComponentFunctions.CreateLabel("Varaukset",mainMenuHeader.Font ,0 ,new Point(270,30), "varaukset");
            formVaraukset.Controls.Add(varaukset);
            Button vButton = ComponentFunctions.CreateButton("Lis‰‰", button2.Font, 1, button2.Location, button2.Size, "vButton",button2.BackColor, button2.ForeColor);
            formVaraukset.Controls.Add(vButton);
            Button vButton1 = ComponentFunctions.CreateButton("Muokkaa", button3.Font, 2, button3.Location, button3.Size, "vButton", button3.BackColor, button3.ForeColor);
            formVaraukset.Controls.Add(vButton1);
            Button vButton2 = ComponentFunctions.CreateButton("Poista", button3.Font, 2, button4.Location, button3.Size, "vButton", button3.BackColor, button3.ForeColor);
            formVaraukset.Controls.Add(vButton2);
            Button vButton3 = ComponentFunctions.CreateButton("Hae", button3.Font, 2, button5.Location, button3.Size, "vButton", button3.BackColor, button3.ForeColor);
            formVaraukset.Controls.Add(vButton3);
        }

    }
} //testi kommentti