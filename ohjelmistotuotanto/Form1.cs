using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Globalization;
using System.Windows.Forms;


namespace ohjelmistotuotanto
{
    public partial class VillageNewbies : Form // asdasdasdasdadasd
    {
        //public static Form formVaraukset; // luodaan varaukset form

        public MainMenuControl mainMenuControl;
        public ReservationMenuControl reservationMenuControl;
        public AddReservationMenuControl addReservationMenuControl;
        public RemoveReservationMenuControl removeReservationMenuControl;
        public SearchReservationMenuControl searchReservationMenuControl;
        public UpdateReservationMenu updateReservationMenuControl;
        public ServicesMenuControl servicesMenuControl;
        public ServicesRemoveMenu servicesRemoveMenuControl;
        public ServicesUpdateMenu servicesUpdateMenuControl;
        public CustomersMenuControl customersMenuControl;
        public CustomersAddControl customersAddControl;
        public DisplaySearchResultsMenuControl displaySearchResultsMenuControl;
        public CustomersSearchControl customersSearchControl;
        public CustomersDeleteControl customersDeleteControl;
        public CustomersUpdateControl customersUpdateControl;
        public BillingMenuControl billingMenuControl;
        public ServicesAddMenu servicesAddMenuControl;

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
            updateReservationMenuControl = new UpdateReservationMenu();
            servicesMenuControl = new ServicesMenuControl();
            servicesAddMenuControl = new ServicesAddMenu();
            servicesRemoveMenuControl = new ServicesRemoveMenu();
            servicesUpdateMenuControl = new ServicesUpdateMenu();
            customersMenuControl = new CustomersMenuControl();
            customersAddControl = new CustomersAddControl();
            searchReservationMenuControl = new SearchReservationMenuControl();
            displaySearchResultsMenuControl = new DisplaySearchResultsMenuControl();
            customersSearchControl = new CustomersSearchControl();
            customersDeleteControl = new CustomersDeleteControl();
            customersUpdateControl = new CustomersUpdateControl();
            billingMenuControl = new BillingMenuControl();

            // hide controls
            mainMenuControl.Hide();
            reservationMenuControl.Hide();
            removeReservationMenuControl.Hide();
            searchReservationMenuControl.Hide();
            updateReservationMenuControl.Hide();
            servicesMenuControl.Hide();
            servicesAddMenuControl.Hide();
            servicesRemoveMenuControl.Hide();
            servicesUpdateMenuControl.Hide();
            customersMenuControl.Hide();
            customersAddControl.Hide();
            addReservationMenuControl.Hide();
            displaySearchResultsMenuControl.Hide();
            customersSearchControl.Hide();
            customersDeleteControl.Hide();
            customersUpdateControl.Hide();
            billingMenuControl.Hide();

            // Subscribe to the MenuSwitchRequested event for each User Control
            SubscribeToMenuSwitchEvents(mainMenuControl);
            SubscribeToMenuSwitchEvents(reservationMenuControl);
            SubscribeToMenuSwitchEvents(addReservationMenuControl);
            SubscribeToMenuSwitchEvents(removeReservationMenuControl);
            SubscribeToMenuSwitchEvents(searchReservationMenuControl);
            SubscribeToMenuSwitchEvents(updateReservationMenuControl);
            SubscribeToMenuSwitchEvents(servicesMenuControl);
            SubscribeToMenuSwitchEvents(servicesAddMenuControl);
            SubscribeToMenuSwitchEvents(servicesRemoveMenuControl);
            SubscribeToMenuSwitchEvents(servicesUpdateMenuControl);
            SubscribeToMenuSwitchEvents(customersMenuControl);
            SubscribeToMenuSwitchEvents(customersAddControl);
            SubscribeToMenuSwitchEvents(displaySearchResultsMenuControl);
            SubscribeToMenuSwitchEvents(customersSearchControl);
            SubscribeToMenuSwitchEvents(customersDeleteControl);
            SubscribeToMenuSwitchEvents(customersUpdateControl);
            SubscribeToMenuSwitchEvents(billingMenuControl);

            // Make the controls fill the whole panel (fullscreen)
            mainMenuControl.Dock = DockStyle.Fill;
            reservationMenuControl.Dock = DockStyle.Fill;
            servicesMenuControl.Dock = DockStyle.Fill;
            servicesAddMenuControl.Dock = DockStyle.Fill;
            servicesRemoveMenuControl.Dock = DockStyle.Fill;
            servicesUpdateMenuControl.Dock = DockStyle.Fill;
            customersMenuControl.Dock = DockStyle.Fill;
            customersAddControl.Dock = DockStyle.Fill;
            addReservationMenuControl.Dock = DockStyle.Fill;
            removeReservationMenuControl.Dock = DockStyle.Fill;
            searchReservationMenuControl.Dock = DockStyle.Fill;
            updateReservationMenuControl.Dock = DockStyle.Fill;
            displaySearchResultsMenuControl.Dock = DockStyle.Fill;
            customersSearchControl.Dock = DockStyle.Fill;
            customersDeleteControl.Dock = DockStyle.Fill;
            customersUpdateControl.Dock = DockStyle.Fill;
            billingMenuControl.Dock = DockStyle.Fill;

