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
    }
}
