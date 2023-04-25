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
        private RemoveReservationMenuControl removeReservationMenuControl;
        private SearchReservationMenuControl searchReservationMenuControl;
        private ServicesMenuControl servicesMenuControl;
        private CustomersMenuControl customersMenuControl;
        private CustomersAddControl customersAddControl;//TODO- Pitäisi olla customersSearchControl nimellä 
        
        private DisplaySearchResultsMenuControl displaySearchResultsMenuControl;
        private CustomersSearchControl customersSearchControl;
        private CustomersDeleteControl customersDeleteControl;

        static PictureBox prevButton;

        private static Size defaultAppContainerSize = new Size(0, 0);

        public static List<string> menuhistory = new List<string>() { Constants.mainMenu };

        public static DatabaseManager _dbManager;

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
            removeReservationMenuControl = new RemoveReservationMenuControl();
            servicesMenuControl = new ServicesMenuControl();
            customersMenuControl = new CustomersMenuControl();
            customersAddControl = new CustomersAddControl();
            searchReservationMenuControl = new SearchReservationMenuControl();
            displaySearchResultsMenuControl = new DisplaySearchResultsMenuControl();
            customersSearchControl = new CustomersSearchControl();
            customersDeleteControl = new CustomersDeleteControl();

            // hide controls
            mainMenuControl.Hide();
            reservationMenuControl.Hide();
            removeReservationMenuControl.Hide();
            searchReservationMenuControl.Hide();
            servicesMenuControl.Hide();
            customersMenuControl.Hide();
            customersAddControl.Hide();
            addReservationMenuControl.Hide();
            displaySearchResultsMenuControl.Hide();
            customersSearchControl.Hide();
            customersDeleteControl.Hide();

            // Subscribe to the MenuSwitchRequested event for each User Control
            SubscribeToMenuSwitchEvents(mainMenuControl);
            SubscribeToMenuSwitchEvents(reservationMenuControl);
            SubscribeToMenuSwitchEvents(addReservationMenuControl);
            SubscribeToMenuSwitchEvents(removeReservationMenuControl);
            SubscribeToMenuSwitchEvents(searchReservationMenuControl);
            SubscribeToMenuSwitchEvents(servicesMenuControl);
            SubscribeToMenuSwitchEvents(customersMenuControl);
            SubscribeToMenuSwitchEvents(customersAddControl);
            SubscribeToMenuSwitchEvents(displaySearchResultsMenuControl);
            SubscribeToMenuSwitchEvents(customersSearchControl);
            SubscribeToMenuSwitchEvents(customersDeleteControl);


            // Add app status strip to all menu's that need it
            mainMenuControl.statusStrip = appStatusStrip;
            addReservationMenuControl.statusStrip = appStatusStrip;

            // add appContainer reference to all menu's that need it
            addReservationMenuControl.appContainer = appContainer;

            // Make the controls fill the whole panel (fullscreen)
            mainMenuControl.Dock = DockStyle.Fill;
            reservationMenuControl.Dock = DockStyle.Fill;
            servicesMenuControl.Dock = DockStyle.Fill;
            customersMenuControl.Dock = DockStyle.Fill;
            customersAddControl.Dock = DockStyle.Fill;
            addReservationMenuControl.Dock = DockStyle.Fill;
            removeReservationMenuControl.Dock = DockStyle.Fill;
            searchReservationMenuControl.Dock = DockStyle.Fill;
            displaySearchResultsMenuControl.Dock = DockStyle.Fill;
            customersSearchControl.Dock = DockStyle.Fill;
            customersDeleteControl.Dock = DockStyle.Fill;

            // add controls to app container
            appContainer.Controls.Add(mainMenuControl);
            appContainer.Controls.Add(reservationMenuControl);
            appContainer.Controls.Add(servicesMenuControl);
            appContainer.Controls.Add(customersMenuControl);
            appContainer.Controls.Add(customersAddControl);
            appContainer.Controls.Add(addReservationMenuControl);
            appContainer.Controls.Add(removeReservationMenuControl);
            appContainer.Controls.Add(searchReservationMenuControl);
            appContainer.Controls.Add(searchReservationMenuControl);
            appContainer.Controls.Add(customersSearchControl);
            appContainer.Controls.Add(customersDeleteControl);
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
                SetDefaultAppSize(appContainer, defaultAppContainerSize);
            }
            else if (menu == Constants.rrvtMenu)
            {
                reservationMenuControl.Visible = true;
                SetDefaultAppSize(appContainer, defaultAppContainerSize);
            }
            else if (menu == Constants.addRrvtMenu)
            {
                addReservationMenuControl.Visible = true;
                appContainer.AutoScrollMinSize = new Size(0, 1350);
            } else if (menu == Constants.searchRrvtMenu)
            {
                searchReservationMenuControl.Visible = true;
                SetDefaultAppSize(appContainer, defaultAppContainerSize);
            }
            else if (menu == Constants.srvcMenu)
            {
                servicesMenuControl.Visible = true;
                SetDefaultAppSize(appContainer, defaultAppContainerSize);
            }
            else if (menu == Constants.customersMenu)
            {
                customersMenuControl.Visible = true;
                SetDefaultAppSize(appContainer, defaultAppContainerSize);
            }
            else if (menu == Constants.customersAdd)
            {
                customersAddControl.Visible = true;
                SetDefaultAppSize(appContainer, defaultAppContainerSize);
            } else if (menu == Constants.removeRrvtMenu)
            {
                removeReservationMenuControl.Visible = true;
                SetDefaultAppSize(appContainer, defaultAppContainerSize);
            } else if (menu == Constants.searchResults)
            {
                searchReservationMenuControl.Visible = true;
                SetDefaultAppSize(appContainer, defaultAppContainerSize);
            }
            else if (menu == Constants.customersSearch)
            {
                customersSearchControl.Visible = true;
                SetDefaultAppSize(appContainer, defaultAppContainerSize);
            }
            else if (menu == Constants.customersDelete)
            {
                customersDeleteControl.Visible = true;
                SetDefaultAppSize(appContainer, defaultAppContainerSize);
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
            } else if (userControl is SearchReservationMenuControl searchReservationMenuControl) 
            {
                searchReservationMenuControl.MenuSwitchRequested += SwitchMenuControl;
            }
            else if (userControl is CustomersMenuControl customersMenuControl)
            {
                customersMenuControl.MenuSwitchRequested += SwitchMenuControl;
            }
            else if (userControl is CustomersAddControl customersAddControl)
            {
                customersAddControl.MenuSwitchRequested += SwitchMenuControl;
            } else if (userControl is RemoveReservationMenuControl removeReservationMenuControl)
            {
                removeReservationMenuControl.MenuSwitchRequested += SwitchMenuControl;
            } else if (userControl is DisplaySearchResultsMenuControl displaySearchResultsMenuControl)
            {
                displaySearchResultsMenuControl.MenuSwitchRequested += SwitchMenuControl;
            }
            else if (userControl is CustomersSearchControl customersSearchControl)
            {
                customersSearchControl.MenuSwitchRequested += SwitchMenuControl;
            }
            else if (userControl is CustomersDeleteControl customersDeleteControl)
            {
                customersDeleteControl.MenuSwitchRequested += SwitchMenuControl;
            }
        }

        // Makes sure we don't use vertical scrollbars when we don't need them
        public static void SetDefaultAppSize(Panel appContainer, Size defaultAppContainerSize)
        {
            if (appContainer.AutoScrollMinSize != defaultAppContainerSize)
            {
                appContainer.AutoScrollMinSize = defaultAppContainerSize;
            }
        }

        private void mainMenuToolStrip_Click(object sender, EventArgs e)
        { // TODO - hide the menu where this was clicked from (probably need to implement menuhistory)
            SwitchMenuControl(Constants.mainMenu);
        }
    }
}