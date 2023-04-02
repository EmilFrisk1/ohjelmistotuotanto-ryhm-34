using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Configuration;


namespace ohjelmistotuotanto
{
    public partial class VillageNewbies : Form // te
    {
        private DatabaseManager _dbManager;

        public VillageNewbies()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // add something to DB
            _dbManager.InsertArea("Helsinki");
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            var builder = new ConfigurationBuilder() // setup config json file 
              .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
              .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            IConfiguration configuration = builder.Build();

            _dbManager = new DatabaseManager(configuration); // setup dbmanager
        }

        private void Form1_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            _dbManager.CloseConnection();
        }
    }
}