using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Drawing;
using System.Drawing.Configuration;
using System.Windows.Forms;


namespace ohjelmistotuotanto
{
    public partial class VillageNewbies : Form // asdasdasdasdadasd
    {
        //public static Form formVaraukset; // luodaan varaukset form

        private MainMenuControl mainMenuControl;
        private ReservationMenuControl reservationMenuControl;
        private AddReservationMenuControl addReservationMenuControl;
        private ServicesMenuControl servicesMenuControl;
        private CustomersMenuControl customersMenuControl;
        private CustomersAddControl customersAddControl;//TODO- Pitäisi olla customersSearchControl nimellä

        static PictureBox prevButton;

        public static List<string> menuhistory = new List<string>() { Constants.mainMenu };

        private static DatabaseManager _dbManager;

        public VillageNewbies()
        {
            InitializeComponent();
        }

        private void SetupUserControllers()
        {
            // INit user controls
            mainMenuControl = new MainMenuControl();
            reservationMenuControl = new ReservationMenuControl();
            addReservationMenuControl = new AddReservationMenuControl();
            servicesMenuControl = new ServicesMenuControl();
            customersMenuControl = new CustomersMenuControl();
            customersAddControl = new CustomersAddControl();

            // hide controls
            mainMenuControl.Hide();
            reservationMenuControl.Hide();
            servicesMenuControl.Hide();
            customersMenuControl.Hide();
            customersAddControl.Hide();
            addReservationMenuControl.Hide();

            // Subscribe to the MenuSwitchRequested event for each User Control
            SubscribeToMenuSwitchEvents(mainMenuControl);
            SubscribeToMenuSwitchEvents(reservationMenuControl);
            SubscribeToMenuSwitchEvents(addReservationMenuControl);
            SubscribeToMenuSwitchEvents(servicesMenuControl);
            SubscribeToMenuSwitchEvents(customersMenuControl);
            SubscribeToMenuSwitchEvents(customersAddControl);

            // Make the controls fill the whole panel (fullscreen)
            mainMenuControl.Dock = DockStyle.Fill;
            reservationMenuControl.Dock = DockStyle.Fill;
            servicesMenuControl.Dock = DockStyle.Fill;
            customersMenuControl.Dock = DockStyle.Fill;
            customersAddControl.Dock = DockStyle.Fill;
            addReservationMenuControl.Dock = DockStyle.Fill;

            // add controls to app container
            appContainer.Controls.Add(mainMenuControl);
            appContainer.Controls.Add(reservationMenuControl);
            appContainer.Controls.Add(servicesMenuControl);
            appContainer.Controls.Add(customersMenuControl);
            appContainer.Controls.Add(customersAddControl);
            appContainer.Controls.Add(addReservationMenuControl);

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
            }
            else if (menu == Constants.addRrvtMenu)
            {
                addReservationMenuControl.Visible = true;
            }
            else if (menu == Constants.srvcMenu)
            {
                servicesMenuControl.Visible = true;
            }
            else if (menu == Constants.customersMenu)
            {
                customersMenuControl.Visible = true;
            }
            else if (menu == Constants.customersAdd)
            {
                customersAddControl.Visible = true;
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
            else if (userControl is AddReservationMenuControl addReservationMenuControl)
            {
                addReservationMenuControl.MenuSwitchRequested += SwitchMenuControl;
            }
            else if (userControl is CustomersMenuControl customersMenuControl)
            {
                customersMenuControl.MenuSwitchRequested += SwitchMenuControl;
            }
            else if (userControl is CustomersAddControl customersAddControl)
            {
                customersAddControl.MenuSwitchRequested += SwitchMenuControl;
            }
        }

        private void mainMenuToolStrip_Click(object sender, EventArgs e)
        { // TODO - hide the menu where this was clicked from (probably need to implement menuhistory)
            SwitchMenuControl(Constants.mainMenu);
        }
    }
}