            // add controls to app container
            appContainer.Controls.Add(mainMenuControl);
            appContainer.Controls.Add(reservationMenuControl);
            appContainer.Controls.Add(servicesMenuControl);
            appContainer.Controls.Add(servicesAddMenuControl);
            appContainer.Controls.Add(servicesRemoveMenuControl);
            appContainer.Controls.Add(servicesUpdateMenuControl);
            appContainer.Controls.Add(customersMenuControl);
            appContainer.Controls.Add(customersAddControl);
            appContainer.Controls.Add(addReservationMenuControl);
            appContainer.Controls.Add(removeReservationMenuControl);
            appContainer.Controls.Add(updateReservationMenuControl);
            appContainer.Controls.Add(searchReservationMenuControl);
            appContainer.Controls.Add(searchReservationMenuControl);
            appContainer.Controls.Add(customersSearchControl);
            appContainer.Controls.Add(customersDeleteControl);
            appContainer.Controls.Add(displaySearchResultsMenuControl);
            appContainer.Controls.Add(customersUpdateControl);
            appContainer.Controls.Add(billingMenuControl);

            // Add app status strip to all menu's that need it
            mainMenuControl.statusStrip = appStatusStrip;
            addReservationMenuControl.statusStrip = appStatusStrip;
            servicesAddMenuControl.statusStrip = appStatusStrip;

            // add appContainer reference to all menu's that need it
            addReservationMenuControl.appContainer = appContainer;

            // Add reference of needed menus for menuhistory purpose
            displaySearchResultsMenuControl.searchReservationMenuControl = searchReservationMenuControl;

            // Show the initial User Control
            SwitchMenuControl(Constants.mainMenu);
        }

