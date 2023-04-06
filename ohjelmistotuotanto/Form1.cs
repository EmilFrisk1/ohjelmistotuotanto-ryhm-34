using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Drawing;
using System.Drawing.Configuration;
using System.Windows.Forms;


namespace ohjelmistotuotanto
{
    public partial class VillageNewbies : Form
    {
        //public static Form formVaraukset; // luodaan varaukset form

        private MainMenuControl mainMenuControl;
        private ReservationMenuControl reservationMenuControl;
        private ServicesMenuControl servicesMenuControl;

        static PictureBox prevButton;

        public static List<string> menuhistory = new List<string>() { Constants.mainMenu };

        private DatabaseManager _dbManager;

        public VillageNewbies()
        {
            InitializeComponent();
        }

        private void SetupUserControllers()
        {
            // INit user controls
            mainMenuControl = new MainMenuControl();
            reservationMenuControl = new ReservationMenuControl();
            servicesMenuControl = new ServicesMenuControl();

            // hide controls
            mainMenuControl.Hide();
            reservationMenuControl.Hide();
            servicesMenuControl.Hide();

            // Subscribe to the MenuSwitchRequested event for each User Control
            SubscribeToMenuSwitchEvents(mainMenuControl);
            SubscribeToMenuSwitchEvents(reservationMenuControl);
            SubscribeToMenuSwitchEvents(servicesMenuControl);

            mainMenuControl.Dock = DockStyle.Fill;
            reservationMenuControl.Dock = DockStyle.Fill;
            servicesMenuControl.Dock = DockStyle.Fill;

            // add controls to app container
            appContainer.Controls.Add(mainMenuControl);
            appContainer.Controls.Add(reservationMenuControl);
            appContainer.Controls.Add(servicesMenuControl);

            // Show the initial User Control
            SwitchMenuControl(Constants.mainMenu);
        }

        private void VillageNewbies_Load(object sender, EventArgs e)
        {
            _dbManager = new DatabaseManager(); // setup dbmanager

            SetupUserControllers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // _dbManager.InsertArea("Kuopio");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //mainMenuShow();
        }

        private void SwitchMenuControl(string menu)
        {
            // Display the specified menu
            if (menu == Constants.mainMenu)
            {
                mainMenuControl.Visible = true;
            }
            else if (menu == Constants.rrvtMenu)
            {
                reservationMenuControl.Visible = true;
            } else if (menu == Constants.srvcMenu)
            {
                servicesMenuControl.Visible = true;
            }
        }


        private void SubscribeToMenuSwitchEvents(UserControl userControl)
        {
            if (userControl is MainMenuControl mainMenuControl)
            {
                mainMenuControl.MenuSwitchRequested += SwitchMenuControl;
            }
            else if (userControl is ReservationMenuControl reservationMenuControl)
            {
                reservationMenuControl.MenuSwitchRequested += SwitchMenuControl;
            }
            else if (userControl is ReservationMenuControl servicesMenuControl)
            {
                servicesMenuControl.MenuSwitchRequested += SwitchMenuControl;
            }
        }

        private void mainMenuToolStrip_Click(object sender, EventArgs e)
        {
            SwitchMenuControl(Constants.mainMenu);
        }
    }
}