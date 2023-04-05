using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ohjelmistotuotanto
{
    internal class ComponentEvents
    {
        static public void HandleButtonMouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Color darkSlateGray = Color.FromArgb(47, 79, 79);
            button.BackColor = Color.FromArgb(darkSlateGray.R + 20, darkSlateGray.G + 20, darkSlateGray.B + 20); // make the color lighter on hover
        }

        static public void HandleButtonMouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.DarkSlateGray; // make it normal again
        }

        static public void HandleButtonMainMenuClick(object sender, EventArgs e)
        {// identify the button
            Button button = (Button)sender;
            if (button.Name == "mainMenuRrvtBtn")
            {
                VillageNewbies.menuhistory.Add(Constants.rrvtMenu); // update menuhistory
                // update GUI
                VillageNewbies.mainMenuHide();
                VillageNewbies.rrvtMenuShow();
                VillageNewbies.prevButtonShow();
            }
        }

        static public void ClickPrevArr(object sender, EventArgs e)
        {
            string currentMenu = VillageNewbies.menuhistory[VillageNewbies.menuhistory.Count - 1];

            if (currentMenu == Constants.rrvtMenu)
            {
                // Update menuhistory - remove last item
                VillageNewbies.menuhistory.RemoveAt(VillageNewbies.menuhistory.Count - 1);

                // Update GUI
                VillageNewbies.rrvtMenuHide();
                VillageNewbies.mainMenuShow();
            }
        }
    }
}