        private async void VillageNewbies_Load(object sender, EventArgs e)
        {
            _dbManager = new DatabaseManager(); // setup dbmanager

            CheckReservations();

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
                // Reset menuhistory
                menuhistory.RemoveRange(1, menuhistory.Count - 1);
            }
            else if (menu == Constants.rrvtMenu)
            {
                reservationMenuControl.Visible = true;
                SetDefaultAppSize(appContainer, defaultAppContainerSize);
                menuhistory.Add(Constants.rrvtMenu);
            }
            else if (menu == Constants.addRrvtMenu)
            {
                addReservationMenuControl.Visible = true;
                appContainer.AutoScrollMinSize = new Size(0, 1350);
                menuhistory.Add(Constants.addRrvtMenu);
            }
            else if (menu == Constants.searchRrvtMenu)
            {
                searchReservationMenuControl.Visible = true;
                SetDefaultAppSize(appContainer, defaultAppContainerSize);
                menuhistory.Add(Constants.searchRrvtMenu);
            }
            else if (menu == Constants.srvcMenu)
            {
                servicesMenuControl.Visible = true;
                SetDefaultAppSize(appContainer, defaultAppContainerSize);
                menuhistory.Add(Constants.srvcMenu);
            }
            else if (menu == Constants.srvcAddMenu)
            {
                servicesAddMenuControl.Visible = true;
                SetDefaultAppSize(appContainer, defaultAppContainerSize);
                menuhistory.Add(Constants.srvcAddMenu);
            }
            else if (menu == Constants.srvcRemoveMenu)
            {
                servicesRemoveMenuControl.Visible = true;
                SetDefaultAppSize(appContainer, defaultAppContainerSize);
                menuhistory.Add(Constants.srvcRemoveMenu);
            } else if (menu == Constants.srvcUpdateMenu)
            {
                servicesUpdateMenuControl.Visible = true;
                SetDefaultAppSize(appContainer, defaultAppContainerSize);
                menuhistory.Add(Constants.srvcUpdateMenu);
            }
            else if (menu == Constants.updateRrvtMenu)
            {
                updateReservationMenuControl.Visible = true;
                appContainer.AutoScrollMinSize = new Size(0, 1200);
                menuhistory.Add(Constants.updateRrvtMenu);
            }
            else if (menu == Constants.customersMenu)
            {
                customersMenuControl.Visible = true;
                SetDefaultAppSize(appContainer, defaultAppContainerSize);
                menuhistory.Add(Constants.customersMenu);
            }
            else if (menu == Constants.customersAdd)
            {
                customersAddControl.Visible = true;
                SetDefaultAppSize(appContainer, defaultAppContainerSize);
                menuhistory.Add(Constants.customersAdd);
            }
            else if (menu == Constants.removeRrvtMenu)
            {
                removeReservationMenuControl.Visible = true;
                SetDefaultAppSize(appContainer, defaultAppContainerSize);
                menuhistory.Add(Constants.removeRrvtMenu);
            }
            else if (menu == Constants.searchResults)
            {
                searchReservationMenuControl.Visible = true;
                SetDefaultAppSize(appContainer, defaultAppContainerSize);
                menuhistory.Add(Constants.searchRrvtMenu);
            }
            else if (menu == Constants.displayResultsMenu)
            {
                displaySearchResultsMenuControl.Visible = true;
                SetDefaultAppSize(appContainer, defaultAppContainerSize);
                menuhistory.Add(Constants.displayResultsMenu);
            }
            else if (menu == Constants.customersSearch)
            {
                customersSearchControl.Visible = true;
                SetDefaultAppSize(appContainer, defaultAppContainerSize);
                menuhistory.Add(Constants.customersSearch);
            }
            else if (menu == Constants.customersDelete)
            {
                customersDeleteControl.Visible = true;
                SetDefaultAppSize(appContainer, defaultAppContainerSize);
                menuhistory.Add(Constants.customersDelete);
            }
            else if (menu == Constants.customersUpdate)
            {
                customersUpdateControl.Visible = true;
                SetDefaultAppSize(appContainer, defaultAppContainerSize);
                menuhistory.Add(Constants.customersUpdate);
            }
            else if (menu == Constants.billingMenu)
            {
                billingMenuControl.Visible = true;
                SetDefaultAppSize(appContainer, defaultAppContainerSize);
                menuhistory.Add(Constants.billingMenu);
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
            else if (userControl is ServicesMenuControl servicesMenuControl)
            {
                servicesMenuControl.MenuSwitchRequested += SwitchMenuControl;
            } else if (userControl is ServicesAddMenu servicesAddMenuControl)
            {
                servicesAddMenuControl.MenuSwitchRequested += SwitchMenuControl;
            } else if (userControl is ServicesRemoveMenu servicesRemoveMenu)
            {
                servicesRemoveMenu.MenuSwitchRequested += SwitchMenuControl;
            } else if (userControl is ServicesUpdateMenu servicesUpdateMenuControl)
            {
                servicesUpdateMenuControl.MenuSwitchRequested += SwitchMenuControl;
            }
            else if (userControl is AddReservationMenuControl addReservationMenuControl)
            {
                addReservationMenuControl.MenuSwitchRequested += SwitchMenuControl;
                
            } else if (userControl is SearchReservationMenuControl searchReservationMenuControl) 
            {
                searchReservationMenuControl.MenuSwitchRequested += SwitchMenuControl;
            } else if (userControl is UpdateReservationMenu updateReservationMenu)
            {
                updateReservationMenuControl.MenuSwitchRequested += SwitchMenuControl;
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
            else if (userControl is CustomersUpdateControl customersUpdate)
            {
                customersUpdateControl.MenuSwitchRequested += SwitchMenuControl;
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
        {
            // Hide the menu we made the click from
            string currentMenu = menuhistory[menuhistory.Count - 1];

            switch (currentMenu)
            {
                case Constants.mainMenu:
                    break;
                case Constants.rrvtMenu:
                    reservationMenuControl.Visible = false;
                    break;
                case Constants.removeRrvtMenu:
                    removeReservationMenuControl.Visible = false;
                    break;
                case Constants.addRrvtMenu:
                    addReservationMenuControl.Visible = false;
                    break;
                case Constants.searchRrvtMenu:
                    searchReservationMenuControl.Visible = false;
                    break;
                case Constants.srvcMenu:
                    servicesMenuControl.Visible = false;
                    break;
                case Constants.customersMenu:
                    customersMenuControl.Visible = false;
                    break;
                case Constants.customersAdd:
                    customersAddControl.Visible = false;
                    break;
                case Constants.searchResults:
                    displaySearchResultsMenuControl.Visible = false;
                    break;
                case Constants.displayResultsMenu:
                    displaySearchResultsMenuControl.Visible = false;
                    break;
                case Constants.customersSearch:
                    customersSearchControl.Visible = false;
                    break;
                case Constants.customersDelete:
                    customersDeleteControl.Visible = false;
                    break;
                case Constants.customersUpdate:
                    customersUpdateControl.Visible = false;
                    break;
            }

            SwitchMenuControl(Constants.mainMenu);
        }

        // Updates reservations if they are within 7 days to be uncancelable and forms a bill.
        private async void CheckReservations()
        {
            // Get all reservations that has not been billed yet
            var reservations = await _dbManager.SelectDataAsync("reservation", null, "reservation_status = 'PENDING'");

            foreach (DataRow row in reservations.Rows)
            {
                var startDate = (DateTime)row["start_date"];
                var distanceInDays = (startDate - DateTime.Now).Days;
                if (distanceInDays <= 7)
                { // Reservation cannot be cancelled anymore create bill 
                    var reservationId = (int)row["id"];
                    var endDate = (DateTime)row["end_date"];
                    _dbManager.CreateBill(reservationId, endDate.ToString("yyyy-MM-dd"));
                }
            }

        }
    }
}