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

        static Button mainMenuRrvtBtn;
        static Button mainMenuSrvcBtn;
        static Button mainMenuClientButton;
        static Button mainMenuAreaButton;
        static Button mainMenuBillButton;
        static Label mainMenuLbl;

        static Button rrvtMenuAddBtn;
        static Button rrvtMenuEditBtn;
        static Button rrvtMenuDeleteBtn;
        static Button rrvtMenuSearchBtn;
        static Label rrvtMenuLbl;

        static PictureBox prevButton;

        public static List<string> menuhistory = new List<string>() { Constants.mainMenu };

        private DatabaseManager _dbManager;

        public VillageNewbies()
        {
            InitializeComponent();
            //InitializeMenus.initMainMenu(this, mainMenuLbl, mainMenuRrvtBtn, mainMenuSrvcBtn, mainMenuClientButton, mainMenuAreaButton, mainMenuBillButton);
            //InitMenu1();//lataa varaus menun komponentit
        }

        private void VillageNewbies_Load(object sender, EventArgs e)
        {
            _dbManager = new DatabaseManager(); // setup dbmanager
            initMainMenu();
            initRrvtMenu();
            prevButton = ComponentFunctions.CreatePrevButton(this, new Point(25, 31), new Size(60, 50));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // _dbManager.InsertArea("Kuopio");
            mainMenuHide();
            prevButtonShow();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //mainMenuShow();
        }

        public void initMainMenu()
        {
            Size btnSize = new Size(451, 66);
            Font btnFont = new Font("Segue", 28, FontStyle.Regular);
            Color btnForeClr = Color.Silver;
            Color btnBcClr = Color.FromArgb(47, 79, 79);

            // Create
            // TODO - t‰n fontin kaa on jotai onglemia pit‰‰ tutkia 
            mainMenuLbl = ComponentFunctions.CreateLabel(this, Color.Silver, "Village Newbies", new Font("Script MT", 48, FontStyle.Bold), 1, new Point(191, 9), "mainMenuLbl", false, true);

            mainMenuRrvtBtn = ComponentFunctions.CreateButton(this, "Varaukset", btnFont, 2, new Point(191, 137), btnSize, "mainMenuRrvtBtn", btnForeClr, btnBcClr, ComponentEvents.HandleButtonMouseEnter, ComponentEvents.HandleButtonMouseLeave);
            mainMenuSrvcBtn = ComponentFunctions.CreateButton(this, "Palvelut", btnFont, 3, new Point(191, 233), btnSize, "mainMenuSrvcBtn", btnForeClr, btnBcClr, ComponentEvents.HandleButtonMouseEnter, ComponentEvents.HandleButtonMouseLeave);
            mainMenuClientButton = ComponentFunctions.CreateButton(this, "Asiakkaat", btnFont, 4, new Point(191, 329), btnSize, "mainMenuClientButton", btnForeClr, btnBcClr, ComponentEvents.HandleButtonMouseEnter, ComponentEvents.HandleButtonMouseLeave);
            mainMenuAreaButton = ComponentFunctions.CreateButton(this, "Alueet", btnFont, 5, new Point(191, 425), btnSize, "mainMenuAreaButton", btnForeClr, btnBcClr, ComponentEvents.HandleButtonMouseEnter, ComponentEvents.HandleButtonMouseLeave);
            mainMenuBillButton = ComponentFunctions.CreateButton(this, "Laskut", btnFont, 6, new Point(191, 521), btnSize, "mainMenuBillButton", btnForeClr, btnBcClr, ComponentEvents.HandleButtonMouseEnter, ComponentEvents.HandleButtonMouseLeave);

            // Events
            mainMenuRrvtBtn.Click += ComponentEvents.HandleButtonMainMenuClick;
            mainMenuSrvcBtn.Click += ComponentEvents.HandleButtonMainMenuClick;
            mainMenuClientButton.Click += ComponentEvents.HandleButtonMainMenuClick;
            mainMenuAreaButton.Click += ComponentEvents.HandleButtonMainMenuClick;
            mainMenuBillButton.Click += ComponentEvents.HandleButtonMainMenuClick;
        }

        public void initRrvtMenu()
        {
            Size btnSize = new Size(451, 66);
            Font btnFont = new Font("Segue", 28, FontStyle.Regular);
            Color btnForeClr = Color.Silver;
            Color btnBcClr = Color.FromArgb(47, 79, 79);

            // TODO - t‰n fontin kaa on jotai onglemia pit‰‰ tutkia 
            rrvtMenuLbl = ComponentFunctions.CreateLabel(this, Color.Silver, "Varaukset", new Font("Script MT", 48, FontStyle.Bold), 1, new Point(191, 9), "rrvtMenuLbl", false, true);

            // Create
            rrvtMenuAddBtn = ComponentFunctions.CreateButton(this, "Lis‰‰", btnFont, 2, new Point(191, 137), btnSize, "rrvtMenuAddBtn", btnForeClr, btnBcClr, ComponentEvents.HandleButtonMouseEnter, ComponentEvents.HandleButtonMouseLeave);
            rrvtMenuEditBtn = ComponentFunctions.CreateButton(this, "Muokkaa", btnFont, 3, new Point(191, 233), btnSize, "rrvtMenuEditBtn", btnForeClr, btnBcClr, ComponentEvents.HandleButtonMouseEnter, ComponentEvents.HandleButtonMouseLeave);
            rrvtMenuDeleteBtn = ComponentFunctions.CreateButton(this, "Poista", btnFont, 4, new Point(191, 329), btnSize, "rrvtMenuDeleteBtn", btnForeClr, btnBcClr, ComponentEvents.HandleButtonMouseEnter, ComponentEvents.HandleButtonMouseLeave);
            rrvtMenuSearchBtn = ComponentFunctions.CreateButton(this, "Hae", btnFont, 5, new Point(191, 425), btnSize, "rrvtMenuSearchBtn", btnForeClr, btnBcClr, ComponentEvents.HandleButtonMouseEnter, ComponentEvents.HandleButtonMouseLeave);

            // Hide
            rrvtMenuAddBtn.Hide();
            rrvtMenuEditBtn.Hide();
            rrvtMenuDeleteBtn.Hide();
            rrvtMenuSearchBtn.Hide();
        }

        public static void mainMenuHide()
        {
            mainMenuLbl.Hide();
            mainMenuRrvtBtn.Hide();
            mainMenuSrvcBtn.Hide();
            mainMenuClientButton.Hide();
            mainMenuAreaButton.Hide();
            mainMenuBillButton.Hide();
        }

        public static void mainMenuShow()
        {
            mainMenuLbl.Show();
            mainMenuRrvtBtn.Show();
            mainMenuSrvcBtn.Show();
            mainMenuClientButton.Show();
            mainMenuAreaButton.Show();
            mainMenuBillButton.Show();
        }

        public static void rrvtMenuShow()
        {
            rrvtMenuAddBtn.Show();
            rrvtMenuEditBtn.Show();
            rrvtMenuDeleteBtn.Show();
            rrvtMenuSearchBtn.Show();
        }

        public static void rrvtMenuHide()
        {
            rrvtMenuAddBtn.Hide();
            rrvtMenuEditBtn.Hide();
            rrvtMenuDeleteBtn.Hide();
            rrvtMenuSearchBtn.Hide();
        }

        public static void prevButtonShow()
        {
            prevButton.Show();
        }


        //private void InitMenu1() //lataa varaukset menun komponentit
        //{
        //    formVaraukset.Size = new Size(1000, 800);
        //    formVaraukset.Location = new Point(100, 100);
        //    Label varaukset = ComponentFunctions.CreateLabel(?"Varaukset", mainMenuHeader.Font, 0, new Point(270, 30), "varaukset");
        //    formVaraukset.Controls.Add(varaukset);
        //    Button vButton = ComponentFunctions.CreateButton("Lis‰‰", button2.Font, 1, button2.Location, button2.Size, "vButton", button2.BackColor, button2.ForeColor);
        //    formVaraukset.Controls.Add(vButton);
        //    Button vButton1 = ComponentFunctions.CreateButton("Muokkaa", button3.Font, 2, button3.Location, button3.Size, "vButton", button3.BackColor, button3.ForeColor);
        //    formVaraukset.Controls.Add(vButton1);
        //    Button vButton2 = ComponentFunctions.CreateButton("Poista", button3.Font, 2, button4.Location, button3.Size, "vButton", button3.BackColor, button3.ForeColor);
        //    formVaraukset.Controls.Add(vButton2);
        //    Button vButton3 = ComponentFunctions.CreateButton("Hae", button3.Font, 2, button5.Location, button3.Size, "vButton", button3.BackColor, button3.ForeColor);
        //    formVaraukset.Controls.Add(vButton3);
        //}
    }
} //testi kommentti